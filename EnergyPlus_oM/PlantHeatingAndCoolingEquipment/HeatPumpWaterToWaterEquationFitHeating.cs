////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class HeatPump:WaterToWater:EquationFit:Heating : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual node SourceSideInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node SourceSideOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node LoadSideInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node LoadSideOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual real ReferenceLoadSideFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real ReferenceSourceSideFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real ReferenceHeatingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real ReferenceHeatingPowerConsumption { get; set; } = new real;
////[Description("No description available")]
////public virtual real HeatingCapacityCoefficient1 { get; set; } = new real;
////[Description("No description available")]
////public virtual real HeatingCapacityCoefficient2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real HeatingCapacityCoefficient3 { get; set; } = new real;
////[Description("No description available")]
////public virtual real HeatingCapacityCoefficient4 { get; set; } = new real;
////[Description("No description available")]
////public virtual real HeatingCapacityCoefficient5 { get; set; } = new real;
////[Description("No description available")]
////public virtual real HeatingCompressorPowerCoefficient1 { get; set; } = new real;
////[Description("No description available")]
////public virtual real HeatingCompressorPowerCoefficient2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real HeatingCompressorPowerCoefficient3 { get; set; } = new real;
////[Description("No description available")]
////public virtual real HeatingCompressorPowerCoefficient4 { get; set; } = new real;
////[Description("No description available")]
////public virtual real HeatingCompressorPowerCoefficient5 { get; set; } = new real;
////[Description("This optional field is used to autosize Reference Heating Power Consumption")]
////public virtual real ReferenceCoefficientOfPerformance { get; set; } = new real;
////[Description("Multiplies the autosized capacity and flow rates")]
////public virtual real SizingFactor { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list CompanionCoolingHeatPumpName { get; set; } = new object-list;
////}
////}