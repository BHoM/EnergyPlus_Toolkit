using BH.oM.Base;
using BH.oM.Geometry;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class ShadingBuildingDetailed : BHoMObject
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "Shading:Building:Detailed";
        [Order]
        [Description("No description available")]
        public override string Name { get; set; } = "";
        [Order]
        [Description("Transmittance schedule for the shading device, defaults to zero (always opaque)")]
        public virtual string TransmittanceScheduleName { get; set; } = "";
        [Order]
        [Description("shown with 6 vertex coordinates -- extensible object")]
        public virtual int NumberOfVertices { get; set; } = 0;
        [Order]
        [Description("No description available")]
        public virtual List<Point> Vertices { get; set; } = new List<Point>();
    }
}
