/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2023, the respective contributors. All rights reserved.
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
////public class ChillerHeater:Absorption:DoubleEffect : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual null NominalCoolingCapacity { get; set; } = new null;
////[Description("A positive fraction that represents the ratio of the")]
////public virtual null HeatingToCoolingCapacityRatio { get; set; } = new null;
////[Description("The positive fraction that represents the ratio of the")]
////public virtual null ThermalEnergyInputToCoolingOutputRatio { get; set; } = new null;
////[Description("The positive fraction that represents the ratio of the")]
////public virtual null ThermalEnergyInputToHeatingOutputRatio { get; set; } = new null;
////[Description("The positive fraction that represents the ratio of the")]
////public virtual null ElectricInputToCoolingOutputRatio { get; set; } = new null;
////[Description("The positive fraction that represents the ratio of the")]
////public virtual null ElectricInputToHeatingOutputRatio { get; set; } = new null;
////[Description("No description available")]
////public virtual node ChilledWaterInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node ChilledWaterOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node CondenserInletNodeName { get; set; } = new node;
////[Description("Not required if air-cooled")]
////public virtual node CondenserOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node HotWaterInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node HotWaterOutletNodeName { get; set; } = new node;
////[Description("The positive fraction that represents the minimum cooling output possible when")]
////public virtual null MinimumPartLoadRatio { get; set; } = new null;
////[Description("The positive fraction that represents the maximum cooling output possible at")]
////public virtual null MaximumPartLoadRatio { get; set; } = new null;
////[Description("The positive fraction that represents the optimal cooling output at rated")]
////public virtual null OptimumPartLoadRatio { get; set; } = new null;
////[Description("The temperature of the water entering the condenser of the chiller when")]
////public virtual null DesignEnteringCondenserWaterTemperature { get; set; } = new null;
////[Description("The temperature of the water leaving the evaporator of the chiller when")]
////public virtual null DesignLeavingChilledWaterTemperature { get; set; } = new null;
////[Description("For variable volume this is the max flow & for constant flow this is the flow.")]
////public virtual null DesignChilledWaterFlowRate { get; set; } = new null;
////[Description("The water flow rate at design conditions through the condenser.")]
////public virtual null DesignCondenserWaterFlowRate { get; set; } = new null;
////[Description("The water flow rate at design conditions through the heater side.")]
////public virtual null DesignHotWaterFlowRate { get; set; } = new null;
////[Description("The CoolCapFT curve represents the fraction of the cooling capacity of the chiller as it")]
////public virtual object-list CoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("The curve represents the fraction of the fuel input to the chiller at full load as")]
////public virtual object-list FuelInputToCoolingOutputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("The curve represents the fraction of the fuel input to the chiller as the load on")]
////public virtual object-list FuelInputToCoolingOutputRatioFunctionOfPartLoadRatioCurveName { get; set; } = new object-list;
////[Description("The curve represents the fraction of the electricity to the chiller at full load as")]
////public virtual object-list ElectricInputToCoolingOutputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("The curve represents the fraction of the electricity to the chiller as the load on")]
////public virtual object-list ElectricInputToCoolingOutputRatioFunctionOfPartLoadRatioCurveName { get; set; } = new object-list;
////[Description("The curve represents how the heating capacity of the chiller varies with cooling")]
////public virtual object-list HeatingCapacityFunctionOfCoolingCapacityCurveName { get; set; } = new object-list;
////[Description("When the chiller is operating as only a heater, this curve is used to represent the")]
////public virtual object-list FuelInputToHeatOutputRatioDuringHeatingOnlyOperationCurveName { get; set; } = new object-list;
////[Description("Sets the second independent variable in the three temperature dependent performance")]
////public virtual choice TemperatureCurveInputVariable { get; set; } = new choice;
////[Description("The condenser can either be air cooled or connected to a cooling tower.")]
////public virtual choice CondenserType { get; set; } = new choice;
////[Description("The chilled water supply temperature below which the chiller")]
////public virtual null ChilledWaterTemperatureLowerLimit { get; set; } = new null;
////[Description("No description available")]
////public virtual choice ExhaustSourceObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ExhaustSourceObjectName { get; set; } = new object-list;
////[Description("Multiplies the autosized capacity and flow rates")]
////public virtual real SizingFactor { get; set; } = new real;
////}
////}



