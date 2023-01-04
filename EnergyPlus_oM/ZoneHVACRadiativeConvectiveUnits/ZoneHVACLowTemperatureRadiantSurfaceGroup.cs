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
////public class ZoneHVAC:LowTemperatureRadiant:SurfaceGroup : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual object-list Surface1Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface1 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface2Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface2 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface3Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface3 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface4Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface4 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface5Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface5 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface6Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface6 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface7Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface7 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface8Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface8 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface9Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface9 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface10Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface10 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface11Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface11 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface12Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface12 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface13Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface13 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface14Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface14 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface15Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface15 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface16Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface16 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface17Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface17 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface18Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface18 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface19Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface19 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface20Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface20 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface21Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface21 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface22Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface22 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface23Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface23 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface24Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface24 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface25Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface25 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface26Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface26 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface27Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface27 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface28Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface28 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface29Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface29 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface30Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface30 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface31Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface31 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface32Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface32 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface33Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface33 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface34Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface34 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface35Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface35 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface36Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface36 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface37Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface37 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface38Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface38 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface39Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface39 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface40Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface40 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface41Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface41 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface42Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface42 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface43Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface43 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface44Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface44 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface45Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface45 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface46Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface46 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface47Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface47 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface48Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface48 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface49Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface49 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface50Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface50 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface51Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface51 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface52Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface52 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface53Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface53 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface54Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface54 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface55Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface55 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface56Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface56 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface57Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface57 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface58Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface58 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface59Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface59 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface60Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface60 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface61Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface61 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface62Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface62 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface63Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface63 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface64Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface64 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface65Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface65 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface66Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface66 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface67Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface67 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface68Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface68 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface69Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface69 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface70Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface70 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface71Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface71 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface72Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface72 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface73Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface73 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface74Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface74 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface75Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface75 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface76Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface76 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface77Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface77 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface78Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface78 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface79Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface79 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface80Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface80 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface81Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface81 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface82Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface82 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface83Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface83 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface84Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface84 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface85Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface85 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface86Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface86 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface87Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface87 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface88Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface88 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface89Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface89 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface90Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface90 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface91Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface91 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface92Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface92 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface93Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface93 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface94Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface94 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface95Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface95 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface96Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface96 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface97Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface97 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface98Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface98 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface99Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface99 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface100Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FlowFractionForSurface100 { get; set; } = new null;
////}
////}



