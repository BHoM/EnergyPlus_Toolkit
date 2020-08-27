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
////public class Coil:Heating:DX:VariableSpeed : BHoMObject
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
////[Description("No description available")]
////public virtual real RatedHeatingCapacityAtSelectedNominalSpeedLevel { get; set; } = new real;
////[Description("No description available")]
////public virtual real RatedAirFlowRateAtSelectedNominalSpeedLevel { get; set; } = new real;
////[Description("quadratic curve = a + b*PLR + c*PLR**2")]
////public virtual object-list EnergyPartLoadFractionCurveName { get; set; } = new object-list;
////[Description("biquadratic curve = a + b*wb + c*wb**2 + d*oat + e*oat**2 + f*wb*oat")]
////public virtual object-list DefrostEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real MinimumOutdoorDry-BulbTemperatureForCompressorOperation { get; set; } = new real;
////[Description("The outdoor temperature when the compressor is automatically turned back on following an")]
////public virtual real OutdoorDry-BulbTemperatureToTurnOnCompressor { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumOutdoorDry-BulbTemperatureForDefrostOperation { get; set; } = new real;
////[Description("No description available")]
////public virtual real CrankcaseHeaterCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumOutdoorDry-BulbTemperatureForCrankcaseHeaterOperation { get; set; } = new real;
////[Description("No description available")]
////public virtual choice DefrostStrategy { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice DefrostControl { get; set; } = new choice;
////[Description("Fraction of time in defrost mode")]
////public virtual real DefrostTimePeriodFraction { get; set; } = new real;
////[Description("only applicable if resistive defrost strategy is specified")]
////public virtual real ResistiveDefrostHeaterCapacity { get; set; } = new real;
////[Description("Heating capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed1ReferenceUnitGrossRatedHeatingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed1ReferenceUnitGrossRatedHeatingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed1ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat")]
////public virtual object-list Speed1HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed1TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat")]
////public virtual object-list Speed1EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed1EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Heating capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed2ReferenceUnitGrossRatedHeatingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed2ReferenceUnitGrossRatedHeatingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed2ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat")]
////public virtual object-list Speed2HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed2TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat")]
////public virtual object-list Speed2EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed2EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Heating capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed3ReferenceUnitGrossRatedHeatingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed3ReferenceUnitGrossRatedHeatingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed3ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat")]
////public virtual object-list Speed3HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed3TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat")]
////public virtual object-list Speed3EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed3EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Heating capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed4ReferenceUnitGrossRatedHeatingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed4ReferenceUnitGrossRatedHeatingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed4ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat")]
////public virtual object-list Speed4HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed4HeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat")]
////public virtual object-list Speed4EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed4EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Heating capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed5ReferenceUnitGrossRatedHeatingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed5ReferenceUnitGrossRatedHeatingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed5ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat")]
////public virtual object-list Speed5HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed5HeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat")]
////public virtual object-list Speed5EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed5EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Heating capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed6ReferenceUnitGrossRatedHeatingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed6ReferenceUnitGrossRatedHeatingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed6ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat")]
////public virtual object-list Speed6HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed6HeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat")]
////public virtual object-list Speed6EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed6EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Heating capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed7ReferenceUnitGrossRatedHeatingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed7ReferenceUnitGrossRatedHeatingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed7ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat")]
////public virtual object-list Speed7HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed7HeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat")]
////public virtual object-list Speed7EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed7EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Heating capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed8ReferenceUnitGrossRatedHeatingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed8ReferenceUnitGrossRatedHeatingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed8ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat")]
////public virtual object-list Speed8HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed8HeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat")]
////public virtual object-list Speed8EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed8EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Heating capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed9ReferenceUnitGrossRatedHeatingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed9ReferenceUnitGrossRatedHeatingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed9ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat")]
////public virtual object-list Speed9HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed9HeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat")]
////public virtual object-list Speed9EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed9EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Heating capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed10ReferenceUnitGrossRatedHeatingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed10ReferenceUnitGrossRatedHeatingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed10ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat")]
////public virtual object-list Speed10HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed10HeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat")]
////public virtual object-list Speed10EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ffa + c*ffa**2")]
////public virtual object-list Speed10EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////}
////}
