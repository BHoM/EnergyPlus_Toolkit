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

using BH.Engine.Environment;
using BH.Engine.Geometry;

using BHG = BH.oM.Geometry;

namespace BH.Engine.EnergyPlus
{
    public static partial class Convert
    {
        public static List<string> ToEnergyPlus(this BHE.Opening opening, string hostPanelName, EnergyPlusSettings settings)
        {
            List<string> openingAsString = new List<string>();

            openingAsString.Add("FenestrationSurface:Detailed,");
            openingAsString.Add("\t" + opening.Name.Replace(' ', '_') + ",\t!- Name"); //Name
            openingAsString.Add("\t" + opening.Type.ToEnergyPlus() + ",\t!- Surface Type"); //PanelType
            openingAsString.Add("\t" + opening.OpeningConstruction.UniqueConstructionName().Replace(' ', '_') + ",\t!- Construction Name"); //Construction name
            openingAsString.Add("\t" + hostPanelName + ",\t!- Surface Name");
            openingAsString.Add("\t,\t!- Outside boundary condition object"); //Outside boundary condition object
            openingAsString.Add("\tautocalculate,\t!- View Factor to Ground"); //View factor to ground
            openingAsString.Add("\t,\t!- Frame and Divider Name"); //Frame and Divider Name
            openingAsString.Add("\t1,\t!- Multiplier Name"); //Multiplier Name
            
            openingAsString.AddRange(opening.Polyline().ToEnergyPlus(settings.DecimalPlaces));

            openingAsString.Add("");
            openingAsString.Add("");

            return openingAsString;
        }
    }
}
