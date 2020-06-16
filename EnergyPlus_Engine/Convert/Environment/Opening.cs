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
        [MultiOutput(0, "fenestrationSurface", "An EnergyPlus FenestrationSurface:Detailed object")]
        [MultiOutput(1, "materials", "A list of EnergyPlus WindowMaterial objects")]
        [MultiOutput(2, "construction", "An EnergyPlus construction object")]
        public static Output<FenestrationSurfaceDetailed, List<EnergyPlusWindowMaterialGlazing>, EnergyPlusConstruction> ToEnergyPlus(this BHE.Opening opening)
        {
            FenestrationSurfaceDetailed fenestrationSurfaceDetailed = new FenestrationSurfaceDetailed();
            fenestrationSurfaceDetailed.Name = opening.Name == "" ? opening.BHoM_Guid.ToString() : opening.Name;
            fenestrationSurfaceDetailed.SurfaceType = opening.Type.ToEnergyPlus();
            fenestrationSurfaceDetailed.ConstructionName = opening.OpeningConstruction.UniqueConstructionName();
            fenestrationSurfaceDetailed.BuildingSurfaceName = "";  // Is populated at the Panel conversion stage
            List<Point> vertices = BH.Engine.Environment.Query.Polyline(opening).ControlPoints();
            vertices.RemoveAt(vertices.Count - 1);
            fenestrationSurfaceDetailed.Vertices = vertices;
            fenestrationSurfaceDetailed.NumberOfVertices = vertices.Count;

            List<EnergyPlusWindowMaterialGlazing> materials = new List<EnergyPlusWindowMaterialGlazing>();
            List<string> materialNames = new List<string>();
            foreach (Layer layer in (opening.OpeningConstruction as BH.oM.Physical.Constructions.Construction).Layers)
            {
                // TODO - for each layer, check for material type and assign accordingly to correct EnergyPlus materuial type
                EnergyPlusWindowMaterialGlazing material = new EnergyPlusWindowMaterialGlazing();
                SolidMaterial layerSolid = layer.FindMaterial<SolidMaterial>(typeof(SolidMaterial));
                string materialName = layer.Material.Name == "" ? layer.Material.BHoM_Guid.ToString() : layer.Material.Name;
                material.Name = materialName;
                material.OpticalDataType = OpticalDataType.SpectralAverage;
                material.Thickness = layer.Thickness;
                material.SolarTransmittanceAtNormalIncidence = layerSolid.SolarTransmittance;
                material.FrontSideSolarReflectanceAtNormalIncidence = layerSolid.SolarReflectanceExternal;
                material.BackSideSolarReflectanceAtNormalIncidence = layerSolid.SolarReflectanceInternal;
                material.VisibleTransmittanceAtNormalIncidence = layerSolid.LightTransmittance;
                material.FrontSideVisibleReflectanceAtNormalIncidence = layerSolid.LightReflectanceExternal;
                material.BackSideVisibleReflectanceAtNormalIncidence = layerSolid.LightReflectanceInternal;
                material.FrontSideInfraredHemisphericalEmissivity = layerSolid.EmissivityExternal;
                material.BackSideInfraredHemisphericalEmissivity = layerSolid.EmissivityInternal;
                material.Conductivity = layerSolid.Conductivity;
                materialNames.Add(materialName);
                materials.Add(material);
            }

            EnergyPlusConstruction construction = new EnergyPlusConstruction();
            construction.Name = opening.OpeningConstruction.UniqueConstructionName();
            construction.Layers = materialNames;

            return new Output<FenestrationSurfaceDetailed, List<EnergyPlusWindowMaterialGlazing>, EnergyPlusConstruction>
            {
                Item1 = fenestrationSurfaceDetailed,
                Item2 = materials,
                Item3 = construction
            };
        }
    }
}
