using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class ScheduleConstant : BHoMObject
    {
        [Description("No description available")]
        public virtual string ScheduleConstantName { get; set; } = "";
        [Description("No description available")]
        public virtual string ScheduleTypeLimitsName { get; set; } = "";
        [Description("No description available")]
        public virtual double HourlyValue { get; set; } = 0.0;
    }
}
