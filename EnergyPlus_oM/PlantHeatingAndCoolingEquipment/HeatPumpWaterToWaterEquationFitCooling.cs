////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class HeatPump:WaterToWater:EquationFit:Cooling : BHoMObject
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
////public virtual real ReferenceCoolingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real ReferenceCoolingPowerConsumption { get; set; } = new real;
////[Description("No description available")]
////public virtual real CoolingCapacityCoefficient1 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CoolingCapacityCoefficient2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CoolingCapacityCoefficient3 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CoolingCapacityCoefficient4 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CoolingCapacityCoefficient5 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CoolingCompressorPowerCoefficient1 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CoolingCompressorPowerCoefficient2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CoolingCompressorPowerCoefficient3 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CoolingCompressorPowerCoefficient4 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CoolingCompressorPowerCoefficient5 { get; set; } = new real;
////[Description("This optional field is used to autosize Reference Cooling Power Consumption")]
////public virtual real ReferenceCoefficientOfPerformance { get; set; } = new real;
////[Description("Multiplies the autosized capacity and flow rates")]
////public virtual real SizingFactor { get; set; } = new real;
////[Description("This optional field is used to coordinate sizing calculations between heating and cooling modes.")]
////public virtual object-list CompanionHeatingHeatPumpName { get; set; } = new object-list;
////}
////}
