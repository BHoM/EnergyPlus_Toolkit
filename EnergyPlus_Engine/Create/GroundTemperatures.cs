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
using System.IO;
using System.Linq;
using BH.oM.Adapters.EnergyPlus;
using BH.oM.Reflection;
using BH.oM.Reflection.Attributes;

namespace BH.Engine.Adapters.EnergyPlus
{
    public static partial class Create
    {
        [Description("Create EnergyPlus SiteGroundTemperatureBuildingSurface, SiteGroundTemperatureShallow and SiteGroundTemperatureDeep objects from an EPW file")]
        [Input("epwFile", "Path to an epw-file")]
        [MultiOutput(0, "siteGroundTemperatureBuildingSurface", "An energyPlus SiteGroundTemperatureBuildingSurface object")]
        [MultiOutput(1, "siteGroundTemperatureBuildingShallow", "An energyPlus SiteGroundTemperatureShallow object")]
        [MultiOutput(2, "siteGroundTemperatureBuildingDeep", "An energyPlus SiteGroundTemperatureDeep object")]
        public static Output<SiteGroundTemperatureBuildingSurface, SiteGroundTemperatureShallow, SiteGroundTemperatureDeep> GroundTemperature(string epwFile)
        {
            // Check that file passed exists, and exit if it doesn't while passing a record of your failure to the Error Log
            if (!File.Exists(epwFile))
            {
                BH.Engine.Reflection.Compute.RecordError("File not found. Did you give the correct path?");
                return null;
            }
            SiteGroundTemperatureBuildingSurface siteGroundTemperatureBuildingSurface = new SiteGroundTemperatureBuildingSurface();
            SiteGroundTemperatureShallow siteGroundTemperatureShallow = new SiteGroundTemperatureShallow();
            SiteGroundTemperatureDeep siteGroundTemperatureDeep = new SiteGroundTemperatureDeep();
            Output<SiteGroundTemperatureBuildingSurface, SiteGroundTemperatureShallow, SiteGroundTemperatureDeep> output = new Output<SiteGroundTemperatureBuildingSurface, SiteGroundTemperatureShallow, SiteGroundTemperatureDeep>
            {
                Item1 = siteGroundTemperatureBuildingSurface,
                Item2 = siteGroundTemperatureShallow,
                Item3 = siteGroundTemperatureDeep,
            };
            string[] EpwFile = System.IO.File.ReadAllLines(epwFile);
            // Check to see if the file passed contains the requisite number of lines to parse as an EPW (> 8760)
            if (EpwFile.Count() < 8760)
            {
                BH.Engine.Reflection.Compute.RecordError("The file passed has less than 8760 lines. Are you sure it's an EPW?");
                return null;
            }
            string groundTemperatures = EpwFile[3];
            List<string> commaPoints = groundTemperatures.Split(',').ToList();
            if (commaPoints.Count() < 17)
            {
                BH.Engine.Reflection.Compute.RecordError("The file has less than 12 temperatures. Does the file contain Surface ground temperatures?");
                return null;
            }
            siteGroundTemperatureBuildingSurface.JanuaryGroundTemperature = System.Convert.ToDouble(commaPoints[6]);
            siteGroundTemperatureBuildingSurface.FebruaryGroundTemperature = System.Convert.ToDouble(commaPoints[7]);
            siteGroundTemperatureBuildingSurface.MarchGroundTemperature = System.Convert.ToDouble(commaPoints[8]);
            siteGroundTemperatureBuildingSurface.AprilGroundTemperature = System.Convert.ToDouble(commaPoints[9]);
            siteGroundTemperatureBuildingSurface.MayGroundTemperature = System.Convert.ToDouble(commaPoints[10]);
            siteGroundTemperatureBuildingSurface.JuneGroundTemperature = System.Convert.ToDouble(commaPoints[11]);
            siteGroundTemperatureBuildingSurface.JulyGroundTemperature = System.Convert.ToDouble(commaPoints[12]);
            siteGroundTemperatureBuildingSurface.AugustGroundTemperature = System.Convert.ToDouble(commaPoints[13]);
            siteGroundTemperatureBuildingSurface.SeptemberGroundTemperature = System.Convert.ToDouble(commaPoints[14]);
            siteGroundTemperatureBuildingSurface.OctoberGroundTemperature = System.Convert.ToDouble(commaPoints[15]);
            siteGroundTemperatureBuildingSurface.NovemberGroundTemperature = System.Convert.ToDouble(commaPoints[16]);
            siteGroundTemperatureBuildingSurface.DecemberGroundTemperature = System.Convert.ToDouble(commaPoints[17]);
            if (commaPoints.Count >= 17 && commaPoints.Count < 33)
            {
                BH.Engine.Reflection.Compute.RecordWarning("The file has less than 36 temperatures. Does the file contain Surface, Shallow and Deep ground temperatures?");
                {
                    output.Item1 = siteGroundTemperatureBuildingSurface;
                    output.Item2 = null;
                    output.Item3 = null;
                };
                return output;
            }
            siteGroundTemperatureShallow.JanuarySurfaceGroundTemperature = System.Convert.ToDouble(commaPoints[22]);
            siteGroundTemperatureShallow.FebruarySurfaceGroundTemperature = System.Convert.ToDouble(commaPoints[23]);
            siteGroundTemperatureShallow.MarchSurfaceGroundTemperature = System.Convert.ToDouble(commaPoints[24]);
            siteGroundTemperatureShallow.AprilSurfaceGroundTemperature = System.Convert.ToDouble(commaPoints[25]);
            siteGroundTemperatureShallow.MaySurfaceGroundTemperature = System.Convert.ToDouble(commaPoints[26]);
            siteGroundTemperatureShallow.JuneSurfaceGroundTemperature = System.Convert.ToDouble(commaPoints[27]);
            siteGroundTemperatureShallow.JulySurfaceGroundTemperature = System.Convert.ToDouble(commaPoints[28]);
            siteGroundTemperatureShallow.AugustSurfaceGroundTemperature = System.Convert.ToDouble(commaPoints[29]);
            siteGroundTemperatureShallow.SeptemberSurfaceGroundTemperature = System.Convert.ToDouble(commaPoints[30]);
            siteGroundTemperatureShallow.OctoberSurfaceGroundTemperature = System.Convert.ToDouble(commaPoints[31]);
            siteGroundTemperatureShallow.NovemberSurfaceGroundTemperature = System.Convert.ToDouble(commaPoints[32]);
            siteGroundTemperatureShallow.DecemberSurfaceGroundTemperature = System.Convert.ToDouble(commaPoints[33]);
            if (commaPoints.Count >= 33 && commaPoints.Count < 49)
            {
                    BH.Engine.Reflection.Compute.RecordWarning("The file has less than 36 temperatures. Does the file contain Surface, Shallow and Deep ground temperatures?");
                 {
                    output.Item1 = siteGroundTemperatureBuildingSurface;
                    output.Item2 = siteGroundTemperatureShallow;
                    output.Item3 = null;
                 };
                    return output;
            }
            siteGroundTemperatureDeep.JanuaryDeepGroundTemperature = System.Convert.ToDouble(commaPoints[38]);
            siteGroundTemperatureDeep.FebruaryDeepGroundTemperature = System.Convert.ToDouble(commaPoints[39]);
            siteGroundTemperatureDeep.MarchDeepGroundTemperature = System.Convert.ToDouble(commaPoints[40]);
            siteGroundTemperatureDeep.AprilDeepGroundTemperature = System.Convert.ToDouble(commaPoints[41]);
            siteGroundTemperatureDeep.MayDeepGroundTemperature = System.Convert.ToDouble(commaPoints[42]);
            siteGroundTemperatureDeep.JuneDeepGroundTemperature = System.Convert.ToDouble(commaPoints[43]);
            siteGroundTemperatureDeep.JulyDeepGroundTemperature = System.Convert.ToDouble(commaPoints[44]);
            siteGroundTemperatureDeep.AugustDeepGroundTemperature = System.Convert.ToDouble(commaPoints[45]);
            siteGroundTemperatureDeep.SeptemberDeepGroundTemperature = System.Convert.ToDouble(commaPoints[46]);
            siteGroundTemperatureDeep.OctoberDeepGroundTemperature = System.Convert.ToDouble(commaPoints[47]);
            siteGroundTemperatureDeep.NovemberDeepGroundTemperature = System.Convert.ToDouble(commaPoints[48]);
            siteGroundTemperatureDeep.DecemberDeepGroundTemperature = System.Convert.ToDouble(commaPoints[49]);
            {
                output.Item1 = siteGroundTemperatureBuildingSurface;
                output.Item2 = siteGroundTemperatureShallow;
                output.Item3 = siteGroundTemperatureDeep;
            };
            return output;
        }
    }
}
