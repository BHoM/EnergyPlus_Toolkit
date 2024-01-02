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
////public class AirLoopHVAC:UnitaryHeatPump:AirToAir : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("Must be less than or equal to the fan's maximum flow rate.")]
////public virtual real CoolingSupplyAirFlowRate { get; set; } = new real;
////[Description("Must be less than or equal to the fan's maximum flow rate.")]
////public virtual real HeatingSupplyAirFlowRate { get; set; } = new real;
////[Description("Must be less than or equal to the fan's maximum flow rate.")]
////public virtual real NoLoadSupplyAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list ControllingZoneOrThermostatLocation { get; set; } = new object-list;
////[Description("Fan:ConstantVolume only works with continuous fan operating mode (i.e. fan")]
////public virtual choice SupplyAirFanObjectType { get; set; } = new choice;
////[Description("Needs to match in the fan object")]
////public virtual object-list SupplyAirFanName { get; set; } = new object-list;
////[Description("Only works with Coil:Heating:DX:SingleSpeed or")]
////public virtual choice HeatingCoilObjectType { get; set; } = new choice;
////[Description("Needs to match in the DX heating coil object")]
////public virtual object-list HeatingCoilName { get; set; } = new object-list;
////[Description("Only works with Coil:Cooling:DX:SingleSpeed or")]
////public virtual choice CoolingCoilObjectType { get; set; } = new choice;
////[Description("Needs to match in the DX cooling coil object")]
////public virtual object-list CoolingCoilName { get; set; } = new object-list;
////[Description("works with gas, electric, hot water and steam heating coils")]
////public virtual choice SupplementalHeatingCoilObjectType { get; set; } = new choice;
////[Description("Needs to match in the supplemental heating coil object")]
////public virtual object-list SupplementalHeatingCoilName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real MaximumSupplyAirTemperatureFromSupplementalHeater { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumOutdoorDry-BulbTemperatureForSupplementalHeaterOperation { get; set; } = new real;
////[Description("No description available")]
////public virtual choice FanPlacement { get; set; } = new choice;
////[Description("A fan operating mode schedule value of 0 indicates cycling fan mode (supply air")]
////public virtual object-list SupplyAirFanOperatingModeScheduleName { get; set; } = new object-list;
////[Description("None = meet sensible load only")]
////public virtual choice DehumidificationControlType { get; set; } = new choice;
////}
////}




