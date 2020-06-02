////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class GasEquipment : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual object-list ZoneOrZoneListName { get; set; } = new object-list;
////[Description("units in Schedule should be fraction applied to design level of gas equipment, generally (0.0 - 1.0)")]
////public virtual object-list ScheduleName { get; set; } = new object-list;
////[Description("The entered calculation method is used to create the maximum amount of gas equipment")]
////public virtual choice DesignLevelCalculationMethod { get; set; } = new choice;
////[Description("No description available")]
////public virtual real DesignLevel { get; set; } = new real;
////[Description("No description available")]
////public virtual real PowerPerZoneFloorArea { get; set; } = new real;
////[Description("No description available")]
////public virtual real PowerPerPerson { get; set; } = new real;
////[Description("No description available")]
////public virtual real FractionLatent { get; set; } = new real;
////[Description("No description available")]
////public virtual real FractionRadiant { get; set; } = new real;
////[Description("No description available")]
////public virtual real FractionLost { get; set; } = new real;
////[Description("CO2 generation rate per unit of power input")]
////public virtual real CarbonDioxideGenerationRate { get; set; } = new real;
////[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Subcategory table.")]
////public virtual alpha End-UseSubcategory { get; set; } = new alpha;
////}
////}
