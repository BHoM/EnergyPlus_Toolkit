////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class FluidCooler:SingleSpeed : BHoMObject
////{
////[Description("fluid cooler name")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Name of fluid cooler water inlet node")]
////public virtual node WaterInletNodeName { get; set; } = new node;
////[Description("Name of fluid cooler water outlet node")]
////public virtual node WaterOutletNodeName { get; set; } = new node;
////[Description("User can define fluid cooler thermal performance by specifying the fluid cooler UA")]
////public virtual choice PerformanceInputMethod { get; set; } = new choice;
////[Description("Leave field blank if fluid cooler Performance Input Method is NominalCapacity")]
////public virtual real DesignAirFlowRateU-factorTimesAreaValue { get; set; } = new real;
////[Description("Nominal fluid cooler capacity")]
////public virtual real NominalCapacity { get; set; } = new real;
////[Description("Design Entering Water Temperature must be specified for both the performance input methods and")]
////public virtual real DesignEnteringWaterTemperature { get; set; } = new real;
////[Description("Design Entering Air Temperature must be specified for both the performance input methods and")]
////public virtual real DesignEnteringAirTemperature { get; set; } = new real;
////[Description("Design Entering Air Wet-bulb Temperature must be specified for both the performance input methods and")]
////public virtual real DesignEnteringAirWetbulbTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual real DesignWaterFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real DesignAirFlowRate { get; set; } = new real;
////[Description("This is the fan motor electric input power")]
////public virtual real DesignAirFlowRateFanPower { get; set; } = new real;
////[Description("Enter the name of an outdoor air node")]
////public virtual node OutdoorAirInletNodeName { get; set; } = new node;
////}
////}
