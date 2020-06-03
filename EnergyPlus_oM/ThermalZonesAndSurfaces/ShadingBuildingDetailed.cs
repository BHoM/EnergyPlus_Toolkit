using BH.oM.Base;
using BH.oM.Geometry;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class ShadingBuildingDetailed : BHoMObject
    {
        [Description("No description available")]
        public virtual string ShadingBuildingDetailedName { get; set; } = "";
        [Description("Transmittance schedule for the shading device, defaults to zero (always opaque)")]
        public virtual string TransmittanceScheduleName { get; set; } = "";
        [Description("shown with 6 vertex coordinates -- extensible object")]
        public virtual int NumberOfVertices { get; set; } = 0;
        [Description("No description available")]
        public virtual List<Point> Vertices { get; set; } = new List<Point>();
    }
}
