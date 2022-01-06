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
////public class ZoneHVAC:VentilatedSlab : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("(name of zone system is serving)")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("(name of surface system is embedded in) or list of surfaces")]
////public virtual object-list SurfaceNameOrRadiantSurfaceGroupName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null MaximumAirFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual choice OutdoorAirControlType { get; set; } = new choice;
////[Description("No description available")]
////public virtual null MinimumOutdoorAirFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list MinimumOutdoorAirScheduleName { get; set; } = new object-list;
////[Description("schedule values multiply the minimum outdoor air flow rate")]
////public virtual null MaximumOutdoorAirFlowRate { get; set; } = new null;
////[Description("Note that this depends on the control type as to whether schedule values are a fraction or temperature")]
////public virtual object-list MaximumOutdoorAirFractionOrTemperatureScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice SystemConfigurationType { get; set; } = new choice;
////[Description("No description available")]
////public virtual null HollowCoreInsideDiameter { get; set; } = new null;
////[Description("(length of core cavity embedded in surface)")]
////public virtual null HollowCoreLength { get; set; } = new null;
////[Description("flow will be divided evenly among the cores")]
////public virtual null NumberOfCores { get; set; } = new null;
////[Description("(temperature on which unit is controlled)")]
////public virtual choice TemperatureControlType { get; set; } = new choice;
////[Description("Air and control temperatures for heating work together to provide")]
////public virtual object-list HeatingHighAirTemperatureScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list HeatingLowAirTemperatureScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list HeatingHighControlTemperatureScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list HeatingLowControlTemperatureScheduleName { get; set; } = new object-list;
////[Description("See note for heating high air temperature schedule above for")]
////public virtual object-list CoolingHighAirTemperatureScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list CoolingLowAirTemperatureScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list CoolingHighControlTemperatureScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list CoolingLowControlTemperatureScheduleName { get; set; } = new object-list;
////[Description("This is the zone return air inlet to the ventilated slab system outdoor air mixer.")]
////public virtual node ReturnAirNodeName { get; set; } = new node;
////[Description("This is the node entering the slab or series of slabs after the fan and coil(s).")]
////public virtual node SlabInNodeName { get; set; } = new node;
////[Description("This is the node name exiting the slab.")]
////public virtual node ZoneSupplyAirNodeName { get; set; } = new node;
////[Description("This node is the outdoor air inlet to the ventilated slab oa mixer.")]
////public virtual node OutdoorAirNodeName { get; set; } = new node;
////[Description("This node is the relief air node from the ventilated slab outdoor air mixer.")]
////public virtual node ReliefAirNodeName { get; set; } = new node;
////[Description("This is the node name leaving the outdoor air mixer and entering the fan and coil(s).")]
////public virtual node OutdoorAirMixerOutletNodeName { get; set; } = new node;
////[Description("This is the node name of the fan outlet.")]
////public virtual node FanOutletNodeName { get; set; } = new node;
////[Description("Allowable fan types are Fan:SystemModel and Fan:ConstantVolume")]
////public virtual object-list FanName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice CoilOptionType { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice HeatingCoilObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list HeatingCoilName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node HotWaterOrSteamInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual choice CoolingCoilObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list CoolingCoilName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node ColdWaterInletNodeName { get; set; } = new node;
////[Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
////public virtual object-list AvailabilityManagerListName { get; set; } = new object-list;
////[Description("Enter the name of a DesignSpecificationZoneHVACSizing object.")]
////public virtual object-list DesignSpecificationZoneHVACSizingObjectName { get; set; } = new object-list;
////}
////}


