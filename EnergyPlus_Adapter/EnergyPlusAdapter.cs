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

using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

using BH.oM.Adapter;
using BH.oM.Adapters.EnergyPlus.Settings;
using BH.oM.Reflection.Attributes;


namespace BH.Adapter.EnergyPlus
{
    public partial class EnergyPlusAdapter : BHoMAdapter
    {
        [Description("Produces an EnergyPlus Adapter to allow interopability with IDF files and the BHoM")]
        [Input("fileSettings", "Input file settings to get the path to an IDF File")]
        [Input("settings", "Settings that define how the EnergyPlus IDF file should be generated")]
        [Output("adapter", "Adapter to an IDF File")]
        public EnergyPlusAdapter(BH.oM.Adapter.FileSettings fileSettings, EnergyPlusSettings settings = null)
        {
            m_AdapterSettings.DefaultPushType = oM.Adapter.PushType.CreateOnly;

            FileSettings = fileSettings;
            _settings = settings ?? new EnergyPlusSettings();

            if(!Path.HasExtension(fileSettings.FileName) || Path.GetExtension(fileSettings.FileName) != ".idf")
            {
                BH.Engine.Reflection.Compute.RecordError("File Name must contain a file extension");
                return;
            }
        }

        private FileSettings FileSettings { get; set; }
        private EnergyPlusSettings _settings;
        private List<string> FileOutput { get; set; }
    }
}


