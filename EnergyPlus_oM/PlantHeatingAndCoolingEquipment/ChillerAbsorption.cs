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
////public class Chiller:Absorption : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("No description available")]
////public virtual real NominalCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual null NominalPumpingPower { get; set; } = new null;
////[Description("No description available")]
////public virtual node ChilledWaterInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node ChilledWaterOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node CondenserInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node CondenserOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual null MinimumPartLoadRatio { get; set; } = new null;
////[Description("No description available")]
////public virtual null MaximumPartLoadRatio { get; set; } = new null;
////[Description("No description available")]
////public virtual null OptimumPartLoadRatio { get; set; } = new null;
////[Description("No description available")]
////public virtual null DesignCondenserInletTemperature { get; set; } = new null;
////[Description("For variable volume this is the max flow & for constant flow this is the flow.")]
////public virtual real DesignChilledWaterFlowRate { get; set; } = new real;
////[Description("The steam use coefficients below specify the")]
////public virtual real DesignCondenserWaterFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual null Coefficient1OfTheHotWaterOrSteamUsePartLoadRatioCurve { get; set; } = new null;
////[Description("No description available")]
////public virtual null Coefficient2OfTheHotWaterOrSteamUsePartLoadRatioCurve { get; set; } = new null;
////[Description("No description available")]
////public virtual null Coefficient3OfTheHotWaterOrSteamUsePartLoadRatioCurve { get; set; } = new null;
////[Description("The pump electric use coefficients specify the")]
////public virtual null Coefficient1OfThePumpElectricUsePartLoadRatioCurve { get; set; } = new null;
////[Description("No description available")]
////public virtual null Coefficient2OfThePumpElectricUsePartLoadRatioCurve { get; set; } = new null;
////[Description("No description available")]
////public virtual null Coefficient3OfThePumpElectricUsePartLoadRatioCurve { get; set; } = new null;
////[Description("No description available")]
////public virtual null ChilledWaterOutletTemperatureLowerLimit { get; set; } = new null;
////[Description("No description available")]
////public virtual node GeneratorInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node GeneratorOutletNodeName { get; set; } = new node;
////[Description("Select operating mode for fluid flow through the chiller. "NotModulated" is for")]
////public virtual choice ChillerFlowMode { get; set; } = new choice;
////[Description("The Generator side of the chiller can be connected to a hot water or steam plant where the")]
////public virtual choice GeneratorHeatSourceType { get; set; } = new choice;
////[Description("No description available")]
////public virtual real DesignGeneratorFluidFlowRate { get; set; } = new real;
////[Description("This field is not used when the generator inlet/outlet nodes are not specified or")]
////public virtual real DegreeOfSubcoolingInSteamGenerator { get; set; } = new real;
////[Description("Multiplies the autosized capacity and flow rates")]
////public virtual real SizingFactor { get; set; } = new real;
////}
////}




