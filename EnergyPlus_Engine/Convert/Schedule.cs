using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using BH.Engine.Reflection;
using BH.oM.Reflection;
using BH.oM.EnergyPlus;

namespace BH.Engine.EnergyPlus
{
    public static partial class Convert
    {
        public static string ToEnergyPlusString(this Schedule schedule)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(schedule.ScheduleTypeLimits.ToEnergyPlusString());
            sb.Append(schedule.ScheduleDayHourly.ToEnergyPlusString());
            sb.Append(schedule.ScheduleWeekDaily.ToEnergyPlusString());
            
            return sb.ToString();
        }
    }
}
