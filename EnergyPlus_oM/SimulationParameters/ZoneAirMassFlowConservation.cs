using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class ZoneAirMassFlowConservation : BHoMObject
    {
        [Description("If True, Zone mixing object flow rates are adjusted to balance the zone air mass flow")]
        public virtual bool AdjustZoneMixingForZoneAirMassFlowBalance { get; set; } = false;
        [Description("This input field allows user to choose how zone infiltration flow is treated during")]
        public virtual InfiltrationBalancingMethod InfiltrationBalancingMethod { get; set; } = InfiltrationBalancingMethod.AddInfiltrationFlow;
        [Description("This input field allows user to choose which zones are included in infiltration balancing.")]
        public virtual List<string> InfiltrationBalancingZones { get; set; } = new List<string>();
    }
}
