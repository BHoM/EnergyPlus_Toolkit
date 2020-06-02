////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Boiler:HotWater : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual choice FuelType { get; set; } = new choice;
////[Description("No description available")]
////public virtual real NominalCapacity { get; set; } = new real;
////[Description("Based on the higher heating value of fuel.")]
////public virtual real NominalThermalEfficiency { get; set; } = new real;
////[Description("No description available")]
////public virtual choice EfficiencyCurveTemperatureEvaluationVariable { get; set; } = new choice;
////[Description("Linear, Quadratic and Cubic efficiency curves are solely a function of PLR.")]
////public virtual object-list NormalizedBoilerEfficiencyCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DesignWaterFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real MinimumPartLoadRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumPartLoadRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real OptimumPartLoadRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual node BoilerWaterInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node BoilerWaterOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual real WaterOutletUpperTemperatureLimit { get; set; } = new real;
////[Description("Select operating mode for fluid flow through the boiler. "NotModulated" is for")]
////public virtual choice BoilerFlowMode { get; set; } = new choice;
////[Description("No description available")]
////public virtual real ParasiticElectricLoad { get; set; } = new real;
////[Description("Multiplies the autosized capacity and flow rates")]
////public virtual real SizingFactor { get; set; } = new real;
////[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Subcategory table.")]
////public virtual alpha End-UseSubcategory { get; set; } = new alpha;
////}
////}
