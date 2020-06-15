using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class Schedule : BHoMObject
    {
        // THIS OBJECT NEEDS RETHINKING AS INHERITING FROM A BHOM SCHEDULE??????
        [Description("")]
        public virtual ScheduleTypeLimits ScheduleTypeLimits { get; set; } = new ScheduleTypeLimits();
        [Description("")]
        public virtual ScheduleDayHourly ScheduleDayHourly { get; set; } = new ScheduleDayHourly();
        [Description("")]
        public virtual ScheduleWeekDaily ScheduleWeekDaily { get; set; } = new ScheduleWeekDaily();
    }
}
