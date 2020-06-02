////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class UtilityCost:Ratchet : BHoMObject
////{
////[Description("Ratchet Variable Name")]
////public virtual null Name { get; set; } = new null;
////[Description("The name of the UtilityCost:Tariff that is associated with this UtilityCost:Ratchet.")]
////public virtual object-list TariffName { get; set; } = new object-list;
////[Description("When the ratcheted value exceeds the baseline value for a month the ratcheted value is used but when the")]
////public virtual null BaselineSourceVariable { get; set; } = new null;
////[Description("The variable that the ratchet is calculated from. It is often but not always the same as the baseline")]
////public virtual null AdjustmentSourceVariable { get; set; } = new null;
////[Description("The name of the season that is being examined. The maximum value for all of the months in the named")]
////public virtual choice SeasonFrom { get; set; } = new choice;
////[Description("The name of the season when the ratchet would be calculated. This is most commonly Winter. The ratchet")]
////public virtual choice SeasonTo { get; set; } = new choice;
////[Description("Often the ratchet has a clause such as "the current month demand or 90% of the summer month demand". For")]
////public virtual null MultiplierValueOrVariableName { get; set; } = new null;
////[Description("A less common strategy is to say that the ratchet must be all demand greater than a value in this case")]
////public virtual null OffsetValueOrVariableName { get; set; } = new null;
////}
////}
