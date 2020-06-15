using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class EnergyPlusMaterial : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "Material";
        [Order]
        [Description("No description available")]
        public override string Name { get; set; } = "DefaultMaterial";
        [Order]
        [Description("No description available")]
        public virtual Roughness Roughness { get; set; } = Roughness.MediumRough;
        [Order]
        [Description("No description available")]
        public virtual double Thickness { get; set; } = 0.1;
        [Order]
        [Description("No description available")]
        public virtual double Conductivity { get; set; } = 0.5;
        [Order]
        [Description("No description available")]
        public virtual double Density { get; set; } = 1000;
        [Order]
        [Description("No description available")]
        public virtual double SpecificHeat { get; set; } = 1000;
        [Order]
        [Description("No description available")]
        public virtual double ThermalAbsorptance { get; set; } = 0.9;
        [Order]
        [Description("No description available")]
        public virtual double SolarAbsorptance { get; set; } = 0.7;
        [Order]
        [Description("No description available")]
        public virtual double VisibleAbsorptance { get; set; } = 0.7;
    }
}
