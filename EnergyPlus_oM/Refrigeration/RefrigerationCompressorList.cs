/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2022, the respective contributors. All rights reserved.
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
////public class Refrigeration:CompressorList : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor1Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor2Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor3Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor4Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor5Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor6Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor7Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor8Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor9Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor10Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor11Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor12Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor13Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor14Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor15Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor16Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor17Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor18Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor19Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor20Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor21Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor22Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor23Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor24Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor25Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor26Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor27Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor28Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor29Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor30Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor31Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor32Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor33Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor34Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor35Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor36Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor37Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor38Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor39Name { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Compressor object.")]
////public virtual object-list RefrigerationCompressor40Name { get; set; } = new object-list;
////}
////}


