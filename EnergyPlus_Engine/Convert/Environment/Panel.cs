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

using BH.oM.EnergyPlus.Settings;
using BHE = BH.oM.Environment.Elements;
using BHP = BH.oM.Environment.Fragments;

using BH.oM.Reflection.Attributes;
using BH.oM.Reflection;
using BH.oM.EnergyPlus;
using BH.Engine.Environment;
using BHG = BH.oM.Geometry;
using BH.Engine.Geometry;
using BH.oM.Physical.Constructions;

using BH.oM.Environment.MaterialFragments;
using System.ComponentModel;
using BH.oM.Diffing;
using BH.oM.Geometry;

namespace BH.Engine.EnergyPlus
{
    public static partial class Convert
    {
        [Description("Convert a BHoM Panel into a set of EnergyPlus surfaces, materials and constructions")]
        [Input("panel", "A BHoM Environments Panel object, with assigned construction")]
        [Output("energyPlusClasses", "A list of EnergyPlus objects")]
        public static List<IEnergyPlusClass> ToEnergyPlus(this BHE.Panel panel)
        {
            List<IEnergyPlusClass> classes = new List<IEnergyPlusClass>();

            List<Point> vertices = BH.Engine.Environment.Query.Polyline(panel).ControlPoints();
            vertices.RemoveAt(vertices.Count - 1);
            int vertexCount = vertices.Count;
            string panelName = panel.Name == "" ? panel.BHoM_Guid.ToString() : panel.Name;
            string zoneName = panel.ConnectedSpaces[0];
            string sunExposure = panel.SunWindExposed() ? "SunExposed" : "NoSun";
            string windExposure = panel.SunWindExposed() ? "WindExposed" : "NoWind";

            GlobalGeometryRules globalGeometryRules = new GlobalGeometryRules();
            classes.Add(globalGeometryRules);

            if (panel.Type == BHE.PanelType.Shade)
            {
                ShadingBuildingDetailed shadingSurface = new ShadingBuildingDetailed();
                shadingSurface.Name = panelName;
                shadingSurface.Vertices = vertices;
                shadingSurface.NumberOfVertices = vertexCount;
                classes.Add(shadingSurface);
            }
            else
            {
                Zone zone = new Zone();
                zone.Name = zoneName;
                classes.Add(zone);

                ZoneList zoneList = new ZoneList();
                zoneList.ZoneNames.Add(zoneName);
                classes.Add(zoneList);

                classes.AddRange(((BH.oM.Physical.Constructions.Construction)panel.Construction).ToEnergyPlus());

                BuildingSurfaceDetailed buildingSurface = new BuildingSurfaceDetailed();
                string surfaceName = panelName;
                buildingSurface.Name = surfaceName;
                buildingSurface.SurfaceType = panel.Type.ToEnergyPlus();
                buildingSurface.ConstructionName = panel.Construction.Name;
                buildingSurface.ZoneName = zoneName;
                buildingSurface.OutsideBoundaryCondition = panel.BoundaryCondition();
                if (buildingSurface.OutsideBoundaryCondition == OutsideBoundaryCondition.Zone)
                {
                    buildingSurface.OutsideBoundaryConditionObject = panel.ConnectedSpaces[-1];
                }
                else
                {
                    buildingSurface.OutsideBoundaryConditionObject = "";
                }
                buildingSurface.SunExposure = sunExposure;
                buildingSurface.WindExposure = windExposure;
                buildingSurface.Vertices = vertices;
                buildingSurface.NumberOfVertices = vertexCount;
                classes.Add(buildingSurface);

                foreach (BHE.Opening o in panel.Openings)
                {
                    classes.AddRange(o.ToEnergyPlus(panelName));
                }
            }

            return classes;
        }
    }
}
