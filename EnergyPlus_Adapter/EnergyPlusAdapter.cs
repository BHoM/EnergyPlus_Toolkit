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
            m_AdapterSettings.DefaultPushType = oM.Adapter.PushType.CreateOnly;

            IDFFilePath = idfFilePath;
            _settings = settings ?? new EnergyPlusSettings();

            AdapterIdName = "EnergyPlus_Adapter";
        }

        private string IDFFilePath { get; set; }
        private EnergyPlusSettings _settings;
    }
}
