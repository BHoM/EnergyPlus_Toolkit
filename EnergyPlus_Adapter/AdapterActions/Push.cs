using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.oM.Adapter;
using BH.oM.Base;
using System.Reflection;

using System.IO;
using BH.Engine.Adapter;

namespace BH.Adapter.EnergyPlus
{
    public partial class EnergyPlusAdapter : BHoMAdapter
    {
        public override List<object> Push(IEnumerable<object> objects, String tag = "", PushType pushType = PushType.AdapterDefault, ActionConfig actionConfig = null)
        {
            // If unset, set the pushType to AdapterSettings' value (base AdapterSettings default is FullCRUD).
            if (pushType == PushType.AdapterDefault)
                pushType = m_AdapterSettings.DefaultPushType;

            IEnumerable<IBHoMObject> objectsToPush = objects.Select(x => (IBHoMObject)x).ToList();

            bool success = true;

            FileOutput = new List<string>();

            MethodInfo methodInfos = typeof(Enumerable).GetMethod("Cast");
            foreach (var typeGroup in objectsToPush.GroupBy(x => x.GetType()))
            {
                MethodInfo mInfo = methodInfos.MakeGenericMethod(new[] { typeGroup.Key });
                var list = mInfo.Invoke(typeGroup, new object[] { typeGroup });
                success &= ICreate(list as dynamic);
            }

            StreamWriter sw = new StreamWriter(FileSettings.GetFullFileName());

            foreach (string s in FileOutput)
                sw.WriteLine(s);

            sw.Close();

            return success ? objects.ToList() : new List<object>();
        }
    }
}
