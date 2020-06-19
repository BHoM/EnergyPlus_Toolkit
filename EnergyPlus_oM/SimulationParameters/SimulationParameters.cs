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
    public class SimulationParameters : BHoMObject
    {
        [Description("")]
        public virtual Version Version { get; set; } = new Version();
        [Description("")]
        public virtual SimulationControl SimulationControl{ get; set; } = new SimulationControl();
        [Description("")]
        public virtual Building Building { get; set; } = new Building();
        [Description("")]
        public virtual ShadowCalculation ShadowCalculation { get; set; } = new ShadowCalculation();
        [Description("")]
        public virtual SurfaceConvectionAlgorithmInside SurfaceConvectionAlgorithmInside { get; set; } = new SurfaceConvectionAlgorithmInside();
        [Description("")]
        public virtual SurfaceConvectionAlgorithmOutside SurfaceConvectionAlgorithmOutside { get; set; } = new SurfaceConvectionAlgorithmOutside();
        [Description("")]
        public virtual HeatBalanceAlgorithm HeatBalanceAlgorithm { get; set; } = new HeatBalanceAlgorithm();
        [Description("")]
        public virtual HeatBalanceSettingsConductionFiniteDifference HeatBalanceSettingsConductionFiniteDifference { get; set; } = new HeatBalanceSettingsConductionFiniteDifference();
        [Description("")]
        public virtual ZoneAirHeatBalanceAlgorithm ZoneAirHeatBalanceAlgorithm { get; set; } = new ZoneAirHeatBalanceAlgorithm();
        [Description("")]
        public virtual Timestep Timestep { get; set; } = new Timestep();
    }
}
