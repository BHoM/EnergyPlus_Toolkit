using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class HeatBalanceAlgorithm : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "HeatBalanceAlgorithm";
        [Order][Description("No description available")]
        public virtual HeatBalanceAlgorithmMethod Algorithm { get; set; } = HeatBalanceAlgorithmMethod.ConductionTransferFunction;
        [Order][Description("No description available")]
        public virtual double SurfaceTemperatureUpperLimit { get; set; } = 200;
        [Order][Description("No description available")]
        public virtual double MinimumSurfaceConvectionHeatTransferCoefficientValue { get; set; } = 0.1;
        [Order][Description("No description available")]
        public virtual double MaximumSurfaceConvectionHeatTransferCoefficientValue { get; set; } = 1000;
    }
}
