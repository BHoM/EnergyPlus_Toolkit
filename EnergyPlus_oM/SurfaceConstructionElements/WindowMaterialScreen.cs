////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class WindowMaterial:Screen : BHoMObject
////{
////[Description("Enter a unique name for this window screen material.")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Select the method used to account for the beam solar reflected off the material surface.")]
////public virtual choice ReflectedBeamTransmittanceAccountingMethod { get; set; } = new choice;
////[Description("Diffuse reflectance of the screen material over the entire solar radiation spectrum.")]
////public virtual real DiffuseSolarReflectance { get; set; } = new real;
////[Description("Diffuse visible reflectance of the screen material averaged over the solar spectrum")]
////public virtual real DiffuseVisibleReflectance { get; set; } = new real;
////[Description("Long-wave emissivity of the screen material.")]
////public virtual real ThermalHemisphericalEmissivity { get; set; } = new real;
////[Description("Thermal conductivity of the screen material.")]
////public virtual real Conductivity { get; set; } = new real;
////[Description("Spacing assumed to be the same in both directions.")]
////public virtual real ScreenMaterialSpacing { get; set; } = new real;
////[Description("Diameter assumed to be the same in both directions.")]
////public virtual real ScreenMaterialDiameter { get; set; } = new real;
////[Description("Distance from the window screen to the adjacent glass surface.")]
////public virtual real ScreenToGlassDistance { get; set; } = new real;
////[Description("Effective area for air flow at the top of the screen divided by the perpendicular")]
////public virtual real TopOpeningMultiplier { get; set; } = new real;
////[Description("Effective area for air flow at the bottom of the screen divided by the perpendicular")]
////public virtual real BottomOpeningMultiplier { get; set; } = new real;
////[Description("Effective area for air flow at the left side of the screen divided by the perpendicular")]
////public virtual real LeftSideOpeningMultiplier { get; set; } = new real;
////[Description("Effective area for air flow at the right side of the screen divided by the perpendicular")]
////public virtual real RightSideOpeningMultiplier { get; set; } = new real;
////[Description("Select the resolution of azimuth and altitude angles for the screen transmittance map.")]
////public virtual choice AngleOfResolutionForScreenTransmittanceOutputMap { get; set; } = new choice;
////}
////}
