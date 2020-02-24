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
using BHG = BH.oM.Geometry;
using BH.Engine.Geometry;

namespace BH.Engine.EnergyPlus
{
    public static partial class Convert
    {
        public static List<string> ToEnergyPlus(this BHE.Panel panel, string connectedSpaceName, EnergyPlusSettings settings)
        {
            List<string> panelAsString = new List<string>();

            panelAsString.Add("BuildingSurface:Detailed,");
            panelAsString.Add("\t" + (panel.Name.Replace(' ', '_') == "" ? panel.BHoM_Guid.ToString() : panel.Name.Replace(' ', '_')) + ",\t!- Name"); //Name
            panelAsString.Add("\t" + panel.Type.ToEnergyPlus() + ",\t!- Surface Type"); //PanelType
            panelAsString.Add("\t" + panel.Construction.UniqueConstructionName().Replace(' ', '_') + ",\t!- Construction Name"); //Construction name
            panelAsString.Add("\t" + connectedSpaceName + ",\t!- Zone Name"); //Zone (space) name
            panelAsString.Add("\t" + panel.OutsideBoundaryCondition() + ",\t!- Outside Boundary Condition"); //Outside boundary condition
            panelAsString.Add("\t,\t!- Outside boundary condition object"); //Outside boundary condition object
            panelAsString.Add("\t" + (panel.ExposedToSun() ? "SunExposed" : "NoSun") + ",\t!- Sun Exposure"); //Sun Exposure
            panelAsString.Add("\t" + (panel.ExposedToSun() ? "WindExposed" : "NoWind") + ",\t!- Wind Exposure"); //Wind Exposure
            panelAsString.Add("\tautocalculate,\t!- View Factor to Ground"); //View factor to ground
            panelAsString.AddRange(panel.Polyline().ToEnergyPlus(settings.DecimalPlaces));
            panelAsString.Add("");
            panelAsString.Add("");

            foreach (BHE.Opening o in panel.Openings)
                panelAsString.AddRange(o.ToEnergyPlus((panel.Name.Replace(' ', '_') == "" ? panel.BHoM_Guid.ToString() : panel.Name.Replace(' ', '_')), settings));

            return panelAsString;
        }
    }
}
