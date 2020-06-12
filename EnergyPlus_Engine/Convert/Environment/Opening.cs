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

            openingAsString.Add(String.Format("{0},", "FenestrationSurface:Detailed"));
            openingAsString.Add(String.Format("    {0, -30}, !- {1}", opening.Name.Replace(' ', '_'), "Name"));
            openingAsString.Add(String.Format("    {0, -30}, !- {1}", opening.Type.ToEnergyPlus(), "Surface Type"));
            openingAsString.Add(String.Format("    {0, -30}, !- {1}", opening.OpeningConstruction.UniqueConstructionName().Replace(' ', '_'), "Construction Name"));
            openingAsString.Add(String.Format("    {0, -30}, !- {1}", hostPanelName, "Surface Name"));
            openingAsString.Add(String.Format("    {0, -30}, !- {1}", "", "Outside boundary condition object"));
            openingAsString.Add(String.Format("    {0, -30}, !- {1}", "autocalculate", "View Factor to Ground"));
            openingAsString.Add(String.Format("    {0, -30}, !- {1}", "", "Frame and Divider Name"));
            openingAsString.Add(String.Format("    {0, -30}, !- {1}", 1, "Multiplier Name"));

            openingAsString.AddRange(opening.Polyline().ToEnergyPlus(settings.DecimalPlaces));

            openingAsString.Add("");

            return openingAsString;
        }
    }
}
