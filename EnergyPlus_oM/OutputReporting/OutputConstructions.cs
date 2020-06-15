using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class OutputConstructions : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "Output:Constructions";
        [Order]
        [Description("No description available")]
        public virtual OutputConstructionsDetailsType DetailsType1 { get; set; } = OutputConstructionsDetailsType.Materials;
        [Order]
        [Description("No description available")]
        public virtual OutputConstructionsDetailsType DetailsType2 { get; set; } = OutputConstructionsDetailsType.Constructions;
    }
}
