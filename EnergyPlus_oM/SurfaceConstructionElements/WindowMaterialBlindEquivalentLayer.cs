////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class WindowMaterial:Blind:EquivalentLayer : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual choice SlatOrientation { get; set; } = new choice;
////[Description("No description available")]
////public virtual real SlatWidth { get; set; } = new real;
////[Description("Distance between adjacent slat faces")]
////public virtual real SlatSeparation { get; set; } = new real;
////[Description("Perpendicular length between the cord and the curve.")]
////public virtual real SlatCrown { get; set; } = new real;
////[Description("Slat angle is +ve if the tip of the slat front face is tilted upward, else")]
////public virtual real SlatAngle { get; set; } = new real;
////[Description("The front side beam-diffuse solar transmittance of the slat at normal")]
////public virtual real FrontSideSlatBeam-DiffuseSolarTransmittance { get; set; } = new real;
////[Description("The back side beam-diffuse solar transmittance of the slat at normal")]
////public virtual real BackSideSlatBeam-DiffuseSolarTransmittance { get; set; } = new real;
////[Description("The front side beam-diffuse solar reflectance of the slat at normal")]
////public virtual real FrontSideSlatBeam-DiffuseSolarReflectance { get; set; } = new real;
////[Description("The back side beam-diffuse solar reflectance of the slat at normal")]
////public virtual real BackSideSlatBeam-DiffuseSolarReflectance { get; set; } = new real;
////[Description("The front side beam-diffuse visible transmittance of the slat")]
////public virtual real FrontSideSlatBeam-DiffuseVisibleTransmittance { get; set; } = new real;
////[Description("The back side beam-diffuse visible transmittance of the slat")]
////public virtual real BackSideSlatBeam-DiffuseVisibleTransmittance { get; set; } = new real;
////[Description("The front side beam-diffuse visible reflectance of the slat")]
////public virtual real FrontSideSlatBeam-DiffuseVisibleReflectance { get; set; } = new real;
////[Description("The back side beam-diffuse visible reflectance of the slat")]
////public virtual real BackSideSlatBeam-DiffuseVisibleReflectance { get; set; } = new real;
////[Description("The beam-diffuse solar transmittance of the slat averaged")]
////public virtual real SlatDiffuse-DiffuseSolarTransmittance { get; set; } = new real;
////[Description("The front side beam-diffuse solar reflectance of the slat")]
////public virtual real FrontSideSlatDiffuse-DiffuseSolarReflectance { get; set; } = new real;
////[Description("The back side beam-diffuse solar reflectance of the slat")]
////public virtual real BackSideSlatDiffuse-DiffuseSolarReflectance { get; set; } = new real;
////[Description("The beam-diffuse visible transmittance of the slat averaged")]
////public virtual real SlatDiffuse-DiffuseVisibleTransmittance { get; set; } = new real;
////[Description("The front side beam-diffuse visible reflectance of the slat")]
////public virtual real FrontSideSlatDiffuse-DiffuseVisibleReflectance { get; set; } = new real;
////[Description("The back side beam-diffuse visible reflectance of the slat")]
////public virtual real BackSideSlatDiffuse-DiffuseVisibleReflectance { get; set; } = new real;
////[Description("Long-wave hemispherical transmittance of the slat material.")]
////public virtual real SlatInfraredTransmittance { get; set; } = new real;
////[Description("Front side long-wave hemispherical emissivity of the slat material.")]
////public virtual real FrontSideSlatInfraredEmissivity { get; set; } = new real;
////[Description("Back side long-wave hemispherical emissivity of the slat material.")]
////public virtual real BackSideSlatInfraredEmissivity { get; set; } = new real;
////[Description("Used only if slat angle control is desired to either maximize solar")]
////public virtual choice SlatAngleControl { get; set; } = new choice;
////}
////}
