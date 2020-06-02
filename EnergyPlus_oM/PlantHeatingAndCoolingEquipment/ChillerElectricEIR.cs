////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Chiller:Electric:EIR : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual real ReferenceCapacity { get; set; } = new real;
////[Description("Efficiency of the chiller compressor (cooling output/compressor energy input).")]
////public virtual real ReferenceCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real ReferenceLeavingChilledWaterTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual real ReferenceEnteringCondenserFluidTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual real ReferenceChilledWaterFlowRate { get; set; } = new real;
////[Description("This field is only used for Condenser Type = AirCooled or EvaporativelyCooled")]
////public virtual real ReferenceCondenserFluidFlowRate { get; set; } = new real;
////[Description("Cooling capacity as a function of CW supply temp and entering condenser temp")]
////public virtual object-list CoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Electric Input Ratio (EIR) as a function of temperature")]
////public virtual object-list ElectricInputToCoolingOutputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Electric Input Ratio (EIR) as a function of Part Load Ratio (PLR)")]
////public virtual object-list ElectricInputToCoolingOutputRatioFunctionOfPartLoadRatioCurveName { get; set; } = new object-list;
////[Description("Part load ratio below which the chiller starts cycling on/off to meet the load.")]
////public virtual real MinimumPartLoadRatio { get; set; } = new real;
////[Description("Maximum allowable part load ratio. Must be greater than or equal to Minimum Part Load Ratio.")]
////public virtual real MaximumPartLoadRatio { get; set; } = new real;
////[Description("Optimum part load ratio where the chiller is most efficient.")]
////public virtual real OptimumPartLoadRatio { get; set; } = new real;
////[Description("Part load ratio where the chiller can no longer unload and false loading begins.")]
////public virtual real MinimumUnloadingRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual node ChilledWaterInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node ChilledWaterOutletNodeName { get; set; } = new node;
////[Description("Not required if air-cooled or evaporatively-cooled")]
////public virtual node CondenserInletNodeName { get; set; } = new node;
////[Description("Not required if air-cooled or evaporatively-cooled")]
////public virtual node CondenserOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual choice CondenserType { get; set; } = new choice;
////[Description("Use for air-cooled or evaporatively-cooled condensers.")]
////public virtual real CondenserFanPowerRatio { get; set; } = new real;
////[Description("Fraction of compressor electrical energy that must be rejected by the condenser.")]
////public virtual real FractionOfCompressorElectricConsumptionRejectedByCondenser { get; set; } = new real;
////[Description("No description available")]
////public virtual real LeavingChilledWaterLowerTemperatureLimit { get; set; } = new real;
////[Description("Select operating mode for fluid flow through the chiller. "NotModulated" is for")]
////public virtual choice ChillerFlowMode { get; set; } = new choice;
////[Description("If non-zero, then the heat recovery inlet and outlet node names must be entered.")]
////public virtual real DesignHeatRecoveryWaterFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual node HeatRecoveryInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node HeatRecoveryOutletNodeName { get; set; } = new node;
////[Description("Multiplies the autosized capacity and flow rates")]
////public virtual real SizingFactor { get; set; } = new real;
////[Description("This field is only used for Condenser Type = EvaporativelyCooled and for periods")]
////public virtual real BasinHeaterCapacity { get; set; } = new real;
////[Description("This field is only used for Condenser Type = EvaporativelyCooled.")]
////public virtual real BasinHeaterSetpointTemperature { get; set; } = new real;
////[Description("This field is only used for Condenser Type = EvaporativelyCooled.")]
////public virtual object-list BasinHeaterOperatingScheduleName { get; set; } = new object-list;
////[Description("This optional field is the fraction of total rejected heat that can be recovered at full load")]
////public virtual real CondenserHeatRecoveryRelativeCapacityFraction { get; set; } = new real;
////[Description("This optional schedule of temperatures will turn off heat recovery if inlet exceeds the value")]
////public virtual object-list HeatRecoveryInletHighTemperatureLimitScheduleName { get; set; } = new object-list;
////[Description("This optional field provides control over the heat recovery")]
////public virtual node HeatRecoveryLeavingTemperatureSetpointNodeName { get; set; } = new node;
////[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Subcategory table.")]
////public virtual alpha End-UseSubcategory { get; set; } = new alpha;
////}
////}
