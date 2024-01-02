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

//using BH.oM.Base;
//using System.Collections.Generic;
//using System.ComponentModel;
//
//namespace BH.oM.Adapters.EnergyPlus
//{
//public class PipingSystem:Underground:Domain : BHoMObject
//{
//[Description("No description available")]
//public virtual alpha Name { get; set; } = new alpha;
//[Description("Domain extent in the local 'X' direction")]
//public virtual real Xmax { get; set; } = new real;
//[Description("Domain extent in the local 'Y' direction")]
//public virtual real Ymax { get; set; } = new real;
//[Description("Domain extent in the local 'Y' direction")]
//public virtual real Zmax { get; set; } = new real;
//[Description("If mesh type is symmetric geometric, this should be an even number.")]
//public virtual integer X-DirectionMeshDensityParameter { get; set; } = new integer;
//[Description("No description available")]
//public virtual choice X-DirectionMeshType { get; set; } = new choice;
//[Description("optional")]
//public virtual real X-DirectionGeometricCoefficient { get; set; } = new real;
//[Description("If mesh type is symmetric geometric, this should be an even number.")]
//public virtual integer Y-DirectionMeshDensityParameter { get; set; } = new integer;
//[Description("No description available")]
//public virtual choice Y-DirectionMeshType { get; set; } = new choice;
//[Description("optional")]
//public virtual real Y-DirectionGeometricCoefficient { get; set; } = new real;
//[Description("If mesh type is symmetric geometric, this should be an even number.")]
//public virtual integer Z-DirectionMeshDensityParameter { get; set; } = new integer;
//[Description("No description available")]
//public virtual choice Z-DirectionMeshType { get; set; } = new choice;
//[Description("optional")]
//public virtual real Z-DirectionGeometricCoefficient { get; set; } = new real;
//[Description("No description available")]
//public virtual real SoilThermalConductivity { get; set; } = new real;
//[Description("No description available")]
//public virtual real SoilDensity { get; set; } = new real;
//[Description("This is a dry soil property, which is adjusted for freezing effects")]
//public virtual real SoilSpecificHeat { get; set; } = new real;
//[Description("No description available")]
//public virtual real SoilMoistureContentVolumeFraction { get; set; } = new real;
//[Description("No description available")]
//public virtual real SoilMoistureContentVolumeFractionAtSaturation { get; set; } = new real;
//[Description("No description available")]
//public virtual choice UndisturbedGroundTemperatureModelType { get; set; } = new choice;
//[Description("No description available")]
//public virtual object-list UndisturbedGroundTemperatureModelName { get; set; } = new object-list;
//[Description("if Yes, then the following basement inputs are used")]
//public virtual choice ThisDomainIncludesBasementSurfaceInteraction { get; set; } = new choice;
//[Description("Required only if Domain Has Basement Interaction")]
//public virtual real WidthOfBasementFloorInGroundDomain { get; set; } = new real;
//[Description("Required only if Domain Has Basement Interaction")]
//public virtual real DepthOfBasementWallInGroundDomain { get; set; } = new real;
//[Description("Required only if Domain Has Basement Interaction")]
//public virtual choice ShiftPipeXCoordinatesByBasementWidth { get; set; } = new choice;
//[Description("Required only if Domain Has Basement Interaction")]
//public virtual object-list NameOfBasementWallBoundaryConditionModel { get; set; } = new object-list;
//[Description("Required only if Domain Has Basement Interaction")]
//public virtual object-list NameOfBasementFloorBoundaryConditionModel { get; set; } = new object-list;
//[Description("No description available")]
//public virtual real ConvergenceCriterionForTheOuterCartesianDomainIterationLoop { get; set; } = new real;
//[Description("No description available")]
//public virtual integer MaximumIterationsInTheOuterCartesianDomainIterationLoop { get; set; } = new integer;
//[Description("This specifies the ground cover effects during evapotranspiration")]
//public virtual real EvapotranspirationGroundCoverParameter { get; set; } = new real;
//[Description("No description available")]
//public virtual integer NumberOfPipeCircuitsEnteredForThisDomain { get; set; } = new integer;
//[Description("Name of a pipe circuit to be simulated in this domain")]
//public virtual object-list PipeCircuit1 { get; set; } = new object-list;
//[Description("optional")]
//public virtual object-list PipeCircuit2 { get; set; } = new object-list;
//[Description("optional")]
//public virtual object-list PipeCircuit3 { get; set; } = new object-list;
//[Description("optional")]
//public virtual object-list PipeCircuit4 { get; set; } = new object-list;
//[Description("optional")]
//public virtual object-list PipeCircuit5 { get; set; } = new object-list;
//[Description("optional")]
//public virtual object-list PipeCircuit6 { get; set; } = new object-list;
//}
//}




