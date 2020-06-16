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
        [Output("energyPlusClasses", "A list of EnergyPlusClass objects")]
        //Output<ThermalZonesAndSurfaces, SurfaceConstructionElements>
        //[MultiOutput(0, "thermalZonesAndSurfaces", "An EnergyPlus Thermal Zones and Surfaces object containing geometry attributes")]
        //[MultiOutput(1, "surfaceConstructionElements", "An EnergyPlus Surface construction Elements object containing materials and constructions attributes")]
        public static List<IEnergyPlusClass> ToEnergyPlusObjects(this List<BHE.Panel> panels)
        {
            List<IEnergyPlusClass> classes = new List<IEnergyPlusClass>();

            List<Zone> zones = new List<Zone>();
            List<ZoneList> zoneLists = new List<ZoneList>();
            List<BuildingSurfaceDetailed> buildingSurfaces = new List<BuildingSurfaceDetailed>();
            List<FenestrationSurfaceDetailed> fenestrationSurfaces = new List<FenestrationSurfaceDetailed>();
            List<InternalMass> internalMasses = new List<InternalMass>();
            List<ShadingBuildingDetailed> shadingSurfaces = new List<ShadingBuildingDetailed>();

            List<EnergyPlusMaterial> materials = new List<EnergyPlusMaterial>();
            List<MaterialRoofVegetation> vegetationMaterials = new List<MaterialRoofVegetation>();
            List<EnergyPlusWindowMaterialGlazing> glazingMaterials = new List<EnergyPlusWindowMaterialGlazing>();
            List<EnergyPlusConstruction> constructions = new List<EnergyPlusConstruction>();

            foreach (BHE.Panel panel in panels)
            {
                Output<ThermalZonesAndSurfaces, SurfaceConstructionElements> output = panel.ToEnergyPlus();
                ThermalZonesAndSurfaces tzf = output.Item1;
                zones.AddRange(tzf.Zones);
                zoneLists.AddRange(tzf.ZoneLists);
                buildingSurfaces.AddRange(tzf.BuildingSurfaces);
                fenestrationSurfaces.AddRange(tzf.FenestrationSurfaces);
                internalMasses.AddRange(tzf.InternalMasses);
                shadingSurfaces.AddRange(tzf.ShadingSurfaces);

                SurfaceConstructionElements sce = output.Item2;
                materials.AddRange(sce.Materials);
                vegetationMaterials.AddRange(sce.VegetationMaterials);
                glazingMaterials.AddRange(sce.GlazingMaterials);
                constructions.AddRange(sce.Constructions);
            }

            classes.AddRange(zones);
            classes.AddRange(zoneLists);
            classes.AddRange(buildingSurfaces);
            classes.AddRange(fenestrationSurfaces);
            classes.AddRange(internalMasses);
            classes.AddRange(shadingSurfaces);
            classes.AddRange(materials);
            classes.AddRange(vegetationMaterials);
            classes.AddRange(glazingMaterials);
            classes.AddRange(constructions);

            return classes.UniqueEnergyPlusClasses();

            //ThermalZonesAndSurfaces thermalZonesAndSurfaces = new ThermalZonesAndSurfaces();
            //thermalZonesAndSurfaces.GlobalGeometryRules = new GlobalGeometryRules();
            //thermalZonesAndSurfaces.Zones = zones;
            //thermalZonesAndSurfaces.ZoneLists = zoneLists;
            //thermalZonesAndSurfaces.BuildingSurfaces = buildingSurfaces;
            //thermalZonesAndSurfaces.FenestrationSurfaces = fenestrationSurfaces;
            //thermalZonesAndSurfaces.InternalMasses = internalMasses;
            //thermalZonesAndSurfaces.ShadingSurfaces = shadingSurfaces;

            //SurfaceConstructionElements surfaceConstructionElements = new SurfaceConstructionElements();
            //surfaceConstructionElements.Materials = materials;
            //surfaceConstructionElements.VegetationMaterials = vegetationMaterials;
            //surfaceConstructionElements.GlazingMaterials = glazingMaterials;
            //surfaceConstructionElements.Constructions = constructions;

            //return new Output<ThermalZonesAndSurfaces, SurfaceConstructionElements>
            //{
            //    Item1 = thermalZonesAndSurfaces,
            //    Item2 = surfaceConstructionElements
            //};
        }

        [Description("Convert a BHoM Panel into a set of EnergyPlus surfaces, materials and constructions")]
        [Input("panel", "A BHoM Environments Panel object, with assigned construction")]
        [MultiOutput(0, "thermalZonesAndSurfaces", "An EnergyPlus Thermal Zones and Surfaces object containing geometry attributes")]
        [MultiOutput(1, "surfaceConstructionElements", "An EnergyPlus Surface construction Elements object containing materials and constructions attributes")]
        public static Output<ThermalZonesAndSurfaces, SurfaceConstructionElements> ToEnergyPlus(this BHE.Panel panel)
        {
            List<Zone> zones = new List<Zone>();
            List<ZoneList> zoneLists = new List<ZoneList>();
            List<BuildingSurfaceDetailed> buildingSurfaces = new List<BuildingSurfaceDetailed>();
            List<FenestrationSurfaceDetailed> fenestrationSurfaces = new List<FenestrationSurfaceDetailed>();
            List<InternalMass> internalMasses = new List<InternalMass>();
            List<ShadingBuildingDetailed> shadingSurfaces = new List<ShadingBuildingDetailed>();

            List<EnergyPlusMaterial> materials = new List<EnergyPlusMaterial>();
            List<MaterialRoofVegetation> vegetationMaterials = new List<MaterialRoofVegetation>();
            List<EnergyPlusWindowMaterialGlazing> glazingMaterials = new List<EnergyPlusWindowMaterialGlazing>();
            List<EnergyPlusConstruction> constructions = new List<EnergyPlusConstruction>();

            if (panel.Type == BHE.PanelType.Shade)
            {
                ShadingBuildingDetailed shadingSurface = new ShadingBuildingDetailed();
                shadingSurface.Name = panel.Name == "" ? panel.BHoM_Guid.ToString() : panel.Name;
                List<Point> vertices = BH.Engine.Environment.Query.Polyline(panel).ControlPoints();
                vertices.RemoveAt(vertices.Count - 1);
                shadingSurface.Vertices = vertices;
                shadingSurface.NumberOfVertices = vertices.Count;
                shadingSurfaces.Add(shadingSurface);
            }
            else
            {
                Zone zone = new Zone();
                zone.Name = panel.ConnectedSpaces[0];
                zones.Add(zone);

                ZoneList zoneList = new ZoneList();
                zoneList.ZoneNames.Add(zone.Name);
                zoneLists.Add(zoneList);

                BuildingSurfaceDetailed buildingSurface = new BuildingSurfaceDetailed();
                string surfaceName = panel.Name == "" ? panel.BHoM_Guid.ToString() : panel.Name;
                buildingSurface.Name = surfaceName;
                buildingSurface.SurfaceType = panel.Type.ToEnergyPlus();
                buildingSurface.ConstructionName = panel.Construction.UniqueConstructionName();
                buildingSurface.ZoneName = panel.ConnectedSpaces[0];
                buildingSurface.OutsideBoundaryCondition = panel.BoundaryCondition();
                if (buildingSurface.OutsideBoundaryCondition == OutsideBoundaryCondition.Zone)
                {
                    buildingSurface.SunExposure = false;
                    buildingSurface.WindExposure = false;
                    buildingSurface.OutsideBoundaryConditionObject = panel.ConnectedSpaces[-1];
                }
                else if (panel.Type == BHE.PanelType.Floor | panel.Type == BHE.PanelType.FloorExposed | panel.Type == BHE.PanelType.SlabOnGrade | panel.Type == BHE.PanelType.UndergroundSlab)
                {
                    buildingSurface.SunExposure = false;
                    buildingSurface.WindExposure = false;
                    buildingSurface.OutsideBoundaryCondition = OutsideBoundaryCondition.Ground;
                }
                else if (panel.Type == BHE.PanelType.Wall | panel.Type == BHE.PanelType.WallExternal | panel.Type == BHE.PanelType.Roof)
                {
                    buildingSurface.SunExposure = true;
                    buildingSurface.WindExposure = true;
                    buildingSurface.OutsideBoundaryCondition = OutsideBoundaryCondition.Outdoors;
                }
                else
                {
                    buildingSurface.SunExposure = false;
                    buildingSurface.WindExposure = false;
                }
                List<Point> vertices = BH.Engine.Environment.Query.Polyline(panel).ControlPoints();
                vertices.RemoveAt(vertices.Count - 1);
                buildingSurface.Vertices = vertices;
                buildingSurface.NumberOfVertices = vertices.Count;
                buildingSurfaces.Add(buildingSurface);

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
                    materialNames.Add(materialName);
                }

                EnergyPlusConstruction construction = new EnergyPlusConstruction();
                construction.Name = panel.Construction.UniqueConstructionName();
                construction.Layers = materialNames;
                constructions.Add(construction);

                foreach (BHE.Opening o in panel.Openings)
                {
                    Output<FenestrationSurfaceDetailed, List<EnergyPlusWindowMaterialGlazing>, EnergyPlusConstruction> items = o.ToEnergyPlus();
                    items.Item1.BuildingSurfaceName = surfaceName;
                    fenestrationSurfaces.Add(items.Item1);
                    glazingMaterials.AddRange(items.Item2);
                    constructions.Add(items.Item3);
                }
            }


            ThermalZonesAndSurfaces thermalZonesAndSurfaces = new ThermalZonesAndSurfaces();
            thermalZonesAndSurfaces.GlobalGeometryRules = new GlobalGeometryRules();
            thermalZonesAndSurfaces.Zones = zones;
            thermalZonesAndSurfaces.ZoneLists = zoneLists;
            thermalZonesAndSurfaces.BuildingSurfaces = buildingSurfaces;
            thermalZonesAndSurfaces.FenestrationSurfaces = fenestrationSurfaces;
            thermalZonesAndSurfaces.InternalMasses = internalMasses;
            thermalZonesAndSurfaces.ShadingSurfaces = shadingSurfaces;

            SurfaceConstructionElements surfaceConstructionElements = new SurfaceConstructionElements();
            surfaceConstructionElements.Materials = materials;
            surfaceConstructionElements.VegetationMaterials = vegetationMaterials;
            surfaceConstructionElements.GlazingMaterials = glazingMaterials;
            surfaceConstructionElements.Constructions = constructions;

            return new Output<ThermalZonesAndSurfaces, SurfaceConstructionElements>
            {
                Item1 = thermalZonesAndSurfaces,
                Item2 = surfaceConstructionElements
            };
        }
    }
}
