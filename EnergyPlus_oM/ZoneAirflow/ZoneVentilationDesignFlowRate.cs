////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class ZoneVentilation:DesignFlowRate : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual string ZoneOrZoneListName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual string ScheduleName { get; set; } = new object-list;
////[Description("The entered calculation method is used to create the maximum amount of ventilation")]
////public virtual choice DesignFlowRateCalculationMethod { get; set; } = new choice;
////[Description("No description available")]
////public virtual real DesignFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real FlowRatePerZoneFloorArea { get; set; } = new real;
////[Description("No description available")]
////public virtual real FlowRatePerPerson { get; set; } = new real;
////[Description("No description available")]
////public virtual real AirChangesPerHour { get; set; } = new real;
////[Description("No description available")]
////public virtual choice VentilationType { get; set; } = new choice;
////[Description("pressure rise across the fan")]
////public virtual real FanPressureRise { get; set; } = new real;
////[Description("No description available")]
////public virtual real FanTotalEfficiency { get; set; } = new real;
////[Description(""A" in Equation")]
////public virtual real ConstantTermCoefficient { get; set; } = new real;
////[Description(""B" in Equation")]
////public virtual real TemperatureTermCoefficient { get; set; } = new real;
////[Description(""C" in Equation")]
////public virtual real VelocityTermCoefficient { get; set; } = new real;
////[Description(""D" in Equation")]
////public virtual real VelocitySquaredTermCoefficient { get; set; } = new real;
////[Description("this is the indoor temperature below which ventilation is shutoff")]
////public virtual real MinimumIndoorTemperature { get; set; } = new real;
////[Description("This schedule contains the indoor temperature versus time below which")]
////public virtual object-list MinimumIndoorTemperatureScheduleName { get; set; } = new object-list;
////[Description("this is the indoor temperature above which ventilation is shutoff")]
////public virtual real MaximumIndoorTemperature { get; set; } = new real;
////[Description("This schedule contains the indoor temperature versus time above which")]
////public virtual object-list MaximumIndoorTemperatureScheduleName { get; set; } = new object-list;
////[Description("This is the temperature differential between indoor and outdoor below which ventilation is shutoff.")]
////public virtual real DeltaTemperature { get; set; } = new real;
////[Description("This schedule contains the temperature differential between indoor and outdoor")]
////public virtual object-list DeltaTemperatureScheduleName { get; set; } = new object-list;
////[Description("this is the outdoor temperature below which ventilation is shutoff")]
////public virtual real MinimumOutdoorTemperature { get; set; } = new real;
////[Description("This schedule contains the outdoor temperature versus time below which")]
////public virtual object-list MinimumOutdoorTemperatureScheduleName { get; set; } = new object-list;
////[Description("this is the outdoor temperature above which ventilation is shutoff")]
////public virtual real MaximumOutdoorTemperature { get; set; } = new real;
////[Description("This schedule contains the outdoor temperature versus time above which")]
////public virtual object-list MaximumOutdoorTemperatureScheduleName { get; set; } = new object-list;
////[Description("this is the outdoor wind speed above which ventilation is shutoff")]
////public virtual real MaximumWindSpeed { get; set; } = new real;
////}
////}
