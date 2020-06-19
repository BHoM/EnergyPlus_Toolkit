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
    public class SwimmingPoolIndoor : BHoMObject
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "SwimmingPool:Indoor";
        [Order]
        [Description("No description available")]
        public override string Name { get; set; } = "";
        [Order]
        [Description("Name of the floor surface where the pool is located.")]
        public virtual string SurfaceName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual double AverageDepth { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual string ActivityFactorScheduleName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string MakeupWaterSupplyScheduleName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string CoverScheduleName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual double CoverEvaporationFactor { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double CoverConvectionFactor { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double CoverShortWavelengthRadiationFactor { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double CoverLongWavelengthRadiationFactor { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual string PoolWaterInletNode { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string PoolWaterOutletNode { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual double PoolHeatingSystemMaximumWaterFlowRate { get; set; } = 0.0;
        [Order]
        [Description("Power input per pool water flow rate")]
        public virtual double PoolMiscellaneousEquipmentPower { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual string SetpointTemperatureSchedule { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual int MaximumNumberOfPeople { get; set; } = 0;
        [Order]
        [Description("No description available")]
        public virtual string PeopleSchedule { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string PeopleHeatGainSchedule { get; set; } = "";
    }
}
