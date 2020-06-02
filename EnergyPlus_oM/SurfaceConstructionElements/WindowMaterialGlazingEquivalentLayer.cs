////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class WindowMaterial:Glazing:EquivalentLayer : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Spectral is not currently supported and SpectralAverage is the default.")]
////public virtual choice OpticalDataType { get; set; } = new choice;
////[Description("Spectral data is not currently supported.")]
////public virtual object-list WindowGlassSpectralDataSetName { get; set; } = new object-list;
////[Description("Used only when Optical Data Type = SpectralAverage")]
////public virtual real FrontSideBeam-BeamSolarTransmittance { get; set; } = new real;
////[Description("Used only when Optical Data Type = SpectralAverage")]
////public virtual real BackSideBeam-BeamSolarTransmittance { get; set; } = new real;
////[Description("Used only when Optical Data Type = SpectralAverage")]
////public virtual real FrontSideBeam-BeamSolarReflectance { get; set; } = new real;
////[Description("Used only when Optical Data Type = SpectralAverage")]
////public virtual real BackSideBeam-BeamSolarReflectance { get; set; } = new real;
////[Description("Used only when Optical Data Type = SpectralAverage")]
////public virtual real FrontSideBeam-BeamVisibleSolarTransmittance { get; set; } = new real;
////[Description("Used only when Optical Data Type = SpectralAverage")]
////public virtual real BackSideBeam-BeamVisibleSolarTransmittance { get; set; } = new real;
////[Description("Used only when Optical Data Type = SpectralAverage")]
////public virtual real FrontSideBeam-BeamVisibleSolarReflectance { get; set; } = new real;
////[Description("Used only when Optical Data Type = SpectralAverage")]
////public virtual real BackSideBeam-BeamVisibleSolarReflectance { get; set; } = new real;
////[Description("Used only when Optical Data Type = SpectralAverage")]
////public virtual real FrontSideBeam-DiffuseSolarTransmittance { get; set; } = new real;
////[Description("Used only when Optical Data Type = SpectralAverage")]
////public virtual real BackSideBeam-DiffuseSolarTransmittance { get; set; } = new real;
////[Description("Used only when Optical Data Type = SpectralAverage")]
////public virtual real FrontSideBeam-DiffuseSolarReflectance { get; set; } = new real;
////[Description("Used only when Optical Data Type = SpectralAverage")]
////public virtual real BackSideBeam-DiffuseSolarReflectance { get; set; } = new real;
////[Description("Used only when Optical Data Type = SpectralAverage")]
////public virtual real FrontSideBeam-DiffuseVisibleSolarTransmittance { get; set; } = new real;
////[Description("Used only when Optical Data Type = SpectralAverage")]
////public virtual real BackSideBeam-DiffuseVisibleSolarTransmittance { get; set; } = new real;
////[Description("Used only when Optical Data Type = SpectralAverage")]
////public virtual real FrontSideBeam-DiffuseVisibleSolarReflectance { get; set; } = new real;
////[Description("Used only when Optical Data Type = SpectralAverage")]
////public virtual real BackSideBeam-DiffuseVisibleSolarReflectance { get; set; } = new real;
////[Description("Used only when Optical Data Type = SpectralAverage")]
////public virtual real Diffuse-DiffuseSolarTransmittance { get; set; } = new real;
////[Description("Used only when Optical Data Type = SpectralAverage")]
////public virtual real FrontSideDiffuse-DiffuseSolarReflectance { get; set; } = new real;
////[Description("Used only when Optical Data Type = SpectralAverage")]
////public virtual real BackSideDiffuse-DiffuseSolarReflectance { get; set; } = new real;
////[Description("Used only when Optical Data Type = SpectralAverage")]
////public virtual real Diffuse-DiffuseVisibleSolarTransmittance { get; set; } = new real;
////[Description("Used only when Optical Data Type = SpectralAverage")]
////public virtual real FrontSideDiffuse-DiffuseVisibleSolarReflectance { get; set; } = new real;
////[Description("Used only when Optical Data Type = SpectralAverage")]
////public virtual real BackSideDiffuse-DiffuseVisibleSolarReflectance { get; set; } = new real;
////[Description("The long-wave hemispherical transmittance of the glazing.")]
////public virtual real InfraredTransmittance(appliesToFrontAndBack) { get; set; } = new real;
////[Description("The front side long-wave hemispherical emissivity of the glazing.")]
////public virtual real FrontSideInfraredEmissivity { get; set; } = new real;
////[Description("The back side long-wave hemispherical emissivity of the glazing.")]
////public virtual real BackSideInfraredEmissivity { get; set; } = new real;
////[Description("This is the R-Value in SI for the glass. The default value is an")]
////public virtual real ThermalResistance { get; set; } = new real;
////}
////}
