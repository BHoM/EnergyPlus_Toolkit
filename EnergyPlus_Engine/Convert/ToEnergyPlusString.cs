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
        // Private methods here for referenced formatting of EPlus strings
        private const string formatStringA = "{0},\n";
        private const string formatStringB = "\t{0}, !- {1}\n";
        private const string formatStringC = "\t{0}; !- {1}\n\n";

        public static string ToEnergyPlusString(this List<Point> vertices)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < vertices.Count; i++)
            {
                sb.AppendFormat(formatStringB, vertices[i].X, String.Format("Vertex{0}XCoordinate", i + 1));
                sb.AppendFormat(formatStringB, vertices[i].Y, String.Format("Vertex{0}YCoordinate", i + 1));
                sb.AppendFormat(formatStringB, vertices[i].Z, String.Format("Vertex{0}ZCoordinate", i + 1));
            }
            string resultString = sb.ToString();
            int lastComma = resultString.LastIndexOf(",");
            string cleanString = resultString.Remove(lastComma, ",".Length).Insert(lastComma, ";");
            return cleanString;
        }
        
        public static string ToEnergyPlusString(this List<IEnergyPlusMaterial> layers)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < layers.Count; i++)
            {
                sb.AppendFormat(formatStringB, layers[i].Name, i == 0 ? "OutsideLayer" : String.Format("Layer{0}", i + 1));
            }
            string resultString = sb.ToString();
            int lastComma = resultString.LastIndexOf(",");
            string cleanString = resultString.Remove(lastComma, ",".Length).Insert(lastComma, ";");
            return cleanString;
        }
        
        public static string ToEnergyPlusString(this EPMaterial material)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(formatStringA, material.ClassName);
            sb.AppendFormat(formatStringB, "Name", material.Name);
            sb.AppendFormat(formatStringB, "Roughness", material.Roughness);
            sb.AppendFormat(formatStringB, "Thickness", material.Thickness);
            sb.AppendFormat(formatStringB, "Conductivity", material.Conductivity);
            sb.AppendFormat(formatStringB, "Density", material.Density);
            sb.AppendFormat(formatStringB, "SpecificHeat", material.SpecificHeat);
            sb.AppendFormat(formatStringB, "ThermalAbsorptance", material.ThermalAbsorptance);
            sb.AppendFormat(formatStringB, "SolarAbsorptance", material.SolarAbsorptance);
            sb.AppendFormat(formatStringC, "VisibleAbsorptance", material.VisibleAbsorptance);
            return sb.ToString();
        }
        
        public static string ToEnergyPlusString(this EPMaterialVegetation material)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(formatStringA, material.ClassName);
            sb.AppendFormat(formatStringB, "Name", material.Name);
            sb.AppendFormat(formatStringB, "HeightOfPlants", material.HeightOfPlants);
            sb.AppendFormat(formatStringB, "LeafAreaIndex", material.LeafAreaIndex);
            sb.AppendFormat(formatStringB, "LeafReflectivity", material.LeafReflectivity);
            sb.AppendFormat(formatStringB, "LeafEmissivity", material.LeafEmissivity);
            sb.AppendFormat(formatStringB, "MinimumStomatalResistance", material.MinimumStomatalResistance);
            sb.AppendFormat(formatStringB, "SoilLayerName", material.SoilLayerName);
            sb.AppendFormat(formatStringB, "Roughness", material.Roughness);
            sb.AppendFormat(formatStringB, "Thickness", material.Thickness);
            sb.AppendFormat(formatStringB, "ConductivityOfDrySoil", material.ConductivityOfDrySoil);
            sb.AppendFormat(formatStringB, "DensityOfDrySoil", material.DensityOfDrySoil);
            sb.AppendFormat(formatStringB, "SpecificHeatOfDrySoil", material.SpecificHeatOfDrySoil);
            sb.AppendFormat(formatStringB, "ThermalAbsorptance", material.ThermalAbsorptance);
            sb.AppendFormat(formatStringB, "SolarAbsorptance", material.SolarAbsorptance);
            sb.AppendFormat(formatStringB, "VisibleAbsorptance", material.VisibleAbsorptance);
            sb.AppendFormat(formatStringB, "SaturationVolumetricMoistureContentOfTheSoilLayer", material.SaturationVolumetricMoistureContentOfTheSoilLayer);
            sb.AppendFormat(formatStringB, "ResidualVolumetricMoistureContentOfTheSoilLayer", material.ResidualVolumetricMoistureContentOfTheSoilLayer);
            sb.AppendFormat(formatStringB, "InitialVolumetricMoistureContentOfTheSoilLayer", material.InitialVolumetricMoistureContentOfTheSoilLayer);
            sb.AppendFormat(formatStringC, "MoistureDiffusionCalculationMethod", material.MoistureDiffusionCalculationMethod);
            return sb.ToString();
        }
        
        public static string ToEnergyPlusString(this EPMaterialWindowGlazing material)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(formatStringA, material.ClassName);
            sb.AppendFormat(formatStringB, "Name", material.Name);
            sb.AppendFormat(formatStringB, "OpticalDataType", material.OpticalDataType);
            sb.AppendFormat(formatStringB, "WindowGlassSpectralDataSetName", material.WindowGlassSpectralDataSetName);
            sb.AppendFormat(formatStringB, "Thickness", material.Thickness);
            sb.AppendFormat(formatStringB, "SolarTransmittanceAtNormalIncidence", material.SolarTransmittanceAtNormalIncidence);
            sb.AppendFormat(formatStringB, "FrontSideSolarReflectanceAtNormalIncidence", material.FrontSideSolarReflectanceAtNormalIncidence);
            sb.AppendFormat(formatStringB, "BackSideSolarReflectanceAtNormalIncidence", material.BackSideSolarReflectanceAtNormalIncidence);
            sb.AppendFormat(formatStringB, "VisibleTransmittanceAtNormalIncidence", material.VisibleTransmittanceAtNormalIncidence);
            sb.AppendFormat(formatStringB, "FrontSideVisibleReflectanceAtNormalIncidence", material.FrontSideVisibleReflectanceAtNormalIncidence);
            sb.AppendFormat(formatStringB, "BackSideVisibleReflectanceAtNormalIncidence", material.BackSideVisibleReflectanceAtNormalIncidence);
            sb.AppendFormat(formatStringB, "InfraredTransmittanceAtNormalIncidence", material.InfraredTransmittanceAtNormalIncidence);
            sb.AppendFormat(formatStringB, "FrontSideInfraredHemisphericalEmissivity", material.FrontSideInfraredHemisphericalEmissivity);
            sb.AppendFormat(formatStringB, "BackSideInfraredHemisphericalEmissivity", material.BackSideInfraredHemisphericalEmissivity);
            sb.AppendFormat(formatStringB, "Conductivity", material.Conductivity);
            sb.AppendFormat(formatStringB, "DirtCorrectionFactorForSolarAndVisibleTransmittance", material.DirtCorrectionFactorForSolarAndVisibleTransmittance);
            sb.AppendFormat(formatStringB, "SolarDiffusing", material.SolarDiffusing);
            sb.AppendFormat(formatStringB, "YoungsModulus", material.YoungsModulus);
            sb.AppendFormat(formatStringC, "PoissonsRatio", material.PoissonsRatio);
            return sb.ToString();
        }
        
        public static string ToEnergyPlusString(this EPMaterialWindowGas material)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(formatStringA, material.ClassName);
            sb.AppendFormat(formatStringB, "Name", material.Name);
            sb.AppendFormat(formatStringB, "GasType", material.GasType);
            sb.AppendFormat(formatStringC, "Thickness", material.Thickness);
            return sb.ToString();
        }
        
        public static string ToEnergyPlusString(this IEnergyPlusMaterial material)
        {
            return material.ToEnergyPlusString();
        }
        
        public static string ToEnergyPlusString(this EPConstruction construction, bool includeMaterials = false)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(formatStringA, construction.ClassName);
            sb.AppendFormat(formatStringB, "Name", construction.Name);
            sb.Append(construction.Layers.ToEnergyPlusString());
            return sb.ToString();
        }



        // Public methods

        //[Description("Convert a BuildingSurfaceDetailed object to it's string representation for passing to IDF file")]
        //[Input("buildingSurfaceDetailed", "An EnergyPlus BuildingSurfaceDetailed object")]
        //[Output("energyPlusString", "String representation of IEnergyPlusClass object/s")]
        //public static string ToEnergyPlusString(this BuildingSurfaceDetailed buildingSurfaceDetailed) 
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append(buildingSurfaceDetailed.ClassName + ",\n");
        //    sb.Append(buildingSurfaceDetailed.)
        //    List<PropertyInfo> properties = new List<PropertyInfo>();
            
        //    foreach (PropertyInfo property in buildingSurfaceDetailed.GetType().GetProperties())
        //    {
        //        if (Attribute.IsDefined(property, typeof(OrderAttribute)))
        //        {
        //            if (property.PropertyType == typeof(bool))
        //            {
        //                sb.AppendFormat(formatString, ((bool)buildingSurfaceDetailed.PropertyValue(property.Name)).ToEnergyPlus(), property.Name);
        //            }
        //            else if (property.PropertyType == typeof(List<Point>))
        //            {
        //                sb.Append(buildingSurfaceDetailed.PropertyValue(property.Name).ToEnergyPlusString());
        //            }
        //            else
        //            {
        //                sb.AppendFormat(formatString, buildingSurfaceDetailed.PropertyValue(property.Name), property.Name);
        //            }
        //        }
        //    }
        //    foreach (PropertyInfo property in properties)
        //    {

        //        sb.AppendFormat(formatString, energyPlusClass.PropertyValue(property.Name), property.Name);

        //    sb.Append(buildingSurfaceDetailed.Vertices.ToEnergyPlusString());
        //    sb.Append("\n");

        //    string resultString = sb.ToString();
        //    int lastComma = resultString.LastIndexOf(",");
        //    string cleanString = resultString.Remove(lastComma, ",".Length).Insert(lastComma, ";");
        //    return cleanString;
        //}

        //[Description("Convert an IEnergyPlusClass object to it's string representation for passing to IDF file")]
        //[Input("energyPlusClass", "IEnergyPlusClass object")]
        //[Output("energyPlusString", "String representation of IEnergyPlusClass object/s")]
        //public static string ToEnergyPlusString(this IEnergyPlusClass energyPlusClass)
        //{
        //    StringBuilder sb = new StringBuilder();

        //    sb.Append(energyPlusClass.ClassName + ",\n");

        //    List<PropertyInfo> properties = new List<PropertyInfo>();
        //    foreach (PropertyInfo property in energyPlusClass.GetType().GetProperties())
        //    {
        //        if (Attribute.IsDefined(property, typeof(OrderAttribute)))
        //        {
        //            properties.Add(property);
        //        }
        //    }

        //    string formatString = "    {0}, !- {1}\n";
        //    foreach (PropertyInfo property in properties)
        //    {
        //        if ((energyPlusClass.ClassName == "BuildingSurface:Detailed") && (property.Name == "Vertices"))
        //        {
        //            int subIncrementor = 1;
        //            foreach (Point vertex in (energyPlusClass as BuildingSurfaceDetailed).Vertices)
        //            {
        //                sb.AppendFormat(formatString, vertex.X, String.Format("Vertex{0}XCoordinate", subIncrementor));
        //                sb.AppendFormat(formatString, vertex.Y, String.Format("Vertex{0}YCoordinate", subIncrementor));
        //                sb.AppendFormat(formatString, vertex.Z, String.Format("Vertex{0}ZCoordinate", subIncrementor));
        //                subIncrementor += 1;
        //            }
        //        }
        //        else if ((energyPlusClass.ClassName == "FenestrationSurface:Detailed") && (property.Name == "Vertices"))
        //        {
        //            int subIncrementor = 1;
        //            foreach (Point vertex in (energyPlusClass as FenestrationSurfaceDetailed).Vertices)
        //            {
        //                sb.AppendFormat(formatString, vertex.X, String.Format("Vertex{0}XCoordinate", subIncrementor));
        //                sb.AppendFormat(formatString, vertex.Y, String.Format("Vertex{0}YCoordinate", subIncrementor));
        //                sb.AppendFormat(formatString, vertex.Z, String.Format("Vertex{0}ZCoordinate", subIncrementor));
        //                subIncrementor += 1;
        //            }
        //        }
        //        else if ((energyPlusClass.ClassName == "Shading:Building:Detailed") && (property.Name == "Vertices"))
        //        {
        //            int subIncrementor = 1;
        //            foreach (Point vertex in (energyPlusClass as ShadingBuildingDetailed).Vertices)
        //            {
        //                sb.AppendFormat(formatString, vertex.X, String.Format("Vertex{0}XCoordinate", subIncrementor));
        //                sb.AppendFormat(formatString, vertex.Y, String.Format("Vertex{0}YCoordinate", subIncrementor));
        //                sb.AppendFormat(formatString, vertex.Z, String.Format("Vertex{0}ZCoordinate", subIncrementor));
        //                subIncrementor += 1;
        //            }
        //        }
        //        else if (energyPlusClass.ClassName == "Construction" && property.Name == "Layers")
        //        {
        //            int subIncrementor = 1;
        //            foreach (string layerName in (energyPlusClass as EPConstruction).Layers)
        //            {
        //                sb.AppendFormat(formatString, layerName, subIncrementor == 1 ? "OutsideLayer" : String.Format("Layer{0}", subIncrementor).ToString());
        //                subIncrementor += 1;
        //            }
        //        }
        //        else if (energyPlusClass.ClassName == "ZoneList" && property.Name == "ZoneNames")
        //        {
        //            int subIncrementor = 1;
        //            foreach (string zoneName in (energyPlusClass as ZoneList).ZoneNames)
        //            {
        //                sb.AppendFormat(formatString, zoneName, String.Format("Zone{0}Name", subIncrementor).ToString());
        //                subIncrementor += 1;
        //            }
        //        }
        //        else
        //        {
        //            if (property.PropertyType == typeof(bool))
        //            {
        //                sb.AppendFormat(formatString, BH.Engine.Adapters.EnergyPlus.Convert.ToEnergyPlus((bool)energyPlusClass.PropertyValue(property.Name)), property.Name);
        //            }
        //            else if (property.PropertyType == typeof(SurfaceConvectionAlgorithmOutsideMethod))
        //            {
        //                sb.AppendFormat(formatString, energyPlusClass.PropertyValue(property.Name).ToString().Replace("DOE2", "DOE-2"), property.Name);
        //            }
        //            else
        //            {
        //                sb.AppendFormat(formatString, energyPlusClass.PropertyValue(property.Name), property.Name);
        //            }
        //        }
        //    }
        //    sb.Append("\n");

        //    string resultString = sb.ToString();
        //    int lastComma = resultString.LastIndexOf(",");
        //    string cleanString = resultString.Remove(lastComma, ",".Length).Insert(lastComma, ";");
        //    return cleanString;
        //}
    }
}
