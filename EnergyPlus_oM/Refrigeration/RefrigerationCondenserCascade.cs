////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Refrigeration:Condenser:Cascade : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("This is the condensing temperature for the lower temperature secondary loop")]
////public virtual real RatedCondensingTemperature { get; set; } = new real;
////[Description("This is the difference between the condensing and evaporating temperatures")]
////public virtual real RatedApproachTemperatureDifference { get; set; } = new real;
////[Description("used for identification and rough system size error checking")]
////public virtual real RatedEffectiveTotalHeatRejectionRate { get; set; } = new real;
////[Description("Fixed keeps condensing temperature constant")]
////public virtual choice CondensingTemperatureControlType { get; set; } = new choice;
////[Description("optional input")]
////public virtual real CondenserRefrigerantOperatingChargeInventory { get; set; } = new real;
////[Description("optional input")]
////public virtual real CondensateReceiverRefrigerantInventory { get; set; } = new real;
////[Description("optional input")]
////public virtual real CondensatePipingRefrigerantInventory { get; set; } = new real;
////}
////}
