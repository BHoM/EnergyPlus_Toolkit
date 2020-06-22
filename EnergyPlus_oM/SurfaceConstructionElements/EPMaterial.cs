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
    public class EPMaterial : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "Material";
        [Order]
        [Description("Material name")]
        public override string Name { get; set; } = "DefaultMaterial";
        [Order]
        [Description("EnergyPlus roughness")]
        public virtual Roughness Roughness { get; set; } = Roughness.MediumRough;
        [Order]
        [Description("Thickness of material (m)")]
        public virtual double Thickness { get; set; } = 0.1;
        [Order]
        [Description("Conductivity of material (W/mK)")]
        public virtual double Conductivity { get; set; } = 0.5;
        [Order]
        [Description("Density of material (kg/m3)")]
        public virtual double Density { get; set; } = 1000;
        [Order]
        [Description("Specific heat capacity of material (J/kgK)")]
        public virtual double SpecificHeat { get; set; } = 1000;
        [Order]
        [Description("Thermal absorptivity (emissivity) of material (0-1)")]
        public virtual double ThermalAbsorptance { get; set; } = 0.9;
        [Order]
        [Description("Solar absorptivity of material (0-1)")]
        public virtual double SolarAbsorptance { get; set; } = 0.7;
        [Order]
        [Description("Light absorptivity (1 - albedo) of material (0-1)")]
        public virtual double VisibleAbsorptance { get; set; } = 0.7;
    }
}
