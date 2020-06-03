using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class Construction : BHoMObject
    {
        [Description("No description available")]
        public virtual string ConstructionName { get; set; } = "";
        [Description("Material layers - outside to inside")]
        public virtual List<EnergyPlusMaterial> Layers { get; set; } = new List<EnergyPlusMaterial>();
    }
}
