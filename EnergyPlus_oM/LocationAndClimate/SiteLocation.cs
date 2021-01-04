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

using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.Adapters.EnergyPlus
{    public class SiteLocation : BHoMObject, IEnergyPlusClass
     {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "Site:Location";
        [Order]
        [Description("Location name")]
        public override string Name { get; set; } = "DefaultLocation";
        [Order]
        [Description("+ is North, - is South, degree minutes represented in decimal (i.e. 30 minutes is .5)")]
        public virtual double Latitude { get; set; } = 0.0;
        [Order]
        [Description("- is West, + is East, degree minutes represented in decimal (i.e. 30 minutes is .5)")]
        public virtual double Longitude { get; set; } = 0.0;
        [Order]
        [Description("UTC offset from GMT")]
        public virtual double TimeZone { get; set; } = 0.0;
        [Order]
        [Description("Elevation in m above sea level")]
        public virtual double Elevation { get; set; } = 0.0;
    }
}
// Import the file, get the data from it
//         
// Assign the different properties to the parts of the text
