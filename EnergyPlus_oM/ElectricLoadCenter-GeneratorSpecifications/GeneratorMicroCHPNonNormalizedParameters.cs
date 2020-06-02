//using BH.oM.Base;
//using System.Collections.Generic;
//using System.ComponentModel;
//
//namespace BH.oM.EnergyPlus
//{
//public class Generator:MicroCHP:NonNormalizedParameters : BHoMObject
//{
//[Description("No description available")]
//public virtual null Name { get; set; } = new null;
//[Description("No description available")]
//public virtual null MaximumElectricPower { get; set; } = new null;
//[Description("No description available")]
//public virtual null MinimumElectricPower { get; set; } = new null;
//[Description("No description available")]
//public virtual null MinimumCoolingWaterFlowRate { get; set; } = new null;
//[Description("No description available")]
//public virtual null MaximumCoolingWaterTemperature { get; set; } = new null;
//[Description("TriQuadratic")]
//public virtual object-list ElectricalEfficiencyCurveName { get; set; } = new object-list;
//[Description("TriQuadratic")]
//public virtual object-list ThermalEfficiencyCurveName { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice CoolingWaterFlowRateMode { get; set; } = new choice;
//[Description("No description available")]
//public virtual object-list CoolingWaterFlowRateCurveName { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list AirFlowRateCurveName { get; set; } = new object-list;
//[Description("No description available")]
//public virtual null MaximumNetElectricalPowerRateOfChange { get; set; } = new null;
//[Description("No description available")]
//public virtual null MaximumFuelFlowRateOfChange { get; set; } = new null;
//[Description("No description available")]
//public virtual null HeatExchangerU-FactorTimesAreaValue { get; set; } = new null;
//[Description("No description available")]
//public virtual null SkinLossU-FactorTimesAreaValue { get; set; } = new null;
//[Description("No description available")]
//public virtual real SkinLossRadiativeFraction { get; set; } = new real;
//[Description("No description available")]
//public virtual null AggregatedThermalMassOfEnergyConversionPortionOfGenerator { get; set; } = new null;
//[Description("No description available")]
//public virtual null AggregatedThermalMassOfHeatRecoveryPortionOfGenerator { get; set; } = new null;
//[Description("No description available")]
//public virtual null StandbyPower { get; set; } = new null;
//[Description("Stirling engines use Nominal Engine Temperature")]
//public virtual choice WarmUpMode { get; set; } = new choice;
//[Description("No description available")]
//public virtual null WarmUpFuelFlowRateCoefficient { get; set; } = new null;
//[Description("No description available")]
//public virtual null NominalEngineOperatingTemperature { get; set; } = new null;
//[Description("No description available")]
//public virtual null WarmUpPowerCoefficient { get; set; } = new null;
//[Description("No description available")]
//public virtual null WarmUpFuelFlowRateLimitRatio { get; set; } = new null;
//[Description("No description available")]
//public virtual null WarmUpDelayTime { get; set; } = new null;
//[Description("No description available")]
//public virtual null CoolDownPower { get; set; } = new null;
//[Description("No description available")]
//public virtual null CoolDownDelayTime { get; set; } = new null;
//[Description("No description available")]
//public virtual choice RestartMode { get; set; } = new choice;
//}
//}
