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
////public class AirLoopHVAC:UnitaryHeatCool:VAVChangeoverBypass : BHoMObject
////{
////[Description("Enter a unique name for this unitary system.")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("Enter the system air flow rate during cooling")]
////public virtual real CoolingSupplyAirFlowRate { get; set; } = new real;
////[Description("Enter the system air flow rate during heating")]
////public virtual real HeatingSupplyAirFlowRate { get; set; } = new real;
////[Description("Only used when the supply air fan operating mode is continuous (see field")]
////public virtual real NoLoadSupplyAirFlowRate { get; set; } = new real;
////[Description("Enter the outdoor air flow rate during")]
////public virtual real CoolingOutdoorAirFlowRate { get; set; } = new real;
////[Description("Enter the outdoor air flow rate during")]
////public virtual real HeatingOutdoorAirFlowRate { get; set; } = new real;
////[Description("Only used when the supply air fan operating mode is continuous (see field")]
////public virtual real NoLoadOutdoorAirFlowRate { get; set; } = new real;
////[Description("Enter the name of a schedule that contains multipliers for the outdoor air")]
////public virtual object-list OutdoorAirFlowRateMultiplierScheduleName { get; set; } = new object-list;
////[Description("Enter the name of the unitary system's air inlet node.")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("Enter the name of the bypass duct mixer node. This name should be the name")]
////public virtual node BypassDuctMixerNodeName { get; set; } = new node;
////[Description("Enter the name of the bypass duct splitter node.")]
////public virtual node BypassDuctSplitterNodeName { get; set; } = new node;
////[Description("Enter the name of the unitary system's air outlet node.")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("currently only one type OutdoorAir:Mixer object is available.")]
////public virtual choice OutdoorAirMixerObjectType { get; set; } = new choice;
////[Description("Enter the name of the outdoor air mixer used with this unitary system.")]
////public virtual object-list OutdoorAirMixerName { get; set; } = new object-list;
////[Description("Specify the type of supply air fan used in this unitary system.")]
////public virtual choice SupplyAirFanObjectType { get; set; } = new choice;
////[Description("Enter the name of the supply air fan used in this unitary system.")]
////public virtual object-list SupplyAirFanName { get; set; } = new object-list;
////[Description("Specify supply air fan placement as either blow through or draw through.")]
////public virtual choice SupplyAirFanPlacement { get; set; } = new choice;
////[Description("Enter the name of a schedule to control the supply air fan. Schedule Name values of zero")]
////public virtual object-list SupplyAirFanOperatingModeScheduleName { get; set; } = new object-list;
////[Description("Specify the type of cooling coil used in this unitary system.")]
////public virtual choice CoolingCoilObjectType { get; set; } = new choice;
////[Description("Enter the name of the cooling coil used in this unitary system.")]
////public virtual object-list CoolingCoilName { get; set; } = new object-list;
////[Description("works with DX, gas, electric, hot water and steam heating coils")]
////public virtual choice HeatingCoilObjectType { get; set; } = new choice;
////[Description("Enter the name of the heating coil used in this unitary system.")]
////public virtual object-list HeatingCoilName { get; set; } = new object-list;
////[Description("CoolingPriority = system provides cooling if any zone requires cooling.")]
////public virtual choice PriorityControlMode { get; set; } = new choice;
////[Description("Specify the minimum outlet air temperature allowed for this unitary system")]
////public virtual real MinimumOutletAirTemperatureDuringCoolingOperation { get; set; } = new real;
////[Description("Specify the maximum outlet air temperature allowed for this unitary system")]
////public virtual real MaximumOutletAirTemperatureDuringHeatingOperation { get; set; } = new real;
////[Description("None = meet sensible load only.")]
////public virtual choice DehumidificationControlType { get; set; } = new choice;
////[Description("Enter the name of the bypass duct node connected to a plenum or mixer.")]
////public virtual node PlenumOrMixerInletNodeName { get; set; } = new node;
////[Description("This is the minimum amount of time the unit operates in cooling or heating mode before changing modes.")]
////public virtual real MinimumRuntimeBeforeOperatingModeChange { get; set; } = new real;
////}
////}
