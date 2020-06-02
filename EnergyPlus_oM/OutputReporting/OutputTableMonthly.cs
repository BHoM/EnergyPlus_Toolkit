////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Output:Table:Monthly : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual integer DigitsAfterDecimal { get; set; } = new integer;
////[Description("The name of an output variable or meter that is available in the RDD file.")]
////public virtual external-list VariableOrMeter1Name { get; set; } = new external-list;
////[Description("The method of aggregation for the selected variable or meter.")]
////public virtual choice AggregationTypeForVariableOrMeter1 { get; set; } = new choice;
////[Description("No description available")]
////public virtual external-list VariableOrMeter2Name { get; set; } = new external-list;
////[Description("See instructions under AggregationType01")]
////public virtual choice AggregationTypeForVariableOrMeter2 { get; set; } = new choice;
////[Description("No description available")]
////public virtual external-list VariableOrMeter3Name { get; set; } = new external-list;
////[Description("See instructions under AggregationType01")]
////public virtual choice AggregationTypeForVariableOrMeter3 { get; set; } = new choice;
////[Description("No description available")]
////public virtual external-list VariableOrMeter4Name { get; set; } = new external-list;
////[Description("See instructions under AggregationType01")]
////public virtual choice AggregationTypeForVariableOrMeter4 { get; set; } = new choice;
////[Description("No description available")]
////public virtual external-list VariableOrMeter5Name { get; set; } = new external-list;
////[Description("See instructions under AggregationType01")]
////public virtual choice AggregationTypeForVariableOrMeter5 { get; set; } = new choice;
////[Description("No description available")]
////public virtual external-list VariableOrMeter6Name { get; set; } = new external-list;
////[Description("See instructions under AggregationType01")]
////public virtual choice AggregationTypeForVariableOrMeter6 { get; set; } = new choice;
////[Description("No description available")]
////public virtual external-list VariableOrMeter7Name { get; set; } = new external-list;
////[Description("See instructions under AggregationType01")]
////public virtual choice AggregationTypeForVariableOrMeter7 { get; set; } = new choice;
////[Description("No description available")]
////public virtual external-list VariableOrMeter8Name { get; set; } = new external-list;
////[Description("See instructions under AggregationType01")]
////public virtual choice AggregationTypeForVariableOrMeter8 { get; set; } = new choice;
////[Description("No description available")]
////public virtual external-list VariableOrMeter9Name { get; set; } = new external-list;
////[Description("See instructions under AggregationType01")]
////public virtual choice AggregationTypeForVariableOrMeter9 { get; set; } = new choice;
////[Description("No description available")]
////public virtual external-list VariableOrMeter10Name { get; set; } = new external-list;
////[Description("See instructions under AggregationType01")]
////public virtual choice AggregationTypeForVariableOrMeter10 { get; set; } = new choice;
////[Description("No description available")]
////public virtual external-list VariableOrMeter11Name { get; set; } = new external-list;
////[Description("See instructions under AggregationType01")]
////public virtual choice AggregationTypeForVariableOrMeter11 { get; set; } = new choice;
////[Description("No description available")]
////public virtual external-list VariableOrMeter12Name { get; set; } = new external-list;
////[Description("See instructions under AggregationType01")]
////public virtual choice AggregationTypeForVariableOrMeter12 { get; set; } = new choice;
////[Description("No description available")]
////public virtual external-list VariableOrMeter13Name { get; set; } = new external-list;
////[Description("See instructions under AggregationType01")]
////public virtual choice AggregationTypeForVariableOrMeter13 { get; set; } = new choice;
////[Description("No description available")]
////public virtual external-list VariableOrMeter14Name { get; set; } = new external-list;
////[Description("See instructions under AggregationType01")]
////public virtual choice AggregationTypeForVariableOrMeter14 { get; set; } = new choice;
////[Description("No description available")]
////public virtual external-list VariableOrMeter15Name { get; set; } = new external-list;
////[Description("See instructions under AggregationType01")]
////public virtual choice AggregationTypeForVariableOrMeter15 { get; set; } = new choice;
////[Description("No description available")]
////public virtual external-list VariableOrMeter16Name { get; set; } = new external-list;
////[Description("See instructions under AggregationType01")]
////public virtual choice AggregationTypeForVariableOrMeter16 { get; set; } = new choice;
////[Description("No description available")]
////public virtual external-list VariableOrMeter17Name { get; set; } = new external-list;
////[Description("See instructions under AggregationType01")]
////public virtual choice AggregationTypeForVariableOrMeter17 { get; set; } = new choice;
////[Description("No description available")]
////public virtual external-list VariableOrMeter18Name { get; set; } = new external-list;
////[Description("See instructions under AggregationType01")]
////public virtual choice AggregationTypeForVariableOrMeter18 { get; set; } = new choice;
////[Description("No description available")]
////public virtual external-list VariableOrMeter19Name { get; set; } = new external-list;
////[Description("See instructions under AggregationType01")]
////public virtual choice AggregationTypeForVariableOrMeter19 { get; set; } = new choice;
////[Description("No description available")]
////public virtual external-list VariableOrMeter20Name { get; set; } = new external-list;
////[Description("See instructions under AggregationType01")]
////public virtual choice AggregationTypeForVariableOrMeter20 { get; set; } = new choice;
////[Description("No description available")]
////public virtual external-list VariableOrMeter21Name { get; set; } = new external-list;
////[Description("See instructions under AggregationType01")]
////public virtual choice AggregationTypeForVariableOrMeter21 { get; set; } = new choice;
////[Description("No description available")]
////public virtual external-list VariableOrMeter22Name { get; set; } = new external-list;
////[Description("See instructions under AggregationType01")]
////public virtual choice AggregationTypeForVariableOrMeter22 { get; set; } = new choice;
////[Description("No description available")]
////public virtual external-list VariableOrMeter23Name { get; set; } = new external-list;
////[Description("See instructions under AggregationType01")]
////public virtual choice AggregationTypeForVariableOrMeter23 { get; set; } = new choice;
////[Description("No description available")]
////public virtual external-list VariableOrMeter24Name { get; set; } = new external-list;
////[Description("See instructions under AggregationType01")]
////public virtual choice AggregationTypeForVariableOrMeter24 { get; set; } = new choice;
////[Description("No description available")]
////public virtual external-list VariableOrMeter25Name { get; set; } = new external-list;
////[Description("See instructions under AggregationType01")]
////public virtual choice AggregationTypeForVariableOrMeter25 { get; set; } = new choice;
////}
////}
