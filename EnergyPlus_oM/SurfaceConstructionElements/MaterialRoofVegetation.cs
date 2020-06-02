////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Material:RoofVegetation : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("The ecoroof module is designed for short plants and shrubs.")]
////public virtual real HeightOfPlants { get; set; } = new real;
////[Description("Entire surface is assumed covered, so decrease LAI accordingly.")]
////public virtual real LeafAreaIndex { get; set; } = new real;
////[Description("Leaf reflectivity (albedo) is typically 0.18-0.25")]
////public virtual real LeafReflectivity { get; set; } = new real;
////[Description("No description available")]
////public virtual real LeafEmissivity { get; set; } = new real;
////[Description("This depends upon plant type")]
////public virtual real MinimumStomatalResistance { get; set; } = new real;
////[Description("No description available")]
////public virtual alpha SoilLayerName { get; set; } = new alpha;
////[Description("No description available")]
////public virtual choice Roughness { get; set; } = new choice;
////[Description("thickness of the soil layer of the EcoRoof")]
////public virtual real Thickness { get; set; } = new real;
////[Description("Thermal conductivity of dry soil.")]
////public virtual real ConductivityOfDrySoil { get; set; } = new real;
////[Description("Density of dry soil (the code modifies this as the soil becomes moist)")]
////public virtual real DensityOfDrySoil { get; set; } = new real;
////[Description("Specific heat of dry soil")]
////public virtual real SpecificHeatOfDrySoil { get; set; } = new real;
////[Description("Soil emissivity is typically in range of 0.90 to 0.98")]
////public virtual real ThermalAbsorptance { get; set; } = new real;
////[Description("Solar absorptance of dry soil (1-albedo) is typically 0.60 to 0.85")]
////public virtual real SolarAbsorptance { get; set; } = new real;
////[Description("No description available")]
////public virtual real VisibleAbsorptance { get; set; } = new real;
////[Description("Maximum moisture content is typically less than 0.5")]
////public virtual real SaturationVolumetricMoistureContentOfTheSoilLayer { get; set; } = new real;
////[Description("No description available")]
////public virtual real ResidualVolumetricMoistureContentOfTheSoilLayer { get; set; } = new real;
////[Description("No description available")]
////public virtual real InitialVolumetricMoistureContentOfTheSoilLayer { get; set; } = new real;
////[Description("Advanced calculation requires increased number of timesteps (recommended >20).")]
////public virtual choice MoistureDiffusionCalculationMethod { get; set; } = new choice;
////}
////}
