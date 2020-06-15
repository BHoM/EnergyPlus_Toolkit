using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using BH.Engine.Reflection;
using BH.oM.Reflection;
using BH.oM.EnergyPlus;

namespace BH.Engine.EnergyPlus
{
    public static partial class Convert
    {
        public static string ToEnergyPlusString(this SurfaceConstructionElements surfaceConstructionElements)
        {
            StringBuilder sb = new StringBuilder();

            foreach (EnergyPlusMaterial material in surfaceConstructionElements.Materials)
            {
                sb.Append(material.ToEnergyPlusString());
            }

            foreach (MaterialRoofVegetation vegetationMaterial in surfaceConstructionElements.VegetationMaterials)
            {
                sb.Append(vegetationMaterial.ToEnergyPlusString());
            }

            foreach (EnergyPlusConstruction construction in surfaceConstructionElements.Constructions)
            {
                sb.Append(construction.ToEnergyPlusString());
            }

            return sb.ToString();
        }
    }
}
