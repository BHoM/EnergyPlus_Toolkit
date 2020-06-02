////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class WaterHeater:Mixed : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual real TankVolume { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list SetpointTemperatureScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DeadbandTemperatureDifference { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumTemperatureLimit { get; set; } = new real;
////[Description("No description available")]
////public virtual choice HeaterControlType { get; set; } = new choice;
////[Description("No description available")]
////public virtual real HeaterMaximumCapacity { get; set; } = new real;
////[Description("Only used when Heater Control Type is set to Modulate")]
////public virtual real HeaterMinimumCapacity { get; set; } = new real;
////[Description("Not yet implemented")]
////public virtual real HeaterIgnitionMinimumFlowRate { get; set; } = new real;
////[Description("Not yet implemented")]
////public virtual real HeaterIgnitionDelay { get; set; } = new real;
////[Description("No description available")]
////public virtual choice HeaterFuelType { get; set; } = new choice;
////[Description("No description available")]
////public virtual real HeaterThermalEfficiency { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list PartLoadFactorCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real OffCycleParasiticFuelConsumptionRate { get; set; } = new real;
////[Description("No description available")]
////public virtual choice OffCycleParasiticFuelType { get; set; } = new choice;
////[Description("No description available")]
////public virtual real OffCycleParasiticHeatFractionToTank { get; set; } = new real;
////[Description("No description available")]
////public virtual real OnCycleParasiticFuelConsumptionRate { get; set; } = new real;
////[Description("No description available")]
////public virtual choice OnCycleParasiticFuelType { get; set; } = new choice;
////[Description("No description available")]
////public virtual real OnCycleParasiticHeatFractionToTank { get; set; } = new real;
////[Description("No description available")]
////public virtual choice AmbientTemperatureIndicator { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list AmbientTemperatureScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list AmbientTemperatureZoneName { get; set; } = new object-list;
////[Description("required for Ambient Temperature Indicator=Outdoors")]
////public virtual node AmbientTemperatureOutdoorAirNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual real OffCycleLossCoefficientToAmbientTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual real OffCycleLossFractionToZone { get; set; } = new real;
////[Description("No description available")]
////public virtual real OnCycleLossCoefficientToAmbientTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual real OnCycleLossFractionToZone { get; set; } = new real;
////[Description("Only used if Use Side Node connections are blank")]
////public virtual real PeakUseFlowRate { get; set; } = new real;
////[Description("Only used if Use Side Node connections are blank")]
////public virtual object-list UseFlowRateFractionScheduleName { get; set; } = new object-list;
////[Description("Only used if Use Side Node connections are blank")]
////public virtual object-list ColdWaterSupplyTemperatureScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node UseSideInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node UseSideOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual real UseSideEffectiveness { get; set; } = new real;
////[Description("No description available")]
////public virtual node SourceSideInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node SourceSideOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual real SourceSideEffectiveness { get; set; } = new real;
////[Description("No description available")]
////public virtual real UseSideDesignFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real SourceSideDesignFlowRate { get; set; } = new real;
////[Description("Parameter for autosizing design flow rates for indirectly heated water tanks")]
////public virtual real IndirectWaterHeatingRecoveryTime { get; set; } = new real;
////[Description("StorageTank mode always requests flow unless tank is at its Maximum Temperature Limit")]
////public virtual choice SourceSideFlowControlMode { get; set; } = new choice;
////[Description("This field is only used if the previous is set to IndirectHeatAlternateSetpoint")]
////public virtual object-list IndirectAlternateSetpointTemperatureScheduleName { get; set; } = new object-list;
////[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Subcategory table.")]
////public virtual alpha End-UseSubcategory { get; set; } = new alpha;
////}
////}
