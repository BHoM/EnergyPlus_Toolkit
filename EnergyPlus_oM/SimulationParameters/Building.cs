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
using BH.oM.Base.Attributes;

namespace BH.oM.Adapters.EnergyPlus
{
    public class Building : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "Building";
        [Order]
        [Description("Name of building")]
        public override string Name { get; set; } = "BuildingName";
        [Order]
        [Description("Degrees from true North")]
        public virtual double NorthAxis { get; set; } = 0.0;
        [Order]
        [Description("Terrain type in which the building is situated")]
        public virtual Terrain Terrain { get; set; } = Terrain.Suburbs;
        [Order]
        [Description("Loads Convergence Tolerance Value is a fraction of load")]
        public virtual double LoadsConvergenceToleranceValue { get; set; } = 0.04;
        [Order]
        [Description("Temperature Convergence Tolerance Value")]
        public virtual double TemperatureConvergenceToleranceValue { get; set; } = 0.4;
        [Order]
        [Description("Solar shadowing calculation method. For Exterior cases, FullExteriorWithReflections is recommended")]
        public virtual SolarDistribution SolarDistribution { get; set; } = SolarDistribution.FullExterior;
        [Order]
        [Description("EnergyPlus will only use as many warmup days as needed to reach convergence tolerance.")]
        public virtual int MaximumNumberOfWarmupDays { get; set; } = 25;
        [Order]
        [Description("The minimum number of warmup days that produce enough temperature and flux history")]
        public virtual int MinimumNumberOfWarmupDays { get; set; } = 6;
    }
}



