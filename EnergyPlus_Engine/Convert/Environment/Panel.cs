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

            panelAsString.Add(String.Format("{0},", "BuildingSurface:Detailed"));
            panelAsString.Add(String.Format("    {0, -30}, !- {1}", (panel.Name.Replace(' ', '_') == "" ? panel.BHoM_Guid.ToString() : panel.Name.Replace(' ', '_')), "Name"));
            panelAsString.Add(String.Format("    {0, -30}, !- {1}", panel.Type.ToEnergyPlus(), "Surface Type"));
            panelAsString.Add(String.Format("    {0, -30}, !- {1}", panel.Construction.UniqueConstructionName().Replace(' ', '_'), "Construction Name"));
            panelAsString.Add(String.Format("    {0, -30}, !- {1}", connectedSpaceName, "Zone Name"));
            panelAsString.Add(String.Format("    {0, -30}, !- {1}", panel.OutsideBoundaryCondition(), "Outside Boundary Condition "));
            panelAsString.Add(String.Format("    {0, -30}, !- {1}", "", "Outside Boundary Condition Object"));
            panelAsString.Add(String.Format("    {0, -30}, !- {1}", (panel.ExposedToSun() ? "SunExposed" : "NoSun"), "Sun Exposure"));
            panelAsString.Add(String.Format("    {0, -30}, !- {1}", (panel.ExposedToSun() ? "WindExposed" : "NoWind"), "Wind Exposure"));
            panelAsString.Add(String.Format("    {0, -30}, !- {1}", "autocalculate", "View Factor to Ground"));

            panelAsString.AddRange(panel.Polyline().ToEnergyPlus(settings.DecimalPlaces));

            panelAsString.Add("");

            foreach (BHE.Opening o in panel.Openings)
                panelAsString.AddRange(o.ToEnergyPlus((panel.Name.Replace(' ', '_') == "" ? panel.BHoM_Guid.ToString() : panel.Name.Replace(' ', '_')), settings));

            return panelAsString;
        }
    }
}
