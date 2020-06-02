////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class SolarCollector:UnglazedTranspired : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Enter the name of a SurfaceProperty:OtherSideConditionsModel object")]
////public virtual object-list BoundaryConditionsModelName { get; set; } = new object-list;
////[Description("Availability schedule name for this collector. Schedule value > 0 means it is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("required field if no SolarCollector:UnglazedTranspired:Multisystem")]
////public virtual node InletNodeName { get; set; } = new node;
////[Description("required field if no SolarCollector:UnglazedTranspired:Multisystem")]
////public virtual node OutletNodeName { get; set; } = new node;
////[Description("This node is where the mixed air setpoint is determined.")]
////public virtual node SetpointNodeName { get; set; } = new node;
////[Description("This node is used to identify the affected zone")]
////public virtual node ZoneNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual object-list FreeHeatingSetpointScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DiameterOfPerforationsInCollector { get; set; } = new real;
////[Description("No description available")]
////public virtual real DistanceBetweenPerforationsInCollector { get; set; } = new real;
////[Description("No description available")]
////public virtual real ThermalEmissivityOfCollectorSurface { get; set; } = new real;
////[Description("No description available")]
////public virtual real SolarAbsorbtivityOfCollectorSurface { get; set; } = new real;
////[Description("No description available")]
////public virtual real EffectiveOverallHeightOfCollector { get; set; } = new real;
////[Description("if corrugated, use average depth")]
////public virtual real EffectiveGapThicknessOfPlenumBehindCollector { get; set; } = new real;
////[Description("if corrugated, use average depth")]
////public virtual real EffectiveCrossSectionAreaOfPlenumBehindCollector { get; set; } = new real;
////[Description("No description available")]
////public virtual choice HoleLayoutPatternForPitch { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice HeatExchangeEffectivenessCorrelation { get; set; } = new choice;
////[Description("This parameter is used to help account for corrugations in the collector")]
////public virtual real RatioOfActualCollectorSurfaceAreaToProjectedSurfaceArea { get; set; } = new real;
////[Description("No description available")]
////public virtual choice RoughnessOfCollector { get; set; } = new choice;
////[Description("Collector thickness is not required for Kutscher correlation")]
////public virtual real CollectorThickness { get; set; } = new real;
////[Description("Cv")]
////public virtual real EffectivenessForPerforationsWithRespectToWind { get; set; } = new real;
////[Description("Cd")]
////public virtual real DischargeCoefficientForOpeningsWithRespectToBuoyancyDrivenFlow { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list Surface1Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list Surface2Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list Surface3Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list Surface4Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list Surface5Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list Surface6Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list Surface7Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list Surface8Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list Surface9Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list Surface10Name { get; set; } = new object-list;
////}
////}
