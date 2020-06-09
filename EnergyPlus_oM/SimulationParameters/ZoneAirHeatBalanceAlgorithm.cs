using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class ZoneAirHeatBalanceAlgorithm : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "ZoneAirHeatBalanceAlgorithm";
        [Order]
        [Description("No description available")]
        public virtual ZoneAirHeatBalanceAlgorithmMethod Algorithm { get; set; } = ZoneAirHeatBalanceAlgorithmMethod.ThirdOrderBackwardDifference;
    }
}
