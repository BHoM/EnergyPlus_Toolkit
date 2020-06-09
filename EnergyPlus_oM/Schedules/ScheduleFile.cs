using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class ScheduleFile : BHoMObject
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "Schedule:File";
        [Order]
        [Description("No description available")]
        public override string Name { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual ScheduleTypeLimits ScheduleTypeLimitsName { get; set; } = new ScheduleTypeLimits();
        [Order]
        [Description("No description available")]
        public virtual string FileName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual int ColumnNumber { get; set; } = 0;
        [Order]
        [Description("No description available")]
        public virtual int RowsToSkipAtTop { get; set; } = 0;
        [Order]
        [Description("8760 hours does not account for leap years, 8784 does.")]
        public virtual int NumberOfHoursOfData { get; set; } = 8760;
        [Order]
        [Description("No description available")]
        public virtual ColumnSeparator ColumnSeparator { get; set; } = ColumnSeparator.Comma;
        [Order]
        [Description("when the interval does not match the user specified timestep a \"Yes\" choice will average between the intervals request (to")]
        public virtual bool InterpolateToTimestep { get; set; } = false;
        [Order]
        [Description("Must be evenly divisible into 60")]
        public virtual int MinutesPerItem { get; set; } = 60;
    }
}
