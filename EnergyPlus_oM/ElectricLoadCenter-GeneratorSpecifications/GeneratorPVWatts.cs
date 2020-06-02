//using BH.oM.Base;
//using System.Collections.Generic;
//using System.ComponentModel;
//
//namespace BH.oM.EnergyPlus
//{
//public class Generator:PVWatts : BHoMObject
//{
//[Description("No description available")]
//public virtual alpha Name { get; set; } = new alpha;
//[Description("No description available")]
//public virtual choice PVWattsVersion { get; set; } = new choice;
//[Description("Nameplate rated DC system capacity in watts")]
//public virtual real DCSystemCapacity { get; set; } = new real;
//[Description("No description available")]
//public virtual choice ModuleType { get; set; } = new choice;
//[Description("No description available")]
//public virtual choice ArrayType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real SystemLosses { get; set; } = new real;
//[Description("TiltAzimuth - The tilt and azimuth angles are specified in the next two fields.")]
//public virtual choice ArrayGeometryType { get; set; } = new choice;
//[Description("The tilt angle is the angle from horizontal of the photovoltaic modules in the array.")]
//public virtual real TiltAngle { get; set; } = new real;
//[Description("For a fixed array, the azimuth angle is the angle clockwise from true north describing")]
//public virtual real AzimuthAngle { get; set; } = new real;
//[Description("No description available")]
//public virtual object-list SurfaceName { get; set; } = new object-list;
//[Description("Applies only to arrays with one-axis tracking and is the ratio of module surface area")]
//public virtual real GroundCoverageRatio { get; set; } = new real;
//}
//}
