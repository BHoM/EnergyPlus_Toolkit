using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class SimulationControl : BHoMObject
    {
        [Description("If True, Zone sizing is accomplished from corresponding Sizing:Zone objects")]
        public virtual bool DoZoneSizingCalculation { get; set; } = false;
        [Description("If True, System sizing is accomplished from corresponding Sizing:System objects")]
        public virtual bool DoSystemSizingCalculation { get; set; } = false;
        [Description("If True, Plant sizing is accomplished from corresponding Sizing:Plant objects")]
        public virtual bool DoPlantSizingCalculation { get; set; } = false;
        [Description("If True, SizingPeriod:* objects are executed and results from those may be displayed..")]
        public virtual bool RunSimulationForSizingPeriods { get; set; } = true;
        [Description("If True, RunPeriod:* objects are executed and results from those may be displayed..")]
        public virtual bool RunSimulationForWeatherFileRunPeriods { get; set; } = true;
        [Description("If True, SizingPeriod:* objects are exectuted additional times for advanced sizing.")]
        public virtual bool DoHVACSizingSimulationForSizingPeriods { get; set; } = false;
        [Description("the entire set of SizingPeriod:* objects may be repeated to fine tune size results")]
        public virtual int MaximumNumberOfHVACSizingSimulationPasses { get; set; } = 1;
    }
}
