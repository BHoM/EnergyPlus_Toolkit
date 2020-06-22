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

using BH.oM.EnergyPlus;
using BH.oM.Physical.Constructions;
using BH.oM.Reflection.Attributes;
using System.Collections.Generic;
using System.ComponentModel;
using BHP = BH.oM.Physical.Constructions;

namespace BH.Engine.EnergyPlus
{
    public static partial class Convert
    {
        [Description("Convert a BHoM Construction into a set of EnergyPlus IEnergyPlusClass objects describing construction and materials")]
        [Input("construction", "A BHoM Construction object")]
        [Output("energyPlusClasses", "A list of EnergyPlus objects")]
        public static List<IEnergyPlusClass> ToEnergyPlus(this BHP.Construction construction)
        {
            List<IEnergyPlusClass> classes = new List<IEnergyPlusClass>();
            EnergyPlusConstruction eplusConstruction = new EnergyPlusConstruction();
            string constructionName = construction.Name == "" ? construction.BHoM_Guid.ToString() : construction.Name;
            eplusConstruction.Name = constructionName;

            foreach (Layer layer in construction.Layers)
            {
                IEnergyPlusClass cls = layer.ToEnergyPlus();
                classes.Add(cls);
                eplusConstruction.Layers.Add(cls.Name);
            }

            classes.Add(eplusConstruction);

            return classes;
        }
    }
}
