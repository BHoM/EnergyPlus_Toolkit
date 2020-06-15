using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class LocationAndClimate : BHoMObject
    {
        [Description("")]
        public virtual SiteLocation SiteLocation { get; set; } = new SiteLocation();
        [Description("")]
        public virtual RunPeriod RunPeriod { get; set; } = new RunPeriod();
        [Description("")]
        public virtual SiteGroundTemperatureBuildingSurface SiteGroundTemperatureBuildingSurface { get; set; } = new SiteGroundTemperatureBuildingSurface();
        [Description("")]
        public virtual SiteGroundTemperatureShallow SiteGroundTemperatureShallow { get; set; } = new SiteGroundTemperatureShallow();
        [Description("")]
        public virtual SiteGroundTemperatureDeep SiteGroundTemperatureDeep { get; set; } = new SiteGroundTemperatureDeep();
    }
}
