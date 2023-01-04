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

////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.Adapters.EnergyPlus
////{
////public class AirflowNetwork:SimulationControl : BHoMObject
////{
////[Description("Enter a unique name for this object.")]
////public virtual null Name { get; set; } = new null;
////[Description("NoMultizoneOrDistribution: Only perform Simple calculations (objects ZoneInfiltration:*,")]
////public virtual choice AirflowNetworkControl { get; set; } = new choice;
////[Description("Input: User must enter AirflowNetwork:MultiZone:WindPressureCoefficientArray,")]
////public virtual choice WindPressureCoefficientType { get; set; } = new choice;
////[Description("If ExternalNode is selected, the height given in the")]
////public virtual choice HeightSelectionForLocalWindPressureCalculation { get; set; } = new choice;
////[Description("Used only if Wind Pressure Coefficient Type = SurfaceAverageCalculation,")]
////public virtual choice BuildingType { get; set; } = new choice;
////[Description("Determines the maximum number of iterations used to converge on a solution. If this limit")]
////public virtual integer MaximumNumberOfIterations { get; set; } = new integer;
////[Description("No description available")]
////public virtual choice InitializationType { get; set; } = new choice;
////[Description("This tolerance is defined as the absolute value of the sum of the mass Flow Rates")]
////public virtual real RelativeAirflowConvergenceTolerance { get; set; } = new real;
////[Description("This tolerance is defined as the absolute value of the sum of the mass flow rates. The mass")]
////public virtual real AbsoluteAirflowConvergenceTolerance { get; set; } = new real;
////[Description("Used only for AirflowNetwork:SimulationControl")]
////public virtual real ConvergenceAccelerationLimit { get; set; } = new real;
////[Description("Degrees clockwise from true North.")]
////public virtual real AzimuthAngleOfLongAxisOfBuilding { get; set; } = new real;
////[Description("Used only if Wind Pressure Coefficient Type = SurfaceAverageCalculation.")]
////public virtual real RatioOfBuildingWidthAlongShortAxisToWidthAlongLongAxis { get; set; } = new real;
////[Description("If True, external node temperature is height dependent.")]
////public virtual choice HeightDependenceOfExternalNodeTemperature { get; set; } = new choice;
////[Description("Select the solver to use for the pressure network solution")]
////public virtual choice Solver { get; set; } = new choice;
////}
////}



