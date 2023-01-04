/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2023, the respective contributors. All rights reserved.
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
////public class Foundation:Kiva : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Indoor air temperature used for Kiva initialization (prior to warmup period)")]
////public virtual real InitialIndoorAirTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list InteriorHorizontalInsulationMaterialName { get; set; } = new object-list;
////[Description("Distance from the slab bottom to the top of interior horizontal")]
////public virtual real InteriorHorizontalInsulationDepth { get; set; } = new real;
////[Description("Extent of insulation as measured from the wall interior")]
////public virtual real InteriorHorizontalInsulationWidth { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list InteriorVerticalInsulationMaterialName { get; set; } = new object-list;
////[Description("Extent of insulation as measured from the wall top to the bottom")]
////public virtual real InteriorVerticalInsulationDepth { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list ExteriorHorizontalInsulationMaterialName { get; set; } = new object-list;
////[Description("Distance from the exterior grade to the top of exterior horizontal")]
////public virtual real ExteriorHorizontalInsulationDepth { get; set; } = new real;
////[Description("Extent of insulation as measured from the wall exterior")]
////public virtual real ExteriorHorizontalInsulationWidth { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list ExteriorVerticalInsulationMaterialName { get; set; } = new object-list;
////[Description("Extent of insulation as measured from the wall top to the bottom")]
////public virtual real ExteriorVerticalInsulationDepth { get; set; } = new real;
////[Description("Distance from the exterior grade to the wall top")]
////public virtual real WallHeightAboveGrade { get; set; } = new real;
////[Description("Distance from the slab bottom to the bottom of the foundation wall")]
////public virtual real WallDepthBelowSlab { get; set; } = new real;
////[Description("Defines the below-grade surface construction for slabs. Required")]
////public virtual object-list FootingWallConstructionName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list FootingMaterialName { get; set; } = new object-list;
////[Description("Top-to-bottom dimension of the footing (not to be confused with its")]
////public virtual real FootingDepth { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list CustomBlock1MaterialName { get; set; } = new object-list;
////[Description("Top-to-bottom dimension of the block downward.")]
////public virtual real CustomBlock1Depth { get; set; } = new real;
////[Description("Position outward (+) or inward (-) relative to the foundation wall")]
////public virtual real CustomBlock1XPosition { get; set; } = new real;
////[Description("Position downward (+) relative to the foundation wall top")]
////public virtual real CustomBlock1ZPosition { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list CustomBlock2MaterialName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real CustomBlock2Depth { get; set; } = new real;
////[Description("No description available")]
////public virtual real CustomBlock2XPosition { get; set; } = new real;
////[Description("No description available")]
////public virtual real CustomBlock2ZPosition { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list CustomBlock3MaterialName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real CustomBlock3Depth { get; set; } = new real;
////[Description("No description available")]
////public virtual real CustomBlock3XPosition { get; set; } = new real;
////[Description("No description available")]
////public virtual real CustomBlock3ZPosition { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list CustomBlock4MaterialName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real CustomBlock4Depth { get; set; } = new real;
////[Description("No description available")]
////public virtual real CustomBlock4XPosition { get; set; } = new real;
////[Description("No description available")]
////public virtual real CustomBlock4ZPosition { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list CustomBlock5MaterialName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real CustomBlock5Depth { get; set; } = new real;
////[Description("No description available")]
////public virtual real CustomBlock5XPosition { get; set; } = new real;
////[Description("No description available")]
////public virtual real CustomBlock5ZPosition { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list CustomBlock6MaterialName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real CustomBlock6Depth { get; set; } = new real;
////[Description("No description available")]
////public virtual real CustomBlock6XPosition { get; set; } = new real;
////[Description("No description available")]
////public virtual real CustomBlock6ZPosition { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list CustomBlock7MaterialName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real CustomBlock7Depth { get; set; } = new real;
////[Description("No description available")]
////public virtual real CustomBlock7XPosition { get; set; } = new real;
////[Description("No description available")]
////public virtual real CustomBlock7ZPosition { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list CustomBlock8MaterialName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real CustomBlock8Depth { get; set; } = new real;
////[Description("No description available")]
////public virtual real CustomBlock8XPosition { get; set; } = new real;
////[Description("No description available")]
////public virtual real CustomBlock8ZPosition { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list CustomBlock9MaterialName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real CustomBlock9Depth { get; set; } = new real;
////[Description("No description available")]
////public virtual real CustomBlock9XPosition { get; set; } = new real;
////[Description("No description available")]
////public virtual real CustomBlock9ZPosition { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list CustomBlock10MaterialName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real CustomBlock10Depth { get; set; } = new real;
////[Description("No description available")]
////public virtual real CustomBlock10XPosition { get; set; } = new real;
////[Description("No description available")]
////public virtual real CustomBlock10ZPosition { get; set; } = new real;
////}
////}



