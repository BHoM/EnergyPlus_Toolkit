using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class ZoneList : BHoMObject
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "ZoneList";
        [Order]
        [Description("No description available")]
        public override string Name { get; set; } = "ExampleZoneList";
        [Order]
        [Description("No description available")]
        public virtual List<string> ZoneNames { get; set; } = new List<string>();
    }
}
