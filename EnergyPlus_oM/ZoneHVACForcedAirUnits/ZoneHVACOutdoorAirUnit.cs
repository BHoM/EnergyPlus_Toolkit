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
////public class ZoneHVAC:OutdoorAirUnit : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("(name of zone system is serving)")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null OutdoorAirFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list OutdoorAirScheduleName { get; set; } = new object-list;
////[Description("Allowable fan types are Fan:SystemModel and Fan:ConstantVolume and Fan:VariableVolume")]
////public virtual object-list SupplyFanName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice SupplyFanPlacement { get; set; } = new choice;
////[Description("Allowable fan types are Fan:ConstantVolume and")]
////public virtual object-list ExhaustFanName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null ExhaustAirFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list ExhaustAirScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice UnitControlType { get; set; } = new choice;
////[Description("Air and control temperatures for cooling. If outdoor air temperature")]
////public virtual object-list HighAirControlTemperatureScheduleName { get; set; } = new object-list;
////[Description("Air and control temperatures for Heating. If outdoor air temperature")]
////public virtual object-list LowAirControlTemperatureScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node OutdoorAirNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("air leaves zone")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node SupplyFanOutletNodeName { get; set; } = new node;
////[Description("Enter the name of an ZoneHVAC:OutdoorAirUnit:EquipmentList object.")]
////public virtual object-list OutdoorAirUnitListName { get; set; } = new object-list;
////[Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
////public virtual object-list AvailabilityManagerListName { get; set; } = new object-list;
////}
////}
