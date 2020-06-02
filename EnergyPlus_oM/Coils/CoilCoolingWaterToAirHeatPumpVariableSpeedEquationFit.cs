////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Coil:Cooling:WaterToAirHeatPump:VariableSpeedEquationFit : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual node Water-to-RefrigerantHXWaterInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Water-to-RefrigerantHXWaterOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node IndoorAirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node IndoorAirOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual integer NumberOfSpeeds { get; set; } = new integer;
////[Description("must be lower than or equal to the highest speed number")]
////public virtual integer NominalSpeedLevel { get; set; } = new integer;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual real GrossRatedTotalCoolingCapacityAtSelectedNominalSpeedLevel { get; set; } = new real;
////[Description("No description available")]
////public virtual real RatedAirFlowRateAtSelectedNominalSpeedLevel { get; set; } = new real;
////[Description("No description available")]
////public virtual real RatedWaterFlowRateAtSelectedNominalSpeedLevel { get; set; } = new real;
////[Description("No description available")]
////public virtual real NominalTimeForCondensateToBeginLeavingTheCoil { get; set; } = new real;
////[Description("No description available")]
////public virtual real InitialMoistureEvaporationRateDividedBySteady-StateACLatentCapacity { get; set; } = new real;
////[Description("Flag for using hot gas reheat, 0 - not used, 1 - used")]
////public virtual real FlagForUsingHotGasReheat,0Or1 { get; set; } = new real;
////[Description("quadratic curve = a + b*PLR + c*PLR**2")]
////public virtual object-list EnergyPartLoadFractionCurveName { get; set; } = new object-list;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed1ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed1ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed1ReferenceUnitGrossRatedCoolingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed1ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed1ReferenceUnitRatedWaterFlowRate { get; set; } = new real;
////[Description("curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt")]
////public virtual object-list Speed1TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed1TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffw + c*ffw**2")]
////public virtual object-list Speed1TotalCoolingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt")]
////public virtual object-list Speed1EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed1EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffw + c*ffw**2")]
////public virtual object-list Speed1EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real Speed1ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = new real;
////[Description("curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt")]
////public virtual object-list Speed1WasteHeatFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed2ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed2ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed2ReferenceUnitGrossRatedCoolingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed2ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed2ReferenceUnitRatedWaterFlowRate { get; set; } = new real;
////[Description("curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt")]
////public virtual object-list Speed2TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed2TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffw + c*ffw**2")]
////public virtual object-list Speed2TotalCoolingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("curve = a + b*wb + c*wb**2 + d*ewet + e*ewt**2 + f*wb*ewt")]
////public virtual object-list Speed2EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed2EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffw + c*ffw**2")]
////public virtual object-list Speed2EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real Speed2ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = new real;
////[Description("curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt")]
////public virtual object-list Speed2WasteHeatFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed3ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed3ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed3ReferenceUnitGrossRatedCoolingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed3ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed3ReferenceUnitRatedWaterFlowRate { get; set; } = new real;
////[Description("optional")]
////public virtual object-list Speed3TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed3TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed3TotalCoolingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed3EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed3EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed3EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real Speed3ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = new real;
////[Description("optional")]
////public virtual object-list Speed3WasteHeatFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed4ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed4ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed4ReferenceUnitGrossRatedCoolingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed4ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed4ReferenceUnitRatedWaterFlowRate { get; set; } = new real;
////[Description("optional")]
////public virtual object-list Speed4TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed4TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed4TotalCoolingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed4EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed4EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed4EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real Speed4ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = new real;
////[Description("optional")]
////public virtual object-list Speed4WasteHeatFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed5ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed5ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed5ReferenceUnitGrossRatedCoolingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed5ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed5ReferenceUnitRatedWaterFlowRate { get; set; } = new real;
////[Description("optional")]
////public virtual object-list Speed5TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed5TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed5TotalCoolingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed5EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed5EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed5EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real Speed5ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = new real;
////[Description("optional")]
////public virtual object-list Speed5WasteHeatFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed6ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed6ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed6ReferenceUnitGrossRatedCoolingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed6ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed6ReferenceUnitRatedWaterFlowRate { get; set; } = new real;
////[Description("optional")]
////public virtual object-list Speed6TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed6TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed6TotalCoolingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed6EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed6EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed6EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real Speed6ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = new real;
////[Description("optional")]
////public virtual object-list Speed6WasteHeatFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed7ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed7ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed7ReferenceUnitGrossRatedCoolingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed7ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed7ReferenceUnitRatedWaterFlowRate { get; set; } = new real;
////[Description("optional")]
////public virtual object-list Speed7TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed7TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed7TotalCoolingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed7EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed7EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed7EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real Speed7ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = new real;
////[Description("optional")]
////public virtual object-list Speed7WasteHeatFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed8ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed8ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed8ReferenceUnitGrossRatedCoolingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed8ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed8ReferenceUnitRatedWaterFlowRate { get; set; } = new real;
////[Description("optional")]
////public virtual object-list Speed8TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed8TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed8TotalCoolingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed8EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed8EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed8EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real Speed8ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = new real;
////[Description("optional")]
////public virtual object-list Speed8WasteHeatFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed9ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed9ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed9ReferenceUnitGrossRatedCoolingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed9ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed9ReferenceUnitRatedWaterFlowRate { get; set; } = new real;
////[Description("optional")]
////public virtual object-list Speed9TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed9TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed9TotalCoolingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed9EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed9EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed9EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real Speed9ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = new real;
////[Description("optional")]
////public virtual object-list Speed9WasteHeatFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed10ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed10ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed10ReferenceUnitGrossRatedCoolingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed10ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed10ReferenceUnitRatedWaterFlowRate { get; set; } = new real;
////[Description("optional")]
////public virtual object-list Speed10TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed10TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed10TotalCoolingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed10EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed10EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed10EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real Speed10ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = new real;
////[Description("optional")]
////public virtual object-list Speed10WasteHeatFunctionOfTemperatureCurveName { get; set; } = new object-list;
////}
////}
