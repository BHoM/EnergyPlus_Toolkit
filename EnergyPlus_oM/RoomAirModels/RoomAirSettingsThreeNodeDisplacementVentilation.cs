////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class RoomAirSettings:ThreeNodeDisplacementVentilation : BHoMObject
////{
////[Description("Name of Zone being described. Any existing zone name")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("Distribution of the convective heat gains between the occupied and mixed zones.")]
////public virtual object-list GainDistributionScheduleName { get; set; } = new object-list;
////[Description("Used only in the UCSD displacement ventilation model.")]
////public virtual real NumberOfPlumesPerOccupant { get; set; } = new real;
////[Description("Height of thermostat/temperature control sensor above floor")]
////public virtual real ThermostatHeight { get; set; } = new real;
////[Description("Height at which air temperature is calculated for comfort purposes")]
////public virtual real ComfortHeight { get; set; } = new real;
////[Description("Minimum temperature difference between predicted upper and lower layer")]
////public virtual real TemperatureDifferenceThresholdForReporting { get; set; } = new real;
////}
////}
