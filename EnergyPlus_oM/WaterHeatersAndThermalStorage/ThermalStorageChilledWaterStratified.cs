////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class ThermalStorage:ChilledWater:Stratified : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual real TankVolume { get; set; } = new real;
////[Description("Height is measured in the axial direction for horizontal cylinders")]
////public virtual real TankHeight { get; set; } = new real;
////[Description("No description available")]
////public virtual choice TankShape { get; set; } = new choice;
////[Description("Only used if Tank Shape is Other")]
////public virtual real TankPerimeter { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list SetpointTemperatureScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DeadbandTemperatureDifference { get; set; } = new real;
////[Description("No description available")]
////public virtual null TemperatureSensorHeight { get; set; } = new null;
////[Description("No description available")]
////public virtual real MinimumTemperatureLimit { get; set; } = new real;
////[Description("No description available")]
////public virtual real NominalCoolingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual choice AmbientTemperatureIndicator { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list AmbientTemperatureScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list AmbientTemperatureZoneName { get; set; } = new object-list;
////[Description("required for Ambient Temperature Indicator=Outdoors")]
////public virtual node AmbientTemperatureOutdoorAirNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual real UniformSkinLossCoefficientPerUnitAreaToAmbientTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual node UseSideInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node UseSideOutletNodeName { get; set; } = new node;
////[Description("The use side effectiveness in the stratified tank model is a simplified analogy of")]
////public virtual real UseSideHeatTransferEffectiveness { get; set; } = new real;
////[Description("Availability schedule name for use side. Schedule value > 0 means the system is available.")]
////public virtual object-list UseSideAvailabilityScheduleName { get; set; } = new object-list;
////[Description("Defaults to top of tank")]
////public virtual real UseSideInletHeight { get; set; } = new real;
////[Description("Defaults to bottom of tank")]
////public virtual real UseSideOutletHeight { get; set; } = new real;
////[Description("No description available")]
////public virtual real UseSideDesignFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual node SourceSideInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node SourceSideOutletNodeName { get; set; } = new node;
////[Description("The source side effectiveness in the stratified tank model is a simplified analogy of")]
////public virtual real SourceSideHeatTransferEffectiveness { get; set; } = new real;
////[Description("Availability schedule name for use side. Schedule value > 0 means the system is available.")]
////public virtual object-list SourceSideAvailabilityScheduleName { get; set; } = new object-list;
////[Description("Defaults to bottom of tank")]
////public virtual real SourceSideInletHeight { get; set; } = new real;
////[Description("Defaults to top of tank")]
////public virtual real SourceSideOutletHeight { get; set; } = new real;
////[Description("No description available")]
////public virtual real SourceSideDesignFlowRate { get; set; } = new real;
////[Description("Parameter for autosizing design flow rates for indirectly cooled water tanks")]
////public virtual real TankRecoveryTime { get; set; } = new real;
////[Description("No description available")]
////public virtual choice InletMode { get; set; } = new choice;
////[Description("No description available")]
////public virtual integer NumberOfNodes { get; set; } = new integer;
////[Description("No description available")]
////public virtual real AdditionalDestratificationConductivity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Node1AdditionalLossCoefficient { get; set; } = new real;
////[Description("No description available")]
////public virtual real Node2AdditionalLossCoefficient { get; set; } = new real;
////[Description("No description available")]
////public virtual real Node3AdditionalLossCoefficient { get; set; } = new real;
////[Description("No description available")]
////public virtual real Node4AdditionalLossCoefficient { get; set; } = new real;
////[Description("No description available")]
////public virtual real Node5AdditionalLossCoefficient { get; set; } = new real;
////[Description("No description available")]
////public virtual real Node6AdditionalLossCoefficient { get; set; } = new real;
////[Description("No description available")]
////public virtual real Node7AdditionalLossCoefficient { get; set; } = new real;
////[Description("No description available")]
////public virtual real Node8AdditionalLossCoefficient { get; set; } = new real;
////[Description("No description available")]
////public virtual real Node9AdditionalLossCoefficient { get; set; } = new real;
////[Description("No description available")]
////public virtual real Node10AdditionalLossCoefficient { get; set; } = new real;
////}
////}