////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Refrigeration:System : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list RefrigeratedCaseOrWalkinOrCaseAndWalkInListName { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:SecondarySystem object OR")]
////public virtual object-list RefrigerationTransferLoadOrTransferLoadListName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list RefrigerationCondenserName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list CompressorOrCompressorListName { get; set; } = new object-list;
////[Description("related to the proper operation of the thermal expansion")]
////public virtual real MinimumCondensingTemperature { get; set; } = new real;
////[Description("Fluid property data for the refrigerant must be entered.")]
////public virtual object-list RefrigerationSystemWorkingFluidType { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice SuctionTemperatureControlType { get; set; } = new choice;
////[Description("Optional Field")]
////public virtual object-list MechanicalSubcoolerName { get; set; } = new object-list;
////[Description("Optional Field")]
////public virtual object-list LiquidSuctionHeatExchangerSubcoolerName { get; set; } = new object-list;
////[Description("Use only if you want to include suction piping heat gain in refrigeration load")]
////public virtual real SumUASuctionPiping { get; set; } = new real;
////[Description("This will be used to determine the temperature used for distribution piping heat gain")]
////public virtual object-list SuctionPipingZoneName { get; set; } = new object-list;
////[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Subcategory table.")]
////public virtual alpha End-UseSubcategory { get; set; } = new alpha;
////[Description("No description available")]
////public virtual choice NumberOfCompressorStages { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice IntercoolerType { get; set; } = new choice;
////[Description("No description available")]
////public virtual real Shell-and-CoilIntercoolerEffectiveness { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list High-StageCompressorOrCompressorListName { get; set; } = new object-list;
////}
////}