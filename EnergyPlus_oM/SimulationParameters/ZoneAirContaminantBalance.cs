using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class ZoneAirContaminantBalance : BHoMObject
    {
        [Description("If True, CO2 simulation will be performed.")]
        public virtual bool CarbonDioxideConcentration { get; set; } = false;
        [Description("Schedule values should be in parts per million (ppm)")]
        public virtual List<string> OutdoorCarbonDioxideScheduleName { get; set; } = new List<string>();
        [Description("If True, generic contaminant simulation will be performed.")]
        public virtual bool GenericContaminantConcentration { get; set; } = false;
        [Description("Schedule values should be generic contaminant concentration in parts per")]
        public virtual List<string> OutdoorGenericContaminantScheduleName { get; set; } = new List<string>();
    }
}
