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

using BH.oM.Adapters.EnergyPlus;
using BH.oM.Reflection.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace BH.Engine.Adapters.EnergyPlus
{
    public static partial class Query
    {
        [Description("Read an EnergyPlus simulation results ESO file")]
        [Input("filepath", "The path to the ESO file")]
        [Output("esoFile", "The ESO file object containing simulation results")]
        public static ESOFile ReadESO(string filepath)
        {
            ESOFile esoFile = new ESOFile();
            esoFile.FilePath = filepath;

            // Load ESO file into list for parsing
            List<string> lines = File.ReadAllLines(filepath, Encoding.UTF8).ToList();

            // Parse header for metadata
            string version = lines[0].Split(',')[2].Trim().Replace("Version ", "");
            esoFile.EnergyPlusVersion = version;
            string creationDate = lines[0].Split(',')[3].Trim().Replace("YMD=", "");
            esoFile.CreationDate = DateTime.Parse(creationDate);

            // Obtain results data dictionary
            int ddStartIndex = 7;
            int ddEndIndex = 1;
            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i] == "End of Data Dictionary")
                {
                    ddEndIndex = i;
                }
            }
            List<string> dataDictionary = lines.GetRange(ddStartIndex, ddEndIndex - ddStartIndex);

            // Obtain results keys
            List<int> resultsIndices = new List<int>();
            List<string> resultsKeys = new List<string>();
            List<string> resultsAtrributes = new List<string>();
            foreach (string i in dataDictionary)
            {
                string[] kvPair = i.Split(',');
                resultsIndices.Add(Int32.Parse(kvPair[0].Trim()));
                resultsKeys.Add(kvPair[2].Trim());
                resultsAtrributes.Add(kvPair[3]);
            }

            // Obtain results value lists
            List<string> valueDictionary = lines.GetRange(ddEndIndex + 1, lines.Count() - 3 - ddEndIndex);
            Dictionary<int, List<double>> resultsValues = new Dictionary<int, List<double>>();
            foreach (int idx in resultsIndices)
            {
                resultsValues.Add(idx, new List<double>());
            }

            foreach (string i in valueDictionary)
            {
                string[] kvPair = i.Split(',');
                int key = Int32.Parse(kvPair[0]);

                if (!resultsIndices.Contains(key))
                {
                    continue;
                }

                double value = Double.Parse(kvPair[1]);
                resultsValues[key].Add(value);
                
            }

            esoFile.ResultsAttribute = resultsAtrributes;
            esoFile.ResultsObjects = resultsKeys;
            esoFile.ResultsValues = resultsValues.Values.ToList();

            return esoFile;
        }
    }
}
