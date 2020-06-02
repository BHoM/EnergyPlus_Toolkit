////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Sizing:Plant : BHoMObject
////{
////[Description("Enter the name of a PlantLoop or a CondenserLoop object")]
////public virtual object-list PlantOrCondenserLoopName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice LoopType { get; set; } = new choice;
////[Description("No description available")]
////public virtual real DesignLoopExitTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual real LoopDesignTemperatureDifference { get; set; } = new real;
////[Description("if Coincident is chosen, then sizing is based on HVAC Sizing Simulations and")]
////public virtual choice SizingOption { get; set; } = new choice;
////[Description("this is used in the coincident sizing algorithm to apply a running average to peak flow rates")]
////public virtual integer ZoneTimestepsInAveragingWindow { get; set; } = new integer;
////[Description("this is used to adjust the result for coincident sizing by applying a sizing factor")]
////public virtual choice CoincidentSizingFactorMode { get; set; } = new choice;
////}
////}
