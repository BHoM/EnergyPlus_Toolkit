using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class SimulationControl : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "SimulationControl";
        [Order][Description("If True, Zone sizing is accomplished from corresponding Sizing:Zone objects")]
        public virtual bool DoZoneSizingCalculation { get; set; } = false;
        [Order][Description("If True, System sizing is accomplished from corresponding Sizing:System objects")]
        public virtual bool DoSystemSizingCalculation { get; set; } = false;
        [Order][Description("If True, Plant sizing is accomplished from corresponding Sizing:Plant objects")]
        public virtual bool DoPlantSizingCalculation { get; set; } = false;
        [Order][Description("If True, SizingPeriod:* objects are executed and results from those may be displayed..")]
        public virtual bool RunSimulationForSizingPeriods { get; set; } = true;
        [Order][Description("If True, RunPeriod:* objects are executed and results from those may be displayed..")]
        public virtual bool RunSimulationForWeatherFileRunPeriods { get; set; } = true;
        [Order][Description("If True, SizingPeriod:* objects are exectuted additional times for advanced sizing.")]
        public virtual bool DoHVACSizingSimulationForSizingPeriods { get; set; } = false;
        [Order][Description("the entire set of SizingPeriod:* objects may be repeated to fine tune size results")]
        public virtual int MaximumNumberOfHVACSizingSimulationPasses { get; set; } = 1;
    }
}
