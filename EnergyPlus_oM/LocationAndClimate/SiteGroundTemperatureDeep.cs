using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class SiteGroundTemperatureDeep : BHoMObject
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "Site:GroundTemperature:Deep";
        [Order]
        [Description("No description available")]
        public virtual double JanuaryDeepGroundTemperature { get; set; } = 16;
        [Order]
        [Description("No description available")]
        public virtual double FebruaryDeepGroundTemperature { get; set; } = 16;
        [Order]
        [Description("No description available")]
        public virtual double MarchDeepGroundTemperature { get; set; } = 16;
        [Order]
        [Description("No description available")]
        public virtual double AprilDeepGroundTemperature { get; set; } = 16;
        [Order]
        [Description("No description available")]
        public virtual double MayDeepGroundTemperature { get; set; } = 16;
        [Order]
        [Description("No description available")]
        public virtual double JuneDeepGroundTemperature { get; set; } = 16;
        [Order]
        [Description("No description available")]
        public virtual double JulyDeepGroundTemperature { get; set; } = 16;
        [Order]
        [Description("No description available")]
        public virtual double AugustDeepGroundTemperature { get; set; } = 16;
        [Order]
        [Description("No description available")]
        public virtual double SeptemberDeepGroundTemperature { get; set; } = 16;
        [Order]
        [Description("No description available")]
        public virtual double OctoberDeepGroundTemperature { get; set; } = 16;
        [Order]
        [Description("No description available")]
        public virtual double NovemberDeepGroundTemperature { get; set; } = 16;
        [Order]
        [Description("No description available")]
        public virtual double DecemberDeepGroundTemperature { get; set; } = 16;
    }
}
