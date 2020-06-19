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
using System.Reflection;
using BH.Engine.Reflection;
using BH.oM.Reflection;
using BH.oM.EnergyPlus;

namespace BH.Engine.EnergyPlus
{
    public static partial class Convert
    {
        public static string ToEnergyPlusString(this SurfaceConstructionElements surfaceConstructionElements)
        {
            StringBuilder sb = new StringBuilder();

            foreach (EnergyPlusMaterial material in surfaceConstructionElements.Materials)
            {
                sb.Append(material.ToEnergyPlusString());
            }

            foreach (EnergyPlusMaterial material in surfaceConstructionElements.Materials)
            {
                sb.Append(material.ToEnergyPlusString());
            }

            foreach (MaterialRoofVegetation vegetationMaterial in surfaceConstructionElements.VegetationMaterials)
            {
                sb.Append(vegetationMaterial.ToEnergyPlusString());
            }

            foreach (EnergyPlusWindowMaterialGlazing glazingMaterial in surfaceConstructionElements.GlazingMaterials)
            {
                sb.Append(glazingMaterial.ToEnergyPlusString());
            }

            foreach (EnergyPlusConstruction construction in surfaceConstructionElements.Constructions)
            {
                sb.Append(construction.ToEnergyPlusString());
            }

            return sb.ToString();
        }
    }
}
