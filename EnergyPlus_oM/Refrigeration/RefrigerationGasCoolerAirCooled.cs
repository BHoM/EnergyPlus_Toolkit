////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Refrigeration:GasCooler:AirCooled : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Be sure the rating corresponds to the correct refrigerant (R744)")]
////public virtual object-list RatedTotalHeatRejectionRateCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice GasCoolerFanSpeedControlType { get; set; } = new choice;
////[Description("Power for gas cooler fan(s) corresponding to rated total heat rejection effect.")]
////public virtual real RatedFanPower { get; set; } = new real;
////[Description("Minimum air flow fraction through gas cooler fan")]
////public virtual real MinimumFanAirFlowRatio { get; set; } = new real;
////[Description("Temperature at which system transitions between subcritical and transcritical operation.")]
////public virtual real TransitionTemperature { get; set; } = new real;
////[Description("Temperature difference between the CO2 exiting the gas cooler and the air entering the")]
////public virtual real TranscriticalApproachTemperature { get; set; } = new real;
////[Description("Temperature difference between the saturated condensing temperature and the air")]
////public virtual real SubcriticalTemperatureDifference { get; set; } = new real;
////[Description("Minimum saturated condensing temperature during subcritical operation.")]
////public virtual real MinimumCondensingTemperature { get; set; } = new real;
////[Description("If field is left blank,")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Subcategory table.")]
////public virtual alpha End-UseSubcategory { get; set; } = new alpha;
////[Description("optional input")]
////public virtual real GasCoolerRefrigerantOperatingChargeInventory { get; set; } = new real;
////[Description("optional input")]
////public virtual real GasCoolerReceiverRefrigerantInventory { get; set; } = new real;
////[Description("optional input")]
////public virtual real GasCoolerOutletPipingRefrigerantInventory { get; set; } = new real;
////}
////}
