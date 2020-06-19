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
////public class Coil:Heating:Fuel : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice FuelType { get; set; } = new choice;
////[Description("No description available")]
////public virtual null BurnerEfficiency { get; set; } = new null;
////[Description("No description available")]
////public virtual null NominalCapacity { get; set; } = new null;
////[Description("No description available")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("optional, used if coil is temperature control and not load-base controlled")]
////public virtual node TemperatureSetpointNodeName { get; set; } = new node;
////[Description("parasitic electric load associated with the coil operation")]
////public virtual null ParasiticElectricLoad { get; set; } = new null;
////[Description("quadratic curve, PLF = a + b*PLR + c*PLR**2")]
////public virtual object-list PartLoadFractionCorrelationCurveName { get; set; } = new object-list;
////[Description("parasitic fuel load associated with the coil operation (i.e., standing pilot)")]
////public virtual null ParasiticFuelLoad { get; set; } = new null;
////}
////}
