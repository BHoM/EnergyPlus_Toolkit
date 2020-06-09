using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class Zone : BHoMObject
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "Zone";
        [Order]
        [Description("No description available")]
        public override string Name { get; set; } = "ExampleZone";
        [Order]
        [Description("No description available")]
        public virtual double DirectionOfRelativeNorth { get; set; } = 0;
        [Order]
        [Description("No description available")]
        public virtual double XOrigin { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double YOrigin { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double ZOrigin { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual int Type { get; set; } = 1;
        [Order]
        [Description("No description available")]
        public virtual int Multiplier { get; set; } = 1;
        [Order]
        [Description("If this field is 0.0, negative or autocalculate, then the average height")]
        public virtual string CeilingHeight { get; set; } = "autocalculate";
        [Order]
        [Description("If this field is 0.0, negative or autocalculate, then the volume of the zone")]
        public virtual string Volume { get; set; } = "autocalculate";
        [Order]
        [Description("If this field is 0.0, negative or autocalculate, then the floor area of the zone")]
        public virtual string FloorArea { get; set; } = "autocalculate";
        [Order]
        [Description("Will default to same value as SurfaceConvectionAlgorithm:Inside object")]
        public virtual SurfaceConvectionAlgorithmInsideMethod ZoneInsideConvectionAlgorithm { get; set; } = SurfaceConvectionAlgorithmInsideMethod.Undefined;
        [Order]
        [Description("Will default to same value as SurfaceConvectionAlgorithm:Outside object")]
        public virtual SurfaceConvectionAlgorithmOutsideMethod ZoneOutsideConvectionAlgorithm { get; set; } = SurfaceConvectionAlgorithmOutsideMethod.Undefined;
        [Order]
        [Description("No description available")]
        public virtual bool PartOfTotalFloorArea { get; set; } = true;
    }
}
