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
////public class Refrigeration:CaseAndWalkInList : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn1Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn2Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn3Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn4Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn5Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn6Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn7Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn8Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn9Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn10Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn11Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn12Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn13Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn14Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn15Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn16Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn17Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn18Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn19Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn20Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn21Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn22Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn23Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn24Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn25Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn26Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn27Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn28Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn29Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn30Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn31Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn32Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn33Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn34Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn35Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn36Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn37Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn38Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn39Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list CaseOrWalkIn40Name { get; set; } = new object-list;
////}
////}
