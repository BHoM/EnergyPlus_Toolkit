/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2022, the respective contributors. All rights reserved.
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
////public class AirLoopHVAC:UnitaryHeatPump:WaterToAir : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("This value should be > 0 and <= than the fan air flow rate.")]
////public virtual real SupplyAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list ControllingZoneOrThermostatLocation { get; set; } = new object-list;
////[Description("Only works with On/Off Fan")]
////public virtual choice SupplyAirFanObjectType { get; set; } = new choice;
////[Description("Needs to match Fan:OnOff object")]
////public virtual object-list SupplyAirFanName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice HeatingCoilObjectType { get; set; } = new choice;
////[Description("Needs to match in the water-to-air heat pump heating coil object")]
////public virtual object-list HeatingCoilName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real HeatingConvergence { get; set; } = new real;
////[Description("No description available")]
////public virtual choice CoolingCoilObjectType { get; set; } = new choice;
////[Description("Needs to match in the water-to-air heat pump cooling coil object")]
////public virtual object-list CoolingCoilName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real CoolingConvergence { get; set; } = new real;
////[Description("The maximum on-off cycling rate for the compressor")]
////public virtual real MaximumCyclingRate { get; set; } = new real;
////[Description("Time constant for the cooling coil's capacity to reach steady state after startup")]
////public virtual real HeatPumpTimeConstant { get; set; } = new real;
////[Description("The fraction of on-cycle power use to adjust the part load fraction based on")]
////public virtual null FractionOfOn-CyclePowerUse { get; set; } = new null;
////[Description("Programmed time delay for heat pump fan to shut off after compressor cycle off.")]
////public virtual null HeatPumpFanDelayTime { get; set; } = new null;
////[Description("works with gas, electric, hot water and steam heating coils")]
////public virtual choice SupplementalHeatingCoilObjectType { get; set; } = new choice;
////[Description("Needs to match in the supplemental heating coil object")]
////public virtual object-list SupplementalHeatingCoilName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real MaximumSupplyAirTemperatureFromSupplementalHeater { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumOutdoorDry-BulbTemperatureForSupplementalHeaterOperation { get; set; } = new real;
////[Description("No description available")]
////public virtual node OutdoorDry-BulbTemperatureSensorNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual choice FanPlacement { get; set; } = new choice;
////[Description("Enter the name of a schedule that controls fan operation. Schedule values of 0 denote")]
////public virtual object-list SupplyAirFanOperatingModeScheduleName { get; set; } = new object-list;
////[Description("None = meet sensible load only")]
////public virtual choice DehumidificationControlType { get; set; } = new choice;
////[Description("used only when the heat pump coils are of the type WaterToAirHeatPump:EquationFit")]
////public virtual choice HeatPumpCoilWaterFlowMode { get; set; } = new choice;
////}
////}


