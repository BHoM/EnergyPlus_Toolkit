using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class SiteGroundTemperatureBuildingSurface : BHoMObject
    {
        [Description("No description available")]
        public virtual double JanuaryGroundTemperature { get; set; } = 18;
        [Description("No description available")]
        public virtual double FebruaryGroundTemperature { get; set; } = 18;
        [Description("No description available")]
        public virtual double MarchGroundTemperature { get; set; } = 18;
        [Description("No description available")]
        public virtual double AprilGroundTemperature { get; set; } = 18;
        [Description("No description available")]
        public virtual double MayGroundTemperature { get; set; } = 18;
        [Description("No description available")]
        public virtual double JuneGroundTemperature { get; set; } = 18;
        [Description("No description available")]
        public virtual double JulyGroundTemperature { get; set; } = 18;
        [Description("No description available")]
        public virtual double AugustGroundTemperature { get; set; } = 18;
        [Description("No description available")]
        public virtual double SeptemberGroundTemperature { get; set; } = 18;
        [Description("No description available")]
        public virtual double OctoberGroundTemperature { get; set; } = 18;
        [Description("No description available")]
        public virtual double NovemberGroundTemperature { get; set; } = 18;
        [Description("No description available")]
        public virtual double DecemberGroundTemperature { get; set; } = 18;
    }
}
