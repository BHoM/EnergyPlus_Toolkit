////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Controller:WaterCoil : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("keys HumidityRatio or TemperatureAndHumidityRatio")]
////public virtual choice ControlVariable { get; set; } = new choice;
////[Description("Leave blank to have this automatically selected from coil type.")]
////public virtual choice Action { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice ActuatorVariable { get; set; } = new choice;
////[Description("No description available")]
////public virtual node SensorNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node ActuatorNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual real ControllerConvergenceTolerance { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumActuatedFlow { get; set; } = new real;
////[Description("No description available")]
////public virtual real MinimumActuatedFlow { get; set; } = new real;
////}
////}
