////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class ZoneHVAC:LowTemperatureRadiant:Electric : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("Name of zone system is serving")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("Identifies surfaces that radiant system is embedded in.")]
////public virtual object-list SurfaceNameOrRadiantSurfaceGroupName { get; set; } = new object-list;
////[Description("Enter the method used to determine the maximum electrical heating design capacity.")]
////public virtual choice HeatingDesignCapacityMethod { get; set; } = new choice;
////[Description("Enter the design heating capacity.Required field when the heating design capacity method")]
////public virtual real HeatingDesignCapacity { get; set; } = new real;
////[Description("Enter the heating design capacity per zone floor area.Required field when the heating design")]
////public virtual real HeatingDesignCapacityPerFloorArea { get; set; } = new real;
////[Description("Enter the fraction of auto - sized heating design capacity.Required field when capacity the")]
////public virtual real FractionOfAutosizedHeatingDesignCapacity { get; set; } = new real;
////[Description("Temperature used to control unit")]
////public virtual choice TemperatureControlType { get; set; } = new choice;
////[Description("No description available")]
////public virtual null HeatingThrottlingRange { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list HeatingSetpointTemperatureScheduleName { get; set; } = new object-list;
////}
////}
