////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class DesignSpecification:OutdoorAir : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Flow/Person => Outdoor Air Flow per Person * Occupancy = Design Flow Rate,")]
////public virtual choice OutdoorAirMethod { get; set; } = new choice;
////[Description("0.00944 m3/s is equivalent to 20 cfm per person")]
////public virtual real OutdoorAirFlowPerPerson { get; set; } = new real;
////[Description("This input is only used if the field Outdoor Air Method is Flow/Area, Sum, or Maximum")]
////public virtual null OutdoorAirFlowPerZoneFloorArea { get; set; } = new null;
////[Description("This input is only used if the field Outdoor Air Method is Flow/Zone, Sum, or Maximum")]
////public virtual real OutdoorAirFlowPerZone { get; set; } = new real;
////[Description("This input is only used if the field Outdoor Air Method is AirChanges/Hour, Sum, or Maximum")]
////public virtual real OutdoorAirFlowAirChangesPerHour { get; set; } = new real;
////[Description("Schedule values are multiplied by the Outdoor Air Flow rate calculated using")]
////public virtual object-list OutdoorAirScheduleName { get; set; } = new object-list;
////[Description("This input is only used to calculate the minimum outdoor air flow rate when the field")]
////public virtual object-list ProportionalControlMinimumOutdoorAirFlowRateScheduleName { get; set; } = new object-list;
////}
////}
