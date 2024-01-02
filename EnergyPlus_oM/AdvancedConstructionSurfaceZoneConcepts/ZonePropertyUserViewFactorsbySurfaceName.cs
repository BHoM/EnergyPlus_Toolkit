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
////public class ZoneProperty:UserViewFactors:bySurfaceName : BHoMObject
////{
////[Description("View factors may be entered for a single zone or for a group of zones connected by Construction:AirBoundary")]
////public virtual string ZoneOrZoneListName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list FromSurface1 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface1 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor1 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface2 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface2 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor2 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface3 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface3 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor3 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface4 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface4 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor4 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface5 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface5 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor5 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface6 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface6 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor6 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface7 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface7 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor7 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface8 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface8 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor8 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface9 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface9 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor9 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface10 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface10 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor10 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface11 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface11 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor11 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface12 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface12 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor12 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface13 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface13 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor13 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface14 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface14 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor14 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface15 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface15 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor15 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface16 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface16 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor16 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface17 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface17 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor17 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface18 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface18 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor18 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface19 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface19 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor19 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface20 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface20 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor20 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface21 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface21 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor21 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface22 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface22 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor22 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface23 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface23 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor23 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface24 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface24 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor24 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface25 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface25 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor25 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface26 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface26 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor26 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface27 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface27 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor27 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface28 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface28 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor28 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface29 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface29 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor29 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface30 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface30 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor30 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface31 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface31 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor31 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface32 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface32 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor32 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface33 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface33 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor33 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface34 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface34 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor34 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface35 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface35 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor35 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface36 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface36 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor36 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface37 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface37 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor37 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface38 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface38 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor38 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface39 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface39 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor39 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface40 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface40 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor40 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface41 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface41 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor41 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface42 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface42 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor42 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface43 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface43 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor43 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface44 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface44 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor44 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface45 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface45 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor45 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface46 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface46 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor46 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface47 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface47 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor47 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface48 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface48 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor48 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface49 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface49 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor49 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface50 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface50 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor50 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface51 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface51 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor51 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface52 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface52 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor52 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface53 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface53 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor53 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface54 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface54 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor54 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface55 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface55 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor55 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface56 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface56 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor56 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface57 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface57 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor57 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface58 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface58 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor58 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface59 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface59 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor59 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface60 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface60 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor60 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface61 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface61 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor61 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface62 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface62 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor62 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface63 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface63 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor63 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface64 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface64 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor64 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface65 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface65 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor65 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface66 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface66 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor66 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface67 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface67 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor67 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface68 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface68 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor68 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface69 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface69 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor69 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface70 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface70 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor70 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface71 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface71 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor71 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface72 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface72 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor72 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface73 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface73 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor73 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface74 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface74 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor74 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface75 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface75 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor75 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface76 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface76 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor76 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface77 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface77 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor77 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface78 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface78 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor78 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface79 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface79 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor79 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface80 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface80 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor80 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface81 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface81 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor81 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface82 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface82 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor82 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface83 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface83 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor83 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface84 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface84 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor84 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface85 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface85 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor85 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface86 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface86 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor86 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface87 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface87 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor87 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface88 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface88 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor88 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface89 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface89 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor89 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface90 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface90 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor90 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface91 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface91 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor91 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface92 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface92 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor92 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface93 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface93 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor93 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface94 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface94 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor94 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface95 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface95 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor95 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface96 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface96 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor96 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface97 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface97 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor97 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface98 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface98 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor98 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface99 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface99 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor99 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface100 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface100 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor100 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface101 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface101 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor101 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface102 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface102 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor102 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface103 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface103 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor103 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface104 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface104 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor104 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface105 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface105 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor105 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface106 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface106 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor106 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface107 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface107 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor107 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface108 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface108 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor108 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface109 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface109 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor109 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface110 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface110 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor110 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface111 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface111 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor111 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface112 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface112 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor112 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface113 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface113 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor113 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface114 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface114 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor114 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface115 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface115 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor115 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface116 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface116 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor116 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface117 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface117 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor117 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface118 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface118 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor118 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface119 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface119 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor119 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface120 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface120 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor120 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface121 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface121 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor121 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface122 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface122 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor122 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface123 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface123 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor123 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface124 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface124 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor124 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface125 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface125 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor125 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface126 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface126 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor126 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface127 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface127 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor127 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface128 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface128 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor128 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface129 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface129 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor129 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface130 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface130 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor130 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface131 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface131 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor131 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface132 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface132 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor132 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface133 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface133 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor133 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface134 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface134 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor134 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface135 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface135 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor135 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface136 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface136 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor136 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface137 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface137 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor137 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface138 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface138 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor138 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface139 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface139 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor139 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface140 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface140 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor140 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface141 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface141 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor141 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface142 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface142 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor142 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface143 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface143 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor143 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface144 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface144 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor144 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface145 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface145 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor145 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface146 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface146 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor146 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface147 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface147 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor147 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface148 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface148 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor148 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface149 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface149 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor149 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface150 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface150 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor150 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface151 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface151 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor151 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface152 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface152 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor152 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface153 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface153 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor153 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface154 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface154 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor154 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface155 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface155 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor155 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface156 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface156 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor156 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface157 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface157 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor157 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface158 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface158 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor158 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface159 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface159 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor159 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface160 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface160 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor160 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface161 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface161 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor161 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface162 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface162 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor162 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface163 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface163 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor163 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface164 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface164 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor164 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface165 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface165 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor165 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface166 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface166 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor166 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface167 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface167 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor167 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface168 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface168 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor168 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface169 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface169 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor169 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface170 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface170 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor170 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface171 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface171 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor171 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface172 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface172 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor172 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface173 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface173 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor173 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface174 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface174 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor174 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface175 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface175 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor175 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface176 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface176 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor176 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface177 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface177 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor177 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface178 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface178 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor178 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface179 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface179 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor179 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface180 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface180 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor180 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface181 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface181 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor181 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface182 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface182 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor182 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface183 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface183 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor183 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface184 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface184 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor184 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface185 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface185 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor185 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface186 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface186 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor186 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface187 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface187 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor187 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface188 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface188 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor188 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface189 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface189 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor189 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface190 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface190 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor190 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface191 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface191 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor191 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface192 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface192 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor192 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface193 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface193 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor193 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface194 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface194 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor194 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface195 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface195 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor195 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface196 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface196 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor196 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface197 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface197 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor197 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface198 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface198 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor198 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface199 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface199 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor199 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface200 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface200 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor200 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface201 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface201 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor201 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface202 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface202 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor202 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface203 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface203 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor203 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface204 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface204 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor204 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface205 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface205 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor205 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface206 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface206 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor206 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface207 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface207 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor207 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface208 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface208 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor208 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface209 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface209 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor209 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface210 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface210 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor210 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface211 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface211 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor211 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface212 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface212 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor212 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface213 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface213 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor213 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface214 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface214 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor214 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface215 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface215 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor215 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface216 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface216 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor216 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface217 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface217 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor217 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface218 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface218 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor218 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface219 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface219 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor219 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface220 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface220 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor220 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface221 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface221 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor221 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface222 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface222 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor222 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface223 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface223 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor223 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface224 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface224 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor224 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface225 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface225 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor225 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface226 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface226 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor226 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface227 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface227 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor227 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface228 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface228 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor228 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface229 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface229 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor229 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface230 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface230 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor230 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface231 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface231 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor231 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface232 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface232 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor232 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface233 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface233 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor233 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface234 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface234 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor234 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface235 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface235 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor235 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface236 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface236 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor236 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface237 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface237 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor237 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface238 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface238 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor238 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface239 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface239 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor239 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface240 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface240 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor240 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface241 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface241 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor241 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface242 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface242 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor242 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface243 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface243 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor243 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface244 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface244 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor244 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface245 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface245 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor245 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface246 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface246 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor246 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface247 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface247 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor247 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface248 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface248 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor248 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface249 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface249 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor249 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface250 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface250 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor250 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface251 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface251 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor251 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface252 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface252 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor252 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface253 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface253 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor253 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface254 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface254 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor254 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface255 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface255 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor255 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface256 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface256 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor256 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface257 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface257 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor257 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface258 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface258 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor258 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface259 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface259 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor259 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface260 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface260 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor260 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface261 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface261 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor261 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface262 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface262 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor262 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface263 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface263 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor263 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface264 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface264 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor264 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface265 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface265 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor265 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface266 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface266 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor266 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface267 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface267 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor267 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface268 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface268 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor268 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface269 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface269 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor269 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface270 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface270 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor270 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface271 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface271 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor271 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface272 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface272 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor272 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface273 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface273 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor273 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface274 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface274 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor274 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface275 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface275 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor275 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface276 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface276 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor276 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface277 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface277 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor277 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface278 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface278 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor278 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface279 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface279 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor279 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface280 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface280 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor280 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface281 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface281 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor281 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface282 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface282 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor282 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface283 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface283 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor283 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface284 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface284 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor284 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface285 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface285 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor285 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface286 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface286 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor286 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface287 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface287 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor287 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface288 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface288 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor288 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface289 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface289 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor289 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface290 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface290 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor290 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface291 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface291 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor291 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface292 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface292 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor292 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface293 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface293 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor293 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface294 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface294 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor294 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface295 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface295 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor295 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface296 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface296 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor296 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface297 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface297 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor297 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface298 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface298 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor298 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface299 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface299 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor299 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface300 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface300 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor300 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface301 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface301 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor301 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface302 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface302 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor302 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface303 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface303 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor303 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface304 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface304 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor304 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface305 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface305 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor305 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface306 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface306 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor306 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface307 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface307 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor307 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface308 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface308 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor308 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface309 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface309 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor309 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface310 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface310 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor310 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface311 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface311 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor311 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface312 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface312 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor312 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface313 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface313 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor313 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface314 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface314 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor314 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface315 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface315 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor315 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface316 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface316 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor316 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface317 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface317 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor317 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface318 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface318 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor318 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface319 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface319 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor319 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface320 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface320 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor320 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface321 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface321 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor321 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface322 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface322 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor322 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface323 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface323 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor323 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface324 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface324 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor324 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface325 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface325 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor325 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface326 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface326 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor326 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface327 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface327 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor327 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface328 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface328 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor328 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface329 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface329 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor329 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface330 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface330 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor330 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface331 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface331 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor331 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface332 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface332 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor332 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface333 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface333 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor333 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface334 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface334 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor334 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface335 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface335 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor335 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface336 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface336 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor336 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface337 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface337 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor337 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface338 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface338 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor338 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface339 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface339 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor339 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface340 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface340 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor340 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface341 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface341 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor341 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface342 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface342 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor342 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface343 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface343 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor343 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface344 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface344 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor344 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface345 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface345 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor345 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface346 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface346 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor346 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface347 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface347 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor347 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface348 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface348 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor348 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface349 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface349 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor349 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface350 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface350 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor350 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface351 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface351 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor351 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface352 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface352 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor352 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface353 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface353 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor353 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface354 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface354 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor354 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface355 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface355 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor355 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface356 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface356 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor356 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface357 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface357 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor357 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface358 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface358 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor358 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface359 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface359 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor359 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface360 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface360 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor360 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface361 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface361 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor361 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface362 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface362 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor362 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface363 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface363 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor363 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface364 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface364 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor364 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface365 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface365 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor365 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface366 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface366 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor366 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface367 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface367 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor367 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface368 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface368 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor368 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface369 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface369 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor369 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface370 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface370 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor370 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface371 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface371 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor371 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface372 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface372 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor372 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface373 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface373 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor373 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface374 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface374 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor374 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface375 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface375 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor375 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface376 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface376 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor376 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface377 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface377 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor377 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface378 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface378 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor378 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface379 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface379 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor379 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface380 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface380 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor380 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface381 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface381 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor381 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface382 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface382 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor382 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface383 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface383 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor383 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface384 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface384 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor384 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface385 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface385 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor385 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface386 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface386 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor386 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface387 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface387 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor387 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface388 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface388 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor388 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface389 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface389 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor389 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface390 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface390 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor390 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface391 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface391 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor391 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface392 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface392 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor392 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface393 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface393 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor393 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface394 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface394 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor394 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface395 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface395 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor395 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface396 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface396 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor396 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface397 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface397 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor397 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface398 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface398 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor398 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface399 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface399 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor399 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface400 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface400 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor400 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface401 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface401 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor401 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface402 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface402 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor402 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface403 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface403 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor403 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface404 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface404 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor404 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface405 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface405 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor405 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface406 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface406 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor406 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface407 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface407 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor407 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface408 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface408 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor408 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface409 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface409 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor409 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface410 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface410 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor410 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface411 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface411 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor411 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface412 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface412 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor412 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface413 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface413 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor413 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface414 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface414 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor414 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface415 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface415 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor415 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface416 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface416 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor416 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface417 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface417 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor417 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface418 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface418 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor418 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface419 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface419 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor419 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface420 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface420 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor420 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface421 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface421 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor421 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface422 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface422 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor422 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface423 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface423 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor423 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface424 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface424 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor424 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface425 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface425 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor425 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface426 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface426 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor426 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface427 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface427 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor427 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface428 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface428 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor428 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface429 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface429 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor429 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface430 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface430 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor430 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface431 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface431 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor431 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface432 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface432 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor432 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface433 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface433 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor433 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface434 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface434 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor434 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface435 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface435 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor435 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface436 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface436 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor436 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface437 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface437 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor437 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface438 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface438 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor438 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface439 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface439 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor439 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface440 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface440 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor440 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface441 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface441 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor441 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface442 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface442 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor442 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface443 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface443 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor443 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface444 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface444 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor444 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface445 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface445 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor445 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface446 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface446 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor446 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface447 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface447 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor447 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface448 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface448 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor448 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface449 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface449 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor449 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface450 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface450 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor450 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface451 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface451 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor451 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface452 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface452 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor452 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface453 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface453 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor453 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface454 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface454 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor454 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface455 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface455 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor455 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface456 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface456 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor456 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface457 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface457 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor457 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface458 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface458 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor458 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface459 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface459 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor459 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface460 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface460 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor460 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface461 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface461 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor461 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface462 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface462 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor462 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface463 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface463 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor463 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface464 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface464 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor464 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface465 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface465 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor465 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface466 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface466 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor466 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface467 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface467 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor467 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface468 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface468 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor468 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface469 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface469 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor469 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface470 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface470 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor470 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface471 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface471 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor471 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface472 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface472 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor472 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface473 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface473 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor473 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface474 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface474 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor474 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface475 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface475 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor475 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface476 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface476 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor476 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface477 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface477 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor477 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface478 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface478 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor478 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface479 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface479 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor479 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface480 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface480 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor480 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface481 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface481 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor481 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface482 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface482 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor482 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface483 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface483 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor483 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface484 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface484 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor484 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface485 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface485 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor485 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface486 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface486 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor486 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface487 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface487 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor487 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface488 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface488 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor488 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface489 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface489 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor489 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list FromSurface490 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ToSurface490 { get; set; } = new object-list;
////[Description("This value is the view factor value From Surface => To Surface")]
////public virtual real ViewFactor490 { get; set; } = new real;
////}
////}




