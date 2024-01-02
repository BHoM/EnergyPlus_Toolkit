/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2024, the respective contributors. All rights reserved.
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
using BH.Engine.Reflection;
using BH.oM.Adapters.EnergyPlus;
using BH.oM.Base;
using BH.oM.Base.Attributes;

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
                BH.Engine.Base.Compute.RecordError("File not found. Did you give the correct path?");
                return null;
            }

            string[] EpwFile = System.IO.File.ReadAllLines(epwFile);

            // Check to see if the file passed contains the requisite number of lines to parse as an EPW (> 8760)
            if (EpwFile.Count() < 8760)
            {
                BH.Engine.Base.Compute.RecordError("The file passed has less than 8760 lines. Are you sure it's an EPW?");
                return null;
            }

            string groundTemperatures = EpwFile[3];
            List<string> commaPoints = groundTemperatures.Split(',').ToList();

            // Check if there are ground temperatures in the file, and that numberOfSets is an integer
            try
            {
                System.Convert.ToInt32(commaPoints[1]); 
            }
            catch (System.Exception)
            {
                BH.Engine.Base.Compute.RecordError("There appears to be no sets of temperatures in this file, or the number of sets if not an integer");
            }

            int numberOfSets = System.Convert.ToInt32(commaPoints[1]);


            SiteGroundTemperatureBuildingSurface siteGroundTemperatureBuildingSurface = new SiteGroundTemperatureBuildingSurface();
            SiteGroundTemperatureShallow siteGroundTemperatureShallow = new SiteGroundTemperatureShallow();
            SiteGroundTemperatureDeep siteGroundTemperatureDeep = new SiteGroundTemperatureDeep();
            Output<SiteGroundTemperatureBuildingSurface, SiteGroundTemperatureShallow, SiteGroundTemperatureDeep> output = new Output<SiteGroundTemperatureBuildingSurface, SiteGroundTemperatureShallow, SiteGroundTemperatureDeep>
            {
                Item1 = siteGroundTemperatureBuildingSurface,
                Item2 = siteGroundTemperatureShallow,
                Item3 = siteGroundTemperatureDeep,
            };

            // Check that there are temperature sets in the file
            if (numberOfSets < 1)

            {
                BH.Engine.Base.Compute.RecordError("The file has less than 12 temperatures. Does the file contain ground temperatures?");
                return null;
            }

            for (int i = 0; i < numberOfSets; i++)
            {
                double depth = System.Convert.ToDouble(commaPoints[2 + i*16]);
                List<string> elements = commaPoints.GetRange(6 + i*16, 12);
                List<double> elementsDouble = new List<double>();

                foreach (string I in elements)
                {
                    elementsDouble.Add(System.Convert.ToDouble(I));
                }

                List<double> groundTemps = elementsDouble;

                if (depth == 0)
                {
                    return null;
                }

                else if (depth <= 1 )
                {

                    siteGroundTemperatureBuildingSurface.JanuaryGroundTemperature = groundTemps[0];
                    siteGroundTemperatureBuildingSurface.FebruaryGroundTemperature = groundTemps[1];
                    siteGroundTemperatureBuildingSurface.MarchGroundTemperature = groundTemps[2];
                    siteGroundTemperatureBuildingSurface.AprilGroundTemperature = groundTemps[3];
                    siteGroundTemperatureBuildingSurface.MayGroundTemperature = groundTemps[4];
                    siteGroundTemperatureBuildingSurface.JuneGroundTemperature = groundTemps[5];
                    siteGroundTemperatureBuildingSurface.JulyGroundTemperature = groundTemps[6];
                    siteGroundTemperatureBuildingSurface.AugustGroundTemperature = groundTemps[7];
                    siteGroundTemperatureBuildingSurface.SeptemberGroundTemperature = groundTemps[8];
                    siteGroundTemperatureBuildingSurface.OctoberGroundTemperature = groundTemps[9];
                    siteGroundTemperatureBuildingSurface.NovemberGroundTemperature = groundTemps[10];
                    siteGroundTemperatureBuildingSurface.DecemberGroundTemperature = groundTemps[11];
                }

                else if (depth <= 5)
                {
                    siteGroundTemperatureShallow.JanuarySurfaceGroundTemperature = groundTemps[0];
                    siteGroundTemperatureShallow.FebruarySurfaceGroundTemperature = groundTemps[1];
                    siteGroundTemperatureShallow.MarchSurfaceGroundTemperature = groundTemps[2];
                    siteGroundTemperatureShallow.AprilSurfaceGroundTemperature = groundTemps[3];
                    siteGroundTemperatureShallow.MaySurfaceGroundTemperature = groundTemps[4];
                    siteGroundTemperatureShallow.JuneSurfaceGroundTemperature = groundTemps[5];
                    siteGroundTemperatureShallow.JulySurfaceGroundTemperature = groundTemps[6];
                    siteGroundTemperatureShallow.AugustSurfaceGroundTemperature = groundTemps[7];
                    siteGroundTemperatureShallow.SeptemberSurfaceGroundTemperature = groundTemps[8];
                    siteGroundTemperatureShallow.OctoberSurfaceGroundTemperature = groundTemps[9];
                    siteGroundTemperatureShallow.NovemberSurfaceGroundTemperature = groundTemps[10];
                    siteGroundTemperatureShallow.DecemberSurfaceGroundTemperature = groundTemps[11];
                }

                else
                {
                    siteGroundTemperatureDeep.JanuaryDeepGroundTemperature = groundTemps[0];
                    siteGroundTemperatureDeep.FebruaryDeepGroundTemperature = groundTemps[1];
                    siteGroundTemperatureDeep.MarchDeepGroundTemperature = groundTemps[2];
                    siteGroundTemperatureDeep.AprilDeepGroundTemperature = groundTemps[3];
                    siteGroundTemperatureDeep.MayDeepGroundTemperature = groundTemps[4];
                    siteGroundTemperatureDeep.JuneDeepGroundTemperature = groundTemps[5];
                    siteGroundTemperatureDeep.JulyDeepGroundTemperature = groundTemps[6];
                    siteGroundTemperatureDeep.AugustDeepGroundTemperature = groundTemps[7];
                    siteGroundTemperatureDeep.SeptemberDeepGroundTemperature = groundTemps[8];
                    siteGroundTemperatureDeep.OctoberDeepGroundTemperature = groundTemps[9];
                    siteGroundTemperatureDeep.NovemberDeepGroundTemperature = groundTemps[10];
                    siteGroundTemperatureDeep.DecemberDeepGroundTemperature = groundTemps[11];
                }

                if (numberOfSets == 1)
                {
                    BH.Engine.Base.Compute.RecordWarning("The file has less than 24 temperatures. The temperature sets not included in the file will be set to default");
                }

                if (numberOfSets == 2)
                {
                    BH.Engine.Base.Compute.RecordWarning("The file has less than 36 temperatures. The temperature sets not included in the file will be set to default");
                    
                    if ((System.Convert.ToDouble(commaPoints[2]) <= 1 &&  System.Convert.ToDouble(commaPoints[18]) <= 1) || (System.Convert.ToDouble(commaPoints[2]) >= 5 && System.Convert.ToDouble(commaPoints[18]) >=5) || (System.Convert.ToDouble(commaPoints[2]) >= 1 && System.Convert.ToDouble(commaPoints[2]) <= 5 && System.Convert.ToDouble(commaPoints[18]) >= 1 && System.Convert.ToDouble(commaPoints[18]) <= 5))
                    {
                        BH.Engine.Base.Compute.RecordWarning("The file has more than one temperature set of the same type. The last one will be computed");
                    }
                }

                if (numberOfSets == 3)
                {
                     if (System.Convert.ToDouble(commaPoints[2]) >= 1 || System.Convert.ToDouble(commaPoints[18]) <= 1 || System.Convert.ToDouble(commaPoints[18]) >= 5 || System.Convert.ToDouble(commaPoints[34]) <= 5)
                     {
                         BH.Engine.Base.Compute.RecordWarning("The file has more than one temperature set of the same type. The last one will be computed");
                     }
                }
            }

            return output;
        }
    }
}




