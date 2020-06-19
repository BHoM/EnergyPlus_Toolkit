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
////public class Coil:Heating:DX:VariableRefrigerantFlow : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilitySchedule { get; set; } = new object-list;
////[Description("Heating capacity not accounting for the effect of supply air fan heat")]
////public virtual real GrossRatedHeatingCapacity { get; set; } = new real;
////[Description("volume flow rate corresponding to rated total capacity")]
////public virtual real RatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual node CoilAirInletNode { get; set; } = new node;
////[Description("No description available")]
////public virtual node CoilAirOutletNode { get; set; } = new node;
////[Description("No description available")]
////public virtual object-list HeatingCapacityRatioModifierFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list HeatingCapacityModifierFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////}
////}
