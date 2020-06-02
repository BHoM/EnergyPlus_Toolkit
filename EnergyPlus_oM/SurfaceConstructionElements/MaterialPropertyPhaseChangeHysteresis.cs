////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class MaterialProperty:PhaseChangeHysteresis : BHoMObject
////{
////[Description("Regular Material Name to which the additional properties will be added.")]
////public virtual object-list Name { get; set; } = new object-list;
////[Description("The total latent heat absorbed or rejected during the transition from solid to liquid, or back")]
////public virtual real LatentHeatDuringTheEntirePhaseChangeProcess { get; set; } = new real;
////[Description("The thermal conductivity used by this material when the material is fully liquid")]
////public virtual real LiquidStateThermalConductivity { get; set; } = new real;
////[Description("The density used by this material when the material is fully liquid")]
////public virtual real LiquidStateDensity { get; set; } = new real;
////[Description("The constant specific heat used for the fully melted (liquid) state")]
////public virtual real LiquidStateSpecificHeat { get; set; } = new real;
////[Description("The total melting range of the material is the sum of low and high temperature difference of melting curve.")]
////public virtual real HighTemperatureDifferenceOfMeltingCurve { get; set; } = new real;
////[Description("The temperature at which the melting curve peaks")]
////public virtual real PeakMeltingTemperature { get; set; } = new real;
////[Description("The total melting range of the material is the sum of low and high temperature difference of melting curve.")]
////public virtual real LowTemperatureDifferenceOfMeltingCurve { get; set; } = new real;
////[Description("The thermal conductivity used by this material when the material is fully solid")]
////public virtual real SolidStateThermalConductivity { get; set; } = new real;
////[Description("The density used by this material when the material is fully solid")]
////public virtual real SolidStateDensity { get; set; } = new real;
////[Description("The constant specific heat used for the fully frozen (crystallized) state")]
////public virtual real SolidStateSpecificHeat { get; set; } = new real;
////[Description("The total freezing range of the material is the sum of low and high temperature difference of freezing curve.")]
////public virtual real HighTemperatureDifferenceOfFreezingCurve { get; set; } = new real;
////[Description("The temperature at which the freezing curve peaks")]
////public virtual real PeakFreezingTemperature { get; set; } = new real;
////[Description("The total freezing range of the material is the sum of low and high temperature difference of freezing curve.")]
////public virtual real LowTemperatureDifferenceOfFreezingCurve { get; set; } = new real;
////}
////}
