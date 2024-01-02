/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2024, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */

////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.Adapters.EnergyPlus
////{
////public class Coil:Cooling:DX:VariableSpeed : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
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
////public virtual real NominalTimeForCondensateToBeginLeavingTheCoil { get; set; } = new real;
////[Description("No description available")]
////public virtual real InitialMoistureEvaporationRateDividedBySteady-StateACLatentCapacity { get; set; } = new real;
////[Description("quadratic curve = a + b*PLR + c*PLR**2")]
////public virtual object-list EnergyPartLoadFractionCurveName { get; set; } = new object-list;
////[Description("Enter the name of an outdoor air node. This node name is also specified in")]
////public virtual node CondenserAirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual choice CondenserType { get; set; } = new choice;
////[Description("Rated power consumed by the evaporative condenser's water pump")]
////public virtual real EvaporativeCondenserPumpRatedPowerConsumption { get; set; } = new real;
////[Description("No description available")]
////public virtual real CrankcaseHeaterCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumOutdoorDry-BulbTemperatureForCrankcaseHeaterOperation { get; set; } = new real;
////[Description("No description available")]
////public virtual real MinimumOutdoorDry-BulbTemperatureForCompressorOperation { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list SupplyWaterStorageTankName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list CondensateCollectionWaterStorageTankName { get; set; } = new object-list;
////[Description("This field is only used for Condenser Type = EvaporativelyCooled and for periods")]
////public virtual real BasinHeaterCapacity { get; set; } = new real;
////[Description("This field is only used for Condenser Type = EvaporativelyCooled.")]
////public virtual real BasinHeaterSetpointTemperature { get; set; } = new real;
////[Description("This field is only used for Condenser Type = EvaporativelyCooled.")]
////public virtual object-list BasinHeaterOperatingScheduleName { get; set; } = new object-list;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed1ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed1ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed1ReferenceUnitGrossRatedCoolingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed1ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("This field is only used for Condenser Type = EvaporativelyCooled")]
////public virtual real Speed1ReferenceUnitRatedCondenserAirFlowRate { get; set; } = new real;
////[Description("This field is only used for Condenser Type = EvaporativelyCooled")]
////public virtual real Speed1ReferenceUnitRatedPadEffectivenessOfEvapPrecooling { get; set; } = new real;
////[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb")]
////public virtual object-list Speed1TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed1TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb")]
////public virtual object-list Speed1EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed1EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed2ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed2ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed2ReferenceUnitGrossRatedCoolingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed2ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed2ReferenceUnitRatedCondenserAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed2ReferenceUnitRatedPadEffectivenessOfEvapPrecooling { get; set; } = new real;
////[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb")]
////public virtual object-list Speed2TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed2TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb")]
////public virtual object-list Speed2EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed2EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed3ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed3ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed3ReferenceUnitGrossRatedCoolingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed3ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed3ReferenceUnitRatedCondenserAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed3ReferenceUnitRatedPadEffectivenessOfEvapPrecooling { get; set; } = new real;
////[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb")]
////public virtual object-list Speed3TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed3TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb")]
////public virtual object-list Speed3EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed3EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed4ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed4ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed4ReferenceUnitGrossRatedCoolingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed4ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed4ReferenceUnitRatedCondenserAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed4ReferenceUnitRatedPadEffectivenessOfEvapPrecooling { get; set; } = new real;
////[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb")]
////public virtual object-list Speed4TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed4TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb")]
////public virtual object-list Speed4EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed4EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed5ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed5ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed5ReferenceUnitGrossRatedCoolingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed5ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed5ReferenceUnitRatedCondenserAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed5ReferenceUnitRatedPadEffectivenessOfEvapPrecooling { get; set; } = new real;
////[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb")]
////public virtual object-list Speed5TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed5TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb")]
////public virtual object-list Speed5EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed5EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed6ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed6ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed6ReferenceUnitGrossRatedCoolingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed6ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed6ReferenceUnitCondenserAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed6ReferenceUnitRatedPadEffectivenessOfEvapPrecooling { get; set; } = new real;
////[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb")]
////public virtual object-list Speed6TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed6TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb")]
////public virtual object-list Speed6EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed6EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed7ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed7ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed7ReferenceUnitGrossRatedCoolingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed7ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed7ReferenceUnitCondenserFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed7ReferenceUnitRatedPadEffectivenessOfEvapPrecooling { get; set; } = new real;
////[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb")]
////public virtual object-list Speed7TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed7TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb")]
////public virtual object-list Speed7EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed7EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed8ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed8ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed8ReferenceUnitGrossRatedCoolingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed8ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed8ReferenceUnitCondenserAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed8ReferenceUnitRatedPadEffectivenessOfEvapPrecooling { get; set; } = new real;
////[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb")]
////public virtual object-list Speed8TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed8TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb")]
////public virtual object-list Speed8EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed8EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed9ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed9ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed9ReferenceUnitGrossRatedCoolingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed9ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("optional")]
////public virtual real Speed9ReferenceUnitCondenserAirFlowRate { get; set; } = new real;
////[Description("optional")]
////public virtual real Speed9ReferenceUnitRatedPadEffectivenessOfEvapPrecooling { get; set; } = new real;
////[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb")]
////public virtual object-list Speed9TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed9TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb")]
////public virtual object-list Speed9EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed9EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed10ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed10ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed10ReferenceUnitGrossRatedCoolingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed10ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("optional")]
////public virtual real Speed10ReferenceUnitCondenserAirFlowRate { get; set; } = new real;
////[Description("optional")]
////public virtual real Speed10ReferenceUnitRatedPadEffectivenessOfEvapPrecooling { get; set; } = new real;
////[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb")]
////public virtual object-list Speed10TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed10TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb")]
////public virtual object-list Speed10EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed10EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////}
////}




