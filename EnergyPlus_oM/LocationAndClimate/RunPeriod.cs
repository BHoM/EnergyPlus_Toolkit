using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class RunPeriod : BHoMObject
    {
        [Description("descriptive name (used in reporting mainly)")]
        public virtual string RunPeriodName { get; set; } = null;
        [Description("No description available")]
        public virtual int BeginMonth { get; set; } = 1;
        [Description("No description available")]
        public virtual int BeginDayOfMonth { get; set; } = 1;
        [Description("Start year of the simulation, if this field is specified it must agree with the Day of Week for Start Day")]
        public virtual int BeginYear { get; set; } = 2018;
        [Description("No description available")]
        public virtual int EndMonth { get; set; } = 12;
        [Description("No description available")]
        public virtual int EndDayOfMonth { get; set; } = 31;
        [Description("end year of simulation, if specified")]
        public virtual int EndYear { get; set; } = 2018;
        [Description("=[Sunday|Monday|Tuesday|Wednesday|Thursday|Friday|Saturday];")]
        public virtual DayOfWeek DayOfWeekForStartDay { get; set; } = DayOfWeek.Monday;
        [Description("If yes or blank, use holidays as specified on Weatherfile.")]
        public virtual bool UseWeatherFileHolidaysAndSpecialDays { get; set; } = true;
        [Description("If yes or blank, use daylight saving period as specified on Weatherfile.")]
        public virtual bool UseWeatherFileDaylightSavingPeriod { get; set; } = true;
        [Description("if yes and single day holiday falls on weekend, \"holiday\" occurs on following Monday")]
        public virtual bool ApplyWeekendHolidayRule { get; set; } = false;
        [Description("No description available")]
        public virtual bool UseWeatherFileRainIndicators { get; set; } = true;
        [Description("No description available")]
        public virtual bool UseWeatherFileSnowIndicators { get; set; } = true;
        [Description("No description available")]
        public virtual bool TreatWeatherAsActual { get; set; } = false;
    }
}
