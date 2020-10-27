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

using BH.Engine.Geometry;
using BH.Engine.Environment;
using BH.oM.Adapters.EnergyPlus;
using BH.oM.Environment.MaterialFragments;
using BH.oM.Geometry;
using BH.oM.Physical.Constructions;
using BH.oM.Physical.Materials;
using BH.oM.Reflection.Attributes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using BHE = BH.oM.Environment.Elements;

using BHM = BH.oM.Environment.MaterialFragments;
using BHP = BH.oM.Physical.Constructions;

namespace BH.Engine.Adapters.EnergyPlus
{
    public static partial class Create
    {
        [Description("Create a construction comprising of a single material suitable for approximate outdoor surface temperature simulation")]
        [Input("material", "An opaque EnergyPlus material")]
        [Output("EPConstruction", "An EnergyPlus construction")]
        public static EPConstruction SingleMaterialConstruction(EPMaterial material)
        {
            return new EPConstruction() { 
                Name = material.Name,
                Layers = new List<IEnergyPlusMaterial>() { material },
            };
        }

        [Description("Create a construction comprising of a single material suitable for approximate outdoor surface temperature simulation")]
        [Input("material", "One of a set of predefined materials")]
        [Output("EPConstruction", "An EnergyPlus construction representing the predefined material type")]
        public static EPConstruction SingleMaterialConstruction(PredefinedMaterials material)
        {
            EPConstruction construction = new EPConstruction();
            switch (material)
            {
                case PredefinedMaterials.Asphalt:
                    construction.Name = "AsphaltConstruction";
                    construction.Layers.Add(
                        new EPMaterial()
                        {
                            Name = "AsphaltMaterial",
                            Roughness = BH.oM.Adapters.EnergyPlus.Roughness.MediumRough,
                            Thickness = 0.5,
                            Conductivity = 0.75,
                            Density = 2360,
                            SpecificHeat = 920,
                            ThermalAbsorptance = 0.93,
                            SolarAbsorptance = 0.87,
                            VisibleAbsorptance = 0.87,
                        }
                    );
                    break;
                case PredefinedMaterials.ConcreteDark:
                    construction.Name = "ConcreteDarkConstruction";
                    construction.Layers.Add(
                        new EPMaterial()
                        {
                            Name = "ConcreteDarkMaterial",
                            Roughness = BH.oM.Adapters.EnergyPlus.Roughness.MediumRough,
                            Thickness = 0.5,
                            Conductivity = 1.73,
                            Density = 2243,
                            SpecificHeat = 837,
                            ThermalAbsorptance = 0.9,
                            SolarAbsorptance = 0.75,
                            VisibleAbsorptance = 0.75,
                        }
                    );
                    break;
                case PredefinedMaterials.ConcreteLight:
                    construction.Name = "ConcreteLightConstruction";
                    construction.Layers.Add(
                        new EPMaterial()
                        {
                            Name = "ConcreteLightMaterial",
                            Roughness = BH.oM.Adapters.EnergyPlus.Roughness.MediumRough,
                            Thickness = 0.5,
                            Conductivity = 1.73,
                            Density = 2243,
                            SpecificHeat = 837,
                            ThermalAbsorptance = 0.9,
                            SolarAbsorptance = 0.65,
                            VisibleAbsorptance = 0.65,
                        }
                    );
                    break;
                case PredefinedMaterials.Sand:
                    construction.Name = "SandConstruction";
                    construction.Layers.Add(
                        new EPMaterial()
                        {
                            Name = "SandMaterial",
                            Roughness = BH.oM.Adapters.EnergyPlus.Roughness.Rough,
                            Thickness = 0.5,
                            Conductivity = 0.33,
                            Density = 1555,
                            SpecificHeat = 800,
                            ThermalAbsorptance = 0.85,
                            SolarAbsorptance = 0.65,
                            VisibleAbsorptance = 0.65,
                        }
                    );
                    break;
                case PredefinedMaterials.SoilDry:
                    construction.Name = "SoilDryConstruction";
                    construction.Layers.Add(
                        new EPMaterial()
                        {
                            Name = "SoilDryMaterial",
                            Roughness = BH.oM.Adapters.EnergyPlus.Roughness.Rough,
                            Thickness = 0.5,
                            Conductivity = 0.5,
                            Density = 1600,
                            SpecificHeat = 1026,
                            ThermalAbsorptance = 0.9,
                            SolarAbsorptance = 0.7,
                            VisibleAbsorptance = 0.7,
                        }
                    );
                    break;
                case PredefinedMaterials.SoilMoist:
                    construction.Name = "SoilMoistConstruction";
                    construction.Layers.Add(
                        new EPMaterial()
                        {
                            Name = "SoilMoistMaterial",
                            Roughness = BH.oM.Adapters.EnergyPlus.Roughness.Rough,
                            Thickness = 0.5,
                            Conductivity = 1,
                            Density = 1250,
                            SpecificHeat = 1252,
                            ThermalAbsorptance = 0.92,
                            SolarAbsorptance = 0.75,
                            VisibleAbsorptance = 0.75,
                        }
                    );
                    break;
                case PredefinedMaterials.SoilSaturated:
                    construction.Name = "SoilSaturatedConstruction";
                    construction.Layers.Add(
                        new EPMaterial()
                        {
                            Name = "SoilSaturatedMaterial",
                            Roughness = BH.oM.Adapters.EnergyPlus.Roughness.MediumRough,
                            Thickness = 0.5,
                            Conductivity = 1.4,
                            Density = 1840,
                            SpecificHeat = 1480,
                            ThermalAbsorptance = 0.95,
                            SolarAbsorptance = 0.8,
                            VisibleAbsorptance = 0.8,
                        }
                    );
                    break;
                case PredefinedMaterials.StoneLight:
                    construction.Name = "StoneLightConstruction";
                    construction.Layers.Add(
                        new EPMaterial()
                        {
                            Name = "StoneLightMaterial",
                            Roughness = BH.oM.Adapters.EnergyPlus.Roughness.MediumRough,
                            Thickness = 0.5,
                            Conductivity = 3,
                            Density = 2700,
                            SpecificHeat = 790,
                            ThermalAbsorptance = 0.96,
                            SolarAbsorptance = 0.55,
                            VisibleAbsorptance = 0.55,
                        }
                    );
                    break;
                case PredefinedMaterials.StoneDark:
                    construction.Name = "StoneDarkConstruction";
                    construction.Layers.Add(
                        new EPMaterial()
                        {
                            Name = "StoneDarkMaterial",
                            Roughness = BH.oM.Adapters.EnergyPlus.Roughness.MediumRough,
                            Thickness = 0.5,
                            Conductivity = 3,
                            Density = 2700,
                            SpecificHeat = 790,
                            ThermalAbsorptance = 0.96,
                            SolarAbsorptance = 0.75,
                            VisibleAbsorptance = 0.75,
                        }
                    );
                    break;
                case PredefinedMaterials.WaterProxy:
                    construction.Name = "WaterProxyConstruction";
                    construction.Layers.Add(
                        new EPMaterial()
                        {
                            Name = "WaterProxyMaterial",
                            Roughness = BH.oM.Adapters.EnergyPlus.Roughness.Smooth,
                            Thickness = 1,
                            Conductivity = 0.6,
                            Density = 997,
                            SpecificHeat = 4200,
                            ThermalAbsorptance = 0.95,
                            SolarAbsorptance = 0.6,
                            VisibleAbsorptance = 0.5,
                        }
                    );
                    break;
                case PredefinedMaterials.Grass:
                    construction.Name = "GrassConstruction";
                    construction.Layers.Add(
                        new EPMaterialVegetation() {
                            Name = "GrassMaterial",
                            HeightOfPlants = 0.05,
                            LeafAreaIndex = 1.71,
                            LeafReflectivity = 0.19,
                            LeafEmissivity = 0.95,
                            MinimumStomatalResistance = 180,
                            SoilLayerName = "GrassMaterialSoilLayer",
                            Roughness = BH.oM.Adapters.EnergyPlus.Roughness.Rough,
                            Thickness = 0.2,
                            ConductivityOfDrySoil = 1,
                            DensityOfDrySoil = 1250,
                            SpecificHeatOfDrySoil = 1252,
                            ThermalAbsorptance = 0.92,
                            SolarAbsorptance = 0.75,
                            VisibleAbsorptance = 0.75,
                            SaturationVolumetricMoistureContentOfTheSoilLayer = 0.3,
                            ResidualVolumetricMoistureContentOfTheSoilLayer = 0.01,
                            InitialVolumetricMoistureContentOfTheSoilLayer = 0.1,
                            MoistureDiffusionCalculationMethod = MoistureDiffusionCalculationMethod.Simple
                        }
                    );
                    break;
                case PredefinedMaterials.Shrubs:
                    construction.Name = "ShrubsConstruction";
                    construction.Layers.Add(
                        new EPMaterialVegetation()
                        {
                            Name = "ShrubsMaterial",
                            HeightOfPlants = 0.25,
                            LeafAreaIndex = 2.08,
                            LeafReflectivity = 0.21,
                            LeafEmissivity = 0.95,
                            MinimumStomatalResistance = 180,
                            SoilLayerName = "ShrubsMaterialSoilLayer",
                            Roughness = BH.oM.Adapters.EnergyPlus.Roughness.Rough,
                            Thickness = 0.2,
                            ConductivityOfDrySoil = 0.5,
                            DensityOfDrySoil = 1600,
                            SpecificHeatOfDrySoil = 1026,
                            ThermalAbsorptance = 0.9,
                            SolarAbsorptance = 0.7,
                            VisibleAbsorptance = 0.7,
                            SaturationVolumetricMoistureContentOfTheSoilLayer = 0.3,
                            ResidualVolumetricMoistureContentOfTheSoilLayer = 0.01,
                            InitialVolumetricMoistureContentOfTheSoilLayer = 0.1,
                            MoistureDiffusionCalculationMethod = MoistureDiffusionCalculationMethod.Simple
                        }
                    );
                    break;
                case PredefinedMaterials.MetalDull:
                    construction.Name = "MetalDullConstruction";
                    construction.Layers.Add(
                        new EPMaterial()
                        {
                            Name = "MetalDullMaterial",
                            Roughness = BH.oM.Adapters.EnergyPlus.Roughness.Smooth,
                            Thickness = 0.05,
                            Conductivity = 45.28,
                            Density = 7824,
                            SpecificHeat = 500,
                            ThermalAbsorptance = 0.88,
                            SolarAbsorptance = 0.7,
                            VisibleAbsorptance = 0.7,
                        }
                    );
                    break;
                case PredefinedMaterials.MetalShiny:
                    construction.Name = "MetalShinyConstruction";
                    construction.Layers.Add(
                        new EPMaterial()
                        {
                            Name = "MetalShinyMaterial",
                            Roughness = BH.oM.Adapters.EnergyPlus.Roughness.Smooth,
                            Thickness = 0.05,
                            Conductivity = 45.28,
                            Density = 7824,
                            SpecificHeat = 500,
                            ThermalAbsorptance = 0.56,
                            SolarAbsorptance = 0.7,
                            VisibleAbsorptance = 0.7,
                        }
                    );
                    break;
                case PredefinedMaterials.Undefined:
                    break;
                default:
                    break;
            }
            return construction;
        }
    }
}