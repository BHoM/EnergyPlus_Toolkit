/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2021, the respective contributors. All rights reserved.
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
    public class Zone : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "Zone";
        [Order]
        [Description("No description available")]
        public override string Name { get; set; } = "ExampleZone";
        [Order]
        [Description("No description available")]
        public virtual double DirectionOfRelativeNorth { get; set; } = 0;
        [Order]
        [Description("No description available")]
        public virtual double XOrigin { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double YOrigin { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double ZOrigin { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual int Type { get; set; } = 1;
        [Order]
        [Description("No description available")]
        public virtual int Multiplier { get; set; } = 1;
        [Order]
        [Description("If this field is 0.0, negative or autocalculate, then the average height")]
        public virtual string CeilingHeight { get; set; } = "autocalculate";
        [Order]
        [Description("If this field is 0.0, negative or autocalculate, then the volume of the zone")]
        public virtual string Volume { get; set; } = "autocalculate";
        [Order]
        [Description("If this field is 0.0, negative or autocalculate, then the floor area of the zone")]
        public virtual string FloorArea { get; set; } = "autocalculate";
        [Order]
        [Description("Will default to same value as SurfaceConvectionAlgorithm:Inside object")]
        public virtual SurfaceConvectionAlgorithmInsideMethod ZoneInsideConvectionAlgorithm { get; set; } = SurfaceConvectionAlgorithmInsideMethod.TARP;
        [Order]
        [Description("Will default to same value as SurfaceConvectionAlgorithm:Outside object")]
        public virtual SurfaceConvectionAlgorithmOutsideMethod ZoneOutsideConvectionAlgorithm { get; set; } = SurfaceConvectionAlgorithmOutsideMethod.DOE2;
        [Order]
        [Description("No description available")]
        public virtual bool PartOfTotalFloorArea { get; set; } = true;
    }
}

