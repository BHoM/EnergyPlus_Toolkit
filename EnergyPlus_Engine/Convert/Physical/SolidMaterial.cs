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

using BHE = BH.oM.Environment.Elements;
using BHM = BH.oM.Physical.Materials;
using BHP = BH.oM.Physical.Constructions;
using BH.oM.EnergyPlus.Settings;
using BH.oM.EnergyPlus;

using BH.Engine.Environment;
using BH.oM.Physical.Materials;
using BH.oM.Environment.MaterialFragments;

namespace BH.Engine.EnergyPlus
{
    public static partial class Convert
    {
        public static IEnergyPlusClass ToEnergyPlus(this SolidMaterial solidMaterial, double thickness)
        {
            Material bhomMaterial = new Material();
            bhomMaterial.Properties.Add(solidMaterial);

            string materialName = solidMaterial.Name == "" ? solidMaterial.BHoM_Guid.ToString() : solidMaterial.Name;

            if (BH.Engine.Environment.Query.IsTransparent(bhomMaterial))
            {
                EPMaterialWindowGlazing eplusMaterial = new EPMaterialWindowGlazing();
                eplusMaterial.Name = materialName;
                eplusMaterial.OpticalDataType = OpticalDataType.SpectralAverage;
                eplusMaterial.Thickness = thickness;
                eplusMaterial.SolarTransmittanceAtNormalIncidence = solidMaterial.SolarTransmittance;
                eplusMaterial.FrontSideSolarReflectanceAtNormalIncidence = solidMaterial.SolarReflectanceExternal;
                eplusMaterial.BackSideSolarReflectanceAtNormalIncidence = solidMaterial.SolarReflectanceInternal;
                eplusMaterial.VisibleTransmittanceAtNormalIncidence = solidMaterial.LightTransmittance;
                eplusMaterial.FrontSideVisibleReflectanceAtNormalIncidence = solidMaterial.LightReflectanceExternal;
                eplusMaterial.BackSideVisibleReflectanceAtNormalIncidence = solidMaterial.LightReflectanceInternal;
                eplusMaterial.FrontSideInfraredHemisphericalEmissivity = solidMaterial.EmissivityExternal;
                eplusMaterial.BackSideInfraredHemisphericalEmissivity = solidMaterial.EmissivityInternal;
                eplusMaterial.Conductivity = solidMaterial.Conductivity;
                return eplusMaterial;
            }
            else
            {
                EPMaterial eplusMaterial = new EPMaterial();
                eplusMaterial.Name = materialName;
                eplusMaterial.Roughness = solidMaterial.Roughness.ToEnergyPlus();
                eplusMaterial.Thickness = thickness;
                eplusMaterial.Conductivity = solidMaterial.Conductivity;
                eplusMaterial.Density = solidMaterial.Density;
                eplusMaterial.SpecificHeat = solidMaterial.SpecificHeat;
                eplusMaterial.ThermalAbsorptance = solidMaterial.EmissivityExternal;
                eplusMaterial.SolarAbsorptance = 1 - solidMaterial.SolarReflectanceExternal;
                eplusMaterial.VisibleAbsorptance = 1 - solidMaterial.LightReflectanceExternal;
                return eplusMaterial;
            }
        }
    }
}
