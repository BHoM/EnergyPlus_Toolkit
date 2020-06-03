using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class MaterialRoofVegetation : BHoMObject
    {
        [Description("No description available")]
        public virtual string MaterialName { get; set; } = "Grass";
        [Description("The ecoroof module is designed for short plants and shrubs.")]
        public virtual double HeightOfPlants { get; set; } = 0.2;
        [Description("Entire surface is assumed covered, so decrease LAI accordingly.")]
        public virtual double LeafAreaIndex { get; set; } = 1.71;
        [Description("Leaf reflectivity (albedo) is typically 0.18-0.25")]
        public virtual double LeafReflectivity { get; set; } = 0.19;
        [Description("No description available")]
        public virtual double LeafEmissivity { get; set; } = 0.95;
        [Description("This depends upon plant type")]
        public virtual double MinimumStomatalResistance { get; set; } = 180.0;
        [Description("No description available")]
        public virtual string SoilLayerName { get; set; } = "SoilLayerName";
        [Description("No description available")]
        public virtual Roughness Roughness { get; set; } = Roughness.Rough;
        [Description("thickness of the soil layer of the EcoRoof")]
        public virtual double Thickness { get; set; } = 0.2;
        [Description("Thermal conductivity of dry soil.")]
        public virtual double ConductivityOfDrySoil { get; set; } = 1.0;
        [Description("Density of dry soil (the code modifies this as the soil becomes moist)")]
        public virtual double DensityOfDrySoil { get; set; } = 1250;
        [Description("Specific heat of dry soil")]
        public virtual double SpecificHeatOfDrySoil { get; set; } = 1252;
        [Description("Soil emissivity is typically in range of 0.90 to 0.98")]
        public virtual double ThermalAbsorptance { get; set; } = 0.92;
        [Description("Solar absorptance of dry soil (1-albedo) is typically 0.60 to 0.85")]
        public virtual double SolarAbsorptance { get; set; } = 0.75;
        [Description("No description available")]
        public virtual double VisibleAbsorptance { get; set; } = 0.75;
        [Description("Maximum moisture content is typically less than 0.5")]
        public virtual double SaturationVolumetricMoistureContentOfTheSoilLayer { get; set; } = 0.3;
        [Description("No description available")]
        public virtual double ResidualVolumetricMoistureContentOfTheSoilLayer { get; set; } = 0.01;
        [Description("No description available")]
        public virtual double InitialVolumetricMoistureContentOfTheSoilLayer { get; set; } = 0.1;
        [Description("Advanced calculation requires increased number of timesteps (recommended >20).")]
        public virtual MoistureDiffusionCalculationMethod MoistureDiffusionCalculationMethod { get; set; } = MoistureDiffusionCalculationMethod.Simple;
    }
}
