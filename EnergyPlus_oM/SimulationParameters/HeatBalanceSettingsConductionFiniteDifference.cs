using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class HeatBalanceSettingsConductionFiniteDifference : BHoMObject
    {
        [Description("No description available")]
        public virtual DifferenceScheme DifferenceScheme { get; set; } = DifferenceScheme.FullyImplicitFirstOrder;
        [Description("increase or decrease number of nodes")]
        public virtual double SpaceDiscretizationConstant { get; set; } = 3.0;
        [Description("No description available")]
        public virtual double RelaxationFactor { get; set; } = 1.0;
        [Description("No description available")]
        public virtual double InsideFaceSurfaceTemperatureConvergenceCriteria { get; set; } = 0.002;
    }
}
