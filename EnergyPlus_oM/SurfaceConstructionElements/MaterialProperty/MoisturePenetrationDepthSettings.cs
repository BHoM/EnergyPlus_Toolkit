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

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("Additional properties for moisture using EMPD procedure HeatBalanceAlgorithm choice=MoisturePenetrationDepthConductionTransferFunction only Has no effect with other HeatBalanceAlgorithm solution algorithms")]
    public class MoisturePenetrationDepthSettings : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "MaterialProperty:MoisturePenetrationDepth:Settings";

        [Order]
        [Description("Material name")]
        public override string Name { get; set; } = "DefaultMaterial";

        [Order]
        [Description("Ratio of water vapor permeability of stangnat air to water vapor permeability of material - (0 < infinite) dimensionless")]
        public virtual double WaterVaporDiffusionResistanceFactor { get; set; } = 0.0;

        [Order]
        [Description("dimensionless")]
        public virtual double MoistureEquationCoefficientA { get; set; } = 0.0;

        [Order]
        [Description("dimensionless")]
        public virtual double MoistureEquationCoefficientB { get; set; } = 0.0;

        [Order]
        [Description("dimensionless")]
        public virtual double MoistureEquationCoefficientC { get; set; } = 0.0;

        [Order]
        [Description("dimensionless")]
        public virtual double MoistureEquationCoefficientD { get; set; } = 0.0;

        [Order]
        [Description("m")]
        public virtual double SurfaceLayerPenetrationDepth { get; set; } = 0.0;

        [Order]
        [Description("m")]
        public virtual double DeepLayerPenetrationDepth { get; set; } = 0.0;

        [Order]
        [Description("m")]
        public virtual double CoatingLayerThickness { get; set; } = 0.0;

        [Order]
        [Description("The coating's resistance to water vapor diffusion relative to the resistance to water vapor diffusion in stagnant air (see Water Vapor Diffusion Resistance Factor above). - dimensionless")]
        public virtual double CoatingLayerWaterVaporDiffusionResistanceFactor { get; set; } = 0.0;
    }
}
