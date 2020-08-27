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
////public class AirflowNetwork:MultiZone:WindPressureCoefficientValues : BHoMObject
////{
////[Description("Enter a unique name for this object.")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Enter the name of the AirflowNetwork:Multizone:WindPressureCoefficientArray object.")]
////public virtual object-list AirflowNetwork:MultiZone:WindPressureCoefficientArrayName { get; set; } = new object-list;
////[Description("Enter the WPC Value corresponding to the 1st wind direction.")]
////public virtual real WindPressureCoefficientValue1 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 2nd wind direction.")]
////public virtual real WindPressureCoefficientValue2 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 3rd wind direction.")]
////public virtual real WindPressureCoefficientValue3 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 4th wind direction.")]
////public virtual real WindPressureCoefficientValue4 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 5th wind direction.")]
////public virtual real WindPressureCoefficientValue5 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 6th wind direction.")]
////public virtual real WindPressureCoefficientValue6 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 7th wind direction.")]
////public virtual real WindPressureCoefficientValue7 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 8th wind direction.")]
////public virtual real WindPressureCoefficientValue8 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 9th wind direction.")]
////public virtual real WindPressureCoefficientValue9 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 10th wind direction.")]
////public virtual real WindPressureCoefficientValue10 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 11th wind direction.")]
////public virtual real WindPressureCoefficientValue11 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 12th wind direction.")]
////public virtual real WindPressureCoefficientValue12 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 13th wind direction.")]
////public virtual real WindPressureCoefficientValue13 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 14th wind direction.")]
////public virtual real WindPressureCoefficientValue14 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 15th wind direction.")]
////public virtual real WindPressureCoefficientValue15 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 16th wind direction.")]
////public virtual real WindPressureCoefficientValue16 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 17th wind direction.")]
////public virtual real WindPressureCoefficientValue17 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 18th wind direction.")]
////public virtual real WindPressureCoefficientValue18 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 19th wind direction.")]
////public virtual real WindPressureCoefficientValue19 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 20th wind direction.")]
////public virtual real WindPressureCoefficientValue20 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 21st wind direction.")]
////public virtual real WindPressureCoefficientValue21 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 22nd wind direction.")]
////public virtual real WindPressureCoefficientValue22 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 23rd wind direction.")]
////public virtual real WindPressureCoefficientValue23 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 24th wind direction.")]
////public virtual real WindPressureCoefficientValue24 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 25th wind direction.")]
////public virtual real WindPressureCoefficientValue25 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 26th wind direction.")]
////public virtual real WindPressureCoefficientValue26 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 27th wind direction.")]
////public virtual real WindPressureCoefficientValue27 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 28th wind direction.")]
////public virtual real WindPressureCoefficientValue28 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 29th wind direction.")]
////public virtual real WindPressureCoefficientValue29 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 30th wind direction.")]
////public virtual real WindPressureCoefficientValue30 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 31st wind direction.")]
////public virtual real WindPressureCoefficientValue31 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 32nd wind direction.")]
////public virtual real WindPressureCoefficientValue32 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 33rd wind direction.")]
////public virtual real WindPressureCoefficientValue33 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 34th wind direction.")]
////public virtual real WindPressureCoefficientValue34 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 35th wind direction.")]
////public virtual real WindPressureCoefficientValue35 { get; set; } = new real;
////[Description("Enter the WPC Value corresponding to the 36th wind direction.")]
////public virtual real WindPressureCoefficientValue36 { get; set; } = new real;
////}
////}
