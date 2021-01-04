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

using BH.Engine.Reflection;
using BH.oM.Adapters.EnergyPlus;
using BH.oM.Geometry;
using BH.oM.Reflection;
using BH.oM.Reflection.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace BH.Engine.Adapters.EnergyPlus
{
    public static partial class Convert
    {
        [Description("Convert an IEnergyPlusClass object to it's string representation for passing to IDF file")]
        [Input("energyPlusClass", "IEnergyPlusClass object")]
        [Output("energyPlusString", "String representation of IEnergyPlusClass object/s")]
        public static string ToEnergyPlusString(this IEnergyPlusClass energyPlusClass)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(energyPlusClass.ClassName + ",\n");

            List<PropertyInfo> properties = new List<PropertyInfo>();
            foreach (PropertyInfo property in energyPlusClass.GetType().GetProperties())
            {
                if (Attribute.IsDefined(property, typeof(OrderAttribute)))
                {
                    properties.Add(property);
                }
            }

            string formatString = "    {0}, !- {1}\n";
            foreach (PropertyInfo property in properties)
            {
                if ((energyPlusClass.ClassName == "BuildingSurface:Detailed") && (property.Name == "Vertices"))
                {
                    int subIncrementor = 1;
                    foreach (Point vertex in (energyPlusClass as BuildingSurfaceDetailed).Vertices)
                    {
                        sb.AppendFormat(formatString, vertex.X, String.Format("Vertex{0}XCoordinate", subIncrementor));
                        sb.AppendFormat(formatString, vertex.Y, String.Format("Vertex{0}YCoordinate", subIncrementor));
                        sb.AppendFormat(formatString, vertex.Z, String.Format("Vertex{0}ZCoordinate", subIncrementor));
                        subIncrementor += 1;
                    }
                }
                else if ((energyPlusClass.ClassName == "FenestrationSurface:Detailed") && (property.Name == "Vertices"))
                {
                    int subIncrementor = 1;
                    foreach (Point vertex in (energyPlusClass as FenestrationSurfaceDetailed).Vertices)
                    {
                        sb.AppendFormat(formatString, vertex.X, String.Format("Vertex{0}XCoordinate", subIncrementor));
                        sb.AppendFormat(formatString, vertex.Y, String.Format("Vertex{0}YCoordinate", subIncrementor));
                        sb.AppendFormat(formatString, vertex.Z, String.Format("Vertex{0}ZCoordinate", subIncrementor));
                        subIncrementor += 1;
                    }
                }
                else if ((energyPlusClass.ClassName == "Shading:Building:Detailed") && (property.Name == "Vertices"))
                {
                    int subIncrementor = 1;
                    foreach (Point vertex in (energyPlusClass as ShadingBuildingDetailed).Vertices)
                    {
                        sb.AppendFormat(formatString, vertex.X, String.Format("Vertex{0}XCoordinate", subIncrementor));
                        sb.AppendFormat(formatString, vertex.Y, String.Format("Vertex{0}YCoordinate", subIncrementor));
                        sb.AppendFormat(formatString, vertex.Z, String.Format("Vertex{0}ZCoordinate", subIncrementor));
                        subIncrementor += 1;
                    }
                }
                else if (energyPlusClass.ClassName == "Construction" && property.Name == "Layers")
                {
                    int subIncrementor = 1;
                    foreach (string layerName in (energyPlusClass as EPConstruction).Layers)
                    {
                        sb.AppendFormat(formatString, layerName, subIncrementor == 1 ? "OutsideLayer" : String.Format("Layer{0}", subIncrementor).ToString());
                        subIncrementor += 1;
                    }
                }
                else if (energyPlusClass.ClassName == "ZoneList" && property.Name == "ZoneNames")
                {
                    int subIncrementor = 1;
                    foreach (string zoneName in (energyPlusClass as ZoneList).ZoneNames)
                    {
                        sb.AppendFormat(formatString, zoneName, String.Format("Zone{0}Name", subIncrementor).ToString());
                        subIncrementor += 1;
                    }
                }
                else
                {
                    if (property.PropertyType == typeof(bool))
                    {
                        sb.AppendFormat(formatString, BH.Engine.Adapters.EnergyPlus.Convert.ToEnergyPlus((bool)energyPlusClass.PropertyValue(property.Name)), property.Name);
                    }
                    else if (property.PropertyType == typeof(SurfaceConvectionAlgorithmOutsideMethod))
                    {
                        sb.AppendFormat(formatString, energyPlusClass.PropertyValue(property.Name).ToString().Replace("DOE2", "DOE-2"), property.Name);
                    }
                    else
                    {
                        sb.AppendFormat(formatString, energyPlusClass.PropertyValue(property.Name), property.Name);
                    }
                }
            }
            sb.Append("\n");

            string resultString = sb.ToString();
            int lastComma = resultString.LastIndexOf(",");
            string cleanString = resultString.Remove(lastComma, ",".Length).Insert(lastComma, ";");
            return cleanString;
        }
    }
}

