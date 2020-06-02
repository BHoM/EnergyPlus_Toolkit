////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class WindowMaterial:Blind : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual choice SlatOrientation { get; set; } = new choice;
////[Description("No description available")]
////public virtual real SlatWidth { get; set; } = new real;
////[Description("Distance between adjacent slat faces")]
////public virtual real SlatSeparation { get; set; } = new real;
////[Description("Distance between top and bottom surfaces of slat")]
////public virtual real SlatThickness { get; set; } = new real;
////[Description("If WindowShadingControl referencing the window that incorporates this blind")]
////public virtual real SlatAngle { get; set; } = new real;
////[Description("default is for aluminum")]
////public virtual real SlatConductivity { get; set; } = new real;
////[Description("No description available")]
////public virtual real SlatBeamSolarTransmittance { get; set; } = new real;
////[Description("No description available")]
////public virtual real FrontSideSlatBeamSolarReflectance { get; set; } = new real;
////[Description("No description available")]
////public virtual real BackSideSlatBeamSolarReflectance { get; set; } = new real;
////[Description("Must equal "Slat beam solar transmittance"")]
////public virtual real SlatDiffuseSolarTransmittance { get; set; } = new real;
////[Description("Must equal "Front Side Slat Beam Solar Reflectance"")]
////public virtual real FrontSideSlatDiffuseSolarReflectance { get; set; } = new real;
////[Description("Must equal "Back Side Slat Beam Solar Reflectance"")]
////public virtual real BackSideSlatDiffuseSolarReflectance { get; set; } = new real;
////[Description("Required for detailed daylighting calculation")]
////public virtual real SlatBeamVisibleTransmittance { get; set; } = new real;
////[Description("Required for detailed daylighting calculation")]
////public virtual real FrontSideSlatBeamVisibleReflectance { get; set; } = new real;
////[Description("Required for detailed daylighting calculation")]
////public virtual real BackSideSlatBeamVisibleReflectance { get; set; } = new real;
////[Description("Used only for detailed daylighting calculation")]
////public virtual real SlatDiffuseVisibleTransmittance { get; set; } = new real;
////[Description("Required for detailed daylighting calculation")]
////public virtual real FrontSideSlatDiffuseVisibleReflectance { get; set; } = new real;
////[Description("Required for detailed daylighting calculation")]
////public virtual real BackSideSlatDiffuseVisibleReflectance { get; set; } = new real;
////[Description("No description available")]
////public virtual real SlatInfraredHemisphericalTransmittance { get; set; } = new real;
////[Description("No description available")]
////public virtual real FrontSideSlatInfraredHemisphericalEmissivity { get; set; } = new real;
////[Description("No description available")]
////public virtual real BackSideSlatInfraredHemisphericalEmissivity { get; set; } = new real;
////[Description("No description available")]
////public virtual real BlindToGlassDistance { get; set; } = new real;
////[Description("No description available")]
////public virtual real BlindTopOpeningMultiplier { get; set; } = new real;
////[Description("No description available")]
////public virtual real BlindBottomOpeningMultiplier { get; set; } = new real;
////[Description("No description available")]
////public virtual real BlindLeftSideOpeningMultiplier { get; set; } = new real;
////[Description("No description available")]
////public virtual real BlindRightSideOpeningMultiplier { get; set; } = new real;
////[Description("Used only if WindowShadingControl referencing the window that incorporates")]
////public virtual real MinimumSlatAngle { get; set; } = new real;
////[Description("Used only if WindowShadingControl referencing the window that incorporates")]
////public virtual real MaximumSlatAngle { get; set; } = new real;
////}
////}
