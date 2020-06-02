using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class ScheduleWeekDaily : BHoMObject
    {
        [Description("No description available")]
        public virtual string ScheduleWeekDailyName { get; set; } = "";
        [Description("No description available")]
        public virtual string SundayScheduleDayName { get; set; } = "";
        [Description("No description available")]
        public virtual string MondayScheduleDayName { get; set; } = "";
        [Description("No description available")]
        public virtual string TuesdayScheduleDayName { get; set; } = "";
        [Description("No description available")]
        public virtual string WednesdayScheduleDayName { get; set; } = "";
        [Description("No description available")]
        public virtual string ThursdayScheduleDayName { get; set; } = "";
        [Description("No description available")]
        public virtual string FridayScheduleDayName { get; set; } = "";
        [Description("No description available")]
        public virtual string SaturdayScheduleDayName { get; set; } = "";
        [Description("No description available")]
        public virtual string HolidayScheduleDayName { get; set; } = "";
        [Description("No description available")]
        public virtual string SummerDesignDayScheduleDayName { get; set; } = "";
        [Description("No description available")]
        public virtual string WinterDesignDayScheduleDayName { get; set; } = "";
        [Description("No description available")]
        public virtual string CustomDay1ScheduleDayName { get; set; } = "";
        [Description("No description available")]
        public virtual string CustomDay2ScheduleDayName { get; set; } = "";
    }
}
