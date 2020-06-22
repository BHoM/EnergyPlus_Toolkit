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

using BH.oM.EnergyPlus;
using BH.oM.Reflection.Attributes;
using System.ComponentModel;
using BHM = BH.oM.Environment.MaterialFragments;

namespace BH.Engine.EnergyPlus
{
    public static partial class Convert
    {
        [Description("Convert a BHoM Roughness to an EnergyPlus Roughness")]
        [Input("roughness", "BHoM roughness")]
        [Output("roughness", "EnergyPlus Roughness")]
        public static Roughness ToEnergyPlus(this BHM.Roughness roughness)
        {
            switch (roughness)
            {
                case BHM.Roughness.MediumRough:
                    return Roughness.MediumRough;
                case BHM.Roughness.MediumSmooth:
                    return Roughness.MediumSmooth;
                case BHM.Roughness.Rough:
                    return Roughness.Rough;
                case BHM.Roughness.Smooth:
                    return Roughness.Smooth;
                case BHM.Roughness.VeryRough:
                    return Roughness.VeryRough;
                case BHM.Roughness.VerySmooth:
                    return Roughness.VerySmooth;
                default:
                    return Roughness.MediumRough;
            }
        }
    }
}

