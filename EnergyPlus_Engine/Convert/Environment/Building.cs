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
using BH.oM.EnergyPlus.Settings;

namespace BH.Engine.EnergyPlus
{
    public static partial class Convert
    {
        public static List<string> ToEnergyPlus(this BHE.Building building, EnergyPlusSettings settings)
        {
            List<string> buildingAsString = new List<string>();

            buildingAsString.Add(String.Format("{0},", "Building"));
            buildingAsString.Add(String.Format("    {0, -30}, !- {1}", building.Name.Replace(' ', '_'), "Name"));
            buildingAsString.Add(String.Format("    {0, -30}, !- {1}", settings.NorthAngle, "North Axis {deg}"));
            buildingAsString.Add(String.Format("    {0, -30}, !- {1}", settings.Terrain, "Terrain"));
            buildingAsString.Add(String.Format("    {0, -30}, !- {1}", settings.LoadsConvergenceToleranceValue, "Loads Convergency Tolerance Value"));
            buildingAsString.Add(String.Format("    {0, -30}, !- {1}", settings.TemperatureConvergenceToleranceValue, "Temperature Convergence Tolerance Value {deltaC}"));
            buildingAsString.Add(String.Format("    {0, -30}, !- {1}", settings.SolarDistribution, "Solar Distribution"));
            buildingAsString.Add(String.Format("    {0, -30}, !- {1}", settings.MaximumWarmupDays, "Maximum Number of Warmup Days"));
            buildingAsString.Add(String.Format("    {0, -30}; !- {1}", settings.MinimumWarmupDays, "Minimum Number of Warmup Days"));
            buildingAsString.Add("");

            buildingAsString.Add(String.Format("{0},", "Site:Location"));
            buildingAsString.Add(String.Format("    {0, -30}, !- {1}", String.IsNullOrEmpty(building.Location.Name) ? "SiteName" : building.Location.Name.Replace(' ', '_'), "Name"));
            buildingAsString.Add(String.Format("    {0, -30}, !- {1}", building.Location.Latitude, "Latitude {deg}"));
            buildingAsString.Add(String.Format("    {0, -30}, !- {1}", building.Location.Longitude, "Longitude {deg}"));
            buildingAsString.Add(String.Format("    {0, -30}, !- {1}", building.Location.UtcOffset, "TimeZone"));
            buildingAsString.Add(String.Format("    {0, -30}; !- {1}", building.Location.Elevation, "Elevation"));
            buildingAsString.Add("");

            return buildingAsString;
        }
    }
}
