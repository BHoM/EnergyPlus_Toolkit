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
////public class ZoneHVAC:FourPipeFanCoil : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice CapacityControlMethod { get; set; } = new choice;
////[Description("No description available")]
////public virtual null MaximumSupplyAirFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual real LowSpeedSupplyAirFlowRatio { get; set; } = new real;
////[Description("Medium Speed Supply Air Flow Ratio should be greater")]
////public virtual real MediumSpeedSupplyAirFlowRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual null MaximumOutdoorAirFlowRate { get; set; } = new null;
////[Description("Value of schedule multiplies maximum outdoor air flow rate")]
////public virtual object-list OutdoorAirScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("Currently only one type OutdoorAir:Mixer object is available.")]
////public virtual choice OutdoorAirMixerObjectType { get; set; } = new choice;
////[Description("If this field is blank, the OutdoorAir:Mixer is not used.")]
////public virtual object-list OutdoorAirMixerName { get; set; } = new object-list;
////[Description("Fan type must be according to capacity control method (see I/O)")]
////public virtual choice SupplyAirFanObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list SupplyAirFanName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice CoolingCoilObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list CoolingCoilName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null MaximumColdWaterFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual null MinimumColdWaterFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual real CoolingConvergenceTolerance { get; set; } = new real;
////[Description("No description available")]
////public virtual choice HeatingCoilObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list HeatingCoilName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null MaximumHotWaterFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual null MinimumHotWaterFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual real HeatingConvergenceTolerance { get; set; } = new real;
////[Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
////public virtual object-list AvailabilityManagerListName { get; set; } = new object-list;
////[Description("Enter the name of a DesignSpecificationZoneHVACSizing object.")]
////public virtual object-list DesignSpecificationZoneHVACSizingObjectName { get; set; } = new object-list;
////[Description("Enter the name of a schedule that controls fan operation. Schedule Name values of 0 denote")]
////public virtual object-list SupplyAirFanOperatingModeScheduleName { get; set; } = new object-list;
////[Description("For Capacity Control Method = ASHRAE90VariableFan, enter the minimum air temperature in cooling mode.")]
////public virtual real MinimumSupplyAirTemperatureInCoolingMode { get; set; } = new real;
////[Description("For Capacity Control Method = ASHRAE90VariableFan, enter the maximum air temperature in heating mode.")]
////public virtual real MaximumSupplyAirTemperatureInHeatingMode { get; set; } = new real;
////}
////}
