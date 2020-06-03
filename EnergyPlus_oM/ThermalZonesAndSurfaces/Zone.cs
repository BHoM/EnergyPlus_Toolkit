using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class Zone : BHoMObject
    {
        [Description("No description available")]
        public virtual string ZoneName { get; set; } = "Zone";
        [Description("No description available")]
        public virtual double DirectionOfRelativeNorth { get; set; } = 0;
        [Description("No description available")]
        public virtual double XOrigin { get; set; } = 0.0;
        [Description("No description available")]
        public virtual double YOrigin { get; set; } = 0.0;
        [Description("No description available")]
        public virtual double ZOrigin { get; set; } = 0.0;
        [Description("No description available")]
        public virtual int Type { get; set; } = 1;
        [Description("No description available")]
        public virtual int Multiplier { get; set; } = 1;
        [Description("If this field is 0.0, negative or autocalculate, then the average height")]
        public virtual string CeilingHeight { get; set; } = "autocalculate";
        [Description("If this field is 0.0, negative or autocalculate, then the volume of the zone")]
        public virtual string Volume { get; set; } = "autocalculate";
        [Description("If this field is 0.0, negative or autocalculate, then the floor area of the zone")]
        public virtual string FloorArea { get; set; } = "autocalculate";
        [Description("Will default to same value as SurfaceConvectionAlgorithm:Inside object")]
        public virtual SurfaceConvectionAlgorithmInsideMethod ZoneInsideConvectionAlgorithm { get; set; } = SurfaceConvectionAlgorithmInsideMethod.Undefined;
        [Description("Will default to same value as SurfaceConvectionAlgorithm:Outside object")]
        public virtual SurfaceConvectionAlgorithmOutsideMethod ZoneOutsideConvectionAlgorithm { get; set; } = SurfaceConvectionAlgorithmOutsideMethod.Undefined;
        [Description("No description available")]
        public virtual bool PartOfTotalFloorArea { get; set; } = true;
    }
}
