/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2020, the respective contributors. All rights reserved.
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
////public class Coil:Heating:WaterToAirHeatPump:VariableSpeedEquationFit : BHoMObject
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
////[Description("No description available")]
////public virtual real RatedHeatingCapacityAtSelectedNominalSpeedLevel { get; set; } = new real;
////[Description("No description available")]
////public virtual real RatedAirFlowRateAtSelectedNominalSpeedLevel { get; set; } = new real;
////[Description("No description available")]
////public virtual real RatedWaterFlowRateAtSelectedNominalSpeedLevel { get; set; } = new real;
////[Description("quadratic curve = a + b*PLR + c*PLR**2")]
////public virtual object-list EnergyPartLoadFractionCurveName { get; set; } = new object-list;
////[Description("Heating capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed1ReferenceUnitGrossRatedHeatingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed1ReferenceUnitGrossRatedHeatingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed1ReferenceUnitRatedAirFlow { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed1ReferenceUnitRatedWaterFlowRate { get; set; } = new real;
////[Description("curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt")]
////public virtual object-list Speed1HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed1TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffw + c*ffw**2")]
////public virtual object-list Speed1HeatingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt")]
////public virtual object-list Speed1EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed1EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffw + c*ffw**2")]
////public virtual object-list Speed1EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real Speed1ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = new real;
////[Description("curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt")]
////public virtual object-list Speed1WasteHeatFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Heating capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed2ReferenceUnitGrossRatedHeatingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed2ReferenceUnitGrossRatedHeatingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed2ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed2ReferenceUnitRatedWaterFlowRate { get; set; } = new real;
////[Description("curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt")]
////public virtual object-list Speed2HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed2TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffw + c*ffw**2")]
////public virtual object-list Speed2HeatingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt")]
////public virtual object-list Speed2EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed2EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed2EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real Speed2ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = new real;
////[Description("curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt")]
////public virtual object-list Speed2WasteHeatFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Heating capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed3ReferenceUnitGrossRatedHeatingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed3ReferenceUnitGrossRatedHeatingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed3ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed3ReferenceUnitRatedWaterFlowRate { get; set; } = new real;
////[Description("optional")]
////public virtual object-list Speed3HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed3TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed3HeatingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
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
////[Description("Heating capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed4ReferenceUnitGrossRatedHeatingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed4ReferenceUnitGrossRatedHeatingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed4ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed4ReferenceUnitRatedWaterFlowRate { get; set; } = new real;
////[Description("optional")]
////public virtual object-list Speed4HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed4TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed4HeatingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
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
////[Description("Heating capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed5ReferenceUnitGrossRatedHeatingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed5ReferenceUnitGrossRatedHeatingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed5ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed5ReferenceUnitRatedWaterFlowRate { get; set; } = new real;
////[Description("optional")]
////public virtual object-list Speed5HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed5TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed5HeatingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
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
////[Description("Heating capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed6ReferenceUnitGrossRatedHeatingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed6ReferenceUnitGrossRatedHeatingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed6ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed6ReferenceUnitRatedWaterFlowRate { get; set; } = new real;
////[Description("optional")]
////public virtual object-list Speed6HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed6TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed6HeatingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
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
////[Description("Heating capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed7ReferenceUnitGrossRatedHeatingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed7ReferenceUnitGrossRatedHeatingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed7ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed7ReferenceUnitRatedWaterFlowRate { get; set; } = new real;
////[Description("optional")]
////public virtual object-list Speed7HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed7TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed7HeatingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
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
////[Description("Heating capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed8ReferenceUnitGrossRatedHeatingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed8ReferenceUnitGrossRatedHeatingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed8ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed8ReferenceUnitRatedWaterFlowRate { get; set; } = new real;
////[Description("optional")]
////public virtual object-list Speed8HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed8TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed8HeatingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
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
////[Description("Heating capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed9ReferenceUnitGrossRatedHeatingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed9ReferenceUnitGrossRatedHeatingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed9ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed9ReferenceUnitRatedWaterFlowRate { get; set; } = new real;
////[Description("optional")]
////public virtual object-list Speed9HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed9TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed9HeatingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
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
////[Description("Heating capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed10ReferenceUnitGrossRatedHeatingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed10ReferenceUnitGrossRatedHeatingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed10ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed10ReferenceUnitRatedWaterFlowRate { get; set; } = new real;
////[Description("optional")]
////public virtual object-list Speed10HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed10TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("optional")]
////public virtual object-list Speed10HeatingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
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
