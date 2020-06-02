////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Refrigeration:Condenser:WaterCooled : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Rating as per ARI 450")]
////public virtual real RatedEffectiveTotalHeatRejectionRate { get; set; } = new real;
////[Description("must correspond to rating given for total heat rejection effect")]
////public virtual real RatedCondensingTemperature { get; set; } = new real;
////[Description("must correspond to rating given for total heat rejection effect")]
////public virtual real RatedSubcoolingTemperatureDifference { get; set; } = new real;
////[Description("must correspond to rating given for total heat rejection effect")]
////public virtual real RatedWaterInletTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual node WaterInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node WaterOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual choice Water-CooledLoopFlowType { get; set; } = new choice;
////[Description("Applicable only when loop flow type is Variable Flow.")]
////public virtual object-list WaterOutletTemperatureScheduleName { get; set; } = new object-list;
////[Description("note required units must be converted from L/s as specified in ARI 450-2007")]
////public virtual real WaterDesignFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real WaterMaximumFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real WaterMaximumWaterOutletTemperature { get; set; } = new real;
////[Description("related to the minimum allowed refrigeration system condensing temperature")]
////public virtual real WaterMinimumWaterInletTemperature { get; set; } = new real;
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
