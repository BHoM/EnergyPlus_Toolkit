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
    public class HeatBalanceSettingsConductionFiniteDifference : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]

        public virtual string ClassName { get; set; } = "HeatBalanceSettings:ConductionFiniteDifference";
        [Order][Description("No description available")]
        public virtual DifferenceScheme DifferenceScheme { get; set; } = DifferenceScheme.FullyImplicitFirstOrder;
        [Order][Description("increase or decrease number of nodes")]
        public virtual double SpaceDiscretizationConstant { get; set; } = 3.0;
        [Order][Description("No description available")]
        public virtual double RelaxationFactor { get; set; } = 1.0;
        [Order][Description("No description available")]
        public virtual double InsideFaceSurfaceTemperatureConvergenceCriteria { get; set; } = 0.002;
    }
}



