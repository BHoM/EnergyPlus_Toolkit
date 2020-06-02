////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Daylighting:Controls : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice DaylightingMethod { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice LightingControlType { get; set; } = new choice;
////[Description("No description available")]
////public virtual real MinimumInputPowerFractionForContinuousOrContinuousOffDimmingControl { get; set; } = new real;
////[Description("No description available")]
////public virtual real MinimumLightOutputFractionForContinuousOrContinuousOffDimmingControl { get; set; } = new real;
////[Description("The number of steps, excluding off, in a stepped lighting control system.")]
////public virtual integer NumberOfSteppedControlSteps { get; set; } = new integer;
////[Description("No description available")]
////public virtual real ProbabilityLightingWillBeResetWhenNeededInManualSteppedControl { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list GlareCalculationDaylightingReferencePointName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null GlareCalculationAzimuthAngleOfViewDirectionClockwiseFromZoneY-Axis { get; set; } = new null;
////[Description("The default is for general office work")]
////public virtual real MaximumAllowableDiscomfortGlareIndex { get; set; } = new real;
////[Description("Maximum surface area for nodes in gridding all surfaces in the DElight zone.")]
////public virtual real DElightGriddingResolution { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list DaylightingReferencePoint1Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real FractionOfZoneControlledByReferencePoint1 { get; set; } = new real;
////[Description("No description available")]
////public virtual real IlluminanceSetpointAtReferencePoint1 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list DaylightingReferencePoint2Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real FractionOfZoneControlledByReferencePoint2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real IlluminanceSetpointAtReferencePoint2 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list DaylightingReferencePoint3Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real FractionOfZoneControlledByReferencePoint3 { get; set; } = new real;
////[Description("No description available")]
////public virtual real IlluminanceSetpointAtReferencePoint3 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list DaylightingReferencePoint4Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real FractionOfZoneControlledByReferencePoint4 { get; set; } = new real;
////[Description("No description available")]
////public virtual real IlluminanceSetpointAtReferencePoint4 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list DaylightingReferencePoint5Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real FractionOfZoneControlledByReferencePoint5 { get; set; } = new real;
////[Description("No description available")]
////public virtual real IlluminanceSetpointAtReferencePoint5 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list DaylightingReferencePoint6Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real FractionOfZoneControlledByReferencePoint6 { get; set; } = new real;
////[Description("No description available")]
////public virtual real IlluminanceSetpointAtReferencePoint6 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list DaylightingReferencePoint7Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real FractionOfZoneControlledByReferencePoint7 { get; set; } = new real;
////[Description("No description available")]
////public virtual real IlluminanceSetpointAtReferencePoint7 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list DaylightingReferencePoint8Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real FractionOfZoneControlledByReferencePoint8 { get; set; } = new real;
////[Description("No description available")]
////public virtual real IlluminanceSetpointAtReferencePoint8 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list DaylightingReferencePoint9Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real FractionOfZoneControlledByReferencePoint9 { get; set; } = new real;
////[Description("No description available")]
////public virtual real IlluminanceSetpointAtReferencePoint9 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list DaylightingReferencePoint10Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real FractionOfZoneControlledByReferencePoint10 { get; set; } = new real;
////[Description("No description available")]
////public virtual real IlluminanceSetpointAtReferencePoint10 { get; set; } = new real;
////}
////}
