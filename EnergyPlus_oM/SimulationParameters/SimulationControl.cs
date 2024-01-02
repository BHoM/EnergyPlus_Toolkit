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
    public class SimulationControl : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]

        public virtual string ClassName { get; set; } = "SimulationControl";
        [Order][Description("If True, Zone sizing is accomplished from corresponding Sizing:Zone objects")]
        public virtual bool DoZoneSizingCalculation { get; set; } = false;
        [Order][Description("If True, System sizing is accomplished from corresponding Sizing:System objects")]
        public virtual bool DoSystemSizingCalculation { get; set; } = false;
        [Order][Description("If True, Plant sizing is accomplished from corresponding Sizing:Plant objects")]
        public virtual bool DoPlantSizingCalculation { get; set; } = false;
        [Order][Description("If True, SizingPeriod:* objects are executed and results from those may be displayed..")]
        public virtual bool RunSimulationForSizingPeriods { get; set; } = true;
        [Order][Description("If True, RunPeriod:* objects are executed and results from those may be displayed..")]
        public virtual bool RunSimulationForWeatherFileRunPeriods { get; set; } = true;
        [Order][Description("If True, SizingPeriod:* objects are exectuted additional times for advanced sizing.")]
        public virtual bool DoHVACSizingSimulationForSizingPeriods { get; set; } = false;
        [Order][Description("The entire set of SizingPeriod:* objects may be repeated to fine tune size results")]
        public virtual int MaximumNumberOfHVACSizingSimulationPasses { get; set; } = 1;
    }
}




