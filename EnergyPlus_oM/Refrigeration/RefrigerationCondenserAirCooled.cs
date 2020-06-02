////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Refrigeration:Condenser:AirCooled : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Rating as per ARI 460")]
////public virtual object-list RatedEffectiveTotalHeatRejectionRateCurveName { get; set; } = new object-list;
////[Description("must correspond to rating given for total heat rejection effect")]
////public virtual real RatedSubcoolingTemperatureDifference { get; set; } = new real;
////[Description("No description available")]
////public virtual choice CondenserFanSpeedControlType { get; set; } = new choice;
////[Description("Power for condenser fan(s) corresponding to rated total heat rejection effect.")]
////public virtual real RatedFanPower { get; set; } = new real;
////[Description("Minimum air flow fraction through condenser fan")]
////public virtual real MinimumFanAirFlowRatio { get; set; } = new real;
////[Description("If field is left blank,")]
////public virtual node AirInletNodeNameOrZoneName { get; set; } = new node;
////[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Subcategory table.")]
////public virtual alpha End-UseSubcategory { get; set; } = new alpha;
////[Description("optional input")]
////public virtual real CondenserRefrigerantOperatingChargeInventory { get; set; } = new real;
////[Description("optional input")]
////public virtual real CondensateReceiverRefrigerantInventory { get; set; } = new real;
////[Description("optional input")]
////public virtual real CondensatePipingRefrigerantInventory { get; set; } = new real;
////}
////}
