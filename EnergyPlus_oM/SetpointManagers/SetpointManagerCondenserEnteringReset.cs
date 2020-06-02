////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class SetpointManager:CondenserEnteringReset : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual choice ControlVariable { get; set; } = new choice;
////[Description("This scheduled setpoint value is only used in a given timestep if the")]
////public virtual object-list DefaultCondenserEnteringWaterTemperatureScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list MinimumDesignWetbulbTemperatureCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list MinimumOutsideAirWetbulbTemperatureCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list OptimizedCondEnteringWaterTemperatureCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real MinimumLift { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumCondenserEnteringWaterTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual real CoolingTowerDesignInletAirWet-BulbTemperature { get; set; } = new real;
////[Description("Node(s) at which control variable will be set")]
////public virtual node SetpointNodeOrNodeListName { get; set; } = new node;
////}
////}
