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
////namespace BH.oM.EnergyPlus
////{
////public class Coil:Cooling:DX:MultiSpeed : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("Enter the name of an outdoor air node. This node name is also specified in")]
////public virtual node CondenserAirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual choice CondenserType { get; set; } = new choice;
////[Description("No description available")]
////public virtual real MinimumOutdoorDry-BulbTemperatureForCompressorOperation { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list SupplyWaterStorageTankName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list CondensateCollectionWaterStorageTankName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice ApplyPartLoadFractionToSpeedsGreaterThan1 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice ApplyLatentDegradationToSpeedsGreaterThan1 { get; set; } = new choice;
////[Description("No description available")]
////public virtual real CrankcaseHeaterCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumOutdoorDry-BulbTemperatureForCrankcaseHeaterOperation { get; set; } = new real;
////[Description("This field is only used for Condenser Type = EvaporativelyCooled and for periods")]
////public virtual real BasinHeaterCapacity { get; set; } = new real;
////[Description("This field is only used for Condenser Type = EvaporativelyCooled.")]
////public virtual real BasinHeaterSetpointTemperature { get; set; } = new real;
////[Description("This field is only used for Condenser Type = EvaporativelyCooled.")]
////public virtual object-list BasinHeaterOperatingScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice FuelType { get; set; } = new choice;
////[Description("Enter the number of the following sets of data for coil capacity, SHR, COP,")]
////public virtual integer NumberOfSpeeds { get; set; } = new integer;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed1GrossRatedTotalCoolingCapacity { get; set; } = new real;
////[Description("Gross Rated Sensible Heat Ratio (gross sensible capacity/gross total capacity)")]
////public virtual real Speed1GrossRatedSensibleHeatRatio { get; set; } = new real;
////[Description("Gross cooling capacity divided by power input to the compressor and outdoor fan,")]
////public virtual real Speed1GrossRatedCoolingCOP { get; set; } = new real;
////[Description("Flow rate corresponding to rated total cooling capacity, rated SHR and rated")]
////public virtual real Speed1RatedAirFlowRate { get; set; } = new real;
////[Description("Enter the evaporator fan power per air volume flow rate at the rated test conditions.")]
////public virtual real Speed1RatedEvaporatorFanPowerPerVolumeFlowRate { get; set; } = new real;
////[Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb")]
////public virtual object-list Speed1TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list Speed1TotalCoolingCapacityFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb")]
////public virtual object-list Speed1EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list Speed1EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*PLR + c*PLR**2")]
////public virtual object-list Speed1PartLoadFractionCorrelationCurveName { get; set; } = new object-list;
////[Description("The nominal time for condensate to begin leaving the coil's condensate")]
////public virtual real Speed1NominalTimeForCondensateRemovalToBegin { get; set; } = new real;
////[Description("Ratio of the initial moisture evaporation Rate from the Cooling Coil (when")]
////public virtual real Speed1RatioOfInitialMoistureEvaporationRateAndSteadyStateLatentCapacity { get; set; } = new real;
////[Description("The maximum on-off cycling rate for the compressor, which occurs at 50% run time")]
////public virtual real Speed1MaximumCyclingRate { get; set; } = new real;
////[Description("Time constant for the cooling coil's latent capacity to reach steady state after")]
////public virtual real Speed1LatentCapacityTimeConstant { get; set; } = new real;
////[Description("Recoverable waste heat at full load and rated conditions")]
////public virtual real Speed1RatedWasteHeatFractionOfPowerInput { get; set; } = new real;
////[Description("curve = a + b*odb + c*odb**2 + d*db + e*db**2 + f*odb*db")]
////public virtual object-list Speed1WasteHeatFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real Speed1EvaporativeCondenserEffectiveness { get; set; } = new real;
////[Description("Used to calculate evaporative condenser water use")]
////public virtual real Speed1EvaporativeCondenserAirFlowRate { get; set; } = new real;
////[Description("Rated power consumed by the evaporative condenser's water pump at high speed")]
////public virtual real Speed1RatedEvaporativeCondenserPumpPowerConsumption { get; set; } = new real;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed2GrossRatedTotalCoolingCapacity { get; set; } = new real;
////[Description("Gross Rated Sensible Heat Ratio (gross sensible capacity/gross total capacity)")]
////public virtual real Speed2GrossRatedSensibleHeatRatio { get; set; } = new real;
////[Description("Gross cooling capacity divided by power input to the compressor and outdoor fan,")]
////public virtual real Speed2GrossRatedCoolingCOP { get; set; } = new real;
////[Description("Flow rate corresponding to rated total cooling capacity, rated SHR and rated")]
////public virtual real Speed2RatedAirFlowRate { get; set; } = new real;
////[Description("Enter the evaporator fan power per air volume flow rate at the rated test conditions.")]
////public virtual real Speed2RatedEvaporatorFanPowerPerVolumeFlowRate { get; set; } = new real;
////[Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb")]
////public virtual object-list Speed2TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list Speed2TotalCoolingCapacityFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb")]
////public virtual object-list Speed2EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list Speed2EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*PLR + c*PLR**2")]
////public virtual object-list Speed2PartLoadFractionCorrelationCurveName { get; set; } = new object-list;
////[Description("The nominal time for condensate to begin leaving the coil's condensate")]
////public virtual real Speed2NominalTimeForCondensateRemovalToBegin { get; set; } = new real;
////[Description("Ratio of the initial moisture evaporation rate from the cooling coil (when")]
////public virtual real Speed2RatioOfInitialMoistureEvaporationRateAndSteadyStateLatentCapacity { get; set; } = new real;
////[Description("The maximum on-off cycling rate for the compressor, which occurs at 50% run time")]
////public virtual real Speed2MaximumCyclingRate { get; set; } = new real;
////[Description("Time constant for the cooling coil's latent capacity to reach steady state after")]
////public virtual real Speed2LatentCapacityTimeConstant { get; set; } = new real;
////[Description("Recoverable waste heat at full load and rated conditions")]
////public virtual real Speed2RatedWasteHeatFractionOfPowerInput { get; set; } = new real;
////[Description("curve = a + b*odb + c*odb**2 + d*db + e*db**2 + f*odb*db")]
////public virtual object-list Speed2WasteHeatFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real Speed2EvaporativeCondenserEffectiveness { get; set; } = new real;
////[Description("Used to calculate evaporative condenser water use")]
////public virtual real Speed2EvaporativeCondenserAirFlowRate { get; set; } = new real;
////[Description("Rated power consumed by the evaporative condenser's water pump at low speed")]
////public virtual real Speed2RatedEvaporativeCondenserPumpPowerConsumption { get; set; } = new real;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed3GrossRatedTotalCoolingCapacity { get; set; } = new real;
////[Description("Gross Rated Sensible Heat Ratio (gross sensible capacity/gross total capacity)")]
////public virtual real Speed3GrossRatedSensibleHeatRatio { get; set; } = new real;
////[Description("Gross cooling capacity divided by power input to the compressor and outdoor fan,")]
////public virtual real Speed3GrossRatedCoolingCOP { get; set; } = new real;
////[Description("Flow rate corresponding to rated total cooling capacity, rated SHR and rated")]
////public virtual real Speed3RatedAirFlowRate { get; set; } = new real;
////[Description("Enter the evaporator fan power per air volume flow rate at the rated test conditions.")]
////public virtual real Speed3RatedEvaporatorFanPowerPerVolumeFlowRate { get; set; } = new real;
////[Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb")]
////public virtual object-list Speed3TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list Speed3TotalCoolingCapacityFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb")]
////public virtual object-list Speed3EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list Speed3EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*PLR + c*PLR**2")]
////public virtual object-list Speed3PartLoadFractionCorrelationCurveName { get; set; } = new object-list;
////[Description("The nominal time for condensate to begin leaving the coil's condensate")]
////public virtual real Speed3NominalTimeForCondensateRemovalToBegin { get; set; } = new real;
////[Description("Ratio of the initial moisture evaporation rate from the cooling coil (when")]
////public virtual real Speed3RatioOfInitialMoistureEvaporationRateAndSteadyStateLatentCapacity { get; set; } = new real;
////[Description("The maximum on-off cycling rate for the compressor, which occurs at 50% run time")]
////public virtual real Speed3MaximumCyclingRate { get; set; } = new real;
////[Description("Time constant for the cooling coil's latent capacity to reach steady state after")]
////public virtual real Speed3LatentCapacityTimeConstant { get; set; } = new real;
////[Description("Recoverable waste heat at full load and rated conditions")]
////public virtual real Speed3RatedWasteHeatFractionOfPowerInput { get; set; } = new real;
////[Description("curve = a + b*odb + c*odb**2 + d*db + e*db**2 + f*odb*db")]
////public virtual object-list Speed3WasteHeatFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real Speed3EvaporativeCondenserEffectiveness { get; set; } = new real;
////[Description("Used to calculate evaporative condenser water use")]
////public virtual real Speed3EvaporativeCondenserAirFlowRate { get; set; } = new real;
////[Description("Rated power consumed by the evaporative condenser's water pump at Low speed")]
////public virtual real Speed3RatedEvaporativeCondenserPumpPowerConsumption { get; set; } = new real;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed4GrossRatedTotalCoolingCapacity { get; set; } = new real;
////[Description("Gross Rated Sensible Heat Ratio (gross sensible capacity/gross total capacity)")]
////public virtual real Speed4GrossRatedSensibleHeatRatio { get; set; } = new real;
////[Description("Gross cooling capacity divided by power input to the compressor and outdoor fan,")]
////public virtual real Speed4GrossRatedCoolingCOP { get; set; } = new real;
////[Description("Flow rate corresponding to rated total cooling capacity, rated SHR and rated")]
////public virtual real Speed4RatedAirFlowRate { get; set; } = new real;
////[Description("Enter the evaporator fan power per air volume flow rate at the rated test conditions.")]
////public virtual real Speed4RatedEvaporatorFanPowerPerVolumeFlowRate { get; set; } = new real;
////[Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb")]
////public virtual object-list Speed4TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list Speed4TotalCoolingCapacityFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb")]
////public virtual object-list Speed4EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list Speed4EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*PLR + c*PLR**2")]
////public virtual object-list Speed4PartLoadFractionCorrelationCurveName { get; set; } = new object-list;
////[Description("The nominal time for condensate to begin leaving the coil's condensate")]
////public virtual real Speed4NominalTimeForCondensateRemovalToBegin { get; set; } = new real;
////[Description("Ratio of the initial moisture evaporation rate from the cooling coil (when")]
////public virtual real Speed4RatioOfInitialMoistureEvaporationRateAndSteadyStateLatentCapacity { get; set; } = new real;
////[Description("The maximum on-off cycling rate for the compressor, which occurs at 50% run time")]
////public virtual real Speed4MaximumCyclingRate { get; set; } = new real;
////[Description("Time constant for the cooling coil's latent capacity to reach steady state after")]
////public virtual real Speed4LatentCapacityTimeConstant { get; set; } = new real;
////[Description("Recoverable waste heat at full load and rated conditions")]
////public virtual real Speed4RatedWasteHeatFractionOfPowerInput { get; set; } = new real;
////[Description("curve = a + b*odb + c*odb**2 + d*db + e*db**2 + f*odb*db")]
////public virtual object-list Speed4WasteHeatFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real Speed4EvaporativeCondenserEffectiveness { get; set; } = new real;
////[Description("Used to calculate evaporative condenser water use")]
////public virtual real Speed4EvaporativeCondenserAirFlowRate { get; set; } = new real;
////[Description("Rated power consumed by the evaporative condenser's water pump at Speed 4")]
////public virtual real Speed4RatedEvaporativeCondenserPumpPowerConsumption { get; set; } = new real;
////[Description("This input field is name of a conditioned or unconditioned zone where the secondary")]
////public virtual object-list ZoneNameForCondenserPlacement { get; set; } = new object-list;
////}
////}
