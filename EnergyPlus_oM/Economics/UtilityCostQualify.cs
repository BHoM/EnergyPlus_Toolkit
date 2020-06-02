////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class UtilityCost:Qualify : BHoMObject
////{
////[Description("Displayed in the report if the tariff does not qualify")]
////public virtual null UtilityCostQualifyName { get; set; } = new null;
////[Description("The name of the UtilityCost:Tariff that is associated with this UtilityCost:Qualify.")]
////public virtual object-list TariffName { get; set; } = new object-list;
////[Description("The name of the variable used. For energy and demand the automatically created variables totalEnergy")]
////public virtual null VariableName { get; set; } = new null;
////[Description("No description available")]
////public virtual choice QualifyType { get; set; } = new choice;
////[Description("The minimum or maximum value for the qualify. If the variable has values that are less than this value")]
////public virtual null ThresholdValueOrVariableName { get; set; } = new null;
////[Description("If the UtilityCost:Qualify only applies to a season enter the season name. If this field is left blank")]
////public virtual choice Season { get; set; } = new choice;
////[Description("Uses the number in Number of Months in one of two different ways depending on the Threshold Test. If")]
////public virtual choice ThresholdTest { get; set; } = new choice;
////[Description("A number from 1 to 12. If no value entered 12 is assumed when the qualify type is minimum and 1 when")]
////public virtual null NumberOfMonths { get; set; } = new null;
////}
////}
