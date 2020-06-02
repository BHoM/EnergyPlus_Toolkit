////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class AirConditioner:VariableRefrigerantFlow : BHoMObject
////{
////[Description("Enter a unique name for this variable refrigerant flow heat pump.")]
////public virtual alpha HeatPumpName { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("Enter the total cooling capacity in watts at rated conditions or set to autosize.")]
////public virtual real GrossRatedTotalCoolingCapacity { get; set; } = new real;
////[Description("Enter the coefficient of performance at rated conditions or leave blank to use default.")]
////public virtual real GrossRatedCoolingCOP { get; set; } = new real;
////[Description("Enter the minimum outdoor temperature allowed for cooling operation.")]
////public virtual real MinimumOutdoorTemperatureInCoolingMode { get; set; } = new real;
////[Description("Enter the maximum outdoor temperature allowed for cooling operation.")]
////public virtual real MaximumOutdoorTemperatureInCoolingMode { get; set; } = new real;
////[Description("Enter a curve name that represents full load cooling capacity ratio as a")]
////public virtual object-list CoolingCapacityRatioModifierFunctionOfLowTemperatureCurveName { get; set; } = new object-list;
////[Description("This curve object is used to allow separate low and high cooling capacity ratio")]
////public virtual object-list CoolingCapacityRatioBoundaryCurveName { get; set; } = new object-list;
////[Description("This curve object is used to describe the high outdoor temperature")]
////public virtual object-list CoolingCapacityRatioModifierFunctionOfHighTemperatureCurveName { get; set; } = new object-list;
////[Description("Enter a curve name that represents cooling energy ratio as a function of")]
////public virtual object-list CoolingEnergyInputRatioModifierFunctionOfLowTemperatureCurveName { get; set; } = new object-list;
////[Description("This curve object is used to allow separate low and high cooling energy input ratio")]
////public virtual object-list CoolingEnergyInputRatioBoundaryCurveName { get; set; } = new object-list;
////[Description("This curve object is used to describe the high outdoor temperature")]
////public virtual object-list CoolingEnergyInputRatioModifierFunctionOfHighTemperatureCurveName { get; set; } = new object-list;
////[Description("Enter a curve name that represents cooling energy ratio as a function of")]
////public virtual object-list CoolingEnergyInputRatioModifierFunctionOfLowPart-LoadRatioCurveName { get; set; } = new object-list;
////[Description("Enter a curve name that represents cooling energy ratio as a function of")]
////public virtual object-list CoolingEnergyInputRatioModifierFunctionOfHighPart-LoadRatioCurveName { get; set; } = new object-list;
////[Description("This curve defines how rated capacity changes when the total indoor terminal unit cooling")]
////public virtual object-list CoolingCombinationRatioCorrectionFactorCurveName { get; set; } = new object-list;
////[Description("This curve defines the cycling losses when the heat pump compressor cycles on and off")]
////public virtual object-list CoolingPart-LoadFractionCorrelationCurveName { get; set; } = new object-list;
////[Description("Enter the heating capacity in watts at rated conditions or set to autosize.")]
////public virtual real GrossRatedHeatingCapacity { get; set; } = new real;
////[Description("If the Gross Rated Heating Capacity is autosized, the heating capacity is sized")]
////public virtual real RatedHeatingCapacitySizingRatio { get; set; } = new real;
////[Description("COP includes compressor and condenser fan electrical energy input")]
////public virtual real GrossRatedHeatingCOP { get; set; } = new real;
////[Description("Enter the minimum outdoor temperature allowed for heating operation.")]
////public virtual real MinimumOutdoorTemperatureInHeatingMode { get; set; } = new real;
////[Description("Enter the maximum outdoor temperature allowed for heating operation.")]
////public virtual real MaximumOutdoorTemperatureInHeatingMode { get; set; } = new real;
////[Description("Enter a curve name that represents full load heating capacity ratio as a")]
////public virtual object-list HeatingCapacityRatioModifierFunctionOfLowTemperatureCurveName { get; set; } = new object-list;
////[Description("This curve object is used to allow separate low and high heating capacity ratio")]
////public virtual object-list HeatingCapacityRatioBoundaryCurveName { get; set; } = new object-list;
////[Description("This curve object is used to describe the high outdoor temperature")]
////public virtual object-list HeatingCapacityRatioModifierFunctionOfHighTemperatureCurveName { get; set; } = new object-list;
////[Description("Enter a curve name that represents heating energy ratio as a function of")]
////public virtual object-list HeatingEnergyInputRatioModifierFunctionOfLowTemperatureCurveName { get; set; } = new object-list;
////[Description("This curve object is used to allow separate low and high heating energy input ratio")]
////public virtual object-list HeatingEnergyInputRatioBoundaryCurveName { get; set; } = new object-list;
////[Description("This curve object is used to allow separate performance curves for heating energy.")]
////public virtual object-list HeatingEnergyInputRatioModifierFunctionOfHighTemperatureCurveName { get; set; } = new object-list;
////[Description("Determines temperature type for heating capacity curves and heating energy curves.")]
////public virtual choice HeatingPerformanceCurveOutdoorTemperatureType { get; set; } = new choice;
////[Description("This curve represents the heating energy input ratio for part-load ratios less than 1.")]
////public virtual object-list HeatingEnergyInputRatioModifierFunctionOfLowPart-LoadRatioCurveName { get; set; } = new object-list;
////[Description("This curve represents the heating energy input ratio for part-load ratios greater than 1.")]
////public virtual object-list HeatingEnergyInputRatioModifierFunctionOfHighPart-LoadRatioCurveName { get; set; } = new object-list;
////[Description("This curve defines how rated capacity changes when the total indoor terminal unit heating")]
////public virtual object-list HeatingCombinationRatioCorrectionFactorCurveName { get; set; } = new object-list;
////[Description("This curve defines the cycling losses when the heat pump compressor cycles on and off")]
////public virtual object-list HeatingPart-LoadFractionCorrelationCurveName { get; set; } = new object-list;
////[Description("Enter the minimum heat pump part-load ratio (PLR). When the cooling or heating PLR is")]
////public virtual real MinimumHeatPumpPart-LoadRatio { get; set; } = new real;
////[Description("Enter the name of the zone where the master thermostat is located.")]
////public virtual object-list ZoneNameForMasterThermostatLocation { get; set; } = new object-list;
////[Description("Choose a thermostat control logic scheme. If these control types fail to control zone")]
////public virtual choice MasterThermostatPriorityControlType { get; set; } = new choice;
////[Description("this field is required if Master Thermostat Priority Control Type is Scheduled.")]
////public virtual object-list ThermostatPriorityScheduleName { get; set; } = new object-list;
////[Description("Enter the name of a ZoneTerminalUnitList. This list connects zone terminal units to this")]
////public virtual object-list ZoneTerminalUnitListName { get; set; } = new object-list;
////[Description("This field enables heat recovery operation within this VRF outdoor unit.")]
////public virtual choice HeatPumpWasteHeatRecovery { get; set; } = new choice;
////[Description("Enter the equivalent length of the farthest terminal unit from the condenser")]
////public virtual real EquivalentPipingLengthUsedForPipingCorrectionFactorInCoolingMode { get; set; } = new real;
////[Description("Enter the height difference between the highest and lowest terminal unit")]
////public virtual real VerticalHeightUsedForPipingCorrectionFactor { get; set; } = new real;
////[Description("PCF = a0 + a1*L + a2*L^2 + a3*L^3 + a4*H")]
////public virtual object-list PipingCorrectionFactorForLengthInCoolingModeCurveName { get; set; } = new object-list;
////[Description("PCF = a0 + a1*L + a2*L^2 + a3*L^3 + a4*H")]
////public virtual real PipingCorrectionFactorForHeightInCoolingModeCoefficient { get; set; } = new real;
////[Description("Enter the equivalent length of the farthest terminal unit from the condenser")]
////public virtual real EquivalentPipingLengthUsedForPipingCorrectionFactorInHeatingMode { get; set; } = new real;
////[Description("PCF = a0 + a1*L + a2*L^2 + a3*L^3 + a4*H")]
////public virtual object-list PipingCorrectionFactorForLengthInHeatingModeCurveName { get; set; } = new object-list;
////[Description("PCF = a0 + a1*L + a2*L^2 + a3*L^3 + a4*H")]
////public virtual real PipingCorrectionFactorForHeightInHeatingModeCoefficient { get; set; } = new real;
////[Description("Enter the value of the resistive heater located in the compressor(s). This heater")]
////public virtual real CrankcaseHeaterPowerPerCompressor { get; set; } = new real;
////[Description("Enter the total number of compressor. This input is used only for crankcase")]
////public virtual integer NumberOfCompressors { get; set; } = new integer;
////[Description("Enter the ratio of the first stage compressor to total compressor capacity.")]
////public virtual real RatioOfCompressorSizeToTotalCompressorCapacity { get; set; } = new real;
////[Description("Enter the maximum outdoor temperature above which the crankcase heaters are disabled.")]
////public virtual real MaximumOutdoorDry-BulbTemperatureForCrankcaseHeater { get; set; } = new real;
////[Description("Select a defrost strategy. Reverse cycle reverses the operating mode from heating to cooling")]
////public virtual choice DefrostStrategy { get; set; } = new choice;
////[Description("Choose a defrost control type. Either use a fixed Timed defrost period or select")]
////public virtual choice DefrostControl { get; set; } = new choice;
////[Description("A valid performance curve must be used if reversecycle defrost strategy is selected.")]
////public virtual object-list DefrostEnergyInputRatioModifierFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Fraction of time in defrost mode.")]
////public virtual real DefrostTimePeriodFraction { get; set; } = new real;
////[Description("Enter the size of the resistive defrost heating element.")]
////public virtual real ResistiveDefrostHeaterCapacity { get; set; } = new real;
////[Description("Enter the maximum outdoor temperature above which defrost operation is disabled.")]
////public virtual real MaximumOutdoorDry-bulbTemperatureForDefrostOperation { get; set; } = new real;
////[Description("Select either an air-cooled, evaporatively-cooled or water-cooled condenser.")]
////public virtual choice CondenserType { get; set; } = new choice;
////[Description("Choose an outside air node name or leave this field blank to use weather data.")]
////public virtual node CondenserInletNodeName { get; set; } = new node;
////[Description("Enter a water outlet node name if Condenser Type = WaterCooled.")]
////public virtual node CondenserOutletNodeName { get; set; } = new node;
////[Description("Only used when Condenser Type = WaterCooled.")]
////public virtual real WaterCondenserVolumeFlowRate { get; set; } = new real;
////[Description("Enter the effectiveness of the evaporatively cooled condenser.")]
////public virtual real EvaporativeCondenserEffectiveness { get; set; } = new real;
////[Description("Used to calculate evaporative condenser water use.")]
////public virtual real EvaporativeCondenserAirFlowRate { get; set; } = new real;
////[Description("Rated power consumed by the evaporative condenser's water pump.")]
////public virtual real EvaporativeCondenserPumpRatedPowerConsumption { get; set; } = new real;
////[Description("A separate storage tank may be used to supply an evaporatively cooled condenser.")]
////public virtual object-list SupplyWaterStorageTankName { get; set; } = new object-list;
////[Description("This field is only used for Condenser Type = EvaporativelyCooled and for periods")]
////public virtual real BasinHeaterCapacity { get; set; } = new real;
////[Description("This field is only used for Condenser Type = EvaporativelyCooled.")]
////public virtual real BasinHeaterSetpointTemperature { get; set; } = new real;
////[Description("This field is only used for Condenser Type = EvaporativelyCooled.")]
////public virtual object-list BasinHeaterOperatingScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice FuelType { get; set; } = new choice;
////[Description("The minimum outdoor temperature below which heat")]
////public virtual real MinimumOutdoorTemperatureInHeatRecoveryMode { get; set; } = new real;
////[Description("The maximum outdoor temperature above which heat")]
////public virtual real MaximumOutdoorTemperatureInHeatRecoveryMode { get; set; } = new real;
////[Description("Enter the name of a performance curve which represents")]
////public virtual object-list HeatRecoveryCoolingCapacityModifierCurveName { get; set; } = new object-list;
////[Description("Enter the fractional capacity available at the start")]
////public virtual real InitialHeatRecoveryCoolingCapacityFraction { get; set; } = new real;
////[Description("Enter the time constant used to model the transition")]
////public virtual real HeatRecoveryCoolingCapacityTimeConstant { get; set; } = new real;
////[Description("Enter the name of a performance curve which represents")]
////public virtual object-list HeatRecoveryCoolingEnergyModifierCurveName { get; set; } = new object-list;
////[Description("Enter the fractional electric consumption rate at the start")]
////public virtual real InitialHeatRecoveryCoolingEnergyFraction { get; set; } = new real;
////[Description("Enter the time constant used to model the transition")]
////public virtual real HeatRecoveryCoolingEnergyTimeConstant { get; set; } = new real;
////[Description("Enter the name of a performance curve which represents")]
////public virtual object-list HeatRecoveryHeatingCapacityModifierCurveName { get; set; } = new object-list;
////[Description("Enter the fractional capacity available at the start")]
////public virtual real InitialHeatRecoveryHeatingCapacityFraction { get; set; } = new real;
////[Description("Enter the time constant used to model the transition")]
////public virtual real HeatRecoveryHeatingCapacityTimeConstant { get; set; } = new real;
////[Description("Enter the name of a performance curve which represents")]
////public virtual object-list HeatRecoveryHeatingEnergyModifierCurveName { get; set; } = new object-list;
////[Description("Enter the fractional electric consumption rate at the start")]
////public virtual real InitialHeatRecoveryHeatingEnergyFraction { get; set; } = new real;
////[Description("Enter the time constant used to model the transition")]
////public virtual real HeatRecoveryHeatingEnergyTimeConstant { get; set; } = new real;
////}
////}
