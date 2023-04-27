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

using BH.oM.Base;
using BH.oM.Geometry;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Base.Attributes;

namespace BH.oM.Adapters.EnergyPlus
{
    public class ThermalZonesAndSurfaces : BHoMObject
    {
        [Description("")]
        public virtual GlobalGeometryRules GlobalGeometryRules { get; set; } = new GlobalGeometryRules();
        [Description("")]
        public virtual List<Zone> Zones { get; set; } = new List<Zone>();
        [Description("")]
        public virtual List<ZoneList> ZoneLists { get; set; } = new List<ZoneList>();
        [Description("")]
        public virtual List<BuildingSurfaceDetailed> BuildingSurfaces { get; set; } = new List<BuildingSurfaceDetailed>();
        [Description("")]
        public virtual List<FenestrationSurfaceDetailed> FenestrationSurfaces { get; set; } = new List<FenestrationSurfaceDetailed>();
        [Description("")]
        public virtual List<ShadingBuildingDetailed> ShadingSurfaces { get; set; } = new List<ShadingBuildingDetailed>();
        [Description("")]
        public virtual List<InternalMass> InternalMasses { get; set; } = new List<InternalMass>();
    }
}



