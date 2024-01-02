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
////public class Coil:Cooling:DX:TwoSpeed : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual real HighSpeedGrossRatedTotalCoolingCapacity { get; set; } = new real;
////[Description("Rated sensible heat ratio (gross sensible capacity/gross total capacity)")]
////public virtual real HighSpeedRatedSensibleHeatRatio { get; set; } = new real;
////[Description("Gross cooling capacity divided by power input to the compressor and outdoor fan,")]
////public virtual real HighSpeedGrossRatedCoolingCOP { get; set; } = new real;
////[Description("Flow rate corresponding to rated total cooling capacity, Rated SHR")]
////public virtual real HighSpeedRatedAirFlowRate { get; set; } = new real;
////[Description("Enter pressure drop for the unit containing the coil.")]
////public virtual real UnitInternalStaticAirPressure { get; set; } = new real;
////[Description("No description available")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb")]
////public virtual object-list TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list TotalCoolingCapacityFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb")]
////public virtual object-list EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*PLR + c*PLR**2")]
////public virtual object-list PartLoadFractionCorrelationCurveName { get; set; } = new object-list;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual real LowSpeedGrossRatedTotalCoolingCapacity { get; set; } = new real;
////[Description("Gross Rated Sensible Heat Ratio (gross sensible capacity/gross total capacity)")]
////public virtual real LowSpeedGrossRatedSensibleHeatRatio { get; set; } = new real;
////[Description("Gross cooling capacity divided by power input to the compressor and outdoor fan,")]
////public virtual real LowSpeedGrossRatedCoolingCOP { get; set; } = new real;
////[Description("Flow rate corresponding to rated total cooling capacity, Rated SHR")]
////public virtual real LowSpeedRatedAirFlowRate { get; set; } = new real;
////[Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb")]
////public virtual object-list LowSpeedTotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb")]
////public virtual object-list LowSpeedEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Enter the name of an outdoor air node. This node name is also specified in")]
////public virtual node CondenserAirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual choice CondenserType { get; set; } = new choice;
////[Description("No description available")]
////public virtual real MinimumOutdoorDry-BulbTemperatureForCompressorOperation { get; set; } = new real;
////[Description("No description available")]
////public virtual real HighSpeedEvaporativeCondenserEffectiveness { get; set; } = new real;
////[Description("Used to calculate evaporative condenser water use")]
////public virtual real HighSpeedEvaporativeCondenserAirFlowRate { get; set; } = new real;
////[Description("Rated power consumed by the evaporative condenser's water pump at high speed")]
////public virtual real HighSpeedEvaporativeCondenserPumpRatedPowerConsumption { get; set; } = new real;
////[Description("No description available")]
////public virtual real LowSpeedEvaporativeCondenserEffectiveness { get; set; } = new real;
////[Description("Used to calculate evaporative condenser water use")]
////public virtual real LowSpeedEvaporativeCondenserAirFlowRate { get; set; } = new real;
////[Description("Rated power consumed by the evaporative condenser's water pump at low speed")]
////public virtual real LowSpeedEvaporativeCondenserPumpRatedPowerConsumption { get; set; } = new real;
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
////[Description("curve = a + b*wb + c*wb**2 + d*db + e*db**2 + f*wb*db")]
////public virtual object-list SensibleHeatRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list SensibleHeatRatioFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("curve = a + b*wb + c*wb**2 + d*db + e*db**2 + f*wb*db")]
////public virtual object-list LowSpeedSensibleHeatRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list LowSpeedSensibleHeatRatioFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("This input field is name of a conditioned or unconditioned zone where the secondary")]
////public virtual object-list ZoneNameForCondenserPlacement { get; set; } = new object-list;
////}
////}




