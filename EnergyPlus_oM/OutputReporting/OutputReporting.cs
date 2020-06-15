using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class OutputReporting: BHoMObject
    {
        [Description("")]
        public virtual OutputDiagnostics OutputDiagnostics { get; set; } = new OutputDiagnostics();
        [Description("")]
        public virtual OutputVariableDictionary OutputVariableDictionary { get; set; } = new OutputVariableDictionary();
        [Description("")]
        public virtual OutputConstructions OutputConstructions { get; set; } = new OutputConstructions();
        [Description("")]
        public virtual List<OutputVariable> OutputVariables { get; set; } = new List<OutputVariable>();
        
    }
}
