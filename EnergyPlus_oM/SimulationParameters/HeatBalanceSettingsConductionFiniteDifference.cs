using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class HeatBalanceSettingsConductionFiniteDifference : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]

        public virtual string ClassName { get; set; } = "HeatBalanceSettings:ConductionFiniteDifference";
        [Order][Description("No description available")]
        public virtual DifferenceScheme DifferenceScheme { get; set; } = DifferenceScheme.FullyImplicitFirstOrder;
        [Order][Description("increase or decrease number of nodes")]
        public virtual double SpaceDiscretizationConstant { get; set; } = 3.0;
        [Order][Description("No description available")]
        public virtual double RelaxationFactor { get; set; } = 1.0;
        [Order][Description("No description available")]
        public virtual double InsideFaceSurfaceTemperatureConvergenceCriteria { get; set; } = 0.002;
    }
}
