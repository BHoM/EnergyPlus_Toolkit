using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class ComplianceBuilding : BHoMObject
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "Compliance:Building";
        [Order]
        [Description("Additional degrees of rotation to be used with the requirement in ASHRAE Standard 90.1 Appendix G")]
        public virtual double BuildingRotationForAppendixG { get; set; } = 0.0;
    }
}
