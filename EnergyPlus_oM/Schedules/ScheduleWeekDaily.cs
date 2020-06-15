using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class ScheduleWeekDaily : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "Schedule:Week:Daily";
        [Order]
        [Description("No description available")]
        public override string Name { get; set; } = "DefaultWeeklySchedule";
        [Order]
        [Description("No description available")]
        public virtual string SundayScheduleDayName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string MondayScheduleDayName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string TuesdayScheduleDayName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string WednesdayScheduleDayName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string ThursdayScheduleDayName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string FridayScheduleDayName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string SaturdayScheduleDayName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string HolidayScheduleDayName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string SummerDesignDayScheduleDayName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string WinterDesignDayScheduleDayName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string CustomDay1ScheduleDayName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string CustomDay2ScheduleDayName { get; set; } = "";
    }
}
