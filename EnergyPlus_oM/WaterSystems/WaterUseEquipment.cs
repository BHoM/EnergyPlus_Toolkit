////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class WaterUse:Equipment : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Subcategory table.")]
////public virtual alpha End-UseSubcategory { get; set; } = new alpha;
////[Description("No description available")]
////public virtual real PeakFlowRate { get; set; } = new real;
////[Description("Defaults to 1.0 at all times")]
////public virtual object-list FlowRateFractionScheduleName { get; set; } = new object-list;
////[Description("Defaults to hot water supply temperature")]
////public virtual object-list TargetTemperatureScheduleName { get; set; } = new object-list;
////[Description("Defaults to cold water supply temperature")]
////public virtual object-list HotWaterSupplyTemperatureScheduleName { get; set; } = new object-list;
////[Description("Defaults to water temperatures calculated by Site:WaterMainsTemperature object")]
////public virtual object-list ColdWaterSupplyTemperatureScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("Defaults to 0.0 at all times")]
////public virtual object-list SensibleFractionScheduleName { get; set; } = new object-list;
////[Description("Defaults to 0.0 at all times")]
////public virtual object-list LatentFractionScheduleName { get; set; } = new object-list;
////}
////}
