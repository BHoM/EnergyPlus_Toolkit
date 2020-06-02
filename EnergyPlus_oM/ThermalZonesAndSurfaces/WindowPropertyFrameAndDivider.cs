////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class WindowProperty:FrameAndDivider : BHoMObject
////{
////[Description("Referenced by surfaces that are exterior windows")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Width of frame in plane of window")]
////public virtual real FrameWidth { get; set; } = new real;
////[Description("Amount that frame projects outward from the outside face of the glazing")]
////public virtual real FrameOutsideProjection { get; set; } = new real;
////[Description("Amount that frame projects inward from the inside face of the glazing")]
////public virtual real FrameInsideProjection { get; set; } = new real;
////[Description("Effective conductance of frame")]
////public virtual real FrameConductance { get; set; } = new real;
////[Description("Excludes air films; applies only to multipane windows")]
////public virtual real RatioOfFrame-EdgeGlassConductanceToCenter-Of-GlassConductance { get; set; } = new real;
////[Description("Assumed same on outside and inside of frame")]
////public virtual real FrameSolarAbsorptance { get; set; } = new real;
////[Description("Assumed same on outside and inside of frame")]
////public virtual real FrameVisibleAbsorptance { get; set; } = new real;
////[Description("Assumed same on outside and inside of frame")]
////public virtual real FrameThermalHemisphericalEmissivity { get; set; } = new real;
////[Description("No description available")]
////public virtual choice DividerType { get; set; } = new choice;
////[Description("Width of dividers in plane of window")]
////public virtual real DividerWidth { get; set; } = new real;
////[Description(""Horizontal" means parallel to local window X-axis")]
////public virtual real NumberOfHorizontalDividers { get; set; } = new real;
////[Description(""Vertical" means parallel to local window Y-axis")]
////public virtual real NumberOfVerticalDividers { get; set; } = new real;
////[Description("Amount that divider projects outward from the outside face of the glazing")]
////public virtual real DividerOutsideProjection { get; set; } = new real;
////[Description("Amount that divider projects inward from the inside face of the glazing")]
////public virtual real DividerInsideProjection { get; set; } = new real;
////[Description("Effective conductance of divider")]
////public virtual real DividerConductance { get; set; } = new real;
////[Description("Excludes air films")]
////public virtual real RatioOfDivider-EdgeGlassConductanceToCenter-Of-GlassConductance { get; set; } = new real;
////[Description("Assumed same on outside and inside of divider")]
////public virtual real DividerSolarAbsorptance { get; set; } = new real;
////[Description("Assumed same on outside and inside of divider")]
////public virtual real DividerVisibleAbsorptance { get; set; } = new real;
////[Description("Assumed same on outside and inside of divider")]
////public virtual real DividerThermalHemisphericalEmissivity { get; set; } = new real;
////[Description("No description available")]
////public virtual real OutsideRevealSolarAbsorptance { get; set; } = new real;
////[Description("No description available")]
////public virtual real InsideSillDepth { get; set; } = new real;
////[Description("No description available")]
////public virtual real InsideSillSolarAbsorptance { get; set; } = new real;
////[Description("Distance from plane of inside surface of glazing")]
////public virtual null InsideRevealDepth { get; set; } = new null;
////[Description("No description available")]
////public virtual real InsideRevealSolarAbsorptance { get; set; } = new real;
////}
////}
