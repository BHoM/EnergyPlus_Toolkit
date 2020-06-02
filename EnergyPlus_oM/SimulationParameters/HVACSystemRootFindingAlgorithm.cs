using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class HVACSystemRootFindingAlgorithm : BHoMObject
    {
        [Description("No description available")]
        public virtual HVACSystemRootFindingAlgorithmMethod Algorithm { get; set; } = HVACSystemRootFindingAlgorithmMethod.RegulaFalsi;
        [Description("This field is used when RegulaFalsiThenBisection or BisectionThenRegulaFalsi is")]
        public virtual int NumberOfIterationsBeforeAlgorithmSwitch { get; set; } = 5;
    }
}
