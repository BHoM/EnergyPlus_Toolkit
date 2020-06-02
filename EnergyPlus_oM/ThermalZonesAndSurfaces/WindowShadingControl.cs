////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class WindowShadingControl : BHoMObject
////{
////[Description("Referenced by surfaces that are exterior windows")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("If multiple WindowShadingControl objects are used than the order that they deploy the window shades")]
////public virtual integer ShadingControlSequenceNumber { get; set; } = new integer;
////[Description("No description available")]
////public virtual choice ShadingType { get; set; } = new choice;
////[Description("Required if Shading Type = SwitchableGlazing")]
////public virtual object-list ConstructionWithShadingName { get; set; } = new object-list;
////[Description("OnIfScheduleAllows requires that Schedule Name be specified and")]
////public virtual choice ShadingControlType { get; set; } = new choice;
////[Description("Required if Shading Control Is Scheduled = Yes.")]
////public virtual object-list ScheduleName { get; set; } = new object-list;
////[Description("W/m2 for solar-based controls, W for cooling- or heating-based controls,")]
////public virtual real Setpoint { get; set; } = new real;
////[Description("If True, Schedule Name is required; if No, Schedule Name is not used.")]
////public virtual choice ShadingControlIsScheduled { get; set; } = new choice;
////[Description("If True and window is in a daylit zone, shading is on if zone's discomfort glare index exceeds")]
////public virtual choice GlareControlIsActive { get; set; } = new choice;
////[Description("Enter the name of a WindowMaterial:Shade, WindowMaterial:Screen or WindowMaterial:Blind object.")]
////public virtual object-list ShadingDeviceMaterialName { get; set; } = new object-list;
////[Description("Used only if Shading Type = InteriorBlind, ExteriorBlind or BetweenGlassBlind.")]
////public virtual choice TypeOfSlatAngleControlForBlinds { get; set; } = new choice;
////[Description("Used only if Shading Type = InteriorBlind, ExteriorBlind or BetweenGlassBlind.")]
////public virtual object-list SlatAngleScheduleName { get; set; } = new object-list;
////[Description("W/m2 for solar-based controls, deg C for temperature-based controls.")]
////public virtual real Setpoint2 { get; set; } = new real;
////[Description("Reference to the Daylighting:Controls object that provides the glare and illuminance control to the zone.")]
////public virtual object-list DaylightingControlObjectName { get; set; } = new object-list;
////[Description("When Sequential is used the list of fenestration surfaces are controlled individually in the order specified")]
////public virtual choice MultipleSurfaceControlType { get; set; } = new choice;
////[Description("When Multiple Surface Control Type is set to Sequential the shades will be deployed for the referenced surface objects in order.")]
////public virtual object-list FenestrationSurface1Name { get; set; } = new object-list;
////[Description("When Multiple Surface Control Type is set to Sequential the shades will be deployed for the referenced surface objects in order.")]
////public virtual object-list FenestrationSurface2Name { get; set; } = new object-list;
////[Description("When Multiple Surface Control Type is set to Sequential the shades will be deployed for the referenced surface objects in order.")]
////public virtual object-list FenestrationSurface3Name { get; set; } = new object-list;
////[Description("When Multiple Surface Control Type is set to Sequential the shades will be deployed for the referenced surface objects in order.")]
////public virtual object-list FenestrationSurface4Name { get; set; } = new object-list;
////[Description("When Multiple Surface Control Type is set to Sequential the shades will be deployed for the referenced surface objects in order.")]
////public virtual object-list FenestrationSurface5Name { get; set; } = new object-list;
////[Description("When Multiple Surface Control Type is set to Sequential the shades will be deployed for the referenced surface objects in order.")]
////public virtual object-list FenestrationSurface6Name { get; set; } = new object-list;
////[Description("When Multiple Surface Control Type is set to Sequential the shades will be deployed for the referenced surface objects in order.")]
////public virtual object-list FenestrationSurface7Name { get; set; } = new object-list;
////[Description("When Multiple Surface Control Type is set to Sequential the shades will be deployed for the referenced surface objects in order.")]
////public virtual object-list FenestrationSurface8Name { get; set; } = new object-list;
////[Description("When Multiple Surface Control Type is set to Sequential the shades will be deployed for the referenced surface objects in order.")]
////public virtual object-list FenestrationSurface9Name { get; set; } = new object-list;
////[Description("When Multiple Surface Control Type is set to Sequential the shades will be deployed for the referenced surface objects in order.")]
////public virtual object-list FenestrationSurface10Name { get; set; } = new object-list;
////}
////}
