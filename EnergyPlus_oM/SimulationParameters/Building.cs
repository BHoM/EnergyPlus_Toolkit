using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class Building : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "Building";
        [Order][Description("Name of building")]
        public virtual string Name { get; set; } = "BuildingName";
        [Order][Description("degrees from true North")]
        public virtual double NorthAxis { get; set; } = 0.0;
        [Order][Description("Country=FlatOpenCountry | Suburbs=CountryTownsSuburbs | City=CityCenter | Ocean=body of water (5km) | Urban=Urban-Industrial-Forest")]
        public virtual Terrain Terrain { get; set; } = Terrain.Suburbs;
        [Order][Description("Loads Convergence Tolerance Value is a fraction of load")]
        public virtual double LoadsConvergenceToleranceValue { get; set; } = 0.04;
        [Order][Description("No description available")]
        public virtual double TemperatureConvergenceToleranceValue { get; set; } = 0.4;
        [Order][Description("MinimalShadowing | FullExterior | FullInteriorAndExterior | FullExteriorWithReflections | FullInteriorAndExteriorWithReflections")]
        public virtual SolarDistribution SolarDistribution { get; set; } = SolarDistribution.FullExterior;
        [Order][Description("EnergyPlus will only use as many warmup days as needed to reach convergence tolerance.")]
        public virtual int MaximumNumberOfWarmupDays { get; set; } = 25;
        [Order][Description("The minimum number of warmup days that produce enough temperature and flux history")]
        public virtual int MinimumNumberOfWarmupDays { get; set; } = 6;
    }
}
