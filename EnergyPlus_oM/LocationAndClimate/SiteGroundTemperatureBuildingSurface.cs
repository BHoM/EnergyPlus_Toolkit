using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class SiteGroundTemperatureBuildingSurface : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "Site:GroundTemperature:BuildingSurface";
        [Order]
        [Description("No description available")]
        public virtual double JanuaryGroundTemperature { get; set; } = 18;
        [Order]
        [Description("No description available")]
        public virtual double FebruaryGroundTemperature { get; set; } = 18;
        [Order]
        [Description("No description available")]
        public virtual double MarchGroundTemperature { get; set; } = 18;
        [Order]
        [Description("No description available")]
        public virtual double AprilGroundTemperature { get; set; } = 18;
        [Order]
        [Description("No description available")]
        public virtual double MayGroundTemperature { get; set; } = 18;
        [Order]
        [Description("No description available")]
        public virtual double JuneGroundTemperature { get; set; } = 18;
        [Order]
        [Description("No description available")]
        public virtual double JulyGroundTemperature { get; set; } = 18;
        [Order]
        [Description("No description available")]
        public virtual double AugustGroundTemperature { get; set; } = 18;
        [Order]
        [Description("No description available")]
        public virtual double SeptemberGroundTemperature { get; set; } = 18;
        [Order]
        [Description("No description available")]
        public virtual double OctoberGroundTemperature { get; set; } = 18;
        [Order]
        [Description("No description available")]
        public virtual double NovemberGroundTemperature { get; set; } = 18;
        [Order]
        [Description("No description available")]
        public virtual double DecemberGroundTemperature { get; set; } = 18;
    }
}
