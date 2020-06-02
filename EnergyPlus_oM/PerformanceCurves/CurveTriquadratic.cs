////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Curve:Triquadratic : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual real Coefficient1Constant { get; set; } = new real;
////[Description("No description available")]
////public virtual real Coefficient2X**2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real Coefficient3X { get; set; } = new real;
////[Description("No description available")]
////public virtual real Coefficient4Y**2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real Coefficient5Y { get; set; } = new real;
////[Description("No description available")]
////public virtual real Coefficient6Z**2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real Coefficient7Z { get; set; } = new real;
////[Description("No description available")]
////public virtual real Coefficient8X**2*y**2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real Coefficient9X*y { get; set; } = new real;
////[Description("No description available")]
////public virtual real Coefficient10X*y**2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real Coefficient11X**2*y { get; set; } = new real;
////[Description("No description available")]
////public virtual real Coefficient12X**2*z**2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real Coefficient13X*z { get; set; } = new real;
////[Description("No description available")]
////public virtual real Coefficient14X*z**2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real Coefficient15X**2*z { get; set; } = new real;
////[Description("No description available")]
////public virtual real Coefficient16Y**2*z**2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real Coefficient17Y*z { get; set; } = new real;
////[Description("No description available")]
////public virtual real Coefficient18Y*z**2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real Coefficient19Y**2*z { get; set; } = new real;
////[Description("No description available")]
////public virtual real Coefficient20X**2*y**2*z**2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real Coefficient21X**2*y**2*z { get; set; } = new real;
////[Description("No description available")]
////public virtual real Coefficient22X**2*y*z**2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real Coefficient23X*y**2*z**2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real Coefficient24X**2*y*z { get; set; } = new real;
////[Description("No description available")]
////public virtual real Coefficient25X*y**2*z { get; set; } = new real;
////[Description("No description available")]
////public virtual real Coefficient26X*y*z**2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real Coefficient27X*y*z { get; set; } = new real;
////[Description("No description available")]
////public virtual real MinimumValueOfX { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumValueOfX { get; set; } = new real;
////[Description("No description available")]
////public virtual real MinimumValueOfY { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumValueOfY { get; set; } = new real;
////[Description("No description available")]
////public virtual real MinimumValueOfZ { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumValueOfZ { get; set; } = new real;
////[Description("Specify the minimum value calculated by this curve object")]
////public virtual real MinimumCurveOutput { get; set; } = new real;
////[Description("Specify the maximum value calculated by this curve object")]
////public virtual real MaximumCurveOutput { get; set; } = new real;
////[Description("No description available")]
////public virtual choice InputUnitTypeForX { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice InputUnitTypeForY { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice InputUnitTypeForZ { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice OutputUnitType { get; set; } = new choice;
////}
////}
