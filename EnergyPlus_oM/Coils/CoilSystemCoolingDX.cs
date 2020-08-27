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
////public class CoilSystem:Cooling:DX : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node DXCoolingCoilSystemInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node DXCoolingCoilSystemOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node DXCoolingCoilSystemSensorNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual choice CoolingCoilObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list CoolingCoilName { get; set; } = new object-list;
////[Description("None = meet sensible load only")]
////public virtual choice DehumidificationControlType { get; set; } = new choice;
////[Description("If True, unit will run if there is a sensible load.")]
////public virtual choice RunOnSensibleLoad { get; set; } = new choice;
////[Description("If True, unit will run if there is a latent load.")]
////public virtual choice RunOnLatentLoad { get; set; } = new choice;
////[Description("This input field is designed for use with DX cooling coils with low air flow")]
////public virtual choice UseOutdoorAirDXCoolingCoil { get; set; } = new choice;
////[Description("DX cooling coil leaving minimum air temperature defines the minimum DX cooling coil")]
////public virtual real OutdoorAirDXCoolingCoilLeavingMinimumAirTemperature { get; set; } = new real;
////}
////}
