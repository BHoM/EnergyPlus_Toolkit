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

////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.Adapters.EnergyPlus
////{
////public class HeatExchanger:Desiccant:BalancedFlow:PerformanceDataType1 : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Air flow rate at nominal conditions (assumed to be the same for both sides")]
////public virtual real NominalAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real NominalAirFaceVelocity { get; set; } = new real;
////[Description("Parasitic electric power (e.g., desiccant wheel motor)")]
////public virtual real NominalElectricPower { get; set; } = new real;
////[Description("No description available")]
////public virtual real TemperatureEquationCoefficient1 { get; set; } = new real;
////[Description("No description available")]
////public virtual real TemperatureEquationCoefficient2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real TemperatureEquationCoefficient3 { get; set; } = new real;
////[Description("No description available")]
////public virtual real TemperatureEquationCoefficient4 { get; set; } = new real;
////[Description("No description available")]
////public virtual real TemperatureEquationCoefficient5 { get; set; } = new real;
////[Description("No description available")]
////public virtual real TemperatureEquationCoefficient6 { get; set; } = new real;
////[Description("No description available")]
////public virtual real TemperatureEquationCoefficient7 { get; set; } = new real;
////[Description("No description available")]
////public virtual real TemperatureEquationCoefficient8 { get; set; } = new real;
////[Description("No description available")]
////public virtual real MinimumRegenerationInletAirHumidityRatioForTemperatureEquation { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumRegenerationInletAirHumidityRatioForTemperatureEquation { get; set; } = new real;
////[Description("No description available")]
////public virtual real MinimumRegenerationInletAirTemperatureForTemperatureEquation { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumRegenerationInletAirTemperatureForTemperatureEquation { get; set; } = new real;
////[Description("No description available")]
////public virtual real MinimumProcessInletAirHumidityRatioForTemperatureEquation { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumProcessInletAirHumidityRatioForTemperatureEquation { get; set; } = new real;
////[Description("No description available")]
////public virtual real MinimumProcessInletAirTemperatureForTemperatureEquation { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumProcessInletAirTemperatureForTemperatureEquation { get; set; } = new real;
////[Description("No description available")]
////public virtual real MinimumRegenerationAirVelocityForTemperatureEquation { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumRegenerationAirVelocityForTemperatureEquation { get; set; } = new real;
////[Description("No description available")]
////public virtual real MinimumRegenerationOutletAirTemperatureForTemperatureEquation { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumRegenerationOutletAirTemperatureForTemperatureEquation { get; set; } = new real;
////[Description("No description available")]
////public virtual real MinimumRegenerationInletAirRelativeHumidityForTemperatureEquation { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumRegenerationInletAirRelativeHumidityForTemperatureEquation { get; set; } = new real;
////[Description("No description available")]
////public virtual real MinimumProcessInletAirRelativeHumidityForTemperatureEquation { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumProcessInletAirRelativeHumidityForTemperatureEquation { get; set; } = new real;
////[Description("No description available")]
////public virtual real HumidityRatioEquationCoefficient1 { get; set; } = new real;
////[Description("No description available")]
////public virtual real HumidityRatioEquationCoefficient2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real HumidityRatioEquationCoefficient3 { get; set; } = new real;
////[Description("No description available")]
////public virtual real HumidityRatioEquationCoefficient4 { get; set; } = new real;
////[Description("No description available")]
////public virtual real HumidityRatioEquationCoefficient5 { get; set; } = new real;
////[Description("No description available")]
////public virtual real HumidityRatioEquationCoefficient6 { get; set; } = new real;
////[Description("No description available")]
////public virtual real HumidityRatioEquationCoefficient7 { get; set; } = new real;
////[Description("No description available")]
////public virtual real HumidityRatioEquationCoefficient8 { get; set; } = new real;
////[Description("No description available")]
////public virtual real MinimumRegenerationInletAirHumidityRatioForHumidityRatioEquation { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumRegenerationInletAirHumidityRatioForHumidityRatioEquation { get; set; } = new real;
////[Description("No description available")]
////public virtual real MinimumRegenerationInletAirTemperatureForHumidityRatioEquation { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumRegenerationInletAirTemperatureForHumidityRatioEquation { get; set; } = new real;
////[Description("No description available")]
////public virtual real MinimumProcessInletAirHumidityRatioForHumidityRatioEquation { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumProcessInletAirHumidityRatioForHumidityRatioEquation { get; set; } = new real;
////[Description("No description available")]
////public virtual real MinimumProcessInletAirTemperatureForHumidityRatioEquation { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumProcessInletAirTemperatureForHumidityRatioEquation { get; set; } = new real;
////[Description("No description available")]
////public virtual real MinimumRegenerationAirVelocityForHumidityRatioEquation { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumRegenerationAirVelocityForHumidityRatioEquation { get; set; } = new real;
////[Description("No description available")]
////public virtual real MinimumRegenerationOutletAirHumidityRatioForHumidityRatioEquation { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumRegenerationOutletAirHumidityRatioForHumidityRatioEquation { get; set; } = new real;
////[Description("No description available")]
////public virtual real MinimumRegenerationInletAirRelativeHumidityForHumidityRatioEquation { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumRegenerationInletAirRelativeHumidityForHumidityRatioEquation { get; set; } = new real;
////[Description("No description available")]
////public virtual real MinimumProcessInletAirRelativeHumidityForHumidityRatioEquation { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumProcessInletAirRelativeHumidityForHumidityRatioEquation { get; set; } = new real;
////}
////}




