using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BHE = BH.oM.Environment.Elements;
using BH.oM.EnergyPlus;
using System.ComponentModel;
using BH.oM.Environment.Fragments;
using System.Reflection;

namespace BH.Engine.EnergyPlus
{
    public static partial class Convert
    {
        public static Schedule ToEnergyPlus(this BH.oM.Environment.Gains.Profile profile, ScheduleTypeLimitsNumericType scheduleTypeLimitsNumericType, ScheduleTypeLimitsUnitType scheduleTypeLimitsUnitType)
        {
            Schedule schedule = new Schedule();

            ScheduleTypeLimits scheduleTypeLimits = new ScheduleTypeLimits();
            scheduleTypeLimits.Name = String.Format("{0} TypeLimits", profile.Name);
            scheduleTypeLimits.NumericType = scheduleTypeLimitsNumericType;
            scheduleTypeLimits.UnitType = scheduleTypeLimitsUnitType;
            scheduleTypeLimits.NumericType = scheduleTypeLimitsNumericType;
            scheduleTypeLimits.LowerLimitValue = profile.HourlyValues.Min();
            scheduleTypeLimits.UpperLimitValue = profile.HourlyValues.Max();

            ScheduleDayHourly scheduleDayHourly = new ScheduleDayHourly();
            scheduleDayHourly.Name = String.Format("{0} Daily", profile.Name);
            scheduleDayHourly.ScheduleTypeLimitsName = scheduleTypeLimits.Name;
            for (int i = 0; i < 24; i++)
            {
                PropertyInfo propertyInfo = scheduleDayHourly.GetType().GetProperty(String.Format("Hour{0}", i + 1));
                propertyInfo.SetValue(scheduleDayHourly, profile.HourlyValues[i]);
            }

            ScheduleWeekDaily scheduleWeekDaily = new ScheduleWeekDaily();
            scheduleWeekDaily.Name = String.Format("{0} Weekly", profile.Name);
            scheduleWeekDaily.SundayScheduleDayName = scheduleDayHourly.Name;
            scheduleWeekDaily.MondayScheduleDayName = scheduleDayHourly.Name;
            scheduleWeekDaily.TuesdayScheduleDayName = scheduleDayHourly.Name;
            scheduleWeekDaily.WednesdayScheduleDayName = scheduleDayHourly.Name;
            scheduleWeekDaily.ThursdayScheduleDayName = scheduleDayHourly.Name;
            scheduleWeekDaily.FridayScheduleDayName = scheduleDayHourly.Name;
            scheduleWeekDaily.SaturdayScheduleDayName = scheduleDayHourly.Name;

            schedule.ScheduleTypeLimits = scheduleTypeLimits;
            schedule.ScheduleDayHourly = scheduleDayHourly;
            schedule.ScheduleWeekDaily = scheduleWeekDaily;

            return schedule;
        }
    }
}
