//using BH.oM.Base;
//using System.Collections.Generic;
//using System.ComponentModel;
//
//namespace BH.oM.EnergyPlus
//{
//public class Generator:InternalCombustionEngine : BHoMObject
//{
//[Description("No description available")]
//public virtual null Name { get; set; } = new null;
//[Description("No description available")]
//public virtual null RatedPowerOutput { get; set; } = new null;
//[Description("No description available")]
//public virtual null ElectricCircuitNodeName { get; set; } = new null;
//[Description("No description available")]
//public virtual null MinimumPartLoadRatio { get; set; } = new null;
//[Description("No description available")]
//public virtual null MaximumPartLoadRatio { get; set; } = new null;
//[Description("No description available")]
//public virtual null OptimumPartLoadRatio { get; set; } = new null;
//[Description("curve = a + b*PLR + c*PLR**2")]
//public virtual object-list ShaftPowerCurveName { get; set; } = new object-list;
//[Description("curve = a + b*PLR + c*PLR**2")]
//public virtual object-list JacketHeatRecoveryCurveName { get; set; } = new object-list;
//[Description("curve = a + b*PLR + c*PLR**2")]
//public virtual object-list LubeHeatRecoveryCurveName { get; set; } = new object-list;
//[Description("curve = a + b*PLR + c*PLR**2")]
//public virtual object-list TotalExhaustEnergyCurveName { get; set; } = new object-list;
//[Description("curve = a + b*PLR + c*PLR**2")]
//public virtual object-list ExhaustTemperatureCurveName { get; set; } = new object-list;
//[Description("curve = C1 * Generator Rated Power Output**C2")]
//public virtual null Coefficient1OfU-FactorTimesAreaCurve { get; set; } = new null;
//[Description("curve = C1 * Generator Rated Power Output**C2")]
//public virtual null Coefficient2OfU-FactorTimesAreaCurve { get; set; } = new null;
//[Description("No description available")]
//public virtual null MaximumExhaustFlowPerUnitOfPowerOutput { get; set; } = new null;
//[Description("No description available")]
//public virtual null DesignMinimumExhaustTemperature { get; set; } = new null;
//[Description("No description available")]
//public virtual null FuelHigherHeatingValue { get; set; } = new null;
//[Description("if non-zero, then inlet, outlet nodes must be entered.")]
//public virtual null DesignHeatRecoveryWaterFlowRate { get; set; } = new null;
//[Description("No description available")]
//public virtual node HeatRecoveryInletNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual node HeatRecoveryOutletNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual choice FuelType { get; set; } = new choice;
//[Description("No description available")]
//public virtual null HeatRecoveryMaximumTemperature { get; set; } = new null;
//}
//}
