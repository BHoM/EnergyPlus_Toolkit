////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Coil:Cooling:DX:SingleSpeed:ThermalStorage : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice OperatingModeControlMethod { get; set; } = new choice;
////[Description("This field is used if the control method is set to ScheduledModes")]
////public virtual object-list OperationModeControlScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice StorageType { get; set; } = new choice;
////[Description("This field is required when Storage Type is UserDefinedFluidType")]
////public virtual object-list UserDefinedFluidType { get; set; } = new object-list;
////[Description("required field if Storage Type is Water or UserDefinedFluidType")]
////public virtual real FluidStorageVolume { get; set; } = new real;
////[Description("required field if Storage Type is Ice")]
////public virtual real IceStorageCapacity { get; set; } = new real;
////[Description("If one of the previous two fields is set to autocalculate, this determines the storage capacity")]
////public virtual real StorageCapacitySizingFactor { get; set; } = new real;
////[Description("No description available")]
////public virtual node StorageTankAmbientTemperatureNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual real StorageTankToAmbientU-valueTimesAreaHeatTransferCoefficient { get; set; } = new real;
////[Description("required field if Storage Type is Water or UserDefinedFluidType")]
////public virtual real FluidStorageTankRatingTemperature { get; set; } = new real;
////[Description("Flow rate corresponding to rated total cooling capacity, Rated SHR and Rated COP")]
////public virtual real RatedEvaporatorAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual node EvaporatorAirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node EvaporatorAirOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual choice CoolingOnlyModeAvailable { get; set; } = new choice;
////[Description("required field if Cooling Only Mode is available or if autocalculating sizes")]
////public virtual real CoolingOnlyModeRatedTotalEvaporatorCoolingCapacity { get; set; } = new real;
////[Description("required field if Cooling Only Mode is available")]
////public virtual real CoolingOnlyModeRatedSensibleHeatRatio { get; set; } = new real;
////[Description("Gross cooling capacity divided by power input to the compressor and outdoor fan,")]
////public virtual real CoolingOnlyModeRatedCOP { get; set; } = new real;
////[Description("required field if Cooling Only Mode is available")]
////public virtual object-list CoolingOnlyModeTotalEvaporatorCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("required field if Cooling Only Mode is available")]
////public virtual object-list CoolingOnlyModeTotalEvaporatorCoolingCapacityFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("required field if Cooling Only Mode is available")]
////public virtual object-list CoolingOnlyModeEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("required field if Cooling Only Mode is available")]
////public virtual object-list CoolingOnlyModeEnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("required field if Cooling Only Mode is available")]
////public virtual object-list CoolingOnlyModePartLoadFractionCorrelationCurveName { get; set; } = new object-list;
////[Description("required field if Cooling Only Mode is available")]
////public virtual object-list CoolingOnlyModeSensibleHeatRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("required field if Cooling Only Mode is available")]
////public virtual object-list CoolingOnlyModeSensibleHeatRatioFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice CoolingAndChargeModeAvailable { get; set; } = new choice;
////[Description("required field if Cooling And Charge Mode is available")]
////public virtual real CoolingAndChargeModeRatedTotalEvaporatorCoolingCapacity { get; set; } = new real;
////[Description("If previous field is autocalculate, this determines the evaporator capacity")]
////public virtual real CoolingAndChargeModeCapacitySizingFactor { get; set; } = new real;
////[Description("required field if Cooling And Charge Mode is available")]
////public virtual real CoolingAndChargeModeRatedStorageChargingCapacity { get; set; } = new real;
////[Description("If previous field is autocalculate, this determines the storage cooling capacity")]
////public virtual real CoolingAndChargeModeStorageCapacitySizingFactor { get; set; } = new real;
////[Description("required field if Cooling And Charge Mode is available")]
////public virtual real CoolingAndChargeModeRatedSensibleHeatRatio { get; set; } = new real;
////[Description("Gross evaporator cooling capacity divided by power input to the compressor (for cooling) and outdoor fan,")]
////public virtual real CoolingAndChargeModeCoolingRatedCOP { get; set; } = new real;
////[Description("net cooling capacity divided by power input to the compressor (for charging) and outdoor fan,")]
////public virtual real CoolingAndChargeModeChargingRatedCOP { get; set; } = new real;
////[Description("required field if Cooling And Charge Mode is available")]
////public virtual object-list CoolingAndChargeModeTotalEvaporatorCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("required field if Cooling And Charge Mode is available")]
////public virtual object-list CoolingAndChargeModeTotalEvaporatorCoolingCapacityFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("required field if Cooling And Charge Mode is available")]
////public virtual object-list CoolingAndChargeModeEvaporatorEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("required field if Cooling And Charge Mode is available")]
////public virtual object-list CoolingAndChargeModeEvaporatorEnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("required field if Cooling And Charge Mode is available")]
////public virtual object-list CoolingAndChargeModeEvaporatorPartLoadFractionCorrelationCurveName { get; set; } = new object-list;
////[Description("required field if Cooling And Charge Mode is available")]
////public virtual object-list CoolingAndChargeModeStorageChargeCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("required field if Cooling And Charge Mode is available")]
////public virtual object-list CoolingAndChargeModeStorageChargeCapacityFunctionOfTotalEvaporatorPLRCurveName { get; set; } = new object-list;
////[Description("required field if Cooling And Charge Mode is available")]
////public virtual object-list CoolingAndChargeModeStorageEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("required field if Cooling And Charge Mode is available")]
////public virtual object-list CoolingAndChargeModeStorageEnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("required field if Cooling And Charge Mode is available")]
////public virtual object-list CoolingAndChargeModeStorageEnergyPartLoadFractionCorrelationCurveName { get; set; } = new object-list;
////[Description("required field if Cooling And Charge Mode is available")]
////public virtual object-list CoolingAndChargeModeSensibleHeatRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("required field if Cooling And Charge Mode is available")]
////public virtual object-list CoolingAndChargeModeSensibleHeatRatioFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice CoolingAndDischargeModeAvailable { get; set; } = new choice;
////[Description("required field if Cooling And Discharge Mode is available")]
////public virtual real CoolingAndDischargeModeRatedTotalEvaporatorCoolingCapacity { get; set; } = new real;
////[Description("If previous field is autocalculate, this determines the charging capacity")]
////public virtual real CoolingAndDischargeModeEvaporatorCapacitySizingFactor { get; set; } = new real;
////[Description("required field if Cooling And Discharge Mode is available")]
////public virtual real CoolingAndDischargeModeRatedStorageDischargingCapacity { get; set; } = new real;
////[Description("If previous field is autocalculate, this determines the charging capacity")]
////public virtual real CoolingAndDischargeModeStorageDischargeCapacitySizingFactor { get; set; } = new real;
////[Description("required field if Cooling And Discharge Mode is available")]
////public virtual real CoolingAndDischargeModeRatedSensibleHeatRatio { get; set; } = new real;
////[Description("Gross evaporator cooling capacity divided by power input to the compressor (for cooling) and outdoor fan,")]
////public virtual real CoolingAndDischargeModeCoolingRatedCOP { get; set; } = new real;
////[Description("gross cooling capacity divided by power input to the compressor (for discharging),")]
////public virtual real CoolingAndDischargeModeDischargingRatedCOP { get; set; } = new real;
////[Description("required field if Cooling Only Mode is available")]
////public virtual object-list CoolingAndDischargeModeTotalEvaporatorCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("required field if Cooling And Discharge Mode is available")]
////public virtual object-list CoolingAndDischargeModeTotalEvaporatorCoolingCapacityFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("required field if Cooling And Discharge Mode is available")]
////public virtual object-list CoolingAndDischargeModeEvaporatorEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("required field if Cooling And Discharge Mode is available")]
////public virtual object-list CoolingAndDischargeModeEvaporatorEnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("required field if Cooling And Discharge Mode is available")]
////public virtual object-list CoolingAndDischargeModeEvaporatorPartLoadFractionCorrelationCurveName { get; set; } = new object-list;
////[Description("required field if Cooling And Discharge Mode is available")]
////public virtual object-list CoolingAndDischargeModeStorageDischargeCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("required field if Cooling And Discharge Mode is available")]
////public virtual object-list CoolingAndDischargeModeStorageDischargeCapacityFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("required field if Cooling And Discharge Mode is available")]
////public virtual object-list CoolingAndDischargeModeStorageDischargeCapacityFunctionOfTotalEvaporatorPLRCurveName { get; set; } = new object-list;
////[Description("required field if Cooling And Discharge Mode is available")]
////public virtual object-list CoolingAndDischargeModeStorageEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("required field if Cooling And Discharge Mode is available")]
////public virtual object-list CoolingAndDischargeModeStorageEnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("required field if Cooling And Discharge Mode is available")]
////public virtual object-list CoolingAndDischargeModeStorageEnergyPartLoadFractionCorrelationCurveName { get; set; } = new object-list;
////[Description("required field if Cooling And Discharge Mode is available")]
////public virtual object-list CoolingAndDischargeModeSensibleHeatRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("required field if Cooling And Discharge Mode is available")]
////public virtual object-list CoolingAndDischargeModeSensibleHeatRatioFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice ChargeOnlyModeAvailable { get; set; } = new choice;
////[Description("required field if Charge Only Mode is available")]
////public virtual real ChargeOnlyModeRatedStorageChargingCapacity { get; set; } = new real;
////[Description("If previous field is autocalculate, this determines the charging capacity")]
////public virtual real ChargeOnlyModeCapacitySizingFactor { get; set; } = new real;
////[Description("net cooling capacity divided by power input to the compressor (for charging) and outdoor fan,")]
////public virtual real ChargeOnlyModeChargingRatedCOP { get; set; } = new real;
////[Description("required field if Charge Only Mode is available")]
////public virtual object-list ChargeOnlyModeStorageChargeCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("required field if Charge Only Mode is available")]
////public virtual object-list ChargeOnlyModeStorageEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice DischargeOnlyModeAvailable { get; set; } = new choice;
////[Description("required field if Discharge Only Mode is available")]
////public virtual real DischargeOnlyModeRatedStorageDischargingCapacity { get; set; } = new real;
////[Description("If previous field is autocalculate, this determines the discharging capacity")]
////public virtual real DischargeOnlyModeCapacitySizingFactor { get; set; } = new real;
////[Description("required field if Discharge Only Mode is available")]
////public virtual real DischargeOnlyModeRatedSensibleHeatRatio { get; set; } = new real;
////[Description("required field if Discharge Only Mode is available")]
////public virtual real DischargeOnlyModeRatedCOP { get; set; } = new real;
////[Description("required field if Discharge Only Mode is available")]
////public virtual object-list DischargeOnlyModeStorageDischargeCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("required field if Discharge Only Mode is available")]
////public virtual object-list DischargeOnlyModeStorageDischargeCapacityFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("required field if Discharge Only Mode is available")]
////public virtual object-list DischargeOnlyModeEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("required field if Discharge Only Mode is available")]
////public virtual object-list DischargeOnlyModeEnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("required field if Discharge Only Mode is available")]
////public virtual object-list DischargeOnlyModePartLoadFractionCorrelationCurveName { get; set; } = new object-list;
////[Description("required field if Discharge Only Mode is available")]
////public virtual object-list DischargeOnlyModeSensibleHeatRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("required field if Discharge Only Mode is available")]
////public virtual object-list DischargeOnlyModeSensibleHeatRatioFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("controls and miscellaneous standby ancillary electric power draw, when available")]
////public virtual real AncillaryElectricPower { get; set; } = new real;
////[Description("No description available")]
////public virtual real ColdWeatherOperationMinimumOutdoorAirTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual real ColdWeatherOperationAncillaryPower { get; set; } = new real;
////[Description("Enter the name of an outdoor air node. This node name is also specified in")]
////public virtual node CondenserAirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node CondenserAirOutletNodeName { get; set; } = new node;
////[Description("Used to calculate condenser leaving conditions and water use if evaporatively cooled.")]
////public virtual real CondenserDesignAirFlowRate { get; set; } = new real;
////[Description("If previous field is autocalculate, this determines the condenser air flow size as a")]
////public virtual real CondenserAirFlowSizingFactor { get; set; } = new real;
////[Description("No description available")]
////public virtual choice CondenserType { get; set; } = new choice;
////[Description("required field if condenser type is evaporatively cooled")]
////public virtual real EvaporativeCondenserEffectiveness { get; set; } = new real;
////[Description("Rated power consumed by the evaporative condenser's water pump")]
////public virtual real EvaporativeCondenserPumpRatedPowerConsumption { get; set; } = new real;
////[Description("This field is only used for Condenser Type = EvaporativelyCooled and for periods")]
////public virtual real BasinHeaterCapacity { get; set; } = new real;
////[Description("This field is only used for Condenser Type = EvaporativelyCooled.")]
////public virtual real BasinHeaterSetpointTemperature { get; set; } = new real;
////[Description("This field is only used for Condenser Type = EvaporativelyCooled.")]
////public virtual object-list BasinHeaterAvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list SupplyWaterStorageTankName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list CondensateCollectionWaterStorageTankName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node StorageTankPlantConnectionInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node StorageTankPlantConnectionOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual real StorageTankPlantConnectionDesignFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real StorageTankPlantConnectionHeatTransferEffectiveness { get; set; } = new real;
////[Description("For fluid storage tanks only, minimum limit for storage tank")]
////public virtual real StorageTankMinimumOperatingLimitFluidTemperature { get; set; } = new real;
////[Description("For fluid storage tanks only, maximum limit for storage tank")]
////public virtual real StorageTankMaximumOperatingLimitFluidTemperature { get; set; } = new real;
////}
////}
