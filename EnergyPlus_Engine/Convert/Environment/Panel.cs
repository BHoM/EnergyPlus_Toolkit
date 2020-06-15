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

namespace BH.Engine.EnergyPlus
{
    public static partial class Convert
    {
        [Description("Convert a BHoM Panel into a set of EnergyPlus surfaces, materials and constructions")]
        [Input("panel", "A BHoM Environments Panel object, with assigned construction")]
        [MultiOutput(0, "buildingSurface", "An EnergyPlus BuildingSurface:Detailed object")]
        [MultiOutput(1, "fenestrationSurfaces", "A list of EnergyPlus FenestrationSurface:Detailed objects")]
        [MultiOutput(2, "materials", "A list of EnergyPlus Material objects")]
        [MultiOutput(2, "glazingMaterials", "A list of EnergyPlus Glazing Material objects")]
        [MultiOutput(3, "construction", "An EnergyPlus construction object")]
        public static Output<BuildingSurfaceDetailed, List<FenestrationSurfaceDetailed>, List<EnergyPlusMaterial>, List<EnergyPlusWindowMaterialGlazing>, List<EnergyPlusConstruction>> ToEnergyPlus(this BHE.Panel panel)
        {
            BuildingSurfaceDetailed buildingSurfaceDetailed = new BuildingSurfaceDetailed();
            string surfaceName = panel.Name == "" ? panel.BHoM_Guid.ToString() : panel.Name;
            buildingSurfaceDetailed.Name = surfaceName;
            buildingSurfaceDetailed.SurfaceType = panel.Type.ToEnergyPlus();
            buildingSurfaceDetailed.ConstructionName = panel.Construction.UniqueConstructionName();
            buildingSurfaceDetailed.ZoneName = panel.ConnectedSpaces[0];
            buildingSurfaceDetailed.Vertices = BH.Engine.Environment.Query.Polyline(panel).ControlPoints();
            buildingSurfaceDetailed.NumberOfVertices = buildingSurfaceDetailed.Vertices.Count();

            List<EnergyPlusMaterial> materials = new List<EnergyPlusMaterial>();
            List<string> materialNames = new List<string>();
            foreach (Layer layer in (panel.Construction as BH.oM.Physical.Constructions.Construction).Layers)
            {
                // TODO - for each layer, check for material type and assign accordingly to correct EnergyPlus materuial type
                EnergyPlusMaterial material = new EnergyPlusMaterial();
                SolidMaterial layerSolid = layer.FindMaterial<SolidMaterial>(typeof(SolidMaterial));
                string materialName = layer.Material.Name == "" ? layer.Material.BHoM_Guid.ToString() : layer.Material.Name;
                material.Name = materialName;
                material.Roughness = layerSolid.Roughness.ToEnergyPlus();
                material.Thickness = layer.Thickness;
                material.Conductivity = layerSolid.Conductivity;
                material.Density = layerSolid.Density;
                material.SpecificHeat = layerSolid.SpecificHeat;
                material.ThermalAbsorptance = layerSolid.EmissivityExternal;
                material.SolarAbsorptance = 1 - layerSolid.SolarReflectanceExternal;
                material.VisibleAbsorptance = 1 - layerSolid.LightReflectanceExternal;

                materials.Add(material);
            }

            List<EnergyPlusConstruction> constructions = new List<EnergyPlusConstruction>();
            EnergyPlusConstruction construction = new EnergyPlusConstruction();
            construction.Name = panel.Construction.UniqueConstructionName();
            construction.Layers = materialNames;
            constructions.Add(construction);

            List<FenestrationSurfaceDetailed> fenestrationSurfaceDetaileds = new List<FenestrationSurfaceDetailed>();
            List<EnergyPlusWindowMaterialGlazing> glzMaterials = new List<EnergyPlusWindowMaterialGlazing>();
            foreach (BHE.Opening o in panel.Openings)
            {
                Output<FenestrationSurfaceDetailed, List<EnergyPlusWindowMaterialGlazing>, EnergyPlusConstruction> items = o.ToEnergyPlus();
                items.Item1.BuildingSurfaceName = surfaceName;
                fenestrationSurfaceDetaileds.Add(items.Item1);
                glzMaterials.AddRange(items.Item2);
                constructions.Add(items.Item3);
            }

            return new Output<BuildingSurfaceDetailed, List<FenestrationSurfaceDetailed>, List<EnergyPlusMaterial>, List<EnergyPlusWindowMaterialGlazing>, List<EnergyPlusConstruction>>
            {
                Item1 = buildingSurfaceDetailed,
                Item2 = fenestrationSurfaceDetaileds,
                Item3 = materials,
                Item4 = glzMaterials,
                Item5 = constructions
            };
        }
    }
}
