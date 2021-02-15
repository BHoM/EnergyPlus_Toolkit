/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2021, the respective contributors. All rights reserved.
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

using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using BH.Engine.Reflection;
using BH.oM.Adapters.EnergyPlus;
using BH.oM.Reflection;
using BH.oM.Reflection.Attributes;

namespace BH.Engine.Adapters.EnergyPlus
{
    public static partial class Create
    {
        [Description("Create one of a predefined set of constructions, comrpsied of a single layer material, applied to massing objects in an external context.")]
        [Input("massingMaterial", "The type of material this construction is comprised of.")]
        [Output("massingConstruction", "An EnergyPlus construction object.")]
        public static EnergyPlusConstruction MassingConstruction(MassingMaterial massingMaterial)
        {
            // Define dictionary of available materials
            Dictionary<MassingMaterial, IEnergyPlusMaterial> materials = new Dictionary<MassingMaterial, IEnergyPlusMaterial>();
            materials[MassingMaterial.Asphalt] = new EnergyPlusMaterial() {
                Name = "DEFAULT_ASPHALT",
                Roughness = Roughness.MediumRough,
                Thickness = 0.2,
                Conductivity = 0.75,
                Density = 2360,
                SpecificHeat = 920,
                ThermalAbsorptance = 0.93,
                SolarAbsorptance = 0.87,
                VisibleAbsorptance = 0.87,
            };
            materials[MassingMaterial.Concrete] = new EnergyPlusMaterial()
            {
                Name = "DEFAULT_CONCRETE",
                Roughness = Roughness.MediumRough,
                Thickness = 0.2,
                Conductivity = 1.73,
                Density = 2243,
                SpecificHeat = 837,
                ThermalAbsorptance = 0.9,
                SolarAbsorptance = 0.65,
                VisibleAbsorptance = 0.65,
            };
            materials[MassingMaterial.Fabric] = new EnergyPlusMaterial()
            {
                Name = "DEFAULT_FABRIC",
                Roughness = Roughness.Smooth,
                Thickness = 0.001,
                Conductivity = 45.28,
                Density = 7824,
                SpecificHeat = 500,
                ThermalAbsorptance = 0.9,
                SolarAbsorptance = 0.7,
                VisibleAbsorptance = 0.7,
            };
            materials[MassingMaterial.Grass] = new EnergyPlusMaterialRoofVegetation()
            {
                Name = "DEFAULT_GRASS",
                HeightOfPlants = 0.05,
                LeafAreaIndex = 1.71,
                LeafReflectivity = 0.19,
                LeafEmissivity = 0.95,
                MinimumStomatalResistance = 180.0,
                SoilLayerName = "DEFAULT_SOIL",
                Roughness = Roughness.Rough,
                Thickness = 0.2,
                ConductivityOfDrySoil = 1.0,
                DensityOfDrySoil = 1250,
                SpecificHeatOfDrySoil = 1252,
                ThermalAbsorptance = 0.92,
                SolarAbsorptance = 0.75,
                VisibleAbsorptance = 0.75,
                SaturationVolumetricMoistureContentOfTheSoilLayer = 0.3,
                ResidualVolumetricMoistureContentOfTheSoilLayer = 0.01,
                InitialVolumetricMoistureContentOfTheSoilLayer = 0.1,
                MoistureDiffusionCalculationMethod = MoistureDiffusionCalculationMethod.Simple,
            };
            materials[MassingMaterial.Hardwood] = new EnergyPlusMaterial()
            {
                Name = "DEFAULT_HARDWOOD",
                Roughness = Roughness.MediumSmooth,
                Thickness = 0.1,
                Conductivity = 0.167,
                Density = 680,
                SpecificHeat = 1630,
                ThermalAbsorptance = 0.9,
                SolarAbsorptance = 0.7,
                VisibleAbsorptance = 0.7,
            };
            materials[MassingMaterial.Limestone] = new EnergyPlusMaterial()
            {
                Name = "DEFAULT_LIMESTONE",
                Roughness = Roughness.MediumRough,
                Thickness = 0.2,
                Conductivity = 3.2,
                Density = 2560,
                SpecificHeat = 790,
                ThermalAbsorptance = 0.96,
                SolarAbsorptance = 0.55,
                VisibleAbsorptance = 0.55,
            };
            materials[MassingMaterial.Metal] = new EnergyPlusMaterial()
            {
                Name = "DEFAULT_METAL",
                Roughness = Roughness.Smooth,
                Thickness = 0.005,
                Conductivity = 45.28,
                Density = 7824,
                SpecificHeat = 500,
                ThermalAbsorptance = 0.9,
                SolarAbsorptance = 0.7,
                VisibleAbsorptance = 0.7,
            };
            materials[MassingMaterial.Sand] = new EnergyPlusMaterial()
            {
                Name = "DEFAULT_SAND",
                Roughness = Roughness.Rough,
                Thickness = 0.2,
                Conductivity = 0.33,
                Density = 1555,
                SpecificHeat = 800,
                ThermalAbsorptance = 0.85,
                SolarAbsorptance = 0.65,
                VisibleAbsorptance = 0.65,
            };
            materials[MassingMaterial.Sandstone] = new EnergyPlusMaterial()
            {
                Name = "DEFAULT_SANDSTONE",
                Roughness = Roughness.MediumRough,
                Thickness = 0.2,
                Conductivity = 6.2,
                Density = 2560,
                SpecificHeat = 790,
                ThermalAbsorptance = 0.65,
                SolarAbsorptance = 0.55,
                VisibleAbsorptance = 0.55,
            };
            materials[MassingMaterial.Shrubs] = new EnergyPlusMaterialRoofVegetation()
            {
                Name = "DEFAULT_SHRUBS",
                HeightOfPlants = 0.25,
                LeafAreaIndex = 2.08,
                LeafReflectivity = 0.21,
                LeafEmissivity = 0.95,
                MinimumStomatalResistance = 180.0,
                SoilLayerName = "DEFAULT_SOIL",
                Roughness = Roughness.Rough,
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
                MoistureDiffusionCalculationMethod = MoistureDiffusionCalculationMethod.Simple,
            };
            materials[MassingMaterial.Softwood] = new EnergyPlusMaterial()
            {
                Name = "DEFAULT_SOFTWOOD",
                Roughness = Roughness.MediumSmooth,
                Thickness = 0.1,
                Conductivity = 0.129,
                Density = 496,
                SpecificHeat = 1630,
                ThermalAbsorptance = 0.9,
                SolarAbsorptance = 0.7,
                VisibleAbsorptance = 0.7,
            };
            materials[MassingMaterial.Undefined] = new EnergyPlusMaterial();
            materials[MassingMaterial.Water] = new EnergyPlusMaterialWindowGlazing()
            {
                Name = "DEFAULT_WATER",
                OpticalDataType = OpticalDataType.SpectralAverage,
                WindowGlassSpectralDataSetName = "",
                Thickness = 0.5,
                SolarTransmittanceAtNormalIncidence = 0.837,
                FrontSideSolarReflectanceAtNormalIncidence = 0.075,
                BackSideSolarReflectanceAtNormalIncidence = 0,
                VisibleTransmittanceAtNormalIncidence = 0.898,
                FrontSideVisibleReflectanceAtNormalIncidence = 0.081,
                BackSideVisibleReflectanceAtNormalIncidence = 0,
                InfraredTransmittanceAtNormalIncidence = 0,
                FrontSideInfraredHemisphericalEmissivity = 0.84,
                BackSideInfraredHemisphericalEmissivity = 0.84,
                Conductivity = 0.9,
                DirtCorrectionFactorForSolarAndVisibleTransmittance = 1,
                SolarDiffusing = false,
            };

            // Check material given is available in dictionary, and return it if it is
            if (materials.ContainsKey(massingMaterial))
            {
                return new EnergyPlusConstruction() {
                    Name = massingMaterial.ToString(),
                    Layers = new List<IEnergyPlusMaterial>() { materials[massingMaterial] },
                };
            }
            else
            {
                BH.Engine.Reflection.Compute.RecordError("Material not found. You may need to define this material manually instead.");
                return null;
            }
        }
    }
}

