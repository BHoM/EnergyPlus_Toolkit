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
using BHE = BH.oM.Environment.Elements;

namespace BH.Engine.EnergyPlus
{
    public static partial class Convert
    {
        [Description("Convert a BHoM OpeningType to an EnergyPlus OpeningType")]
        [Input("type", "BHoM opening type")]
        [Output("type", "EnergyPlus opening type")]
        public static FenestrationSurfaceType ToEnergyPlus(this BHE.OpeningType type)
        {
            switch (type)
            {
                case BHE.OpeningType.Window:
                    return FenestrationSurfaceType.Window;
                case BHE.OpeningType.WindowWithFrame:
                    return FenestrationSurfaceType.Window;
                case BHE.OpeningType.Rooflight:
                    return FenestrationSurfaceType.Window;
                case BHE.OpeningType.RooflightWithFrame:
                    return FenestrationSurfaceType.Window;
                case BHE.OpeningType.Door:
                    return FenestrationSurfaceType.Door;
                default:
                    return FenestrationSurfaceType.Window;
            }
        }
    }
}
