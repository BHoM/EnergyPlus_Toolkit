////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Lights : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual object-list ZoneOrZoneListName { get; set; } = new object-list;
////[Description("units in schedule should be fraction applied to design level of lights, generally (0.0 - 1.0)")]
////public virtual object-list ScheduleName { get; set; } = new object-list;
////[Description("The entered calculation method is used to create the maximum amount of lights")]
////public virtual choice DesignLevelCalculationMethod { get; set; } = new choice;
////[Description("No description available")]
////public virtual real LightingLevel { get; set; } = new real;
////[Description("No description available")]
////public virtual real WattsPerZoneFloorArea { get; set; } = new real;
////[Description("No description available")]
////public virtual real WattsPerPerson { get; set; } = new real;
////[Description("Used only for sizing calculation if return-air-fraction")]
////public virtual real ReturnAirFraction { get; set; } = new real;
////[Description("No description available")]
////public virtual real FractionRadiant { get; set; } = new real;
////[Description("No description available")]
////public virtual real FractionVisible { get; set; } = new real;
////[Description("For Daylighting:Controls must be 0 or 1: 0 = no dimming control, 1 = full dimming control")]
////public virtual real FractionReplaceable { get; set; } = new real;
////[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Subcategory table.")]
////public virtual alpha End-UseSubcategory { get; set; } = new alpha;
////[Description("No description available")]
////public virtual choice ReturnAirFractionCalculatedFromPlenumTemperature { get; set; } = new choice;
////[Description("Used only if Return Air Fraction Is Calculated from Plenum Temperature = Yes")]
////public virtual real ReturnAirFractionFunctionOfPlenumTemperatureCoefficient1 { get; set; } = new real;
////[Description("Used only if Return Air Fraction Is Calculated from Plenum Temperature = Yes")]
////public virtual real ReturnAirFractionFunctionOfPlenumTemperatureCoefficient2 { get; set; } = new real;
////[Description("Name of the return air node for this heat gain.")]
////public virtual node ReturnAirHeatGainNodeName { get; set; } = new node;
////}
////}
