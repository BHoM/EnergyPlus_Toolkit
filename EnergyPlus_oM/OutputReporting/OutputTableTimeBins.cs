////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Output:Table:TimeBins : BHoMObject
////{
////[Description("use '*' (without quotes) to apply this variable to all keys")]
////public virtual null KeyValue { get; set; } = new null;
////[Description("No description available")]
////public virtual external-list VariableName { get; set; } = new external-list;
////[Description("The lowest value for the intervals being binned into.")]
////public virtual real IntervalStart { get; set; } = new real;
////[Description("The size of the bins starting with Interval start.")]
////public virtual real IntervalSize { get; set; } = new real;
////[Description("The number of bins used. The number of hours below the start of the")]
////public virtual integer IntervalCount { get; set; } = new integer;
////[Description("Optional schedule name. Binning is performed for non-zero hours.")]
////public virtual object-list ScheduleName { get; set; } = new object-list;
////[Description("Optional input on the type of units for the variable used by other fields in the object.")]
////public virtual choice VariableType { get; set; } = new choice;
////}
////}
