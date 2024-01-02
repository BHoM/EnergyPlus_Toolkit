/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2024, the respective contributors. All rights reserved.
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
    public class ScheduleTypeLimits : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "ScheduleTypeLimits";
        [Order]
        [Description("used to validate schedule types in various schedule objects")]
        public override string Name { get; set; } = "DefaultScheduleTypeLimits";
        [Order]
        [Description("lower limit (real or integer) for the Schedule Type. e.g. if fraction, this is 0.0")]
        public virtual double LowerLimitValue { get; set; } = 0.0;
        [Order]
        [Description("upper limit (real or integer) for the Schedule Type. e.g. if fraction, this is 1.0")]
        public virtual double UpperLimitValue { get; set; } = 1.0;
        [Order]
        [Description("Numeric type is either Continuous (all numbers within the min and")]
        public virtual ScheduleTypeLimitsNumericType NumericType { get; set; } = ScheduleTypeLimitsNumericType.Continuous;
        [Order]
        [Description("Temperature (C or F)")]
        public virtual ScheduleTypeLimitsUnitType UnitType { get; set; } = ScheduleTypeLimitsUnitType.Dimensionless;
    }
}




