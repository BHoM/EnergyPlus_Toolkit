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
    public class SiteGroundTemperatureBuildingSurface : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "Site:GroundTemperature:BuildingSurface";
        [Order]
        [Description("Ground surface temperature in January")]
        public virtual double JanuaryGroundTemperature { get; set; } = 18;
        [Order]
        [Description("Ground surface temperature in February")]
        public virtual double FebruaryGroundTemperature { get; set; } = 18;
        [Order]
        [Description("Ground surface temperature in March")]
        public virtual double MarchGroundTemperature { get; set; } = 18;
        [Order]
        [Description("Ground surface temperature in April")]
        public virtual double AprilGroundTemperature { get; set; } = 18;
        [Order]
        [Description("Ground surface temperature in May")]
        public virtual double MayGroundTemperature { get; set; } = 18;
        [Order]
        [Description("Ground surface temperature in June")]
        public virtual double JuneGroundTemperature { get; set; } = 18;
        [Order]
        [Description("Ground surface temperature in July")]
        public virtual double JulyGroundTemperature { get; set; } = 18;
        [Order]
        [Description("Ground surface temperature in August")]
        public virtual double AugustGroundTemperature { get; set; } = 18;
        [Order]
        [Description("Ground surface temperature in September")]
        public virtual double SeptemberGroundTemperature { get; set; } = 18;
        [Order]
        [Description("Ground surface temperature in October")]
        public virtual double OctoberGroundTemperature { get; set; } = 18;
        [Order]
        [Description("Ground surface temperature in November")]
        public virtual double NovemberGroundTemperature { get; set; } = 18;
        [Order]
        [Description("Ground surface temperature in December")]
        public virtual double DecemberGroundTemperature { get; set; } = 18;
    }
}



