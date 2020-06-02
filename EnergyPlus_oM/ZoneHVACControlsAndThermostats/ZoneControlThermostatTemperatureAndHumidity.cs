////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class ZoneControl:Thermostat:TemperatureAndHumidity : BHoMObject
////{
////[Description("Enter the name of a ZoneControl:Thermostat object whose operation is to be modified to")]
////public virtual object-list ThermostatName { get; set; } = new object-list;
////[Description("Schedule values should be in Relative Humidity (percent)")]
////public virtual object-list DehumidifyingRelativeHumiditySetpointScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice DehumidificationControlType { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice OvercoolRangeInputMethod { get; set; } = new choice;
////[Description("Maximum Overcool temperature range for cooling setpoint reduction.")]
////public virtual real OvercoolConstantRange { get; set; } = new real;
////[Description("Schedule values of 0.0 indicates no zone temperature overcooling will be")]
////public virtual object-list OvercoolRangeScheduleName { get; set; } = new object-list;
////[Description("The value of this input field is used to adjust the cooling setpoint temperature")]
////public virtual real OvercoolControlRatio { get; set; } = new real;
////}
////}
