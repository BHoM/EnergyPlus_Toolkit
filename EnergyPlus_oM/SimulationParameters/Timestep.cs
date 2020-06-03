using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class Timestep : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "Timestep";
        [Description("Number in hour: normal validity 4 to 60: 6 suggested")]
        public virtual int NumberOfTimestepsPerHour { get; set; } = 6;
    }
}
