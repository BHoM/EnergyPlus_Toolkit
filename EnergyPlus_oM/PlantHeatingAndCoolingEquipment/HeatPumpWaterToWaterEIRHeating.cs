////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class HeatPump:WaterToWater:EIR:Heating : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual node LoadSideInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node LoadSideOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node SourceSideInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node SourceSideOutletNodeName { get; set; } = new node;
////[Description("This field allows the user to specify a companion cooling")]
////public virtual object-list CompanionHeatPumpName { get; set; } = new object-list;
////[Description("This component is currently a constant-flow device, meaning it will always")]
////public virtual real LoadSideReferenceFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real SourceSideReferenceFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real ReferenceCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real ReferenceCoefficientOfPerformance { get; set; } = new real;
////[Description("Multiplies the autosized capacity and flow rates")]
////public virtual real SizingFactor { get; set; } = new real;
////[Description("Heating capacity modifier as a function of CW supply temp and entering condenser temp")]
////public virtual object-list CapacityModifierFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Electric Input Ratio (EIR) modifier as a function of temperature")]
////public virtual object-list ElectricInputToOutputRatioModifierFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Electric Input Ratio (EIR) modifier as a function of Part Load Ratio (PLR)")]
////public virtual object-list ElectricInputToOutputRatioModifierFunctionOfPartLoadRatioCurveName { get; set; } = new object-list;
////}
////}
