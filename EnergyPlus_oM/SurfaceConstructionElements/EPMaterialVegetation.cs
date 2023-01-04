/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2023, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */

using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.Adapters.EnergyPlus
{
    public class EPMaterialVegetation : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "Material:RoofVegetation";
        [Order]
        [Description("Vegetation material name. Default is Grass")]
        public override string Name { get; set; } = "Grass";
        [Order]
        [Description("This field defines the height of plants in units of meters. This field is limited to values in the range 0.005 < Height < 1.00 m. Default is .2 m.")]
        public virtual double HeightOfPlants { get; set; } = 0.2;
        [Order]
        [Description("This is the projected leaf area per unit area of soil surface. This field is dimensionless and is limited to values in the range of 0.001 < LAI < 5.0. Default is 1.71 for grass. At the present time the fraction vegetation cover is calculated directly from LAI (Leaf Area Index) using an empirical relation. The user may find it necessary to increase the specified value of LAI in order to represent high fractional coverage of the surface by vegetation.")]
        public virtual double LeafAreaIndex { get; set; } = 1.71;
        [Order]
        [Description("This field represents the fraction of incident solar radiation that is reflected by the individual leaf surfaces (albedo). Solar radiation includes the visible spectrum as well as infrared and ultraviolet wavelengths. Values for this field must be between 0.05 and 0.5. Typical values are .18 to .25.")]
        public virtual double LeafReflectivity { get; set; } = 0.19;
        [Order]
        [Description("This field is the ratio of thermal radiation emitted from leaf surfaces to that emitted by an ideal black body at the same temperature. This parameter is used when calculating the long wavelength radiant exchange at the leaf surfaces. Values for this field must be between 0.8 and 1.0 (with 1.0 representing \"black body\" conditions). Default is .95.")]
        public virtual double LeafEmissivity { get; set; } = 0.95;
        [Order]
        [Description("This field represents the resistance of the plants to moisture transport. It has units of s/m. Plants with low values of stomatal resistance will result in higher evapotranspiration rates than plants with high resistance. Values for this field must be in the range of 50.0 to 300.0. Default is 180.")]
        public virtual double MinimumStomatalResistance { get; set; } = 180.0;
        [Order]
        [Description("This field is a unique reference name that the user assigns to the soil layer for a particular ecoroof. This name can then be referred to by other input data. Default is Soil")]
        public virtual string SoilLayerName { get; set; } = "Soil";
        [Order]
        [Description("This alpha field defines the relative roughness of a particular material layer. This parameter only influences the convection coefficients, more specifically the exterior convection coefficient. A keyword is expected in this field with the options being \"VeryRough\", \"Rough\", \"MediumRough\", \"MediumSmooth\", \"Smooth\", and \"VerySmooth\" in order of roughest to smoothest options. Default is MediumRough.")]
        public virtual Roughness Roughness { get; set; } = Roughness.Rough;
        [Order]
        [Description("This field characterizes the thickness of the material layer in meters. This should be the dimension of the layer in the direction perpendicular to the main path of heat conduction. This value must be a positive number. Depths of .10m (4 inches) and .15m (6 inches) are common. Default if this field is left blank is .1. Maximum is .7m. Must be greater than .05 m.")]
        public virtual double Thickness { get; set; } = 0.2;
        [Order]
        [Description("This field is used to enter the thermal conductivity of the material layer. Units for this parameter are W/(m-K). Thermal conductivity must be greater than zero. Typical soils have values from .3 to .5. Minimum is .2 (specified in IDD). and maximum (in IDD) is 1.5.")]
        public virtual double ConductivityOfDrySoil { get; set; } = 1.0;
        [Order]
        [Description("This field is used to enter the density of the material layer in units of kg/m3. Density must be a positive quantity. Typical soils range from 400 to 1000 (dry to wet).Minimum is 300, maximum is 2000 and default if field is left blank is 1250.")]
        public virtual double DensityOfDrySoil { get; set; } = 1250;
        [Order]
        [Description("This field represents the specific heat of the material layer in units of J/(kg-K). Note that these units are most likely different than those reported in textbooks and references which tend to use kJ/(kg-K) or J/(g-K). They were chosen for internal consistency within EnergyPlus. Only positive values of specific heat are allowed.")]
        public virtual double SpecificHeatOfDrySoil { get; set; } = 1252;
        [Order]
        [Description("The thermal absorptance field in the Material input syntax represents the fraction of incident long wavelength (>2.5 microns) radiation that is absorbed by the material. This parameter is used when calculating the long wavelength radiant exchange between various surfaces and affects the surface heat balances (both inside and outside as appropriate). For long wavelength radiant exchange, thermal emissivity and thermal emittance are equal to thermal absorptance. Values for this field must be between 0.0 and 1.0 (with 1.0 representing \"black body\" conditions). Typical values are from .9 to .98. The default value for this field is 0.92.")]
        public virtual double ThermalAbsorptance { get; set; } = 0.92;
        [Order]
        [Description("The solar absorptance field in the Material input syntax represents the fraction of incident solar radiation that is absorbed by the material. Solar radiation (0.3 to 2.537 microns) includes the visible spectrum as well as infrared and ultraviolet wavelengths. This parameter is used when calculating the amount of incident solar radiation absorbed by various surfaces and affects the surface heat balances (both inside and outside as appropriate). If solar reflectance (or reflectivity) data is available, then absorptance is equal to 1.0 minus reflectance (for opaque materials). Values for this field must be between 0.0 and 1.0. Typical values are from .6 to .85. The default value for this field is 0.75.")]
        public virtual double SolarAbsorptance { get; set; } = 0.75;
        [Order]
        [Description("The visible absorptance field in the Material input syntax represents the fraction of incident visible wavelength radiation that is absorbed by the material. Visible wavelength radiation ( 0.37 to 0.78 microns weighted by photopic response) is slightly different than solar radiation in that the visible band of wavelengths is much more narrow while solar radiation includes the visible spectrum as well as infrared and ultraviolet wavelengths. This parameter is used when calculating the amount of incident visible radiation absorbed by various surfaces and affects the surface heat balances (both inside and outside as appropriate) as well as the daylighting calculations. If visible reflectance (or reflectivity) data is available, then absorptance is equal to 1.0 minus reflectance (for opaque materials). Values for this field must be between 0.5 and 1.0. The default value for this field is 0.75.")]
        public virtual double VisibleAbsorptance { get; set; } = 0.75;
        [Order]
        [Description("The field allows for user input of the saturation moisture content of the soil layer. Maximum moisture content is typically less than .5. Range is [.1,.5] with the default being .3.")]
        public virtual double SaturationVolumetricMoistureContentOfTheSoilLayer { get; set; } = 0.3;
        [Order]
        [Description("The field allows for user input of the residual moisture content of the soil layer. Default is .01, range is [.01,.1].")]
        public virtual double ResidualVolumetricMoistureContentOfTheSoilLayer { get; set; } = 0.01;
        [Order]
        [Description("The field allows for user input of the initial moisture content of the soil layer. Range is (.05, .5] with the default being .1.")]
        public virtual double InitialVolumetricMoistureContentOfTheSoilLayer { get; set; } = 0.1;
        [Order]
        [Description("The field allows for two models to be selected: Simple or Advanced.\nSimple is the original Ecoroof model - based on a constant diffusion of moisture through the soil.This model starts with the soil in two layers.Every time the soil properties update is called, it will look at the two soils moisture layers and asses which layer has more moisture in it.It then takes moisture from the higher moisture layer and redistributes it to the lower moisture layer at a constant rate.\nAdvanced is the later Ecoroof model.If you use it, you will need to increase your number of timesteps in hour for the simulation with a recommended value of 20.This moisture transport model is based on a project which looked at the way moisture transports through soil.It uses a finite difference method to divide the soil into layers(nodes).It redistributes the soil moisture according the model described in:\nMarcel G Schaap and Martinus Th.van Genuchten, 2006, �A modified Maulem - van Genuchten Formulation for Improved Description of the Hydraulic Conductivity Near Saturation�, Vadose Zone Journal 5(1), p 27 - 34.")]
        public virtual MoistureDiffusionCalculationMethod MoistureDiffusionCalculationMethod { get; set; } = MoistureDiffusionCalculationMethod.Simple;
    }
}



