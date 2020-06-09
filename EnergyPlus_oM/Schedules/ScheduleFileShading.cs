using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class ScheduleFileShading : BHoMObject
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "Schedule:File:Shading";
        [Order]
        [Description("The name of the file that writes all shading data.")]
        public virtual string FileName { get; set; } = "";
    }
}
