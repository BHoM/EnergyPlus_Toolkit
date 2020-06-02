////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class ZoneHVAC:Baseboard:Convective:Water : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node InletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node OutletNodeName { get; set; } = new node;
////[Description("Enter the method used to determine the heating design capacity.")]
////public virtual choice HeatingDesignCapacityMethod { get; set; } = new choice;
////[Description("Enter the design heating capacity.Required field when the heating design capacity method")]
////public virtual real HeatingDesignCapacity { get; set; } = new real;
////[Description("Enter the heating design capacity per zone floor area.Required field when the heating design")]
////public virtual real HeatingDesignCapacityPerFloorArea { get; set; } = new real;
////[Description("Enter the fraction of auto - sized heating design capacity.Required field when capacity the")]
////public virtual real FractionOfAutosizedHeatingDesignCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual null U-FactorTimesAreaValue { get; set; } = new null;
////[Description("No description available")]
////public virtual null MaximumWaterFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual real ConvergenceTolerance { get; set; } = new real;
////}
////}
