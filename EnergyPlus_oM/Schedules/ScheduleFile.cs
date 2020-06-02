using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class ScheduleFile : BHoMObject
    {
        [Description("No description available")]
        public virtual string ScheduleFileName { get; set; } = "";
        [Description("No description available")]
        public virtual string ScheduleTypeLimitsName { get; set; } = "";
        [Description("No description available")]
        public virtual string FileName { get; set; } = "";
        [Description("No description available")]
        public virtual int ColumnNumber { get; set; } = 0;
        [Description("No description available")]
        public virtual int RowsToSkipAtTop { get; set; } = 0;
        [Description("8760 hours does not account for leap years, 8784 does.")]
        public virtual int NumberOfHoursOfData { get; set; } = 8760;
        [Description("No description available")]
        public virtual ColumnSeparator ColumnSeparator { get; set; } = ColumnSeparator.Comma;
        [Description("when the interval does not match the user specified timestep a \"Yes\" choice will average between the intervals request (to")]
        public virtual bool InterpolateToTimestep { get; set; } = false;
        [Description("Must be evenly divisible into 60")]
        public virtual int MinutesPerItem { get; set; } = 60;
    }
}
