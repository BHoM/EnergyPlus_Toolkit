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

////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class ZoneEarthtube : BHoMObject
////{
////[Description("No description available")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual string ScheduleName { get; set; } = new object-list;
////[Description(""Edesign" in Equation")]
////public virtual real DesignFlowRate { get; set; } = new real;
////[Description("this is the indoor temperature below which the earth tube is shut off")]
////public virtual real MinimumZoneTemperatureWhenCooling { get; set; } = new real;
////[Description("this is the indoor temperature above which the earth tube is shut off")]
////public virtual real MaximumZoneTemperatureWhenHeating { get; set; } = new real;
////[Description("This is the temperature difference between indoor and outdoor below which the earth tube is shut off")]
////public virtual real DeltaTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual choice EarthtubeType { get; set; } = new choice;
////[Description("pressure rise across the fan")]
////public virtual real FanPressureRise { get; set; } = new real;
////[Description("No description available")]
////public virtual real FanTotalEfficiency { get; set; } = new real;
////[Description("No description available")]
////public virtual real PipeRadius { get; set; } = new real;
////[Description("No description available")]
////public virtual real PipeThickness { get; set; } = new real;
////[Description("No description available")]
////public virtual real PipeLength { get; set; } = new real;
////[Description("No description available")]
////public virtual real PipeThermalConductivity { get; set; } = new real;
////[Description("No description available")]
////public virtual real PipeDepthUnderGroundSurface { get; set; } = new real;
////[Description("No description available")]
////public virtual choice SoilCondition { get; set; } = new choice;
////[Description("No description available")]
////public virtual real AverageSoilSurfaceTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual real AmplitudeOfSoilSurfaceTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual real PhaseConstantOfSoilSurfaceTemperature { get; set; } = new real;
////[Description(""A" in Equation")]
////public virtual real ConstantTermFlowCoefficient { get; set; } = new real;
////[Description(""B" in Equation")]
////public virtual real TemperatureTermFlowCoefficient { get; set; } = new real;
////[Description(""C" in Equation")]
////public virtual real VelocityTermFlowCoefficient { get; set; } = new real;
////[Description(""D" in Equation")]
////public virtual real VelocitySquaredTermFlowCoefficient { get; set; } = new real;
////}
////}
