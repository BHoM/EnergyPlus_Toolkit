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
////public class SetpointManager:ReturnTemperature:HotWater : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("This is the name of the supply outlet node for the plant being controlled by this")]
////public virtual node PlantLoopSupplyOutletNode { get; set; } = new node;
////[Description("This is the name of the supply inlet node for the plant being controlled with this")]
////public virtual node PlantLoopSupplyInletNode { get; set; } = new node;
////[Description("This is the minimum reset temperature for the hot water supply.")]
////public virtual real MinimumSupplyTemperatureSetpoint { get; set; } = new real;
////[Description("This is the maximum hot water supply temperature setpoint. This is also used as the default")]
////public virtual real MaximumSupplyTemperatureSetpoint { get; set; } = new real;
////[Description("This defines whether the hot water return temperature target is constant,")]
////public virtual choice ReturnTemperatureSetpointInputType { get; set; } = new choice;
////[Description("This is the desired return temperature target, which is met by adjusting the")]
////public virtual real ReturnTemperatureSetpointConstantValue { get; set; } = new real;
////[Description("This is the desired return temperature target, which is met by adjusting the")]
////public virtual object-list ReturnTemperatureSetpointScheduleName { get; set; } = new object-list;
////}
////}
