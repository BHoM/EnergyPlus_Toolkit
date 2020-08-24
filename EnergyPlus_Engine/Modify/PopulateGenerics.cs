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

using BH.oM.Diffing;
using BH.oM.EnergyPlus;
using BH.oM.Reflection.Attributes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace BH.Engine.EnergyPlus
{
    public static partial class Modify
    {
        [Description("Populate a list of IEnergyPlusClasses with the requisite parts necessary to run a passive simulation")]
        [Input("energyPlusClasses", "A list of EnergyPlus classes")]
        [Output("energyPlusClasses", "A list of EnergyPlus classes with missing generic classes included")]
        public static List<IEnergyPlusClass> PopulateGenerics(this List<IEnergyPlusClass> energyPlusClasses)
        {
            List<IEnergyPlusClass> uniques = RemoveDuplicates(energyPlusClasses);

            List<IEnergyPlusClass> output = new List<IEnergyPlusClass>();

            if (!uniques.Any(n => n.ClassName == "Version"))
                output.Add(new Version() { VersionIdentifier = "9.0.0" });

            if (!uniques.Any(n => n.ClassName == "ShadowCalculation"))
                output.Add(new ShadowCalculation() { CalculationMethod = ShadowCalculationMethod.TimestepFrequency, CalculationFrequency = 1, MaximumFiguresInShadowOverlapCalculations = 3000 });

            if (!uniques.Any(n => n.ClassName == "Building"))
                output.Add(new Building() { Name = "GenericBuilding", Terrain = Terrain.Country, SolarDistribution = SolarDistribution.FullInteriorAndExteriorWithReflections });

            if (!uniques.Any(n => n.ClassName == "SimulationControl"))
                output.Add(new SimulationControl() { RunSimulationForWeatherFileRunPeriods = true, RunSimulationForSizingPeriods = false });

            if (!uniques.Any(n => n.ClassName == "Output:VariableDictionary"))
                output.Add(new OutputVariableDictionary() { KeyField = OutputVariableDictionaryKeyField.regular });
            
            foreach (string i in new List<string>() { "Zone Mean Air Temperature", "Zone Mean Radiant Temperature", "Zone Air Relative Humidity", "Zone Windows Total Transmitted Solar Radiation Rate", "Zone Infiltration Air Change Rate" })
            {
                if (!uniques.Any(n => n.ClassName == "Output:Variable"))
                    output.Add(new OutputVariable() { ReportingFrequency = ReportingFrequency.Hourly, KeyValue = i });
            }

            output.AddRange(uniques);

            return output;
        }
    }
}
