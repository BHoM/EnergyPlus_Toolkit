using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class HeatBalanceAlgorithm : BHoMObject
    {
        [Description("No description available")]
        public virtual HeatBalanceAlgorithmMethod Algorithm { get; set; } = HeatBalanceAlgorithmMethod.ConductionTransferFunction;
        [Description("No description available")]
        public virtual double SurfaceTemperatureUpperLimit { get; set; } = 200;
        [Description("No description available")]
        public virtual double MinimumSurfaceConvectionHeatTransferCoefficientValue { get; set; } = 0.1;
        [Description("No description available")]
        public virtual double MaximumSurfaceConvectionHeatTransferCoefficientValue { get; set; } = 1000;
    }
}
