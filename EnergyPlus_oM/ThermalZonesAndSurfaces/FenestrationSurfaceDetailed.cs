using BH.oM.Base;
using BH.oM.Geometry;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class FenestrationSurfaceDetailed : BHoMObject
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "FenestrationSurface:Detailed";
        [Order]
        [Description("No description available")]
        public override string Name { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual FenestrationSurfaceType SurfaceType { get; set; } = FenestrationSurfaceType.Undefined;
        [Order]
        [Description("To be matched with a construction in this input file")]
        public virtual string ConstructionName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string BuildingSurfaceName { get; set; } = "";
        [Order]
        [Description("Non-blank only if base surface field Outside Boundary Condition is")]
        public virtual string OutsideBoundaryConditionObject { get; set; } = "";
        [Order]
        [Description("From the exterior of the surface")]
        public virtual string ViewFactorToGround { get; set; } = "autocalculate";
        [Order]
        [Description("Enter the name of a WindowProperty:FrameAndDivider object")]
        public virtual string FrameAndDividerName { get; set; } = "";
        [Order]
        [Description("Used only for Surface Type = WINDOW, GLASSDOOR or DOOR")]
        public virtual int Multiplier { get; set; } = 1;
        [Order]
        [Description("vertices are given in GlobalGeometryRules coordinates -- if relative, all surface coordinates")]
        public virtual int NumberOfVertices { get; set; } = 0;
        [Order]
        [Description("No description available")]
        public virtual List<Point> Vertices { get; set; } = new List<Point>();
    }
}
