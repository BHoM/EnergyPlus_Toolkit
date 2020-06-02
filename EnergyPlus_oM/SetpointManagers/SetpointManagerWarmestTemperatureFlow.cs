////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class SetpointManager:WarmestTemperatureFlow : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("No description available")]
////public virtual choice ControlVariable { get; set; } = new choice;
////[Description("Enter the name of an AirLoopHVAC object.")]
////public virtual object-list HVACAirLoopName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real MinimumSetpointTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumSetpointTemperature { get; set; } = new real;
////[Description("For TemperatureFirst the manager tries to find the highest setpoint temperature")]
////public virtual choice Strategy { get; set; } = new choice;
////[Description("Node(s) at which the temperature will be set")]
////public virtual node SetpointNodeOrNodeListName { get; set; } = new node;
////[Description("Fraction of the maximum supply air flow rate.")]
////public virtual real MinimumTurndownRatio { get; set; } = new real;
////}
////}
