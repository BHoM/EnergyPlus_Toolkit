////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Zone : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual real DirectionOfRelativeNorth { get; set; } = new real;
////[Description("No description available")]
////public virtual real XOrigin { get; set; } = new real;
////[Description("No description available")]
////public virtual real YOrigin { get; set; } = new real;
////[Description("No description available")]
////public virtual real ZOrigin { get; set; } = new real;
////[Description("No description available")]
////public virtual integer Type { get; set; } = new integer;
////[Description("No description available")]
////public virtual integer Multiplier { get; set; } = new integer;
////[Description("If this field is 0.0, negative or autocalculate, then the average height")]
////public virtual real CeilingHeight { get; set; } = new real;
////[Description("If this field is 0.0, negative or autocalculate, then the volume of the zone")]
////public virtual real Volume { get; set; } = new real;
////[Description("If this field is 0.0, negative or autocalculate, then the floor area of the zone")]
////public virtual real FloorArea { get; set; } = new real;
////[Description("Will default to same value as SurfaceConvectionAlgorithm:Inside object")]
////public virtual choice ZoneInsideConvectionAlgorithm { get; set; } = new choice;
////[Description("Will default to same value as SurfaceConvectionAlgorithm:Outside object")]
////public virtual choice ZoneOutsideConvectionAlgorithm { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PartOfTotalFloorArea { get; set; } = new choice;
////}
////}
