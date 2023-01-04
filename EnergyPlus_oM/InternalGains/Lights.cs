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
    public class Lights : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "Lights";
        [Order]
        [Description("Name of the gain")]
        public override string Name { get; set; } = "";
        [Order]
        [Description("List of zones in which gain is present")]
        public virtual ZoneList ZoneOrZoneListName { get; set; } = new ZoneList();
        [Order]
        [Description("units in schedule should be fraction applied to design level of lights, generally (0.0 - 1.0)")]
        public virtual string ScheduleName { get; set; } = "";
        [Order]
        [Description("The entered calculation method is used to create the maximum amount of lights")]
        public virtual LightsDesignLevelCalculationMethod DesignLevelCalculationMethod { get; set; } = LightsDesignLevelCalculationMethod.Undefined;
        [Order]
        [Description("Base gain value (W)")]
        public virtual double LightingLevel { get; set; } = 0.0;
        [Order]
        [Description("Base gain value (W/m2)")]
        public virtual double WattsPerZoneFloorArea { get; set; } = 0.0;
        [Order]
        [Description("Base gain value (W/person)")]
        public virtual double WattsPerPerson { get; set; } = 0.0;
        [Order]
        [Description("Fraction of gain into return-air (0-1). Used only for sizing calculation if return-air-fraction")]
        public virtual double ReturnAirFraction { get; set; } = 0.0;
        [Order]
        [Description("Fraction of gain radiant (0-1)")]
        public virtual double FractionRadiant { get; set; } = 0.0;
        [Order]
        [Description("Fraction of gain as visible light (0-1)")]
        public virtual double FractionVisible { get; set; } = 0.0;
        [Order]
        [Description("For Daylighting:Controls must be 0 or 1: 0 = no dimming control, 1 = full dimming control")]
        public virtual double FractionReplaceable { get; set; } = 0.0;
        [Order]
        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Subcategory table.")]
        public virtual string EndUseSubcategory { get; set; } = "";
        [Order]
        [Description("Boolean flag to state whether fraction of gain is autocalcultaed from plenum temperature")]
        public virtual bool ReturnAirFractionCalculatedFromPlenumTemperature { get; set; } = false;
        [Order]
        [Description("Used only if Return Air Fraction Is Calculated from Plenum Temperature = True")]
        public virtual double ReturnAirFractionFunctionOfPlenumTemperatureCoefficient1 { get; set; } = 0.0;
        [Order]
        [Description("Used only if Return Air Fraction Is Calculated from Plenum Temperature = True")]
        public virtual double ReturnAirFractionFunctionOfPlenumTemperatureCoefficient2 { get; set; } = 0.0;
        [Order]
        [Description("Name of the return air node for this heat gain.")]
        public virtual string ReturnAirHeatGainNodeName { get; set; } = "";
    }
}



