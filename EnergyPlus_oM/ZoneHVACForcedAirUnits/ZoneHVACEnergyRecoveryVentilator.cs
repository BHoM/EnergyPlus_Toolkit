////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class ZoneHVAC:EnergyRecoveryVentilator : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("Heat exchanger type must be HeatExchanger:AirToAir:SensibleAndLatent")]
////public virtual object-list HeatExchangerName { get; set; } = new object-list;
////[Description("This flow rate must match the supply fan's air flow rate.")]
////public virtual real SupplyAirFlowRate { get; set; } = new real;
////[Description("This flow rate must match the supply fan air flow rate.")]
////public virtual real ExhaustAirFlowRate { get; set; } = new real;
////[Description("Fan type must be Fan:OnOff or Fan:SystemModel")]
////public virtual object-list SupplyAirFanName { get; set; } = new object-list;
////[Description("Fan type must be Fan:OnOff or Fan:SystemModel")]
////public virtual object-list ExhaustAirFanName { get; set; } = new object-list;
////[Description("Enter the name of a ZoneHVAC:EnergyRecoveryVentilator:Controller object.")]
////public virtual object-list ControllerName { get; set; } = new object-list;
////[Description("0.000508 m3/s-m2 corresponds to 0.1 ft3/min-ft2")]
////public virtual real VentilationRatePerUnitFloorArea { get; set; } = new real;
////[Description("0.00236 m3/s-person corresponds to 5 ft3/min-person")]
////public virtual real VentilationRatePerOccupant { get; set; } = new real;
////[Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
////public virtual object-list AvailabilityManagerListName { get; set; } = new object-list;
////}
////}
