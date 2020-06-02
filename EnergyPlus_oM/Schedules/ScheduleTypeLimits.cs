using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class ScheduleTypeLimits : BHoMObject
    {
        [Description("used to validate schedule types in various schedule objects")]
        public virtual string ScheduleTypeLimitName { get; set; } = "";
        [Description("lower limit (real or integer) for the Schedule Type. e.g. if fraction, this is 0.0")]
        public virtual double LowerLimitValue { get; set; } = 0.0;
        [Description("upper limit (real or integer) for the Schedule Type. e.g. if fraction, this is 1.0")]
        public virtual double UpperLimitValue { get; set; } = 1.0;
        [Description("Numeric type is either Continuous (all numbers within the min and")]
        public virtual ScheduleTypeLimitsNumericType NumericType { get; set; } = ScheduleTypeLimitsNumericType.Continuous;
        [Description("Temperature (C or F)")]
        public virtual ScheduleTypeLimitsUnitType UnitType { get; set; } = ScheduleTypeLimitsUnitType.Dimensionless;
    }
}
