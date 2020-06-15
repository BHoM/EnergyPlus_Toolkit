using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class ScheduleTypeLimits : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "ScheduleTypeLimits";
        [Order]
        [Description("used to validate schedule types in various schedule objects")]
        public override string Name { get; set; } = "DefaultScheduleTypeLimits";
        [Order]
        [Description("lower limit (real or integer) for the Schedule Type. e.g. if fraction, this is 0.0")]
        public virtual double LowerLimitValue { get; set; } = 0.0;
        [Order]
        [Description("upper limit (real or integer) for the Schedule Type. e.g. if fraction, this is 1.0")]
        public virtual double UpperLimitValue { get; set; } = 1.0;
        [Order]
        [Description("Numeric type is either Continuous (all numbers within the min and")]
        public virtual ScheduleTypeLimitsNumericType NumericType { get; set; } = ScheduleTypeLimitsNumericType.Continuous;
        [Order]
        [Description("Temperature (C or F)")]
        public virtual ScheduleTypeLimitsUnitType UnitType { get; set; } = ScheduleTypeLimitsUnitType.Dimensionless;
    }
}
