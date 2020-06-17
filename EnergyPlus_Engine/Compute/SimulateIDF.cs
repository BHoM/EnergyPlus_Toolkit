using BH.oM.Reflection.Attributes;
using System;
using System.ComponentModel;
using BH.oM.EnergyPlus.Settings;

namespace BH.Engine.Radiance
{
    public static partial class Compute
    {
        [Description("Run an IDF file")]
        [Input("energyPlusSettings", "EnergyPlusSettings object")]
        [Input("idfFile", "EnergyPlus IDF file to simulate")]
        [Output("success", "True if command has been run sucessfully (subject to program being called correctly returning an Exit Code)")]
        public static bool SimulateIDF(EnergyPlusSettings energyPlusSettings, string idfFile)
        {
            string formatString = "{0} -a -r -x -d {1} -p {2} -w {3} {4}";
            string commandString = String.Format(formatString, energyPlusSettings.EnergyPlusExecutable, energyPlusSettings.ProjectDirectory, energyPlusSettings.ProjectName, energyPlusSettings.WeatherFile, idfFile);

            if (RunCommand(commandString))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}