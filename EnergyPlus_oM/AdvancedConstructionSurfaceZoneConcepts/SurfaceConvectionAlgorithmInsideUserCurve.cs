////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class SurfaceConvectionAlgorithm:Inside:UserCurve : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("Controls which temperature is differenced from surface temperature when using the Hc value")]
////public virtual choice ReferenceTemperatureForConvectionHeatTransfer { get; set; } = new choice;
////[Description("Curve's "x" is absolute value of delta-T (Surface temperature minus reference temperature, (C))")]
////public virtual object-list HcFunctionOfTemperatureDifferenceCurveName { get; set; } = new object-list;
////[Description("Curve's "x" is absolute value of delta-T/Height (Surface temp minus Air temp)/(vertical length scale), (C/m)")]
////public virtual object-list HcFunctionOfTemperatureDifferenceDividedByHeightCurveName { get; set; } = new object-list;
////[Description("Curve's "x" is mechanical ACH (Air Changes per hour from mechanical air system), (1/hr)")]
////public virtual object-list HcFunctionOfAirChangeRateCurveName { get; set; } = new object-list;
////[Description("Curve's "x" is mechanical system air flow rate (m3/s) divided by zone's length along")]
////public virtual object-list HcFunctionOfAirSystemVolumeFlowRateDividedByZonePerimeterLengthCurveName { get; set; } = new object-list;
////}
////}
