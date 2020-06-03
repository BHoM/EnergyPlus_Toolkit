using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class OutputDiagnostics : BHoMObject
    {
        [Description("No description available")]
        public virtual OutputDiagnosticsKey Key1 { get; set; } = OutputDiagnosticsKey.Undefined;
        [Description("No description available")]
        public virtual OutputDiagnosticsKey Key2 { get; set; } = OutputDiagnosticsKey.Undefined;
    }
}
