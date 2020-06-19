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

using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class RunPeriod : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "RunPeriod";
        [Order]
        [Description("descriptive name (used in reporting mainly)")]
        public override string Name { get; set; } = "DefaultRunPeriod";
        [Order]
        [Description("No description available")]
        public virtual int BeginMonth { get; set; } = 1;
        [Order]
        [Description("No description available")]
        public virtual int BeginDayOfMonth { get; set; } = 1;
        [Order]
        [Description("Start year of the simulation, if this field is specified it must agree with the Day of Week for Start Day")]
        public virtual int BeginYear { get; set; } = 2018;
        [Order]
        [Description("No description available")]
        public virtual int EndMonth { get; set; } = 12;
        [Order]
        [Description("No description available")]
        public virtual int EndDayOfMonth { get; set; } = 31;
        [Order]
        [Description("end year of simulation, if specified")]
        public virtual int EndYear { get; set; } = 2018;
        [Order]
        [Description("=[Sunday|Monday|Tuesday|Wednesday|Thursday|Friday|Saturday];")]
        public virtual DayOfWeek DayOfWeekForStartDay { get; set; } = DayOfWeek.Monday;
        [Order]
        [Description("If yes or blank, use holidays as specified on Weatherfile.")]
        public virtual bool UseWeatherFileHolidaysAndSpecialDays { get; set; } = true;
        [Order]
        [Description("If yes or blank, use daylight saving period as specified on Weatherfile.")]
        public virtual bool UseWeatherFileDaylightSavingPeriod { get; set; } = true;
        [Order]
        [Description("if yes and single day holiday falls on weekend, \"holiday\" occurs on following Monday")]
        public virtual bool ApplyWeekendHolidayRule { get; set; } = false;
        [Order]
        [Description("No description available")]
        public virtual bool UseWeatherFileRainIndicators { get; set; } = true;
        [Order]
        [Description("No description available")]
        public virtual bool UseWeatherFileSnowIndicators { get; set; } = true;
        [Order]
        [Description("No description available")]
        public virtual bool TreatWeatherAsActual { get; set; } = false;
    }
}
