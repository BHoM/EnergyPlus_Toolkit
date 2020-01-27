using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BH.oM.Base;
//using System.Reflection;
using BH.oM.Data.Requests;
using BH.oM.Reflection.Attributes;
using System.ComponentModel;

using BH.oM.EnergyPlus.Settings;

using System.Reflection;

using BH.oM.Adapter;

namespace BH.Adapter.EnergyPlus
{
    public partial class EnergyPlusAdapter : BHoMAdapter
    {
        [Description("Produces an EnergyPlus Adapter to allow interopability with IDF files and the BHoM")]
        [Input("idfFilePath", "Path to an IDF File")]
        [Input("settings", "Settings that define how the EnergyPlus IDF file should be generated")]
        [Output("adapter", "Adapter to an IDF File")]
        public EnergyPlusAdapter(string idfFilePath, EnergyPlusSettings settings = null)
        {
            IDFFilePath = idfFilePath;
            _settings = settings ?? new EnergyPlusSettings();

            AdapterIdName = "EnergyPlus_Adapter";
        }

        public override List<object> Push(IEnumerable<object> objects, String tag = "", PushType pushType = PushType.AdapterDefault, ActionConfig actionConfig = null)
        {
            bool success = true;

            /*MethodInfo methodInfos = typeof(Enumerable).GetMethod("Cast");
            foreach (var typeGroup in objects.GroupBy(x => x.GetType()))
            {
                MethodInfo mInfo = methodInfos.MakeGenericMethod(new[] { typeGroup.Key });
                var list = mInfo.Invoke(typeGroup, new object[] { typeGroup });
                success &= Create(list as dynamic);
            }*/

            List<IObject> objs = objects.Select(x => (IObject)x).ToList();

            //success &= ICreate(objs as dynamic);
            success &= WOrkDamnYou(objs);

            return success ? objects.ToList() : new List<object>();
        }

        private string IDFFilePath { get; set; }
        private EnergyPlusSettings _settings;
    }
}
