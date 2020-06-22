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

using BH.oM.EnergyPlus;
using BH.oM.Reflection.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace BH.Engine.EnergyPlus
{
    public static partial class Convert
    {
        [Description("Convert a BHoM Profile to an EnergyPlus Schedule")]
        [Input("profile", "BHoM Profile")]
        [Input("scheduleTypeLimitsNumericType", "EnergyPlus ScheduleTypeLimitsNumericType")]
        [Input("scheduleTypeLimitsUnitType", "EnergyPlus ScheduleTypeLimitsUnitType")]
        [Output("schedule", "EnergyPlus Schedule")]
        public static List<IEnergyPlusClass> ToEnergyPlus(this BH.oM.Environment.Gains.Profile profile, ScheduleTypeLimitsNumericType scheduleTypeLimitsNumericType, ScheduleTypeLimitsUnitType scheduleTypeLimitsUnitType)
        {
            ScheduleTypeLimits scheduleTypeLimits = new ScheduleTypeLimits();
            scheduleTypeLimits.Name = String.Format("{0} TypeLimits", profile.Name).Trim();
            scheduleTypeLimits.NumericType = scheduleTypeLimitsNumericType;
            scheduleTypeLimits.UnitType = scheduleTypeLimitsUnitType;
            scheduleTypeLimits.NumericType = scheduleTypeLimitsNumericType;
            scheduleTypeLimits.LowerLimitValue = profile.HourlyValues.Min();
            scheduleTypeLimits.UpperLimitValue = profile.HourlyValues.Max();

            ScheduleDayHourly scheduleDayHourly = new ScheduleDayHourly();
            scheduleDayHourly.Name = String.Format("{0} Daily", profile.Name).Trim();
            scheduleDayHourly.ScheduleTypeLimitsName = scheduleTypeLimits.Name;
            for (int i = 0; i < 24; i++)
            {
                PropertyInfo propertyInfo = scheduleDayHourly.GetType().GetProperty(String.Format("Hour{0}", i + 1));
                propertyInfo.SetValue(scheduleDayHourly, profile.HourlyValues[i]);
            }

            ScheduleWeekDaily scheduleWeekDaily = new ScheduleWeekDaily();
            scheduleWeekDaily.Name = String.Format("{0} Weekly", profile.Name).Trim();
            scheduleWeekDaily.SundayScheduleDayName = scheduleDayHourly.Name;
            scheduleWeekDaily.MondayScheduleDayName = scheduleDayHourly.Name;
            scheduleWeekDaily.TuesdayScheduleDayName = scheduleDayHourly.Name;
            scheduleWeekDaily.WednesdayScheduleDayName = scheduleDayHourly.Name;
            scheduleWeekDaily.ThursdayScheduleDayName = scheduleDayHourly.Name;
            scheduleWeekDaily.FridayScheduleDayName = scheduleDayHourly.Name;
            scheduleWeekDaily.SaturdayScheduleDayName = scheduleDayHourly.Name;
            scheduleWeekDaily.HolidayScheduleDayName = scheduleDayHourly.Name;
            scheduleWeekDaily.SummerDesignDayScheduleDayName = scheduleDayHourly.Name;
            scheduleWeekDaily.WinterDesignDayScheduleDayName = scheduleDayHourly.Name;
            scheduleWeekDaily.CustomDay1ScheduleDayName = scheduleDayHourly.Name;
            scheduleWeekDaily.CustomDay2ScheduleDayName = scheduleDayHourly.Name;

            return new List<IEnergyPlusClass>() { scheduleTypeLimits, scheduleDayHourly, scheduleWeekDaily};
        }
    }
}
