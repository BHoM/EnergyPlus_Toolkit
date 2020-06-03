using BH.oM.Base;
using BH.oM.Geometry;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class BuildingSurfaceDetailed : BHoMObject
    {
        [Description("No description available")]
        public virtual string BuildingSurfaceDetailedName { get; set; } = "";
        [Description("No description available")]
        public virtual BuildingSurfaceType SurfaceType { get; set; } = BuildingSurfaceType.Undefined;
        [Description("To be matched with a construction in this input file")]
        public virtual string ConstructionName { get; set; } = "";
        [Description("Zone the surface is a part of")]
        public virtual string ZoneName { get; set; } = "";
        [Description("No description available")]
        public virtual OutsideBoundaryCondition OutsideBoundaryCondition { get; set; } = OutsideBoundaryCondition.Undefined;
        [Description("Non-blank only if the field Outside Boundary Condition is Surface,")]
        public virtual string OutsideBoundaryConditionObject { get; set; } = "";
        [Description("No description available")]
        public virtual bool SunExposure { get; set; } =  false;
        [Description("No description available")]
        public virtual bool WindExposure { get; set; } = false;
        [Description("From the exterior of the surface")]
        public virtual string ViewFactorToGround { get; set; } = "autocalculate";
        [Description("shown with 120 vertex coordinates -- extensible object")]
        public virtual int NumberOfVertices { get; set; } = 0;
        [Description("No description available")]
        public virtual List<Point> Vertices { get; set; } = new List<Point>();
    }
}
