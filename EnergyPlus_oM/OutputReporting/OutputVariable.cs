using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class OutputVariable : BHoMObject
    {
        [Description("use '*' (without quotes) to apply this variable to all keys")]
        public virtual string KeyValue { get; set; } = "";
        [Description("No description available")]
        public virtual string VariableName { get; set; } = "";
        [Description("Detailed lists every instance (i.e. HVAC variable timesteps)")]
        public virtual ReportingFrequency ReportingFrequency { get; set; } = ReportingFrequency.Undefined;
        [Description("No description available")]
        public virtual string ScheduleName { get; set; } = "";
    }
}
