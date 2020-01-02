using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BH.oM.Base;
using BH.oM.Data.Requests;
using BH.oM.Reflection.Attributes;
using System.ComponentModel;

namespace BH.Adapter.EnergyPlus
{
    public partial class EnergyPlusAdapter : BHoMAdapter
    {
        [Description("Produces an EnergyPlus Adapter to allow interopability with IDF files and the BHoM. This adapter is under development. Its use is not yet sanctioned for project work. You use this at your own risk. Check the GitHub repo for the latest version and updates on development status")]
        [Input("idfFilePath", "Path to an IDF File")]
        [Output("adapter", "Adapter to an IDF File")]
        public EnergyPlusAdapter(string idfFilePath)
        {
            BH.Engine.Reflection.Compute.RecordWarning("This adapter is under development. Its use is not yet sanctioned for project work. You use this at your own risk. Check the GitHub repo for the latest version and updates on development status");
            IDFFilePath = idfFilePath;

            AdapterIdName = "EnergyPlus_Adapter";
        }

        private string IDFFilePath { get; set; }
    }
}
