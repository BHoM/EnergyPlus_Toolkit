using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class SurfaceConstructionElements : BHoMObject
    {
        [Description("")]
        public virtual List<EnergyPlusMaterial> Materials { get; set; } = new List<EnergyPlusMaterial>();
        [Description("")]
        public virtual List<MaterialRoofVegetation> VegetationMaterials { get; set; } = new List<MaterialRoofVegetation>();
        [Description("")]
        public virtual List<EnergyPlusWindowMaterialGlazing> GlazingMaterials { get; set; } = new List<EnergyPlusWindowMaterialGlazing>();
        [Description("")]
        public virtual List<EnergyPlusConstruction> Constructions { get; set; } = new List<EnergyPlusConstruction>();
    }
}
