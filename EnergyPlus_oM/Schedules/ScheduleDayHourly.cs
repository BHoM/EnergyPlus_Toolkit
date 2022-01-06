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

using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.Adapters.EnergyPlus
{
    public class ScheduleDayHourly : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "Schedule:Day:Hourly";
        [Order]
        [Description("No description available")]
        public override string Name { get; set; } = "DefautDailySchedule";
        [Order]
        [Description("No description available")]
        public virtual string ScheduleTypeLimitsName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual double Hour1 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour2 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour3 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour4 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour5 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour6 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour7 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour8 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour9 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour10 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour11 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour12 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour13 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour14 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour15 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour16 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour17 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour18 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour19 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour20 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour21 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour22 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour23 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour24 { get; set; } = 0.0;
    }
}


