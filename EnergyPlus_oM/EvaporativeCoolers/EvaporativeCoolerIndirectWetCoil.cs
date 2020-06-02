////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class EvaporativeCooler:Indirect:WetCoil : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real CoilMaximumEfficiency { get; set; } = new real;
////[Description("No description available")]
////public virtual real CoilFlowRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual null RecirculatingWaterPumpPowerConsumption { get; set; } = new null;
////[Description("No description available")]
////public virtual null SecondaryAirFanFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual real SecondaryAirFanTotalEfficiency { get; set; } = new real;
////[Description("No description available")]
////public virtual null SecondaryAirFanDeltaPressure { get; set; } = new null;
////[Description("No description available")]
////public virtual node PrimaryAirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node PrimaryAirOutletNodeName { get; set; } = new node;
////[Description("This field is not currently used and can be left blank")]
////public virtual null ControlType { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list WaterSupplyStorageTankName { get; set; } = new object-list;
////[Description("Enter the name of an outdoor air node")]
////public virtual node SecondaryAirInletNodeName { get; set; } = new node;
////}
////}
