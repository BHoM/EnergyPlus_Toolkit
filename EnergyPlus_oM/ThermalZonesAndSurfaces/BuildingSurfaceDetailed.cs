using BH.oM.Base;
using BH.oM.Geometry;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class BuildingSurfaceDetailed : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "BuildingSurface:Detailed";
        [Order]
        [Description("No description available")]
        public override string Name { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual BuildingSurfaceType SurfaceType { get; set; } = BuildingSurfaceType.Undefined;
        [Order]
        [Description("To be matched with a construction in this input file")]
        public virtual string ConstructionName { get; set; } = "";
        [Order]
        [Description("Zone the surface is a part of")]
        public virtual string ZoneName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual OutsideBoundaryCondition OutsideBoundaryCondition { get; set; } = OutsideBoundaryCondition.Undefined;
        [Order]
        [Description("Non-blank only if the field Outside Boundary Condition is Surface,")]
        public virtual string OutsideBoundaryConditionObject { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string SunExposure { get; set; } =  "NoSun";
        [Order]
        [Description("No description available")]
        public virtual string WindExposure { get; set; } = "NoWind";
        [Order]
        [Description("From the exterior of the surface")]
        public virtual string ViewFactorToGround { get; set; } = "autocalculate";
        [Order]
        [Description("shown with 120 vertex coordinates -- extensible object")]
        public virtual int NumberOfVertices { get; set; } = 0;
        [Order]
        [Description("No description available")]
        public virtual List<Point> Vertices { get; set; } = new List<Point>();
    }
}
