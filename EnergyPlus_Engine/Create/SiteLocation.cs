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

using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using BH.oM.Adapters.EnergyPlus;
using BH.oM.Reflection.Attributes;

namespace BH.Engine.Adapters.EnergyPlus
{
    public static partial class Create
    {
        [Description("Create an EnergyPlus SiteLocation object from an EPW file")]
        [Input("epwFile", "Path to an epw-file")]
        [Output("siteLocation", "An energyPlus siteLocation object")]
        public static SiteLocation SiteLocation(string epwFile)
        {
            SiteLocation siteLocation = new SiteLocation();
            string Epwfile = System.IO.File.ReadLines(epwFile).First();
            List<string> commaPoints = Epwfile.Split(',').ToList();
            siteLocation.Name = commaPoints[1] + "_" + commaPoints[2] + "_" + commaPoints[3] + "_" + commaPoints[4] + "_" + commaPoints[5];  // Expected output
            siteLocation.Latitude = System.Convert.ToDouble(commaPoints[6]);
            siteLocation.Longitude = System.Convert.ToDouble(commaPoints[7]);
            siteLocation.TimeZone = System.Convert.ToDouble(commaPoints[8]);
            siteLocation.Elevation = System.Convert.ToDouble(commaPoints[9]);
            return siteLocation;
        }
    }
}