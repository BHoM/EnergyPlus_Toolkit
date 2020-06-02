////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class UtilityCost:Tariff : BHoMObject
////{
////[Description("The name of the tariff. Tariffs are sometimes called rates. The name is used in identifying")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("The name of any standard meter or custom meter or but usually set to either Electricity:Facility or Gas:Facility")]
////public virtual external-list OutputMeterName { get; set; } = new external-list;
////[Description("A choice that allows several different predefined conversion factors to be used; otherwise user")]
////public virtual choice ConversionFactorChoice { get; set; } = new choice;
////[Description("Is a multiplier used to convert energy into the units specified by the utility in their tariff. If")]
////public virtual real EnergyConversionFactor { get; set; } = new real;
////[Description("Is a multiplier used to convert demand into the units specified by the utility in their tariff. If")]
////public virtual real DemandConversionFactor { get; set; } = new real;
////[Description("The name of the schedule that defines the time-of-use periods that occur each day. The values for the")]
////public virtual object-list TimeOfUsePeriodScheduleName { get; set; } = new object-list;
////[Description("The name of a schedule that defines the seasons. The schedule values are: 1 for Winter. 2 for Spring.")]
////public virtual object-list SeasonScheduleName { get; set; } = new object-list;
////[Description("The name of the schedule that defines the billing periods of the year. Normally this entry is allowed")]
////public virtual object-list MonthScheduleName { get; set; } = new object-list;
////[Description("The determination of demand can vary by utility. Some utilities use the peak instantaneous demand")]
////public virtual choice DemandWindowLength { get; set; } = new choice;
////[Description("The fixed monthly service charge that many utilities have. The entry may be numeric and gets added to")]
////public virtual null MonthlyChargeOrVariableName { get; set; } = new null;
////[Description("The minimum total charge for the tariff or if a variable name is entered here its")]
////public virtual null MinimumMonthlyChargeOrVariableName { get; set; } = new null;
////[Description("Used with real time pricing rates. The name of a schedule that contains the cost of")]
////public virtual object-list RealTimePricingChargeScheduleName { get; set; } = new object-list;
////[Description("Used with real time pricing rates. The name of a schedule that contains the baseline")]
////public virtual object-list CustomerBaselineLoadScheduleName { get; set; } = new object-list;
////[Description("The group name of the tariff such as distribution transmission supplier etc. If more than one tariff")]
////public virtual null GroupName { get; set; } = new null;
////[Description("Sets whether the tariff is used for buying selling or both to the utility. This")]
////public virtual choice BuyOrSell { get; set; } = new choice;
////}
////}
