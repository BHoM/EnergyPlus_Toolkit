////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class People : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual object-list ZoneOrZoneListName { get; set; } = new object-list;
////[Description("units in schedule should be fraction applied to number of people (0.0 - 1.0)")]
////public virtual object-list NumberOfPeopleScheduleName { get; set; } = new object-list;
////[Description("The entered calculation method is used to create the maximum number of people")]
////public virtual choice NumberOfPeopleCalculationMethod { get; set; } = new choice;
////[Description("No description available")]
////public virtual real NumberOfPeople { get; set; } = new real;
////[Description("No description available")]
////public virtual real PeoplePerZoneFloorArea { get; set; } = new real;
////[Description("No description available")]
////public virtual real ZoneFloorAreaPerPerson { get; set; } = new real;
////[Description("This is radiant fraction of the sensible heat released by people in a zone. This value will be")]
////public virtual real FractionRadiant { get; set; } = new real;
////[Description("if input, overrides program calculated sensible/latent split")]
////public virtual null SensibleHeatFraction { get; set; } = new null;
////[Description("Note that W has to be converted to mets in TC routine")]
////public virtual object-list ActivityLevelScheduleName { get; set; } = new object-list;
////[Description("CO2 generation rate per unit of activity level.")]
////public virtual real CarbonDioxideGenerationRate { get; set; } = new real;
////[Description("No description available")]
////public virtual choice EnableASHRAE55ComfortWarnings { get; set; } = new choice;
////[Description("optional (only required for thermal comfort runs)")]
////public virtual choice MeanRadiantTemperatureCalculationType { get; set; } = new choice;
////[Description("optional (only required for runs of thermal comfort models: Fanger, Pierce and KSU)")]
////public virtual object-list SurfaceName/AngleFactorListName { get; set; } = new object-list;
////[Description("units in schedule are 0.0 to 1.0")]
////public virtual object-list WorkEfficiencyScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice ClothingInsulationCalculationMethod { get; set; } = new choice;
////[Description("a schedule value of 1 for the Scheduled method, and 2 for the DynamicClothingModelASHRAE55 method")]
////public virtual object-list ClothingInsulationCalculationMethodScheduleName { get; set; } = new object-list;
////[Description("use "Clo" from ASHRAE or Thermal Comfort guides")]
////public virtual object-list ClothingInsulationScheduleName { get; set; } = new object-list;
////[Description("units in the schedule are m/s")]
////public virtual object-list AirVelocityScheduleName { get; set; } = new object-list;
////[Description("optional (only needed for people thermal comfort results reporting)")]
////public virtual choice ThermalComfortModel1Type { get; set; } = new choice;
////[Description("optional (second type of thermal comfort model and results reporting)")]
////public virtual choice ThermalComfortModel2Type { get; set; } = new choice;
////[Description("optional (third thermal comfort model and report type)")]
////public virtual choice ThermalComfortModel3Type { get; set; } = new choice;
////[Description("optional (fourth thermal comfort model and report type)")]
////public virtual choice ThermalComfortModel4Type { get; set; } = new choice;
////[Description("optional (fifth thermal comfort model and report type)")]
////public virtual choice ThermalComfortModel5Type { get; set; } = new choice;
////}
////}
