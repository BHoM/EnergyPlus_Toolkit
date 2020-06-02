using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class ComplianceBuilding : BHoMObject
    {
        [Description("Additional degrees of rotation to be used with the requirement in ASHRAE Standard 90.1 Appendix G")]
        public virtual double BuildingRotationForAppendixG { get; set; } = 0.0;
    }
}
