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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using BH.Engine.Reflection;
using BH.oM.Reflection;
using BH.oM.EnergyPlus;

namespace BH.Engine.EnergyPlus
{
    public static partial class Convert
    {
        public static string ToEnergyPlusString(this ThermalZonesAndSurfaces thermalZonesAndSurfaces)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(thermalZonesAndSurfaces.GlobalGeometryRules);

            foreach (Zone zone in thermalZonesAndSurfaces.Zones)
            {
                sb.Append(zone.ToEnergyPlusString());
            }

            foreach (ZoneList zoneList in thermalZonesAndSurfaces.ZoneLists)
            {
                sb.Append(zoneList.ToEnergyPlusString());
            }

            foreach (BuildingSurfaceDetailed buildingSurfaceDetailed in thermalZonesAndSurfaces.BuildingSurfaces)
            {
                sb.Append(buildingSurfaceDetailed.ToEnergyPlusString());
            }

            foreach (FenestrationSurfaceDetailed fenestrationSurfaceDetailed in thermalZonesAndSurfaces.FenestrationSurfaces)
            {
                sb.Append(fenestrationSurfaceDetailed.ToEnergyPlusString());
            }

            foreach (ShadingBuildingDetailed shadingBuildingDetailed in thermalZonesAndSurfaces.ShadingSurfaces)
            {
                sb.Append(shadingBuildingDetailed.ToEnergyPlusString());
            }

            return sb.ToString();
        }
    }
}
