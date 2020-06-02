////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Refrigeration:TranscriticalSystem : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual choice SystemType { get; set; } = new choice;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list MediumTemperatureRefrigeratedCaseOrWalkinOrCaseAndWalkInListName { get; set; } = new object-list;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list LowTemperatureRefrigeratedCaseOrWalkinOrCaseAndWalkInListName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list RefrigerationGasCoolerName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list HighPressureCompressorOrCompressorListName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list LowPressureCompressorOrCompressorListName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real ReceiverPressure { get; set; } = new real;
////[Description("No description available")]
////public virtual real SubcoolerEffectiveness { get; set; } = new real;
////[Description("Fluid property data for the refrigerant must be entered.")]
////public virtual object-list RefrigerationSystemWorkingFluidType { get; set; } = new object-list;
////[Description("Use only if you want to include suction piping heat gain in refrigeration load")]
////public virtual real SumUASuctionPipingForMediumTemperatureLoads { get; set; } = new real;
////[Description("This will be used to determine the temperature used for distribution piping heat")]
////public virtual object-list MediumTemperatureSuctionPipingZoneName { get; set; } = new object-list;
////[Description("Use only if you want to include suction piping heat gain in refrigeration load")]
////public virtual real SumUASuctionPipingForLowTemperatureLoads { get; set; } = new real;
////[Description("This will be used to determine the temperature used for distribution piping heat")]
////public virtual object-list LowTemperatureSuctionPipingZoneName { get; set; } = new object-list;
////[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Subcategory table.")]
////public virtual alpha End-UseSubcategory { get; set; } = new alpha;
////}
////}
