////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Refrigeration:Subcooler : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("plan to add ambient subcoolers at future time")]
////public virtual choice SubcoolerType { get; set; } = new choice;
////[Description("Applicable only and required for liquid suction heat exchangers")]
////public virtual real LiquidSuctionDesignSubcoolingTemperatureDifference { get; set; } = new real;
////[Description("design inlet temperature on liquid side")]
////public virtual real DesignLiquidInletTemperature { get; set; } = new real;
////[Description("design inlet temperature on vapor side")]
////public virtual real DesignVaporInletTemperature { get; set; } = new real;
////[Description("Name of the Detailed Refrigeration System providing cooling capacity")]
////public virtual object-list Capacity-ProvidingSystem { get; set; } = new object-list;
////[Description("Control Temperature Out for subcooled liquid")]
////public virtual real OutletControlTemperature { get; set; } = new real;
////}
////}
