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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BH.oM.EnergyPlus.Settings;
using BHE = BH.oM.Environment.Elements;
using BHP = BH.oM.Environment.Fragments;

using BH.Engine.Environment;
using BH.Engine.Geometry;

using BHG = BH.oM.Geometry;
using BH.oM.EnergyPlus;
using System.ComponentModel;
using BH.oM.Reflection.Attributes;
using BH.oM.Reflection;
using BH.Engine.Diffing;
using BH.oM.Diffing;

namespace BH.Engine.EnergyPlus
{
    public static partial class Convert
    {
        [Description("Convert a boolean to an EnergyPlus freindly Yes or No")]
        [Input("bool", "A True or False value")]
        [Output("answer", "A Yes or a No")]
        public static string ToYesNoString(this bool value)
        {
            return value ? "Yes" : "No";
        }
    }
}
