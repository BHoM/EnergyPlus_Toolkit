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
using System.IO;

namespace BH.Adapter.EnergyPlus
{
    public partial class EnergyPlusAdapter : BHoMAdapter
    {
        [Description("Produces an EnergyPlus Adapter to allow interopability with IDF files and the BHoM")]
        [Input("fileSettings", "Input file settings to get the path to an IDF File")]
        [Input("settings", "Settings that define how the EnergyPlus IDF file should be generated")]
        [Output("adapter", "Adapter to an IDF File")]
        public EnergyPlusAdapter(BH.oM.Adapter.FileSettings fileSettings, EnergyPlusSettings settings = null)
        {
            m_AdapterSettings.DefaultPushType = oM.Adapter.PushType.CreateOnly;

            FileSettings = fileSettings;
            _settings = settings ?? new EnergyPlusSettings();

            if(!Path.HasExtension(fileSettings.FileName) || Path.GetExtension(fileSettings.FileName) != ".idf")
            {
                BH.Engine.Reflection.Compute.RecordError("File Name must contain a file extension");
                return;
            }

            AdapterIdName = "EnergyPlus_Adapter";
        }

        private FileSettings FileSettings { get; set; }
        private EnergyPlusSettings _settings;
        private List<string> FileOutput { get; set; }
    }
}
