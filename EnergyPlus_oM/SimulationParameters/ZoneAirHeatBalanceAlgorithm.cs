using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class ZoneAirHeatBalanceAlgorithm : BHoMObject
    {
        [Description("No description available")]
        public virtual ZoneAirHeatBalanceAlgorithmMethod Algorithm { get; set; } = ZoneAirHeatBalanceAlgorithmMethod.ThirdOrderBackwardDifference;
    }
}
