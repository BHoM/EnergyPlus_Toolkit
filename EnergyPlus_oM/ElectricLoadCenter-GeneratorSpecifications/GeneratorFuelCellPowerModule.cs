//using BH.oM.Base;
//using System.Collections.Generic;
//using System.ComponentModel;
//
//namespace BH.oM.EnergyPlus
//{
//public class Generator:FuelCell:PowerModule : BHoMObject
//{
//[Description("No description available")]
//public virtual null Name { get; set; } = new null;
//[Description("No description available")]
//public virtual choice EfficiencyCurveMode { get; set; } = new choice;
//[Description("No description available")]
//public virtual object-list EfficiencyCurveName { get; set; } = new object-list;
//[Description("This field is not used.")]
//public virtual null NominalEfficiency { get; set; } = new null;
//[Description("This field is not used")]
//public virtual null NominalElectricalPower { get; set; } = new null;
//[Description("this is Nstops in SOFC model specification")]
//public virtual null NumberOfStopsAtStartOfSimulation { get; set; } = new null;
//[Description("this is D in SOFC model specification")]
//public virtual null CyclingPerformanceDegradationCoefficient { get; set; } = new null;
//[Description("No description available")]
//public virtual null NumberOfRunHoursAtBeginningOfSimulation { get; set; } = new null;
//[Description("this is L in SOFC model specification")]
//public virtual null AccumulatedRunTimeDegradationCoefficient { get; set; } = new null;
//[Description("No description available")]
//public virtual null RunTimeDegradationInitiationTimeThreshold { get; set; } = new null;
//[Description("Maximum rate of change in electrical output [power increasing]")]
//public virtual null PowerUpTransientLimit { get; set; } = new null;
//[Description("Maximum rate of change in electrical output [power decreasing]")]
//public virtual null PowerDownTransientLimit { get; set; } = new null;
//[Description("Time from start up to normal operation")]
//public virtual null StartUpTime { get; set; } = new null;
//[Description("No description available")]
//public virtual null StartUpFuel { get; set; } = new null;
//[Description("No description available")]
//public virtual null StartUpElectricityConsumption { get; set; } = new null;
//[Description("No description available")]
//public virtual null StartUpElectricityProduced { get; set; } = new null;
//[Description("No description available")]
//public virtual null ShutDownTime { get; set; } = new null;
//[Description("No description available")]
//public virtual null ShutDownFuel { get; set; } = new null;
//[Description("No description available")]
//public virtual null ShutDownElectricityConsumption { get; set; } = new null;
//[Description("No description available")]
//public virtual null AncillaryElectricityConstantTerm { get; set; } = new null;
//[Description("No description available")]
//public virtual null AncillaryElectricityLinearTerm { get; set; } = new null;
//[Description("No description available")]
//public virtual choice SkinLossCalculationMode { get; set; } = new choice;
//[Description("No description available")]
//public virtual object-list ZoneName { get; set; } = new object-list;
//[Description("No description available")]
//public virtual null SkinLossRadiativeFraction { get; set; } = new null;
//[Description("No description available")]
//public virtual null ConstantSkinLossRate { get; set; } = new null;
//[Description("No description available")]
//public virtual null SkinLossU-FactorTimesAreaTerm { get; set; } = new null;
//[Description("curve is function of fuel use rate")]
//public virtual object-list SkinLossQuadraticCurveName { get; set; } = new object-list;
//[Description("No description available")]
//public virtual null DilutionAirFlowRate { get; set; } = new null;
//[Description("No description available")]
//public virtual null StackHeatLossToDilutionAir { get; set; } = new null;
//[Description("No description available")]
//public virtual node DilutionInletAirNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual node DilutionOutletAirNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual null MinimumOperatingPoint { get; set; } = new null;
//[Description("No description available")]
//public virtual null MaximumOperatingPoint { get; set; } = new null;
//}
//}
