using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class People : BHoMObject
    {
        [Description("No description available")]
        public virtual string PeopleName { get; set; } = "";
        [Description("No description available")]
        public virtual string ZoneOrZoneListName { get; set; } = "";
        [Description("units in schedule should be fraction applied to number of people (0.0 - 1.0)")]
        public virtual string NumberOfPeopleScheduleName { get; set; } = "";
        [Description("The entered calculation method is used to create the maximum number of people")]
        public virtual PeopleDesignLevelCalculationMethod NumberOfPeopleCalculationMethod { get; set; } = PeopleDesignLevelCalculationMethod.Undefined;
        [Description("No description available")]
        public virtual double NumberOfPeople { get; set; } = 0.0;
        [Description("No description available")]
        public virtual double PeoplePerZoneFloorArea { get; set; } = 0.0;
        [Description("No description available")]
        public virtual double ZoneFloorAreaPerPerson { get; set; } = 0.0;
        [Description("This is radiant fraction of the sensible heat released by people in a zone. This value will be")]
        public virtual double FractionRadiant { get; set; } = 0.0;
        [Description("if input, overrides program calculated sensible/latent split")]
        public virtual double SensibleHeatFraction { get; set; } = 0.0;
        [Description("Note that W has to be converted to mets in TC routine")]
        public virtual string ActivityLevelScheduleName { get; set; } = "";
        [Description("CO2 generation rate per unit of activity level.")]
        public virtual double CarbonDioxideGenerationRate { get; set; } = 0.0;
        [Description("No description available")]
        public virtual bool EnableASHRAE55ComfortWarnings { get; set; } = false;
        [Description("optional (only required for thermal comfort runs)")]
        public virtual MeanRadiantTemperatureCalculationType MeanRadiantTemperatureCalculationType { get; set; } = MeanRadiantTemperatureCalculationType.Undefined;
        [Description("optional (only required for runs of thermal comfort models: Fanger, Pierce and KSU)")]
        public virtual string SurfaceNameAngleFactorListName { get; set; } = "";
        [Description("units in schedule are 0.0 to 1.0")]
        public virtual string WorkEfficiencyScheduleName { get; set; } = "";
        [Description("No description available")]
        public virtual ClothingInsulationCalculationMethod ClothingInsulationCalculationMethod { get; set; } = ClothingInsulationCalculationMethod.Undefined;
        [Description("a schedule value of 1 for the Scheduled method, and 2 for the DynamicClothingModelASHRAE55 method")]
        public virtual string ClothingInsulationCalculationMethodScheduleName { get; set; } = "";
        [Description("use \"Clo\" from ASHRAE or Thermal Comfort guides")]
        public virtual string ClothingInsulationScheduleName { get; set; } = "";
        [Description("units in the schedule are m/s")]
        public virtual string AirVelocityScheduleName { get; set; } = "";
        [Description("optional (only needed for people thermal comfort results reporting)")]
        public virtual ThermalComfortModelType ThermalComfortModel1Type { get; set; } = ThermalComfortModelType.Undefined;
        [Description("optional (second type of thermal comfort model and results reporting)")]
        public virtual ThermalComfortModelType ThermalComfortModel2Type { get; set; } = ThermalComfortModelType.Undefined;
        [Description("optional (third thermal comfort model and report type)")]
        public virtual ThermalComfortModelType ThermalComfortModel3Type { get; set; } = ThermalComfortModelType.Undefined;
        [Description("optional (fourth thermal comfort model and report type)")]
        public virtual ThermalComfortModelType ThermalComfortModel4Type { get; set; } = ThermalComfortModelType.Undefined;
        [Description("optional (fifth thermal comfort model and report type)")]
        public virtual ThermalComfortModelType ThermalComfortModel5Type { get; set; } = ThermalComfortModelType.Undefined;
    }
}
