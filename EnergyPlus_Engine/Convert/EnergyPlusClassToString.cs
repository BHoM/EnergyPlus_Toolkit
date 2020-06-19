﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using BH.Engine.Reflection;
using BH.oM.Reflection;
using BH.oM.EnergyPlus;
using BH.oM.Geometry;


/////
//using BH.Engine.Diffing;
///// 
/////
//BH.oM.Diffing.DiffConfig proptignore = new oM.Diffing.DiffConfig();
//proptignore.PropertiesToIgnore = new List<string>() { "A", "B" };
//            BH.Engine.Diffing.Query.DifferentProperties(glzMaterials[0], glzMaterials[1]);
//            ///

namespace BH.Engine.EnergyPlus
{
    public static partial class Convert
    {
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
                else if (energyPlusClass.ClassName == "Construction" && property.Name == "Layers")
                {
                    int subIncrementor = 1;
                    foreach (string layerName in (energyPlusClass as EnergyPlusConstruction).Layers)
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
                        sb.AppendFormat(formatString, BH.Engine.EnergyPlus.Convert.Boolean((bool)energyPlusClass.PropertyValue(property.Name)), property.Name);
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