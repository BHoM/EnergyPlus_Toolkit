/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2024, the respective contributors. All rights reserved.
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
////public class Parametric:RunControl : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual choice PerformRun1 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun2 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun3 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun4 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun5 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun6 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun7 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun8 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun9 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun10 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun11 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun12 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun13 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun14 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun15 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun16 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun17 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun18 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun19 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun20 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun21 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun22 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun23 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun24 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun25 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun26 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun27 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun28 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun29 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun30 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun31 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun32 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun33 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun34 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun35 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun36 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun37 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun38 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun39 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun40 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun41 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun42 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun43 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun44 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun45 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun46 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun47 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun48 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun49 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun50 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun51 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun52 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun53 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun54 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun55 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun56 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun57 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun58 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun59 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun60 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun61 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun62 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun63 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun64 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun65 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun66 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun67 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun68 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun69 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun70 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun71 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun72 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun73 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun74 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun75 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun76 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun77 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun78 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun79 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun80 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun81 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun82 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun83 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun84 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun85 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun86 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun87 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun88 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun89 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun90 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun91 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun92 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun93 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun94 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun95 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun96 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun97 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun98 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun99 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PerformRun100 { get; set; } = new choice;
////}
////}




