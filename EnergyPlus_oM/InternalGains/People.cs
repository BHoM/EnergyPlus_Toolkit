using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class People : BHoMObject
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "People";
        [Order]
        [Description("No description available")]
        public override string Name { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual ZoneList ZoneOrZoneListName { get; set; } = new ZoneList();
        [Order]
        [Description("units in schedule should be fraction applied to number of people (0.0 - 1.0)")]
        public virtual string NumberOfPeopleScheduleName { get; set; } = "";
        [Order]
        [Description("The entered calculation method is used to create the maximum number of people")]
        public virtual PeopleDesignLevelCalculationMethod NumberOfPeopleCalculationMethod { get; set; } = PeopleDesignLevelCalculationMethod.Undefined;
        [Order]
        [Description("No description available")]
        public virtual double NumberOfPeople { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double PeoplePerZoneFloorArea { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double ZoneFloorAreaPerPerson { get; set; } = 0.0;
        [Order]
        [Description("This is radiant fraction of the sensible heat released by people in a zone. This value will be")]
        public virtual double FractionRadiant { get; set; } = 0.0;
        [Order]
        [Description("if input, overrides program calculated sensible/latent split")]
        public virtual double SensibleHeatFraction { get; set; } = 0.0;
        [Order]
        [Description("Note that W has to be converted to mets in TC routine")]
        public virtual string ActivityLevelScheduleName { get; set; } = "";
        [Order]
        [Description("CO2 generation rate per unit of activity level.")]
        public virtual double CarbonDioxideGenerationRate { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual bool EnableASHRAE55ComfortWarnings { get; set; } = false;
        [Order]
        [Description("optional (only required for thermal comfort runs)")]
        public virtual MeanRadiantTemperatureCalculationType MeanRadiantTemperatureCalculationType { get; set; } = MeanRadiantTemperatureCalculationType.Undefined;
        [Order]
        [Description("optional (only required for runs of thermal comfort models: Fanger, Pierce and KSU)")]
        public virtual string SurfaceNameAngleFactorListName { get; set; } = "";
        [Order]
        [Description("units in schedule are 0.0 to 1.0")]
        public virtual string WorkEfficiencyScheduleName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual ClothingInsulationCalculationMethod ClothingInsulationCalculationMethod { get; set; } = ClothingInsulationCalculationMethod.Undefined;
        [Order]
        [Description("a schedule value of 1 for the Scheduled method, and 2 for the DynamicClothingModelASHRAE55 method")]
        public virtual string ClothingInsulationCalculationMethodScheduleName { get; set; } = "";
        [Order]
        [Description("use \"Clo\" from ASHRAE or Thermal Comfort guides")]
        public virtual string ClothingInsulationScheduleName { get; set; } = "";
        [Order]
        [Description("units in the schedule are m/s")]
        public virtual string AirVelocityScheduleName { get; set; } = "";
        [Order]
        [Description("optional (only needed for people thermal comfort results reporting)")]
        public virtual ThermalComfortModelType ThermalComfortModel1Type { get; set; } = ThermalComfortModelType.Undefined;
        [Order]
        [Description("optional (second type of thermal comfort model and results reporting)")]
        public virtual ThermalComfortModelType ThermalComfortModel2Type { get; set; } = ThermalComfortModelType.Undefined;
        [Order]
        [Description("optional (third thermal comfort model and report type)")]
        public virtual ThermalComfortModelType ThermalComfortModel3Type { get; set; } = ThermalComfortModelType.Undefined;
        [Order]
        [Description("optional (fourth thermal comfort model and report type)")]
        public virtual ThermalComfortModelType ThermalComfortModel4Type { get; set; } = ThermalComfortModelType.Undefined;
        [Order]
        [Description("optional (fifth thermal comfort model and report type)")]
        public virtual ThermalComfortModelType ThermalComfortModel5Type { get; set; } = ThermalComfortModelType.Undefined;
    }
}
