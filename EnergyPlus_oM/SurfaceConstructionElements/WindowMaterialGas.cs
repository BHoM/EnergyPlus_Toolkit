using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class EnergyPlusWindowMaterialGas : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "WindowMaterial:Gas";
        [Order]
        [Description("No description available")]
        public override string Name { get; set; } = "DefaultWindwGasMaterial";
        [Order]
        [Description("No description available")]
        public virtual GasType GasType { get; set; } = GasType.Air;
        [Order]
        [Description("No description available")]
        public virtual double Thickness { get; set; } = 0.005;
    }
}
