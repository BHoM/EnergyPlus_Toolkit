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

//using BH.oM.Base;
//using System.Collections.Generic;
//using System.ComponentModel;
//
//namespace BH.oM.Adapters.EnergyPlus
//{
//public class OutdoorAir:Node : BHoMObject
//{
//[Description("No description available")]
//public virtual node Name { get; set; } = new node;
//[Description("A value less than zero indicates that the height will be ignored and the weather file conditions will be used.")]
//public virtual real HeightAboveGround { get; set; } = new real;
//[Description("Schedule values are real numbers, -100.0 to 100.0, units C")]
//public virtual object-list DrybulbTemperatureScheduleName { get; set; } = new object-list;
//[Description("Schedule values are real numbers, -100.0 to 100.0, units C")]
//public virtual object-list WetbulbTemperatureScheduleName { get; set; } = new object-list;
//[Description("Schedule values are real numbers, 0.0 to 40.0, units m/s")]
//public virtual object-list WindSpeedScheduleName { get; set; } = new object-list;
//[Description("Schedule values are real numbers, 0.0 to 360.0, units degree")]
//public virtual object-list WindDirectionScheduleName { get; set; } = new object-list;
//[Description("The name of the AirflowNetwork:MultiZone:WindPressureCoefficientValues, curve, or table object specifying the wind pressure coefficient.")]
//public virtual object-list WindPressureCoefficientCurveName { get; set; } = new object-list;
//[Description("Specify whether the pressure curve is symmetric or not.")]
//public virtual choice SymmetricWindPressureCoefficientCurve { get; set; } = new choice;
//[Description("Specify whether the angle used to compute the wind pressure coefficient is absolute or relative")]
//public virtual choice WindAngleType { get; set; } = new choice;
//}
//}
