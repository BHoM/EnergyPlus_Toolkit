using BH.oM.Base;
using BH.oM.Geometry;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class FenestrationSurfaceDetailed : BHoMObject
    {
        [Description("No description available")]
        public virtual string FenestrationSurfaceDetailedName { get; set; } = "";
        [Description("No description available")]
        public virtual FenestrationSurfaceType SurfaceType { get; set; } = FenestrationSurfaceType.Undefined;
        [Description("To be matched with a construction in this input file")]
        public virtual string ConstructionName { get; set; } = "";
        [Description("No description available")]
        public virtual string BuildingSurfaceName { get; set; } = "";
        [Description("Non-blank only if base surface field Outside Boundary Condition is")]
        public virtual string OutsideBoundaryConditionObject { get; set; } = "";
        [Description("From the exterior of the surface")]
        public virtual string ViewFactorToGround { get; set; } = "autocalculate";
        [Description("Enter the name of a WindowProperty:FrameAndDivider object")]
        public virtual string FrameAndDividerName { get; set; } = "";
        [Description("Used only for Surface Type = WINDOW, GLASSDOOR or DOOR")]
        public virtual int Multiplier { get; set; } = 1;
        [Description("vertices are given in GlobalGeometryRules coordinates -- if relative, all surface coordinates")]
        public virtual int NumberOfVertices { get; set; } = 0;
        [Description("No description available")]
        public virtual List<Point> Vertices { get; set; } = new List<Point>();
    }
}
