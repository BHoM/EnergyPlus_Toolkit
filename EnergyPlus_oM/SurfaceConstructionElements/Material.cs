using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class EnergyPlusMaterial : BHoMObject
    {
        [Description("No description available")]
        public virtual string EnergyPlusMaterialName { get; set; } = "";
        [Description("No description available")]
        public virtual Roughness Roughness { get; set; } = Roughness.MediumRough;
        [Description("No description available")]
        public virtual double Thickness { get; set; } = 0.1;
        [Description("No description available")]
        public virtual double Conductivity { get; set; } = 0.5;
        [Description("No description available")]
        public virtual double Density { get; set; } = 1000;
        [Description("No description available")]
        public virtual double SpecificHeat { get; set; } = 1000;
        [Description("No description available")]
        public virtual double ThermalAbsorptance { get; set; } = 0.9;
        [Description("No description available")]
        public virtual double SolarAbsorptance { get; set; } = 0.7;
        [Description("No description available")]
        public virtual double VisibleAbsorptance { get; set; } = 0.7;
    }
}
