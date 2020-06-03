using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class OutputConstructions : BHoMObject
    {
        [Description("No description available")]
        public virtual OutputConstructionsDetailsType DetailsType1 { get; set; } = OutputConstructionsDetailsType.Undefined;
        [Description("No description available")]
        public virtual OutputConstructionsDetailsType DetailsType2 { get; set; } = OutputConstructionsDetailsType.Undefined;
    }
}
