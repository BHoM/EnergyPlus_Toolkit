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
////public class ZoneHVAC:PackagedTerminalHeatPump : BHoMObject
////{
////[Description("Unique name for this packaged terminal heat pump object.")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("Air inlet node for the PTHP must be a zone air exhaust node.")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("Air outlet node for the PTHP must be a zone air inlet node.")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("Currently only one OutdoorAir:Mixer object type is available.")]
////public virtual choice OutdoorAirMixerObjectType { get; set; } = new choice;
////[Description("If this field is blank, the OutdoorAir:Mixer is not used.")]
////public virtual object-list OutdoorAirMixerName { get; set; } = new object-list;
////[Description("Must be less than or equal to fan size.")]
////public virtual real CoolingSupplyAirFlowRate { get; set; } = new real;
////[Description("Must be less than or equal to fan size.")]
////public virtual real HeatingSupplyAirFlowRate { get; set; } = new real;
////[Description("Must be less than or equal to fan size.")]
////public virtual real NoLoadSupplyAirFlowRate { get; set; } = new real;
////[Description("Must be less than or equal to supply air flow rate during cooling operation.")]
////public virtual real CoolingOutdoorAirFlowRate { get; set; } = new real;
////[Description("Must be less than or equal to supply air flow rate during heating operation.")]
////public virtual real HeatingOutdoorAirFlowRate { get; set; } = new real;
////[Description("Only used when heat pump Fan operating mode is continuous. This air flow rate")]
////public virtual real NoLoadOutdoorAirFlowRate { get; set; } = new real;
////[Description("Fan:ConstantVolume only works with fan operating mode is continuous.")]
////public virtual choice SupplyAirFanObjectType { get; set; } = new choice;
////[Description("Needs to match a fan object.")]
////public virtual object-list SupplyAirFanName { get; set; } = new object-list;
////[Description("Only works with Coil:Heating:DX:SingleSpeed or")]
////public virtual choice HeatingCoilObjectType { get; set; } = new choice;
////[Description("Needs to match in the DX Heating Coil object.")]
////public virtual object-list HeatingCoilName { get; set; } = new object-list;
////[Description("Defines Heating convergence tolerance as a fraction of Heating load to be met.")]
////public virtual real HeatingConvergenceTolerance { get; set; } = new real;
////[Description("Only works with Coil:Cooling:DX:SingleSpeed or")]
////public virtual choice CoolingCoilObjectType { get; set; } = new choice;
////[Description("Needs to match in the DX Cooling Coil object.")]
////public virtual object-list CoolingCoilName { get; set; } = new object-list;
////[Description("Defines Cooling convergence tolerance as a fraction of the Cooling load to be met.")]
////public virtual real CoolingConvergenceTolerance { get; set; } = new real;
////[Description("works with gas, electric, hot water and steam heating coil.")]
////public virtual choice SupplementalHeatingCoilObjectType { get; set; } = new choice;
////[Description("Needs to match in the supplemental heating coil object.")]
////public virtual object-list SupplementalHeatingCoilName { get; set; } = new object-list;
////[Description("Supply air temperature from the supplemental heater will not exceed this value.")]
////public virtual real MaximumSupplyAirTemperatureFromSupplementalHeater { get; set; } = new real;
////[Description("Supplemental heater will not operate when outdoor temperature exceeds this value.")]
////public virtual real MaximumOutdoorDry-BulbTemperatureForSupplementalHeaterOperation { get; set; } = new real;
////[Description("Select fan placement as either blow through or draw through.")]
////public virtual choice FanPlacement { get; set; } = new choice;
////[Description("Enter the name of a schedule that controls fan operation. Schedule values of 0 denote")]
////public virtual object-list SupplyAirFanOperatingModeScheduleName { get; set; } = new object-list;
////[Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
////public virtual object-list AvailabilityManagerListName { get; set; } = new object-list;
////[Description("Enter the name of a DesignSpecificationZoneHVACSizing object.")]
////public virtual object-list DesignSpecificationZoneHVACSizingObjectName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice CapacityControlMethod { get; set; } = new choice;
////[Description("For Capacity Control Method = SingleZoneVAV, enter the minimum air temperature limit for reduced fan speed.")]
////public virtual real MinimumSupplyAirTemperatureInCoolingMode { get; set; } = new real;
////[Description("For Capacity Control Method = SingleZoneVAV, enter the maximum air temperature limit for reduced fan speed.")]
////public virtual real MaximumSupplyAirTemperatureInHeatingMode { get; set; } = new real;
////}
////}


