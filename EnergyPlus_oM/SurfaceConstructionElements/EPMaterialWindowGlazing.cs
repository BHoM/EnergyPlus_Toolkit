/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2020, the respective contributors. All rights reserved.
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

namespace BH.oM.EnergyPlus
{
    public class EPMaterialWindowGlazing : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "WindowMaterial:Glazing";
        [Order]
        [Description("Window glass material name")]
        public override string Name { get; set; } = "DefaultWindowGlazingMaterial";
        [Order]
        [Description("Spectral transmittance calculation method")]
        public virtual OpticalDataType OpticalDataType{ get; set; } = OpticalDataType.SpectralAverage;
        [Order]
        [Description("If any option other than SpectralAverage chosen for OpticalDataType, this must be passed alongside")]
        public virtual string WindowGlassSpectralDataSetName { get; set; } = "";
        [Order]
        [Description("Thickness of glass")]
        public virtual double Thickness { get; set; } = 0.005;
        [Order]
        [Description("Normal solar transmittance of glass")]
        public virtual double SolarTransmittanceAtNormalIncidence { get; set; } = 0.5;
        [Order]
        [Description("Front side solar reflectance")]
        public virtual double FrontSideSolarReflectanceAtNormalIncidence { get; set; } = 0.5;
        [Order]
        [Description("Back side solar reflectance")]
        public virtual double BackSideSolarReflectanceAtNormalIncidence { get; set; } = 0.5;
        [Order]
        [Description("Normal visible trnamittance of glass")]
        public virtual double VisibleTransmittanceAtNormalIncidence { get; set; } = 0.5;
        [Order]
        [Description("Front side visible reflectance")]
        public virtual double FrontSideVisibleReflectanceAtNormalIncidence { get; set; } = 0.5;
        [Order]
        [Description("Back side visible reflectance")]
        public virtual double BackSideVisibleReflectanceAtNormalIncidence { get; set; } = 0.5;
        [Order]
        [Description("Normal infrared emissivity")]
        public virtual double InfraredTransmittanceAtNormalIncidence { get; set; } = 0.5;
        [Order]
        [Description("Front side infrared emissivity")]
        public virtual double FrontSideInfraredHemisphericalEmissivity { get; set; } = 0.5;
        [Order]
        [Description("Back side infrared emissivity")]
        public virtual double BackSideInfraredHemisphericalEmissivity { get; set; } = 0.5;
        [Order]
        [Description("Conductivity (W/mK)")]
        public virtual double Conductivity { get; set; } = 0.9;
        [Order]
        [Description("Factor to reduce overall transmissivity of glass due to dirt")]
        public virtual double DirtCorrectionFactorForSolarAndVisibleTransmittance { get; set; } = 1;
        [Order]
        [Description("True if glass diffuses light perfectly")]
        public virtual bool SolarDiffusing { get; set; } = false;
        [Order]
        [Description("Value used for deformation and impact on transmittance angles")]
        public virtual double YoungsModulus { get; set; } = 72000000000;
        [Order]
        [Description("Value used for deformation and impact on transmittance angles")]
        public virtual double PoissonsRatio { get; set; } = 0.22;
    }
}
