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
    public class ElectricEquipment : BHoMObject
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "ElectricEquipment";
        [Order]
        [Description("No description available")]
        public override string Name { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual ZoneList ZoneOrZoneListName { get; set; } = new ZoneList();
        [Order]
        [Description("units in schedule should be fraction applied to design level of electric equipment, generally (0.0 - 1.0)")]
        public virtual string ScheduleName { get; set; } = "";
        [Order]
        [Description("The entered calculation method is used to create the maximum amount of electric equipment")]
        public virtual ElectricEquipmentDesignLevelCalculationMethod DesignLevelCalculationMethod { get; set; } = ElectricEquipmentDesignLevelCalculationMethod.Undefined;
        [Order]
        [Description("No description available")]
        public virtual double DesignLevel { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double WattsPerZoneFloorArea { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double WattsPerPerson { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double FractionLatent { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double FractionRadiant { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double FractionLost { get; set; } = 0.0;
        [Order]
        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Subcategory table.")]
        public virtual string EndUseSubcategory { get; set; } = "";
}
}
