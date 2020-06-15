using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class EnergyPlusWindowMaterialGlazing : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "WindowMaterial:Glazing";
        [Order]
        [Description("No description available")]
        public override string Name { get; set; } = "DefaultMaterial";
        [Order]
        [Description("No description available")]
        public virtual OpticalDataType OpticalDataType{ get; set; } = OpticalDataType.SpectralAverage;
        [Order]
        [Description("No description available")]
        public virtual string WindowGlassSpectralDataSetName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual double Thickness { get; set; } = 0.005;
        [Order]
        [Description("No description available")]
        public virtual double SolarTransmittanceAtNormalIncidence { get; set; } = 0.5;
        [Order]
        [Description("No description available")]
        public virtual double FrontSideSolarReflectanceAtNormalIncidence { get; set; } = 0.5;
        [Order]
        [Description("No description available")]
        public virtual double BackSideSolarReflectanceAtNormalIncidence { get; set; } = 0.5;
        [Order]
        [Description("No description available")]
        public virtual double VisibleTransmittanceAtNormalIncidence { get; set; } = 0.8;
        [Order]
        [Description("No description available")]
        public virtual double FrontSideVisibleReflectanceAtNormalIncidence { get; set; } = 0.8;
        [Order]
        [Description("No description available")]
        public virtual double BackSideVisibleReflectanceAtNormalIncidence { get; set; } = 0.8;
        [Order]
        [Description("No description available")]
        public virtual double InfraredTransmittanceAtNormalIncidence { get; set; } = 0.8;
        [Order]
        [Description("No description available")]
        public virtual double FrontSideInfraredHemisphericalEmissivity { get; set; } = 0.84;
        [Order]
        [Description("No description available")]
        public virtual double BackSideInfraredHemisphericalEmissivity { get; set; } = 0.84;
        [Order]
        [Description("No description available")]
        public virtual double Conductivity { get; set; } = 0.9;
        [Order]
        [Description("No description available")]
        public virtual double DirtCorrectionFactorForSolarAndVisibleTransmittance { get; set; } = 1;
        [Order]
        [Description("No description available")]
        public virtual bool SolarDiffusing { get; set; } = false;
        [Order]
        [Description("No description available")]
        public virtual double YoungsModulus { get; set; } = 72000000000;
        [Order]
        [Description("No description available")]
        public virtual double PoissonsRatio { get; set; } = 0.22;
    }
}
