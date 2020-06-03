using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class ZoneList : BHoMObject
    {
        [Description("No description available")]
        public virtual string ZoneListName { get; set; } = "";
        [Description("No description available")]
        public virtual List<string> ZoneNames { get; set; } = new List<string>();
    }
}
