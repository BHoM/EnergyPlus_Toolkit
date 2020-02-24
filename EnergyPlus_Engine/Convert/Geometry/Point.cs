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

using OpenStudio;
using BHG = BH.oM.Geometry;

namespace BH.Engine.EnergyPlus
{
    public static partial class Convert
    {
        public static List<string> ToEnergyPlus(this BHG.Point pnt, int decimalPlaces = 6)
        {
            List<string> pointAsString = new List<string>();

            pointAsString.Add("\t" + Math.Round(pnt.X, decimalPlaces).ToString() + ",");
            pointAsString.Add("\t" + Math.Round(pnt.Y, decimalPlaces).ToString() + ",");
            pointAsString.Add("\t" + Math.Round(pnt.Z, decimalPlaces).ToString() + ",");

            return pointAsString;
        }

        public static List<string> ToEnergyPlus(this List<BHG.Point> pnts, int decimalPlaces = 6)
        {
            List<string> pointsAsString = new List<string>();

            for(int x = 0; x < pnts.Count; x++)
                pointsAsString.AddRange(pnts[x].ToEnergyPlus(decimalPlaces));

            pointsAsString[pointsAsString.Count - 1] = pointsAsString[pointsAsString.Count - 1].Replace(',', ';');

            return pointsAsString;
        }
    }
}
