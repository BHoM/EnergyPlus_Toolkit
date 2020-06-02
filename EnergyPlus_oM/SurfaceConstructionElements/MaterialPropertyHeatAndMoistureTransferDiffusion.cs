////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class MaterialProperty:HeatAndMoistureTransfer:Diffusion : BHoMObject
////{
////[Description("Moisture Material Name that the moisture properties will be added to.")]
////public virtual object-list MaterialName { get; set; } = new object-list;
////[Description("Water Vapor Diffusion Resistance Factor")]
////public virtual integer NumberOfDataPairs { get; set; } = new integer;
////[Description("The relative humidity is entered as a fraction.")]
////public virtual null RelativeHumidityFraction1 { get; set; } = new null;
////[Description("No description available")]
////public virtual null WaterVaporDiffusionResistanceFactor1 { get; set; } = new null;
////[Description("The relative humidity is entered as a fraction.")]
////public virtual null RelativeHumidityFraction2 { get; set; } = new null;
////[Description("No description available")]
////public virtual null WaterVaporDiffusionResistanceFactor2 { get; set; } = new null;
////[Description("The relative humidity is entered as a fraction.")]
////public virtual null RelativeHumidityFraction3 { get; set; } = new null;
////[Description("No description available")]
////public virtual null WaterVaporDiffusionResistanceFactor3 { get; set; } = new null;
////[Description("The relative humidity is entered as a fraction.")]
////public virtual null RelativeHumidityFraction4 { get; set; } = new null;
////[Description("No description available")]
////public virtual null WaterVaporDiffusionResistanceFactor4 { get; set; } = new null;
////[Description("The relative humidity is entered as a fraction.")]
////public virtual null RelativeHumidityFraction5 { get; set; } = new null;
////[Description("No description available")]
////public virtual null WaterVaporDiffusionResistanceFactor5 { get; set; } = new null;
////[Description("The relative humidity is entered as a fraction.")]
////public virtual null RelativeHumidityFraction6 { get; set; } = new null;
////[Description("No description available")]
////public virtual null WaterVaporDiffusionResistanceFactor6 { get; set; } = new null;
////[Description("The relative humidity is entered as a fraction.")]
////public virtual null RelativeHumidityFraction7 { get; set; } = new null;
////[Description("No description available")]
////public virtual null WaterVaporDiffusionResistanceFactor7 { get; set; } = new null;
////[Description("The relative humidity is entered as a fraction.")]
////public virtual null RelativeHumidityFraction8 { get; set; } = new null;
////[Description("No description available")]
////public virtual null WaterVaporDiffusionResistanceFactor8 { get; set; } = new null;
////[Description("The relative humidity is entered as a fraction.")]
////public virtual null RelativeHumidityFraction9 { get; set; } = new null;
////[Description("No description available")]
////public virtual null WaterVaporDiffusionResistanceFactor9 { get; set; } = new null;
////[Description("The relative humidity is entered as a fraction.")]
////public virtual null RelativeHumidityFraction10 { get; set; } = new null;
////[Description("No description available")]
////public virtual null WaterVaporDiffusionResistanceFactor10 { get; set; } = new null;
////[Description("The relative humidity is entered as a fraction.")]
////public virtual null RelativeHumidityFraction11 { get; set; } = new null;
////[Description("No description available")]
////public virtual null WaterVaporDiffusionResistanceFactor11 { get; set; } = new null;
////[Description("The relative humidity is entered as a fraction.")]
////public virtual null RelativeHumidityFraction12 { get; set; } = new null;
////[Description("No description available")]
////public virtual null WaterVaporDiffusionResistanceFactor12 { get; set; } = new null;
////[Description("The relative humidity is entered as a fraction.")]
////public virtual null RelativeHumidityFraction13 { get; set; } = new null;
////[Description("No description available")]
////public virtual null WaterVaporDiffusionResistanceFactor13 { get; set; } = new null;
////[Description("The relative humidity is entered as a fraction.")]
////public virtual null RelativeHumidityFraction14 { get; set; } = new null;
////[Description("No description available")]
////public virtual null WaterVaporDiffusionResistanceFactor14 { get; set; } = new null;
////[Description("The relative humidity is entered as a fraction.")]
////public virtual null RelativeHumidityFraction15 { get; set; } = new null;
////[Description("No description available")]
////public virtual null WaterVaporDiffusionResistanceFactor15 { get; set; } = new null;
////[Description("The relative humidity is entered as a fraction.")]
////public virtual null RelativeHumidityFraction16 { get; set; } = new null;
////[Description("No description available")]
////public virtual null WaterVaporDiffusionResistanceFactor16 { get; set; } = new null;
////[Description("The relative humidity is entered as a fraction.")]
////public virtual null RelativeHumidityFraction17 { get; set; } = new null;
////[Description("No description available")]
////public virtual null WaterVaporDiffusionResistanceFactor17 { get; set; } = new null;
////[Description("The relative humidity is entered as a fraction.")]
////public virtual null RelativeHumidityFraction18 { get; set; } = new null;
////[Description("No description available")]
////public virtual null WaterVaporDiffusionResistanceFactor18 { get; set; } = new null;
////[Description("The relative humidity is entered as a fraction.")]
////public virtual null RelativeHumidityFraction19 { get; set; } = new null;
////[Description("No description available")]
////public virtual null WaterVaporDiffusionResistanceFactor19 { get; set; } = new null;
////[Description("The relative humidity is entered as a fraction.")]
////public virtual null RelativeHumidityFraction20 { get; set; } = new null;
////[Description("No description available")]
////public virtual null WaterVaporDiffusionResistanceFactor20 { get; set; } = new null;
////[Description("The relative humidity is entered as a fraction.")]
////public virtual null RelativeHumidityFraction21 { get; set; } = new null;
////[Description("No description available")]
////public virtual null WaterVaporDiffusionResistanceFactor21 { get; set; } = new null;
////[Description("The relative humidity is entered as a fraction.")]
////public virtual null RelativeHumidityFraction22 { get; set; } = new null;
////[Description("No description available")]
////public virtual null WaterVaporDiffusionResistanceFactor22 { get; set; } = new null;
////[Description("The relative humidity is entered as a fraction.")]
////public virtual null RelativeHumidityFraction23 { get; set; } = new null;
////[Description("No description available")]
////public virtual null WaterVaporDiffusionResistanceFactor23 { get; set; } = new null;
////[Description("The relative humidity is entered as a fraction.")]
////public virtual null RelativeHumidityFraction24 { get; set; } = new null;
////[Description("No description available")]
////public virtual null WaterVaporDiffusionResistanceFactor24 { get; set; } = new null;
////[Description("The relative humidity is entered as a fraction.")]
////public virtual null RelativeHumidityFraction25 { get; set; } = new null;
////[Description("No description available")]
////public virtual null WaterVaporDiffusionResistanceFactor25 { get; set; } = new null;
////}
////}
