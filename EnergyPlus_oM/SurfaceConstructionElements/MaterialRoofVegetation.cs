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

using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class MaterialRoofVegetation : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "Material:RoofVegetation";
        [Order]
        [Description("No description available")]
        public override string Name { get; set; } = "Grass";
        [Order]
        [Description("The ecoroof module is designed for short plants and shrubs.")]
        public virtual double HeightOfPlants { get; set; } = 0.2;
        [Order]
        [Description("Entire surface is assumed covered, so decrease LAI accordingly.")]
        public virtual double LeafAreaIndex { get; set; } = 1.71;
        [Order]
        [Description("Leaf reflectivity (albedo) is typically 0.18-0.25")]
        public virtual double LeafReflectivity { get; set; } = 0.19;
        [Order]
        [Description("No description available")]
        public virtual double LeafEmissivity { get; set; } = 0.95;
        [Order]
        [Description("This depends upon plant type")]
        public virtual double MinimumStomatalResistance { get; set; } = 180.0;
        [Order]
        [Description("No description available")]
        public virtual string SoilLayerName { get; set; } = "SoilLayerName";
        [Order]
        [Description("No description available")]
        public virtual Roughness Roughness { get; set; } = Roughness.Rough;
        [Order]
        [Description("thickness of the soil layer of the EcoRoof")]
        public virtual double Thickness { get; set; } = 0.2;
        [Order]
        [Description("Thermal conductivity of dry soil.")]
        public virtual double ConductivityOfDrySoil { get; set; } = 1.0;
        [Order]
        [Description("Density of dry soil (the code modifies this as the soil becomes moist)")]
        public virtual double DensityOfDrySoil { get; set; } = 1250;
        [Order]
        [Description("Specific heat of dry soil")]
        public virtual double SpecificHeatOfDrySoil { get; set; } = 1252;
        [Order]
        [Description("Soil emissivity is typically in range of 0.90 to 0.98")]
        public virtual double ThermalAbsorptance { get; set; } = 0.92;
        [Order]
        [Description("Solar absorptance of dry soil (1-albedo) is typically 0.60 to 0.85")]
        public virtual double SolarAbsorptance { get; set; } = 0.75;
        [Order]
        [Description("No description available")]
        public virtual double VisibleAbsorptance { get; set; } = 0.75;
        [Order]
        [Description("Maximum moisture content is typically less than 0.5")]
        public virtual double SaturationVolumetricMoistureContentOfTheSoilLayer { get; set; } = 0.3;
        [Order]
        [Description("No description available")]
        public virtual double ResidualVolumetricMoistureContentOfTheSoilLayer { get; set; } = 0.01;
        [Order]
        [Description("No description available")]
        public virtual double InitialVolumetricMoistureContentOfTheSoilLayer { get; set; } = 0.1;
        [Order]
        [Description("Advanced calculation requires increased number of timesteps (recommended >20).")]
        public virtual MoistureDiffusionCalculationMethod MoistureDiffusionCalculationMethod { get; set; } = MoistureDiffusionCalculationMethod.Simple;
    }
}
