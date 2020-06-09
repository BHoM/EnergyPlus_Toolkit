using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class OutputDiagnostics : BHoMObject
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "Output:Diagnostics";
        [Order]
        [Description("No description available")]
        public virtual OutputDiagnosticsKey Key1 { get; set; } = OutputDiagnosticsKey.Undefined;
        [Order]
        [Description("No description available")]
        public virtual OutputDiagnosticsKey Key2 { get; set; } = OutputDiagnosticsKey.Undefined;
    }
}
