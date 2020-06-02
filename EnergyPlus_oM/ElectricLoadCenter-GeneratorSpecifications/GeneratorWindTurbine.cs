//using BH.oM.Base;
//using System.Collections.Generic;
//using System.ComponentModel;
//
//namespace BH.oM.EnergyPlus
//{
//public class Generator:WindTurbine : BHoMObject
//{
//[Description("No description available")]
//public virtual null Name { get; set; } = new null;
//[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
//public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
//[Description("allowed values are: Horizontal Axis Wind Turbine or Vertical Axis Wind Turbine")]
//public virtual choice RotorType { get; set; } = new choice;
//[Description("Constant power output is obtained in the last three control types")]
//public virtual choice PowerControl { get; set; } = new choice;
//[Description("No description available")]
//public virtual real RatedRotorSpeed { get; set; } = new real;
//[Description("This field is the diameter of the perpendicular circle of the Vertical Axis Wind Turbine system")]
//public virtual real RotorDiameter { get; set; } = new real;
//[Description("This field is the height of the hub for the Horizontal Axis Wind Turbines and")]
//public virtual real OverallHeight { get; set; } = new real;
//[Description("No description available")]
//public virtual null NumberOfBlades { get; set; } = new null;
//[Description("This field is the nominal power at the rated wind speed.")]
//public virtual real RatedPower { get; set; } = new real;
//[Description("No description available")]
//public virtual real RatedWindSpeed { get; set; } = new real;
//[Description("No description available")]
//public virtual real CutInWindSpeed { get; set; } = new real;
//[Description("No description available")]
//public virtual real CutOutWindSpeed { get; set; } = new real;
//[Description("No description available")]
//public virtual real FractionSystemEfficiency { get; set; } = new real;
//[Description("No description available")]
//public virtual real MaximumTipSpeedRatio { get; set; } = new real;
//[Description("This field should be input if the rotor type is Horizontal Axis Wind Turbine")]
//public virtual real MaximumPowerCoefficient { get; set; } = new real;
//[Description("No description available")]
//public virtual real AnnualLocalAverageWindSpeed { get; set; } = new real;
//[Description("No description available")]
//public virtual real HeightForLocalAverageWindSpeed { get; set; } = new real;
//[Description("No description available")]
//public virtual real BladeChordArea { get; set; } = new real;
//[Description("This field is only for Vertical Axis Wind Turbine..")]
//public virtual real BladeDragCoefficient { get; set; } = new real;
//[Description("This field is only for Vertical Axis Wind Turbine..")]
//public virtual real BladeLiftCoefficient { get; set; } = new real;
//[Description("This field is only available for Horizontal Axis Wind Turbine.")]
//public virtual real PowerCoefficientC1 { get; set; } = new real;
//[Description("No description available")]
//public virtual real PowerCoefficientC2 { get; set; } = new real;
//[Description("No description available")]
//public virtual real PowerCoefficientC3 { get; set; } = new real;
//[Description("No description available")]
//public virtual real PowerCoefficientC4 { get; set; } = new real;
//[Description("No description available")]
//public virtual real PowerCoefficientC5 { get; set; } = new real;
//[Description("No description available")]
//public virtual real PowerCoefficientC6 { get; set; } = new real;
//}
//}
