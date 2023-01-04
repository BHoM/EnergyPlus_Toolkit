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
using BH.oM.Geometry;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.Adapters.EnergyPlus
{
    public class BuildingSurfaceDetailed : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "BuildingSurface:Detailed";
        [Order]
        [Description("Name of surface")]
        public override string Name { get; set; } = "";
        [Order]
        [Description("Type of surface")]
        public virtual BuildingSurfaceType SurfaceType { get; set; } = BuildingSurfaceType.Undefined;
        [Order]
        [Description("To be matched with a construction applied to surface")]
        public virtual string ConstructionName { get; set; } = "";
        [Order]
        [Description("Zone the surface is a part of")]
        public virtual string ZoneName { get; set; } = "";
        [Order]
        [Description("Adjacent (external) boundary condition of surface")]
        public virtual OutsideBoundaryCondition OutsideBoundaryCondition { get; set; } = OutsideBoundaryCondition.Undefined;
        [Order]
        [Description("Non-blank only if the field Outside Boundary Condition is Surface,")]
        public virtual string OutsideBoundaryConditionObject { get; set; } = "";
        [Order]
        [Description("True if exposed to Sun")]
        public virtual string SunExposure { get; set; } =  "NoSun";
        [Order]
        [Description("True if exposed to Wind")]
        public virtual string WindExposure { get; set; } = "NoWind";
        [Order]
        [Description("From the exterior of the surface")]
        public virtual string ViewFactorToGround { get; set; } = "autocalculate";
        [Order]
        [Description("Number of vertices comprising the surface boundary")]
        public virtual int NumberOfVertices { get; set; } = 0;
        [Order]
        [Description("List of surface boundary vertices")]
        public virtual List<Point> Vertices { get; set; } = new List<Point>();
    }
}



