/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2021, the respective contributors. All rights reserved.
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

using BH.oM.Reflection.Attributes;
using System;
using System.ComponentModel;

namespace BH.Engine.Adapters.EnergyPlus
{
    public static partial class Compute
    {
        [Description("Run a command line command from a string")]
        [Input("commandString", "The full command string to pass to command line")]
        [Output("success", "True if command has been run sucessfully (subject to program being called correctly returning an Exit Code)")]
        public static bool RunCommand(string commandString = null)
        {

            bool success = false;

            if (commandString == null)
            {
                Reflection.Compute.RecordError("No command given.");
                return false;
            }

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal; // Hidden
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = String.Format("/C {0}", commandString);
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();

            if (process.ExitCode == 0)
            {
                success = true;
            }
            else
            {
                success = false;
            }

            return success;
        }
    }
}

