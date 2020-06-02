////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class SurfaceConvectionAlgorithm:Outside:AdaptiveModelSelections : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual choice WindConvectionWindwardVerticalWallEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Outside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list WindConvectionWindwardEquationVerticalWallUserCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice WindConvectionLeewardVerticalWallEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Outside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list WindConvectionLeewardVerticalWallEquationUserCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice WindConvectionHorizontalRoofEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Outside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list WindConvectionHorizontalRoofUserCurveName { get; set; } = new object-list;
////[Description("This is for vertical walls")]
////public virtual choice NaturalConvectionVerticalWallEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Outside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list NaturalConvectionVerticalWallEquationUserCurveName { get; set; } = new object-list;
////[Description("This is for horizontal surfaces with heat flow directed for stable thermal stratification")]
////public virtual choice NaturalConvectionStableHorizontalEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Outside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list NaturalConvectionStableHorizontalEquationUserCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice NaturalConvectionUnstableHorizontalEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Outside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list NaturalConvectionUnstableHorizontalEquationUserCurveName { get; set; } = new object-list;
////}
////}
