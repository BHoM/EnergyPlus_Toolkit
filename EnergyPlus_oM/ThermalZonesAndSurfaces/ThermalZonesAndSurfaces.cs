using BH.oM.Base;
using BH.oM.Geometry;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class ThermalZonesAndSurfaces : BHoMObject
    {
        [Description("")]
        public virtual GlobalGeometryRules GlobalGeometryRules { get; set; } = new GlobalGeometryRules();
        [Description("")]
        public virtual List<Zone> Zones { get; set; } = new List<Zone>();
        [Description("")]
        public virtual List<ZoneList> ZoneLists { get; set; } = new List<ZoneList>();
        [Description("")]
        public virtual List<BuildingSurfaceDetailed> BuildingSurfaces { get; set; } = new List<BuildingSurfaceDetailed>();
        [Description("")]
        public virtual List<FenestrationSurfaceDetailed> FenestrationSurfaces { get; set; } = new List<FenestrationSurfaceDetailed>();
        [Description("")]
        public virtual List<ShadingBuildingDetailed> ShadingSurfaces { get; set; } = new List<ShadingBuildingDetailed>();
        [Description("")]
        public virtual List<InternalMass> InternalMasses { get; set; } = new List<InternalMass>();
    }
}
