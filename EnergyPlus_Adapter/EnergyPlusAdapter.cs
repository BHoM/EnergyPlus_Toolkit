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

            AdapterId = "EnergyPlus_Adapter";
            Config.UseAdapterId = false;        //Set to true when NextId method and id tagging has been implemented
        }

        public override List<IObject> Push(IEnumerable<IObject> objects, String tag = "", Dictionary<String, object> config = null)
        {
            bool success = true;

            MethodInfo methodInfos = typeof(Enumerable).GetMethod("Cast");
            foreach (var typeGroup in objects.GroupBy(x => x.GetType()))
            {
                MethodInfo mInfo = methodInfos.MakeGenericMethod(new[] { typeGroup.Key });
                var list = mInfo.Invoke(typeGroup, new object[] { typeGroup });
                success &= Create(list as dynamic);
            }

            return success ? objects.ToList() : new List<IObject>();
        }

        public override IEnumerable<object> Pull(IRequest request, Dictionary<string, object> config = null)
        {
            if (request is IRequest)
                return Read();

            return new List<IBHoMObject>();
        }


        private string IDFFilePath { get; set; }
        private EnergyPlusSettings _settings;
    }
}
