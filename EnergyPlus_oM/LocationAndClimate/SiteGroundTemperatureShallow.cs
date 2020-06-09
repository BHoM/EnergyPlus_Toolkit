using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class SiteGroundTemperatureShallow : BHoMObject
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "Site:GroundTemperature:Shallow";
        [Order]
        [Description("No description available")]
        public virtual double JanuarySurfaceGroundTemperature { get; set; } = 13;
        [Order]
        [Description("No description available")]
        public virtual double FebruarySurfaceGroundTemperature { get; set; } = 13;
        [Order]
        [Description("No description available")]
        public virtual double MarchSurfaceGroundTemperature { get; set; } = 13;
        [Order]
        [Description("No description available")]
        public virtual double AprilSurfaceGroundTemperature { get; set; } = 13;
        [Order]
        [Description("No description available")]
        public virtual double MaySurfaceGroundTemperature { get; set; } = 13;
        [Order]
        [Description("No description available")]
        public virtual double JuneSurfaceGroundTemperature { get; set; } = 13;
        [Order]
        [Description("No description available")]
        public virtual double JulySurfaceGroundTemperature { get; set; } = 13;
        [Order]
        [Description("No description available")]
        public virtual double AugustSurfaceGroundTemperature { get; set; } = 13;
        [Order]
        [Description("No description available")]
        public virtual double SeptemberSurfaceGroundTemperature { get; set; } = 13;
        [Order]
        [Description("No description available")]
        public virtual double OctoberSurfaceGroundTemperature { get; set; } = 13;
        [Order]
        [Description("No description available")]
        public virtual double NovemberSurfaceGroundTemperature { get; set; } = 13;
        [Order]
        [Description("No description available")]
        public virtual double DecemberSurfaceGroundTemperature { get; set; } = 13;
    }
}
