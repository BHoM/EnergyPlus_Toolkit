using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class SiteGroundTemperatureDeep : BHoMObject
    {
        [Description("No description available")]
        public virtual double JanuaryDeepGroundTemperature { get; set; } = 16;
        [Description("No description available")]
        public virtual double FebruaryDeepGroundTemperature { get; set; } = 16;
        [Description("No description available")]
        public virtual double MarchDeepGroundTemperature { get; set; } = 16;
        [Description("No description available")]
        public virtual double AprilDeepGroundTemperature { get; set; } = 16;
        [Description("No description available")]
        public virtual double MayDeepGroundTemperature { get; set; } = 16;
        [Description("No description available")]
        public virtual double JuneDeepGroundTemperature { get; set; } = 16;
        [Description("No description available")]
        public virtual double JulyDeepGroundTemperature { get; set; } = 16;
        [Description("No description available")]
        public virtual double AugustDeepGroundTemperature { get; set; } = 16;
        [Description("No description available")]
        public virtual double SeptemberDeepGroundTemperature { get; set; } = 16;
        [Description("No description available")]
        public virtual double OctoberDeepGroundTemperature { get; set; } = 16;
        [Description("No description available")]
        public virtual double NovemberDeepGroundTemperature { get; set; } = 16;
        [Description("No description available")]
        public virtual double DecemberDeepGroundTemperature { get; set; } = 16;
    }
}
