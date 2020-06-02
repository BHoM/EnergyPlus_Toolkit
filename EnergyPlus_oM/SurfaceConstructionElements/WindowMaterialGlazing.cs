////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class WindowMaterial:Glazing : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual choice OpticalDataType { get; set; } = new choice;
////[Description("Used only when Optical Data Type = Spectral")]
////public virtual object-list WindowGlassSpectralDataSetName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real Thickness { get; set; } = new real;
////[Description("Used only when Optical Data Type = SpectralAverage")]
////public virtual real SolarTransmittanceAtNormalIncidence { get; set; } = new real;
////[Description("Used only when Optical Data Type = SpectralAverage")]
////public virtual real FrontSideSolarReflectanceAtNormalIncidence { get; set; } = new real;
////[Description("Used only when Optical Data Type = SpectralAverage")]
////public virtual real BackSideSolarReflectanceAtNormalIncidence { get; set; } = new real;
////[Description("Used only when Optical Data Type = SpectralAverage")]
////public virtual real VisibleTransmittanceAtNormalIncidence { get; set; } = new real;
////[Description("Used only when Optical Data Type = SpectralAverage")]
////public virtual real FrontSideVisibleReflectanceAtNormalIncidence { get; set; } = new real;
////[Description("Used only when Optical Data Type = SpectralAverage")]
////public virtual real BackSideVisibleReflectanceAtNormalIncidence { get; set; } = new real;
////[Description("No description available")]
////public virtual real InfraredTransmittanceAtNormalIncidence { get; set; } = new real;
////[Description("No description available")]
////public virtual real FrontSideInfraredHemisphericalEmissivity { get; set; } = new real;
////[Description("No description available")]
////public virtual real BackSideInfraredHemisphericalEmissivity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Conductivity { get; set; } = new real;
////[Description("No description available")]
////public virtual real DirtCorrectionFactorForSolarAndVisibleTransmittance { get; set; } = new real;
////[Description("No description available")]
////public virtual choice SolarDiffusing { get; set; } = new choice;
////[Description("coefficient used for deflection calculations. Used only with complex")]
////public virtual real Young'sModulus { get; set; } = new real;
////[Description("coefficient used for deflection calculations. Used only with complex")]
////public virtual real Poisson'sRatio { get; set; } = new real;
////[Description("Used only when Optical Data Type = SpectralAndAngle")]
////public virtual object-list WindowGlassSpectralAndIncidentAngleTransmittanceDataSetTableName { get; set; } = new object-list;
////[Description("Used only when Optical Data Type = SpectralAndAngle")]
////public virtual object-list WindowGlassSpectralAndIncidentAngleFrontReflectanceDataSetTableName { get; set; } = new object-list;
////[Description("Used only when Optical Data Type = SpectralAndAngle")]
////public virtual object-list WindowGlassSpectralAndIncidentAngleBackReflectanceDataSetTableName { get; set; } = new object-list;
////}
////}
