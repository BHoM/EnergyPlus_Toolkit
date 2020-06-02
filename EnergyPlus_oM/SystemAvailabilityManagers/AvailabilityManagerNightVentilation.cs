////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class AvailabilityManager:NightVentilation : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual object-list ApplicabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list FanScheduleName { get; set; } = new object-list;
////[Description("One zone temperature must be above this scheduled temperature")]
////public virtual object-list VentilationTemperatureScheduleName { get; set; } = new object-list;
////[Description("The outdoor air temperature minus the control zone temperature")]
////public virtual null VentilationTemperatureDifference { get; set; } = new null;
////[Description("Night ventilation is disabled if any conditioned zone served by")]
////public virtual null VentilationTemperatureLowLimit { get; set; } = new null;
////[Description("the fraction (could be > 1) of the design system Flow Rate at which")]
////public virtual null NightVentingFlowFraction { get; set; } = new null;
////[Description("When AvailabilityManager:NightVentilation is used in the zone component availability")]
////public virtual object-list ControlZoneName { get; set; } = new object-list;
////}
////}
