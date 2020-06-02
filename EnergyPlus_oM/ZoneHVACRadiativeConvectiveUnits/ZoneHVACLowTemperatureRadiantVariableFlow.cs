////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class ZoneHVAC:LowTemperatureRadiant:VariableFlow : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("Name of zone system is serving")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("Identifies surfaces that radiant system is embedded in.")]
////public virtual object-list SurfaceNameOrRadiantSurfaceGroupName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null HydronicTubingInsideDiameter { get; set; } = new null;
////[Description("(total length of pipe embedded in surface)")]
////public virtual null HydronicTubingLength { get; set; } = new null;
////[Description("(Temperature on which unit is controlled)")]
////public virtual choice TemperatureControlType { get; set; } = new choice;
////[Description("Enter the method used to determine the heating design capacity.")]
////public virtual choice HeatingDesignCapacityMethod { get; set; } = new choice;
////[Description("Enter the design heating capacity.Required field when the heating design capacity method")]
////public virtual real HeatingDesignCapacity { get; set; } = new real;
////[Description("Enter the heating design capacity per zone floor area.Required field when the heating design")]
////public virtual real HeatingDesignCapacityPerFloorArea { get; set; } = new real;
////[Description("Enter the fraction of auto - sized heating design capacity.Required field when capacity the")]
////public virtual real FractionOfAutosizedHeatingDesignCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual null MaximumHotWaterFlow { get; set; } = new null;
////[Description("No description available")]
////public virtual node HeatingWaterInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node HeatingWaterOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual null HeatingControlThrottlingRange { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list HeatingControlTemperatureScheduleName { get; set; } = new object-list;
////[Description("Enter the method used to determine the cooling design capacity for scalable sizing.")]
////public virtual choice CoolingDesignCapacityMethod { get; set; } = new choice;
////[Description("Enter the design cooling capacity. Required field when the cooling design capacity method")]
////public virtual real CoolingDesignCapacity { get; set; } = new real;
////[Description("Enter the cooling design capacity per total floor area of cooled zones served by the unit.")]
////public virtual real CoolingDesignCapacityPerFloorArea { get; set; } = new real;
////[Description("Enter the fraction of auto-sized cooling design capacity. Required field when the cooling")]
////public virtual real FractionOfAutosizedCoolingDesignCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual null MaximumColdWaterFlow { get; set; } = new null;
////[Description("No description available")]
////public virtual node CoolingWaterInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node CoolingWaterOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual null CoolingControlThrottlingRange { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list CoolingControlTemperatureScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice CondensationControlType { get; set; } = new choice;
////[Description("No description available")]
////public virtual null CondensationControlDewpointOffset { get; set; } = new null;
////[Description("No description available")]
////public virtual choice NumberOfCircuits { get; set; } = new choice;
////[Description("No description available")]
////public virtual null CircuitLength { get; set; } = new null;
////}
////}
