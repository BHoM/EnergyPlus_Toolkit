////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class MaterialProperty:GlazingSpectralData : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength1 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance1 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance1 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance1 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength2 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance2 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance2 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance2 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength3 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance3 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance3 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance3 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength4 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance4 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance4 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance4 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength5 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance5 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance5 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance5 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength6 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance6 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance6 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance6 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength7 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance7 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance7 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance7 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength8 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance8 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance8 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance8 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength9 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance9 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance9 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance9 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength10 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance10 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance10 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance10 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength11 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance11 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance11 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance11 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength12 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance12 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance12 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance12 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength13 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance13 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance13 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance13 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength14 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance14 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance14 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance14 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength15 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance15 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance15 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance15 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength16 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance16 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance16 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance16 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength17 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance17 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance17 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance17 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength18 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance18 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance18 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance18 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength19 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance19 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance19 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance19 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength20 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance20 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance20 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance20 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength21 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance21 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance21 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance21 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength22 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance22 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance22 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance22 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength23 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance23 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance23 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance23 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength24 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance24 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance24 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance24 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength25 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance25 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance25 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance25 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength26 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance26 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance26 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance26 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength27 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance27 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance27 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance27 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength28 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance28 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance28 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance28 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength29 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance29 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance29 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance29 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength30 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance30 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance30 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance30 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength31 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance31 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance31 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance31 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength32 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance32 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance32 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance32 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength33 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance33 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance33 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance33 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength34 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance34 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance34 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance34 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength35 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance35 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance35 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance35 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength36 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance36 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance36 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance36 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength37 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance37 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance37 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance37 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength38 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance38 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance38 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance38 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength39 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance39 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance39 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance39 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength40 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance40 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance40 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance40 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength41 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance41 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance41 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance41 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength42 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance42 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance42 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance42 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength43 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance43 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance43 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance43 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength44 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance44 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance44 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance44 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength45 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance45 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance45 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance45 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength46 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance46 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance46 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance46 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength47 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance47 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance47 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance47 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength48 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance48 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance48 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance48 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength49 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance49 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance49 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance49 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength50 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance50 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance50 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance50 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength51 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance51 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance51 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance51 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength52 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance52 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance52 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance52 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength53 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance53 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance53 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance53 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength54 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance54 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance54 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance54 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength55 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance55 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance55 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance55 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength56 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance56 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance56 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance56 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength57 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance57 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance57 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance57 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength58 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance58 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance58 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance58 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength59 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance59 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance59 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance59 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength60 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance60 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance60 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance60 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength61 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance61 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance61 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance61 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength62 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance62 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance62 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance62 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength63 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance63 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance63 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance63 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength64 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance64 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance64 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance64 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength65 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance65 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance65 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance65 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength66 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance66 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance66 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance66 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength67 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance67 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance67 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance67 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength68 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance68 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance68 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance68 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength69 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance69 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance69 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance69 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength70 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance70 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance70 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance70 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength71 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance71 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance71 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance71 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength72 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance72 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance72 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance72 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength73 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance73 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance73 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance73 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength74 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance74 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance74 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance74 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength75 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance75 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance75 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance75 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength76 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance76 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance76 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance76 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength77 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance77 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance77 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance77 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength78 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance78 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance78 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance78 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength79 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance79 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance79 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance79 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength80 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance80 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance80 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance80 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength81 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance81 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance81 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance81 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength82 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance82 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance82 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance82 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength83 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance83 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance83 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance83 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength84 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance84 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance84 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance84 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength85 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance85 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance85 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance85 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength86 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance86 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance86 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance86 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength87 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance87 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance87 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance87 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength88 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance88 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance88 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance88 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength89 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance89 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance89 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance89 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength90 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance90 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance90 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance90 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength91 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance91 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance91 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance91 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength92 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance92 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance92 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance92 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength93 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance93 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance93 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance93 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength94 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance94 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance94 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance94 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength95 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance95 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance95 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance95 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength96 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance96 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance96 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance96 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength97 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance97 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance97 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance97 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength98 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance98 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance98 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance98 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength99 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance99 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance99 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance99 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength100 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance100 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance100 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance100 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength101 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance101 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance101 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance101 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength102 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance102 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance102 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance102 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength103 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance103 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance103 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance103 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength104 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance104 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance104 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance104 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength105 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance105 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance105 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance105 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength106 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance106 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance106 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance106 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength107 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance107 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance107 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance107 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength108 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance108 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance108 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance108 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength109 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance109 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance109 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance109 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength110 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance110 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance110 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance110 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength111 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance111 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance111 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance111 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength112 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance112 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance112 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance112 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength113 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance113 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance113 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance113 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength114 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance114 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance114 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance114 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength115 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance115 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance115 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance115 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength116 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance116 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance116 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance116 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength117 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance117 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance117 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance117 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength118 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance118 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance118 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance118 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength119 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance119 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance119 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance119 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength120 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance120 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance120 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance120 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength121 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance121 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance121 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance121 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength122 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance122 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance122 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance122 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength123 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance123 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance123 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance123 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength124 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance124 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance124 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance124 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength125 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance125 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance125 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance125 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength126 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance126 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance126 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance126 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength127 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance127 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance127 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance127 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength128 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance128 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance128 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance128 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength129 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance129 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance129 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance129 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength130 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance130 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance130 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance130 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength131 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance131 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance131 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance131 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength132 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance132 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance132 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance132 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength133 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance133 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance133 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance133 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength134 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance134 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance134 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance134 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength135 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance135 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance135 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance135 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength136 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance136 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance136 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance136 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength137 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance137 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance137 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance137 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength138 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance138 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance138 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance138 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength139 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance139 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance139 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance139 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength140 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance140 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance140 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance140 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength141 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance141 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance141 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance141 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength142 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance142 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance142 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance142 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength143 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance143 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance143 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance143 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength144 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance144 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance144 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance144 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength145 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance145 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance145 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance145 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength146 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance146 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance146 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance146 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength147 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance147 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance147 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance147 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength148 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance148 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance148 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance148 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength149 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance149 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance149 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance149 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength150 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance150 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance150 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance150 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength151 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance151 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance151 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance151 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength152 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance152 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance152 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance152 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength153 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance153 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance153 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance153 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength154 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance154 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance154 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance154 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength155 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance155 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance155 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance155 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength156 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance156 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance156 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance156 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength157 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance157 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance157 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance157 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength158 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance158 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance158 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance158 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength159 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance159 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance159 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance159 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength160 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance160 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance160 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance160 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength161 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance161 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance161 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance161 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength162 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance162 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance162 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance162 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength163 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance163 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance163 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance163 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength164 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance164 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance164 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance164 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength165 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance165 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance165 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance165 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength166 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance166 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance166 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance166 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength167 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance167 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance167 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance167 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength168 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance168 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance168 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance168 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength169 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance169 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance169 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance169 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength170 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance170 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance170 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance170 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength171 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance171 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance171 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance171 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength172 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance172 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance172 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance172 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength173 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance173 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance173 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance173 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength174 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance174 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance174 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance174 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength175 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance175 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance175 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance175 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength176 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance176 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance176 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance176 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength177 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance177 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance177 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance177 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength178 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance178 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance178 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance178 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength179 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance179 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance179 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance179 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength180 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance180 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance180 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance180 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength181 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance181 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance181 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance181 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength182 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance182 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance182 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance182 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength183 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance183 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance183 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance183 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength184 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance184 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance184 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance184 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength185 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance185 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance185 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance185 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength186 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance186 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance186 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance186 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength187 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance187 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance187 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance187 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength188 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance188 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance188 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance188 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength189 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance189 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance189 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance189 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength190 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance190 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance190 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance190 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength191 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance191 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance191 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance191 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength192 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance192 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance192 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance192 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength193 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance193 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance193 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance193 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength194 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance194 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance194 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance194 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength195 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance195 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance195 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance195 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength196 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance196 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance196 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance196 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength197 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance197 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance197 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance197 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength198 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance198 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance198 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance198 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength199 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance199 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance199 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance199 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength200 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance200 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance200 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance200 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength201 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance201 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance201 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance201 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength202 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance202 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance202 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance202 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength203 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance203 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance203 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance203 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength204 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance204 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance204 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance204 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength205 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance205 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance205 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance205 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength206 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance206 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance206 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance206 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength207 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance207 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance207 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance207 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength208 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance208 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance208 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance208 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength209 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance209 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance209 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance209 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength210 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance210 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance210 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance210 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength211 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance211 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance211 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance211 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength212 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance212 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance212 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance212 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength213 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance213 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance213 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance213 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength214 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance214 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance214 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance214 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength215 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance215 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance215 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance215 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength216 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance216 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance216 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance216 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength217 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance217 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance217 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance217 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength218 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance218 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance218 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance218 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength219 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance219 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance219 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance219 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength220 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance220 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance220 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance220 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength221 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance221 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance221 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance221 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength222 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance222 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance222 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance222 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength223 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance223 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance223 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance223 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength224 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance224 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance224 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance224 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength225 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance225 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance225 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance225 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength226 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance226 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance226 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance226 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength227 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance227 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance227 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance227 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength228 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance228 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance228 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance228 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength229 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance229 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance229 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance229 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength230 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance230 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance230 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance230 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength231 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance231 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance231 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance231 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength232 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance232 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance232 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance232 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength233 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance233 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance233 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance233 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength234 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance234 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance234 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance234 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength235 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance235 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance235 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance235 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength236 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance236 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance236 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance236 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength237 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance237 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance237 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance237 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength238 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance238 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance238 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance238 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength239 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance239 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance239 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance239 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength240 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance240 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance240 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance240 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength241 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance241 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance241 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance241 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength242 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance242 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance242 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance242 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength243 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance243 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance243 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance243 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength244 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance244 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance244 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance244 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength245 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance245 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance245 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance245 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength246 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance246 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance246 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance246 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength247 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance247 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance247 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance247 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength248 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance248 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance248 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance248 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength249 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance249 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance249 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance249 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength250 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance250 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance250 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance250 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength251 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance251 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance251 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance251 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength252 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance252 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance252 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance252 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength253 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance253 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance253 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance253 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength254 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance254 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance254 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance254 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength255 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance255 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance255 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance255 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength256 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance256 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance256 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance256 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength257 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance257 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance257 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance257 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength258 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance258 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance258 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance258 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength259 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance259 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance259 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance259 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength260 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance260 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance260 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance260 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength261 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance261 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance261 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance261 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength262 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance262 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance262 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance262 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength263 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance263 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance263 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance263 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength264 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance264 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance264 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance264 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength265 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance265 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance265 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance265 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength266 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance266 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance266 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance266 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength267 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance267 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance267 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance267 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength268 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance268 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance268 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance268 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength269 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance269 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance269 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance269 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength270 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance270 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance270 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance270 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength271 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance271 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance271 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance271 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength272 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance272 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance272 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance272 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength273 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance273 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance273 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance273 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength274 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance274 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance274 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance274 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength275 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance275 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance275 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance275 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength276 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance276 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance276 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance276 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength277 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance277 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance277 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance277 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength278 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance278 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance278 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance278 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength279 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance279 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance279 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance279 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength280 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance280 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance280 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance280 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength281 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance281 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance281 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance281 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength282 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance282 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance282 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance282 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength283 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance283 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance283 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance283 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength284 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance284 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance284 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance284 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength285 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance285 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance285 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance285 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength286 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance286 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance286 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance286 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength287 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance287 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance287 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance287 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength288 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance288 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance288 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance288 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength289 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance289 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance289 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance289 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength290 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance290 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance290 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance290 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength291 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance291 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance291 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance291 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength292 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance292 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance292 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance292 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength293 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance293 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance293 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance293 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength294 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance294 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance294 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance294 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength295 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance295 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance295 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance295 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength296 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance296 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance296 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance296 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength297 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance297 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance297 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance297 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength298 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance298 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance298 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance298 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength299 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance299 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance299 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance299 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength300 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance300 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance300 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance300 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength301 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance301 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance301 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance301 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength302 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance302 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance302 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance302 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength303 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance303 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance303 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance303 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength304 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance304 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance304 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance304 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength305 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance305 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance305 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance305 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength306 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance306 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance306 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance306 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength307 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance307 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance307 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance307 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength308 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance308 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance308 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance308 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength309 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance309 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance309 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance309 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength310 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance310 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance310 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance310 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength311 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance311 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance311 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance311 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength312 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance312 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance312 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance312 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength313 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance313 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance313 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance313 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength314 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance314 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance314 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance314 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength315 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance315 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance315 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance315 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength316 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance316 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance316 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance316 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength317 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance317 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance317 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance317 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength318 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance318 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance318 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance318 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength319 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance319 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance319 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance319 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength320 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance320 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance320 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance320 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength321 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance321 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance321 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance321 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength322 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance322 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance322 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance322 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength323 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance323 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance323 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance323 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength324 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance324 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance324 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance324 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength325 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance325 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance325 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance325 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength326 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance326 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance326 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance326 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength327 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance327 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance327 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance327 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength328 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance328 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance328 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance328 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength329 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance329 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance329 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance329 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength330 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance330 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance330 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance330 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength331 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance331 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance331 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance331 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength332 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance332 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance332 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance332 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength333 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance333 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance333 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance333 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength334 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance334 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance334 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance334 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength335 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance335 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance335 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance335 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength336 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance336 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance336 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance336 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength337 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance337 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance337 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance337 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength338 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance338 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance338 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance338 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength339 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance339 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance339 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance339 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength340 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance340 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance340 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance340 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength341 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance341 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance341 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance341 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength342 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance342 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance342 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance342 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength343 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance343 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance343 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance343 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength344 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance344 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance344 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance344 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength345 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance345 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance345 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance345 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength346 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance346 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance346 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance346 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength347 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance347 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance347 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance347 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength348 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance348 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance348 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance348 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength349 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance349 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance349 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance349 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength350 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance350 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance350 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance350 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength351 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance351 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance351 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance351 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength352 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance352 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance352 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance352 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength353 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance353 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance353 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance353 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength354 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance354 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance354 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance354 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength355 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance355 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance355 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance355 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength356 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance356 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance356 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance356 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength357 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance357 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance357 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance357 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength358 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance358 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance358 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance358 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength359 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance359 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance359 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance359 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength360 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance360 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance360 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance360 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength361 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance361 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance361 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance361 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength362 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance362 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance362 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance362 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength363 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance363 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance363 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance363 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength364 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance364 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance364 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance364 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength365 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance365 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance365 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance365 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength366 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance366 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance366 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance366 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength367 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance367 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance367 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance367 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength368 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance368 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance368 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance368 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength369 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance369 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance369 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance369 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength370 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance370 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance370 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance370 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength371 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance371 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance371 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance371 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength372 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance372 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance372 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance372 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength373 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance373 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance373 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance373 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength374 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance374 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance374 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance374 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength375 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance375 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance375 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance375 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength376 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance376 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance376 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance376 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength377 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance377 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance377 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance377 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength378 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance378 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance378 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance378 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength379 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance379 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance379 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance379 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength380 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance380 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance380 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance380 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength381 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance381 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance381 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance381 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength382 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance382 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance382 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance382 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength383 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance383 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance383 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance383 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength384 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance384 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance384 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance384 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength385 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance385 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance385 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance385 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength386 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance386 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance386 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance386 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength387 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance387 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance387 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance387 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength388 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance388 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance388 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance388 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength389 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance389 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance389 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance389 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength390 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance390 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance390 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance390 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength391 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance391 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance391 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance391 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength392 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance392 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance392 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance392 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength393 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance393 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance393 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance393 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength394 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance394 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance394 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance394 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength395 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance395 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance395 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance395 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength396 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance396 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance396 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance396 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength397 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance397 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance397 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance397 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength398 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance398 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance398 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance398 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength399 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance399 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance399 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance399 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength400 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance400 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance400 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance400 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength401 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance401 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance401 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance401 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength402 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance402 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance402 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance402 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength403 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance403 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance403 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance403 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength404 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance404 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance404 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance404 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength405 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance405 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance405 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance405 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength406 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance406 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance406 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance406 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength407 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance407 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance407 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance407 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength408 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance408 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance408 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance408 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength409 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance409 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance409 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance409 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength410 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance410 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance410 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance410 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength411 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance411 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance411 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance411 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength412 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance412 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance412 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance412 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength413 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance413 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance413 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance413 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength414 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance414 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance414 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance414 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength415 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance415 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance415 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance415 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength416 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance416 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance416 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance416 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength417 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance417 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance417 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance417 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength418 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance418 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance418 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance418 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength419 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance419 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance419 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance419 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength420 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance420 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance420 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance420 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength421 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance421 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance421 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance421 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength422 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance422 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance422 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance422 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength423 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance423 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance423 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance423 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength424 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance424 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance424 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance424 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength425 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance425 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance425 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance425 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength426 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance426 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance426 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance426 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength427 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance427 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance427 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance427 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength428 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance428 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance428 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance428 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength429 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance429 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance429 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance429 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength430 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance430 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance430 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance430 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength431 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance431 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance431 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance431 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength432 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance432 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance432 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance432 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength433 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance433 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance433 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance433 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength434 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance434 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance434 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance434 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength435 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance435 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance435 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance435 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength436 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance436 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance436 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance436 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength437 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance437 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance437 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance437 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength438 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance438 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance438 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance438 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength439 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance439 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance439 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance439 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength440 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance440 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance440 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance440 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength441 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance441 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance441 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance441 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength442 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance442 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance442 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance442 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength443 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance443 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance443 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance443 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength444 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance444 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance444 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance444 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength445 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance445 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance445 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance445 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength446 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance446 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance446 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance446 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength447 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance447 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance447 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance447 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength448 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance448 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance448 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance448 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength449 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance449 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance449 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance449 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength450 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance450 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance450 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance450 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength451 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance451 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance451 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance451 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength452 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance452 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance452 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance452 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength453 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance453 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance453 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance453 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength454 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance454 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance454 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance454 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength455 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance455 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance455 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance455 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength456 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance456 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance456 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance456 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength457 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance457 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance457 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance457 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength458 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance458 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance458 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance458 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength459 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance459 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance459 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance459 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength460 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance460 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance460 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance460 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength461 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance461 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance461 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance461 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength462 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance462 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance462 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance462 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength463 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance463 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance463 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance463 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength464 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance464 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance464 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance464 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength465 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance465 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance465 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance465 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength466 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance466 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance466 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance466 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength467 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance467 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance467 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance467 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength468 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance468 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance468 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance468 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength469 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance469 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance469 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance469 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength470 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance470 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance470 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance470 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength471 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance471 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance471 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance471 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength472 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance472 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance472 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance472 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength473 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance473 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance473 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance473 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength474 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance474 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance474 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance474 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength475 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance475 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance475 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance475 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength476 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance476 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance476 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance476 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength477 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance477 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance477 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance477 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength478 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance478 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance478 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance478 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength479 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance479 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance479 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance479 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength480 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance480 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance480 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance480 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength481 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance481 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance481 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance481 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength482 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance482 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance482 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance482 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength483 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance483 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance483 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance483 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength484 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance484 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance484 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance484 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength485 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance485 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance485 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance485 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength486 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance486 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance486 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance486 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength487 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance487 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance487 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance487 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength488 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance488 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance488 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance488 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength489 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance489 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance489 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance489 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength490 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance490 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance490 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance490 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength491 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance491 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance491 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance491 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength492 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance492 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance492 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance492 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength493 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance493 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance493 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance493 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength494 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance494 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance494 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance494 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength495 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance495 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance495 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance495 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength496 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance496 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance496 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance496 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength497 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance497 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance497 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance497 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength498 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance498 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance498 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance498 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength499 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance499 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance499 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance499 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength500 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance500 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance500 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance500 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength501 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance501 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance501 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance501 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength502 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance502 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance502 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance502 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength503 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance503 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance503 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance503 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength504 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance504 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance504 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance504 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength505 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance505 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance505 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance505 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength506 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance506 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance506 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance506 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength507 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance507 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance507 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance507 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength508 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance508 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance508 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance508 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength509 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance509 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance509 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance509 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength510 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance510 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance510 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance510 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength511 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance511 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance511 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance511 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength512 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance512 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance512 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance512 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength513 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance513 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance513 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance513 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength514 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance514 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance514 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance514 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength515 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance515 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance515 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance515 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength516 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance516 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance516 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance516 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength517 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance517 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance517 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance517 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength518 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance518 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance518 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance518 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength519 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance519 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance519 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance519 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength520 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance520 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance520 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance520 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength521 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance521 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance521 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance521 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength522 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance522 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance522 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance522 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength523 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance523 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance523 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance523 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength524 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance524 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance524 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance524 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength525 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance525 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance525 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance525 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength526 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance526 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance526 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance526 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength527 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance527 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance527 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance527 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength528 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance528 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance528 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance528 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength529 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance529 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance529 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance529 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength530 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance530 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance530 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance530 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength531 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance531 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance531 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance531 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength532 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance532 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance532 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance532 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength533 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance533 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance533 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance533 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength534 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance534 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance534 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance534 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength535 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance535 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance535 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance535 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength536 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance536 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance536 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance536 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength537 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance537 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance537 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance537 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength538 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance538 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance538 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance538 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength539 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance539 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance539 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance539 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength540 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance540 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance540 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance540 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength541 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance541 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance541 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance541 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength542 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance542 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance542 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance542 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength543 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance543 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance543 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance543 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength544 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance544 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance544 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance544 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength545 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance545 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance545 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance545 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength546 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance546 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance546 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance546 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength547 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance547 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance547 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance547 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength548 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance548 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance548 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance548 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength549 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance549 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance549 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance549 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength550 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance550 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance550 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance550 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength551 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance551 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance551 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance551 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength552 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance552 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance552 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance552 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength553 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance553 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance553 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance553 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength554 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance554 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance554 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance554 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength555 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance555 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance555 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance555 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength556 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance556 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance556 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance556 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength557 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance557 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance557 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance557 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength558 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance558 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance558 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance558 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength559 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance559 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance559 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance559 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength560 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance560 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance560 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance560 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength561 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance561 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance561 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance561 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength562 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance562 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance562 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance562 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength563 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance563 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance563 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance563 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength564 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance564 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance564 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance564 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength565 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance565 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance565 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance565 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength566 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance566 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance566 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance566 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength567 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance567 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance567 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance567 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength568 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance568 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance568 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance568 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength569 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance569 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance569 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance569 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength570 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance570 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance570 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance570 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength571 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance571 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance571 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance571 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength572 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance572 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance572 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance572 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength573 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance573 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance573 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance573 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength574 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance574 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance574 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance574 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength575 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance575 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance575 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance575 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength576 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance576 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance576 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance576 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength577 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance577 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance577 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance577 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength578 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance578 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance578 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance578 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength579 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance579 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance579 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance579 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength580 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance580 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance580 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance580 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength581 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance581 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance581 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance581 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength582 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance582 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance582 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance582 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength583 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance583 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance583 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance583 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength584 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance584 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance584 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance584 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength585 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance585 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance585 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance585 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength586 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance586 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance586 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance586 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength587 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance587 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance587 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance587 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength588 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance588 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance588 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance588 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength589 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance589 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance589 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance589 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength590 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance590 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance590 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance590 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength591 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance591 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance591 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance591 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength592 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance592 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance592 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance592 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength593 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance593 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance593 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance593 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength594 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance594 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance594 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance594 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength595 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance595 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance595 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance595 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength596 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance596 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance596 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance596 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength597 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance597 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance597 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance597 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength598 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance598 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance598 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance598 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength599 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance599 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance599 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance599 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength600 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance600 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance600 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance600 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength601 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance601 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance601 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance601 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength602 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance602 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance602 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance602 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength603 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance603 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance603 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance603 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength604 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance604 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance604 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance604 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength605 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance605 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance605 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance605 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength606 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance606 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance606 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance606 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength607 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance607 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance607 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance607 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength608 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance608 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance608 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance608 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength609 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance609 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance609 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance609 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength610 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance610 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance610 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance610 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength611 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance611 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance611 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance611 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength612 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance612 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance612 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance612 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength613 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance613 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance613 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance613 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength614 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance614 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance614 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance614 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength615 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance615 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance615 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance615 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength616 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance616 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance616 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance616 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength617 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance617 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance617 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance617 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength618 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance618 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance618 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance618 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength619 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance619 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance619 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance619 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength620 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance620 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance620 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance620 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength621 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance621 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance621 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance621 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength622 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance622 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance622 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance622 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength623 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance623 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance623 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance623 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength624 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance624 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance624 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance624 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength625 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance625 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance625 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance625 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength626 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance626 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance626 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance626 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength627 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance627 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance627 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance627 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength628 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance628 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance628 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance628 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength629 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance629 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance629 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance629 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength630 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance630 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance630 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance630 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength631 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance631 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance631 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance631 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength632 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance632 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance632 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance632 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength633 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance633 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance633 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance633 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength634 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance634 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance634 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance634 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength635 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance635 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance635 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance635 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength636 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance636 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance636 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance636 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength637 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance637 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance637 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance637 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength638 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance638 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance638 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance638 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength639 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance639 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance639 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance639 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength640 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance640 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance640 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance640 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength641 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance641 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance641 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance641 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength642 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance642 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance642 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance642 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength643 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance643 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance643 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance643 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength644 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance644 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance644 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance644 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength645 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance645 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance645 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance645 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength646 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance646 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance646 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance646 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength647 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance647 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance647 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance647 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength648 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance648 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance648 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance648 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength649 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance649 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance649 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance649 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength650 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance650 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance650 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance650 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength651 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance651 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance651 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance651 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength652 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance652 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance652 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance652 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength653 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance653 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance653 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance653 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength654 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance654 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance654 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance654 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength655 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance655 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance655 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance655 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength656 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance656 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance656 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance656 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength657 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance657 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance657 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance657 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength658 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance658 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance658 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance658 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength659 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance659 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance659 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance659 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength660 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance660 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance660 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance660 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength661 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance661 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance661 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance661 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength662 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance662 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance662 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance662 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength663 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance663 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance663 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance663 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength664 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance664 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance664 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance664 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength665 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance665 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance665 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance665 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength666 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance666 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance666 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance666 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength667 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance667 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance667 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance667 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength668 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance668 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance668 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance668 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength669 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance669 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance669 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance669 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength670 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance670 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance670 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance670 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength671 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance671 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance671 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance671 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength672 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance672 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance672 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance672 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength673 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance673 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance673 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance673 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength674 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance674 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance674 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance674 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength675 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance675 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance675 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance675 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength676 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance676 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance676 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance676 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength677 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance677 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance677 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance677 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength678 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance678 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance678 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance678 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength679 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance679 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance679 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance679 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength680 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance680 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance680 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance680 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength681 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance681 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance681 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance681 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength682 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance682 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance682 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance682 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength683 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance683 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance683 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance683 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength684 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance684 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance684 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance684 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength685 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance685 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance685 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance685 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength686 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance686 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance686 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance686 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength687 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance687 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance687 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance687 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength688 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance688 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance688 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance688 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength689 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance689 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance689 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance689 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength690 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance690 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance690 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance690 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength691 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance691 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance691 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance691 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength692 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance692 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance692 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance692 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength693 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance693 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance693 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance693 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength694 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance694 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance694 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance694 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength695 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance695 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance695 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance695 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength696 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance696 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance696 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance696 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength697 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance697 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance697 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance697 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength698 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance698 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance698 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance698 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength699 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance699 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance699 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance699 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength700 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance700 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance700 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance700 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength701 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance701 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance701 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance701 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength702 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance702 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance702 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance702 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength703 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance703 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance703 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance703 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength704 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance704 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance704 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance704 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength705 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance705 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance705 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance705 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength706 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance706 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance706 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance706 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength707 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance707 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance707 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance707 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength708 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance708 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance708 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance708 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength709 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance709 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance709 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance709 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength710 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance710 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance710 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance710 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength711 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance711 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance711 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance711 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength712 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance712 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance712 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance712 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength713 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance713 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance713 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance713 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength714 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance714 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance714 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance714 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength715 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance715 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance715 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance715 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength716 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance716 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance716 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance716 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength717 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance717 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance717 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance717 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength718 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance718 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance718 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance718 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength719 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance719 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance719 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance719 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength720 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance720 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance720 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance720 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength721 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance721 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance721 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance721 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength722 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance722 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance722 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance722 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength723 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance723 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance723 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance723 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength724 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance724 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance724 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance724 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength725 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance725 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance725 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance725 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength726 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance726 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance726 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance726 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength727 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance727 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance727 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance727 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength728 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance728 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance728 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance728 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength729 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance729 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance729 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance729 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength730 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance730 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance730 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance730 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength731 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance731 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance731 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance731 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength732 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance732 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance732 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance732 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength733 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance733 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance733 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance733 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength734 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance734 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance734 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance734 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength735 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance735 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance735 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance735 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength736 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance736 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance736 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance736 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength737 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance737 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance737 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance737 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength738 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance738 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance738 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance738 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength739 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance739 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance739 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance739 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength740 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance740 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance740 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance740 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength741 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance741 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance741 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance741 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength742 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance742 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance742 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance742 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength743 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance743 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance743 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance743 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength744 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance744 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance744 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance744 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength745 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance745 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance745 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance745 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength746 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance746 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance746 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance746 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength747 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance747 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance747 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance747 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength748 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance748 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance748 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance748 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength749 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance749 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance749 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance749 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength750 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance750 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance750 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance750 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength751 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance751 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance751 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance751 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength752 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance752 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance752 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance752 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength753 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance753 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance753 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance753 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength754 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance754 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance754 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance754 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength755 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance755 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance755 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance755 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength756 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance756 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance756 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance756 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength757 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance757 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance757 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance757 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength758 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance758 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance758 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance758 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength759 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance759 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance759 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance759 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength760 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance760 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance760 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance760 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength761 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance761 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance761 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance761 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength762 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance762 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance762 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance762 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength763 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance763 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance763 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance763 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength764 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance764 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance764 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance764 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength765 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance765 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance765 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance765 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength766 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance766 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance766 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance766 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength767 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance767 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance767 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance767 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength768 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance768 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance768 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance768 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength769 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance769 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance769 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance769 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength770 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance770 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance770 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance770 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength771 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance771 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance771 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance771 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength772 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance772 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance772 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance772 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength773 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance773 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance773 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance773 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength774 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance774 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance774 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance774 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength775 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance775 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance775 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance775 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength776 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance776 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance776 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance776 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength777 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance777 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance777 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance777 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength778 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance778 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance778 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance778 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength779 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance779 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance779 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance779 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength780 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance780 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance780 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance780 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength781 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance781 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance781 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance781 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength782 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance782 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance782 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance782 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength783 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance783 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance783 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance783 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength784 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance784 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance784 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance784 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength785 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance785 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance785 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance785 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength786 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance786 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance786 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance786 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength787 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance787 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance787 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance787 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength788 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance788 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance788 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance788 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength789 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance789 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance789 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance789 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength790 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance790 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance790 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance790 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength791 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance791 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance791 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance791 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength792 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance792 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance792 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance792 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength793 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance793 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance793 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance793 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength794 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance794 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance794 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance794 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength795 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance795 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance795 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance795 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength796 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance796 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance796 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance796 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength797 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance797 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance797 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance797 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength798 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance798 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance798 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance798 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength799 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance799 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance799 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance799 { get; set; } = new null;
////[Description("No description available")]
////public virtual real Wavelength800 { get; set; } = new real;
////[Description("No description available")]
////public virtual null Transmittance800 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FrontReflectance800 { get; set; } = new null;
////[Description("No description available")]
////public virtual null BackReflectance800 { get; set; } = new null;
////}
////}
