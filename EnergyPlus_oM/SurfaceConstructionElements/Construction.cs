using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class EnergyPlusConstruction : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "Construction";
        [Order]
        [Description("No description available")]
        public override string Name { get; set; } = "DefaultConstruction";
        [Order]
        [Description("Material layers - outside to inside")]
        public virtual List<string> Layers { get; set; } = new List<string>();
    }
}
