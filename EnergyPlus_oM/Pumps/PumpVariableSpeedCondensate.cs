////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Pump:VariableSpeed:Condensate : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("No description available")]
////public virtual node InletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node OutletNodeName { get; set; } = new node;
////[Description("this is the volume of steam before condensation, the volume of condensate is much lower and calculated from steam density")]
////public virtual null DesignSteamVolumeFlowRate { get; set; } = new null;
////[Description("default head is 60 feet")]
////public virtual null DesignPumpHead { get; set; } = new null;
////[Description("When autosized the type of scaling factor is chosen in the input field Design Power Sizing Method")]
////public virtual null DesignPowerConsumption { get; set; } = new null;
////[Description("This is the motor efficiency only. When the Design Power Consumption is autosized using PowerPerFlowPerPressure,")]
////public virtual real MotorEfficiency { get; set; } = new real;
////[Description("No description available")]
////public virtual null FractionOfMotorInefficienciesToFluidStream { get; set; } = new null;
////[Description("No description available")]
////public virtual null Coefficient1OfThePartLoadPerformanceCurve { get; set; } = new null;
////[Description("No description available")]
////public virtual null Coefficient2OfThePartLoadPerformanceCurve { get; set; } = new null;
////[Description("No description available")]
////public virtual null Coefficient3OfThePartLoadPerformanceCurve { get; set; } = new null;
////[Description("No description available")]
////public virtual null Coefficient4OfThePartLoadPerformanceCurve { get; set; } = new null;
////[Description("Modifies the rated flow rate of the pump on a time basis. Default is")]
////public virtual object-list PumpFlowRateScheduleName { get; set; } = new object-list;
////[Description("optional, if used pump losses transfered to zone as internal gains")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("optional. If zone identified in previous field then this determines")]
////public virtual real SkinLossRadiativeFraction { get; set; } = new real;
////[Description("Used to indicate which sizing factor is used to calculate Design Power Consumption.")]
////public virtual choice DesignPowerSizingMethod { get; set; } = new choice;
////[Description("Used to size Design Power Consumption from design flow rate")]
////public virtual real DesignElectricPowerPerUnitFlowRate { get; set; } = new real;
////[Description("Used to size Design Power Consumption from design flow rate for head and motor efficiency")]
////public virtual real DesignShaftPowerPerUnitFlowRatePerUnitHead { get; set; } = new real;
////[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Subcategory table.")]
////public virtual alpha End-UseSubcategory { get; set; } = new alpha;
////}
////}