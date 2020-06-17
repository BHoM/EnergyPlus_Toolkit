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

using BH.Engine.Environment;
using BH.Engine.Geometry;

using BHG = BH.oM.Geometry;
using BH.oM.EnergyPlus;
using System.ComponentModel;
using BH.oM.Reflection.Attributes;
using BH.oM.Reflection;
using BH.oM.Physical.Constructions;
using BH.oM.Environment.MaterialFragments;
using BH.oM.Geometry;

namespace BH.Engine.EnergyPlus
{
    public static partial class Convert
    {
        [Description("Convert a BHoM Opening into a set of EnergyPlus surfaces, materials and constructions")]
        [Input("opening", "A BHoM Environments Opening object, with assigned construction")]
        [Output("energyPlusClasses", "A list of EnergyPlus FenestrationSurface:Detailed, Construction, WindowMaterial:Glazing and WindowMaterial:Gas objects")]
        public static List<IEnergyPlusClass> ToEnergyPlus(this BHE.Opening opening, string hostName)
        {

            List<IEnergyPlusClass> classes = new List<IEnergyPlusClass>();

            FenestrationSurfaceDetailed fenestrationSurfaceDetailed = new FenestrationSurfaceDetailed();
            fenestrationSurfaceDetailed.Name = opening.Name == "" ? opening.BHoM_Guid.ToString() : opening.Name;
            fenestrationSurfaceDetailed.SurfaceType = opening.Type.ToEnergyPlus();
            fenestrationSurfaceDetailed.ConstructionName = opening.OpeningConstruction.Name;
            fenestrationSurfaceDetailed.BuildingSurfaceName = hostName;
            List<Point> vertices = BH.Engine.Environment.Query.Polyline(opening).ControlPoints();
            vertices.RemoveAt(vertices.Count - 1);
            vertices.Reverse();
            fenestrationSurfaceDetailed.Vertices = vertices;
            fenestrationSurfaceDetailed.NumberOfVertices = vertices.Count;

            List<IEnergyPlusClass> materialsAndConstruction = ((Construction)opening.OpeningConstruction).ToEnergyPlus();

            classes.Add(fenestrationSurfaceDetailed);
            classes.AddRange(materialsAndConstruction);

            return classes;
        }
    }
}
