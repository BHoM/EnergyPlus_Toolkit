using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class Timestep : BHoMObject
    {
        [Description("Number in hour: normal validity 4 to 60: 6 suggested")]
        public virtual int NumberOfTimestepsPerHour { get; set; } = 6;
    }
}
