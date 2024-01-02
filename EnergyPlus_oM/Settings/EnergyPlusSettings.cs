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

using System;
using System.Collections.Generic;
using BH.oM.Base;

using System.ComponentModel;

namespace BH.oM.Adapters.EnergyPlus.Settings
{
    public class EnergyPlusSettings : BHoMObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [Description("Name of EnergyPlus case")]
        public virtual string ProjectName { get; set; } = "BHoM_EnergyPlus_Project";
        [Description("Path to the directory where the EnergyPlus simulation results will be stored")]
        public virtual string ProjectDirectory { get; set; } = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop);
        [Description("Path to the weatherfile to be used in any climate-based daylight simulations")]
        public virtual string WeatherFile { get; set; } = "";
        [Description("How many decimal places any rounding function should use. Default to 6. E.g. a number such as 1.12345678 will be rounded to 1.123457 (rounded to 6 decimal places)")]
        public virtual int DecimalPlaces { get; set; } = 6;
        [Description("Full path to EnergyPlus executable")]
        public virtual string EnergyPlusExecutable { get; set; } = "";

        /***************************************************/
    }
}




