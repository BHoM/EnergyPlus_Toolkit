using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class ScheduleFileShading : BHoMObject
    {
        [Description("The name of the file that writes all shading data.")]
        public virtual string FileName { get; set; } = "";
    }
}
