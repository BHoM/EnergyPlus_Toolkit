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
////namespace BH.oM.Adapters.EnergyPlus
////{
////public class Chiller:Electric : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("No description available")]
////public virtual choice CondenserType { get; set; } = new choice;
////[Description("No description available")]
////public virtual null NominalCapacity { get; set; } = new null;
////[Description("No description available")]
////public virtual null NominalCOP { get; set; } = new null;
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
////[Description("No description available")]
////public virtual null TemperatureRiseCoefficient { get; set; } = new null;
////[Description("No description available")]
////public virtual null DesignChilledWaterOutletTemperature { get; set; } = new null;
////[Description("For variable volume this is the maximum flow & for constant flow this is the flow.")]
////public virtual null DesignChilledWaterFlowRate { get; set; } = new null;
////[Description("This field is only used for Condenser Type = AirCooled or EvaporativelyCooled")]
////public virtual null DesignCondenserFluidFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual null Coefficient1OfCapacityRatioCurve { get; set; } = new null;
////[Description("No description available")]
////public virtual null Coefficient2OfCapacityRatioCurve { get; set; } = new null;
////[Description("No description available")]
////public virtual null Coefficient3OfCapacityRatioCurve { get; set; } = new null;
////[Description("No description available")]
////public virtual null Coefficient1OfPowerRatioCurve { get; set; } = new null;
////[Description("No description available")]
////public virtual null Coefficient2OfPowerRatioCurve { get; set; } = new null;
////[Description("No description available")]
////public virtual null Coefficient3OfPowerRatioCurve { get; set; } = new null;
////[Description("No description available")]
////public virtual null Coefficient1OfFullLoadRatioCurve { get; set; } = new null;
////[Description("No description available")]
////public virtual null Coefficient2OfFullLoadRatioCurve { get; set; } = new null;
////[Description("No description available")]
////public virtual null Coefficient3OfFullLoadRatioCurve { get; set; } = new null;
////[Description("No description available")]
////public virtual null ChilledWaterOutletTemperatureLowerLimit { get; set; } = new null;
////[Description("Select operating mode for fluid flow through the chiller. "NotModulated" is for")]
////public virtual choice ChillerFlowMode { get; set; } = new choice;
////[Description("If non-zero, then the heat recovery inlet and outlet node names must be entered.")]
////public virtual null DesignHeatRecoveryWaterFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual node HeatRecoveryInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node HeatRecoveryOutletNodeName { get; set; } = new node;
////[Description("Multiplies the autosized capacity and flow rates")]
////public virtual real SizingFactor { get; set; } = new real;
////[Description("This field is only used for Condenser Type = EvaporativelyCooled and for periods")]
////public virtual real BasinHeaterCapacity { get; set; } = new real;
////[Description("This field is only used for Condenser Type = EvaporativelyCooled.")]
////public virtual real BasinHeaterSetpointTemperature { get; set; } = new real;
////[Description("This field is only used for Condenser Type = EvaporativelyCooled.")]
////public virtual object-list BasinHeaterOperatingScheduleName { get; set; } = new object-list;
////[Description("This optional field is the fraction of total rejected heat that can be recovered at full load")]
////public virtual real CondenserHeatRecoveryRelativeCapacityFraction { get; set; } = new real;
////[Description("This optional schedule of temperatures will turn off heat recovery if inlet exceeds the value")]
////public virtual object-list HeatRecoveryInletHighTemperatureLimitScheduleName { get; set; } = new object-list;
////[Description("This optional field provides control over the heat recovery")]
////public virtual node HeatRecoveryLeavingTemperatureSetpointNodeName { get; set; } = new node;
////[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Subcategory table.")]
////public virtual alpha End-UseSubcategory { get; set; } = new alpha;
////}
////}
