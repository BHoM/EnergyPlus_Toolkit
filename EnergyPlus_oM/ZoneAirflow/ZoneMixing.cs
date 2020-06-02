////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class ZoneMixing : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ScheduleName { get; set; } = new object-list;
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
////public virtual object-list SourceZoneName { get; set; } = new object-list;
////[Description("This field contains the constant temperature differential between source and")]
////public virtual real DeltaTemperature { get; set; } = new real;
////[Description("This schedule contains the temperature differential between source and receiving")]
////public virtual object-list DeltaTemperatureScheduleName { get; set; } = new object-list;
////[Description("This schedule contains the zone dry-bulb temperature versus time below which")]
////public virtual object-list MinimumZoneTemperatureScheduleName { get; set; } = new object-list;
////[Description("This schedule contains the zone dry-bulb temperature versus time above which")]
////public virtual object-list MaximumZoneTemperatureScheduleName { get; set; } = new object-list;
////[Description("This schedule contains the source zone dry-bulb temperature versus time below")]
////public virtual object-list MinimumSourceZoneTemperatureScheduleName { get; set; } = new object-list;
////[Description("This schedule contains the source zone dry-bulb temperature versus time above")]
////public virtual object-list MaximumSourceZoneTemperatureScheduleName { get; set; } = new object-list;
////[Description("This schedule contains the outdoor temperature versus time below which")]
////public virtual object-list MinimumOutdoorTemperatureScheduleName { get; set; } = new object-list;
////[Description("This schedule contains the outdoor temperature versus time above which")]
////public virtual object-list MaximumOutdoorTemperatureScheduleName { get; set; } = new object-list;
////}
////}
