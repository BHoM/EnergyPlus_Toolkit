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
////public class DemandManager:Thermostats : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice ResetControl { get; set; } = new choice;
////[Description("If blank, duration defaults to the timestep")]
////public virtual integer MinimumResetDuration { get; set; } = new integer;
////[Description("No description available")]
////public virtual real MaximumHeatingSetpointReset { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumCoolingSetpointReset { get; set; } = new real;
////[Description("Not yet implemented")]
////public virtual real ResetStepChange { get; set; } = new real;
////[Description("No description available")]
////public virtual choice SelectionControl { get; set; } = new choice;
////[Description("If blank, duration defaults to the timestep")]
////public virtual integer RotationDuration { get; set; } = new integer;
////[Description("Enter the name of a ZoneControl:Thermostat object.")]
////public virtual object-list Thermostat1Name { get; set; } = new object-list;
////[Description("Enter the name of a ZoneControl:Thermostat object.")]
////public virtual object-list Thermostat2Name { get; set; } = new object-list;
////[Description("Enter the name of a ZoneControl:Thermostat object.")]
////public virtual object-list Thermostat3Name { get; set; } = new object-list;
////[Description("Enter the name of a ZoneControl:Thermostat object.")]
////public virtual object-list Thermostat4Name { get; set; } = new object-list;
////[Description("Enter the name of a ZoneControl:Thermostat object.")]
////public virtual object-list Thermostat5Name { get; set; } = new object-list;
////[Description("Enter the name of a ZoneControl:Thermostat object.")]
////public virtual object-list Thermostat6Name { get; set; } = new object-list;
////[Description("Enter the name of a ZoneControl:Thermostat object.")]
////public virtual object-list Thermostat7Name { get; set; } = new object-list;
////[Description("Enter the name of a ZoneControl:Thermostat object.")]
////public virtual object-list Thermostat8Name { get; set; } = new object-list;
////[Description("Enter the name of a ZoneControl:Thermostat object.")]
////public virtual object-list Thermostat9Name { get; set; } = new object-list;
////[Description("Enter the name of a ZoneControl:Thermostat object.")]
////public virtual object-list Thermostat10Name { get; set; } = new object-list;
////}
////}
