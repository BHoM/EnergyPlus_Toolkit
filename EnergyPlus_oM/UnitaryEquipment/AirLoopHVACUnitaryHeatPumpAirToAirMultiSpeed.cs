/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2021, the respective contributors. All rights reserved.
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
////public class AirLoopHVAC:UnitaryHeatPump:AirToAir:MultiSpeed : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual object-list ControllingZoneOrThermostatLocation { get; set; } = new object-list;
////[Description("Select the type of supply air fan used in this unitary system.")]
////public virtual choice SupplyAirFanObjectType { get; set; } = new choice;
////[Description("Enter the name of the supply air fan used in this unitary system.")]
////public virtual object-list SupplyAirFanName { get; set; } = new object-list;
////[Description("Select supply air fan placement as either BlowThrough or DrawThrough.")]
////public virtual choice SupplyAirFanPlacement { get; set; } = new choice;
////[Description("Enter the name of a schedule to control the supply air fan. Schedule values of zero")]
////public virtual object-list SupplyAirFanOperatingModeScheduleName { get; set; } = new object-list;
////[Description("Multi Speed DX, Electric, Gas, and Single speed Water and Steam coils")]
////public virtual choice HeatingCoilObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list HeatingCoilName { get; set; } = new object-list;
////[Description("Needs to match the corresponding minimum outdoor temperature defined")]
////public virtual real MinimumOutdoorDry-BulbTemperatureForCompressorOperation { get; set; } = new real;
////[Description("Only works with Coil:Cooling:DX:MultiSpeed")]
////public virtual choice CoolingCoilObjectType { get; set; } = new choice;
////[Description("Needs to match in the DX Cooling Coil object")]
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
////public virtual real AuxiliaryOn-CycleElectricPower { get; set; } = new real;
////[Description("No description available")]
////public virtual real AuxiliaryOff-CycleElectricPower { get; set; } = new real;
////[Description("If non-zero, then the heat recovery inlet and outlet node names must be entered.")]
////public virtual real DesignHeatRecoveryWaterFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual null MaximumTemperatureForHeatRecovery { get; set; } = new null;
////[Description("No description available")]
////public virtual node HeatRecoveryWaterInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node HeatRecoveryWaterOutletNodeName { get; set; } = new node;
////[Description("Only used when the supply air fan operating mode is continuous (see field")]
////public virtual real NoLoadSupplyAirFlowRate { get; set; } = new real;
////[Description("Enter the number of the following sets of data for air flow rates.")]
////public virtual integer NumberOfSpeedsForHeating { get; set; } = new integer;
////[Description("Enter the number of the following sets of data for air flow rates.")]
////public virtual integer NumberOfSpeedsForCooling { get; set; } = new integer;
////[Description("Enter the operating supply air flow rate during heating")]
////public virtual real HeatingSpeed1SupplyAirFlowRate { get; set; } = new real;
////[Description("Enter the operating supply air flow rate during heating")]
////public virtual real HeatingSpeed2SupplyAirFlowRate { get; set; } = new real;
////[Description("Enter the operating supply air flow rate during heating")]
////public virtual real HeatingSpeed3SupplyAirFlowRate { get; set; } = new real;
////[Description("Enter the operating supply air flow rate during heating")]
////public virtual real HeatingSpeed4SupplyAirFlowRate { get; set; } = new real;
////[Description("Enter the operating supply air flow rate during cooling")]
////public virtual real CoolingSpeed1SupplyAirFlowRate { get; set; } = new real;
////[Description("Enter the operating supply air flow rate during cooling")]
////public virtual real CoolingSpeed2SupplyAirFlowRate { get; set; } = new real;
////[Description("Enter the operating supply air flow rate during cooling")]
////public virtual real CoolingSpeed3SupplyAirFlowRate { get; set; } = new real;
////[Description("Enter the operating supply air flow rate during cooling")]
////public virtual real CoolingSpeed4SupplyAirFlowRate { get; set; } = new real;
////}
////}

