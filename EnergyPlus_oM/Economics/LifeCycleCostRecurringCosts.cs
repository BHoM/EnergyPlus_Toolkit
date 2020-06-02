////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class LifeCycleCost:RecurringCosts : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual choice Category { get; set; } = new choice;
////[Description("Enter the cost in dollars (or the appropriate monetary unit) for the recurring costs. Enter")]
////public virtual real Cost { get; set; } = new real;
////[Description("Enter when the costs start. The First Year of Cost is based on the number of years past the")]
////public virtual choice StartOfCosts { get; set; } = new choice;
////[Description("This field and the Months From Start field together represent the time from either the start")]
////public virtual integer YearsFromStart { get; set; } = new integer;
////[Description("This field and the Years From Start field together represent the time from either the start")]
////public virtual integer MonthsFromStart { get; set; } = new integer;
////[Description("This field and the Repeat Period Months field indicate how much time elapses between")]
////public virtual integer RepeatPeriodYears { get; set; } = new integer;
////[Description("This field and the Repeat Period Years field indicate how much time elapses between")]
////public virtual integer RepeatPeriodMonths { get; set; } = new integer;
////[Description("Enter the annual escalation rate as a decimal. For a 1% rate enter the value 0.01.")]
////public virtual real AnnualEscalationRate { get; set; } = new real;
////}
////}
