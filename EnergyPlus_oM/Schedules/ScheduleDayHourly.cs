using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class ScheduleDayHourly : BHoMObject
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "Schedule:Day:Hourly";
        [Order]
        [Description("No description available")]
        public override string Name { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual ScheduleTypeLimits ScheduleTypeLimitsName { get; set; } = new ScheduleTypeLimits();
        [Order]
        [Description("No description available")]
        public virtual double Hour1 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour2 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour3 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour4 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour5 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour6 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour7 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour8 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour9 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour10 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour11 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour12 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour13 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour14 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour15 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour16 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour17 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour18 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour19 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour20 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour21 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour22 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour23 { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Hour24 { get; set; } = 0.0;
    }
}
