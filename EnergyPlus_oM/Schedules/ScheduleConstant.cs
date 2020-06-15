using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class ScheduleConstant : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "Schedule:Constant";
        [Order]
        [Description("No description available")]
        public override string Name { get; set; } = "Default constant schedule";
        [Order]
        [Description("No description available")]
        public virtual string ScheduleTypeLimitsName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual double HourlyValue { get; set; } = 0.0;
    }
}
