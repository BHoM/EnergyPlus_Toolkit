using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class SimulationParameters : BHoMObject
    {
        [Description("")]
        public virtual Version Version { get; set; } = new Version();
        [Description("")]
        public virtual SimulationControl SimulationControl{ get; set; } = new SimulationControl();
        [Description("")]
        public virtual Building Building { get; set; } = new Building();
        [Description("")]
        public virtual ShadowCalculation ShadowCalculation { get; set; } = new ShadowCalculation();
        [Description("")]
        public virtual SurfaceConvectionAlgorithmInside SurfaceConvectionAlgorithmInside { get; set; } = new SurfaceConvectionAlgorithmInside();
        [Description("")]
        public virtual SurfaceConvectionAlgorithmOutside SurfaceConvectionAlgorithmOutside { get; set; } = new SurfaceConvectionAlgorithmOutside();
        [Description("")]
        public virtual HeatBalanceAlgorithm HeatBalanceAlgorithm { get; set; } = new HeatBalanceAlgorithm();
        [Description("")]
        public virtual HeatBalanceSettingsConductionFiniteDifference HeatBalanceSettingsConductionFiniteDifference { get; set; } = new HeatBalanceSettingsConductionFiniteDifference();
        [Description("")]
        public virtual ZoneAirHeatBalanceAlgorithm ZoneAirHeatBalanceAlgorithm { get; set; } = new ZoneAirHeatBalanceAlgorithm();
        [Description("")]
        public virtual Timestep Timestep { get; set; } = new Timestep();
    }
}
