using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class PerformancePrecisionTradeoffs : BHoMObject
    {
        [Description("If True, an analytical or empirical solution will be used to replace iterations in")]
        public virtual bool UseCoilDirectSolutions { get; set; } = false;
    }
}
