/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2022, the respective contributors. All rights reserved.
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

using BH.oM.Adapters.EnergyPlus.Settings;
using BH.oM.Reflection.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace BH.Engine.Adapters.EnergyPlus
{
    public static partial class Compute
    {
        [Description("Run an IDF file")]
        [Input("energyPlusSettings", "EnergyPlusSettings object")]
        [Input("idfFile", "EnergyPlus IDF file to simulate")]
        [Input("run", "Set to \"True\" to run simulation")]
        [Output("success", "True if command has been run sucessfully (subject to program being called correctly returning an Exit Code)")]
        public static bool SimulateIDF(EnergyPlusSettings energyPlusSettings, string idfFile, bool run = false)
        {
            // Clear existing files to prevent re-use of these in simulation
            List<string> toDelete = new List<string>() { "audit", "bnd", "csv", "dbg", "eio", "end", "err", "eso", "mtd", "mtr", "rdd", "shd" };
            foreach (string ext in toDelete)
            {
                foreach (string f in Directory.EnumerateFiles(energyPlusSettings.ProjectDirectory, String.Format("{0}.{1}", energyPlusSettings.ProjectName, ext)))
                {
                    File.Delete(f);
                }
            }

            // Construct full run-command
            string formatString = "{0} -r -x -d {1} -p {2} -w {3} {4}";
            string commandString = String.Format(formatString, energyPlusSettings.EnergyPlusExecutable, energyPlusSettings.ProjectDirectory, energyPlusSettings.ProjectName, energyPlusSettings.WeatherFile, idfFile);

            bool success;
            if (run)
            {
                success = RunCommand(commandString);
                if (success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}

