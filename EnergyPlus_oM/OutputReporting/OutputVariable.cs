using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class OutputVariable : BHoMObject
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "Output:Variable";
        [Order]
        [Description("use '*' (without quotes) to apply this variable to all keys")]
        public virtual string KeyValue { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string VariableName { get; set; } = "";
        [Order]
        [Description("Detailed lists every instance (i.e. HVAC variable timesteps)")]
        public virtual ReportingFrequency ReportingFrequency { get; set; } = ReportingFrequency.Undefined;
        [Order]
        [Description("No description available")]
        public virtual string ScheduleName { get; set; } = "";
    }
}
