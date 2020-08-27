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
////public class Pump:VariableSpeed : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("No description available")]
////public virtual node InletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node OutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual null DesignMaximumFlowRate { get; set; } = new null;
////[Description("default head is 60 feet")]
////public virtual null DesignPumpHead { get; set; } = new null;
////[Description("When autosized the type of scaling factor is chosen in the input field Design Power Sizing Method")]
////public virtual null DesignPowerConsumption { get; set; } = new null;
////[Description("This is the motor efficiency only. When the Design Power Consumption is autosized using PowerPerFlowPerPressure,")]
////public virtual real MotorEfficiency { get; set; } = new real;
////[Description("No description available")]
////public virtual null FractionOfMotorInefficienciesToFluidStream { get; set; } = new null;
////[Description("No description available")]
////public virtual null Coefficient1OfThePartLoadPerformanceCurve { get; set; } = new null;
////[Description("No description available")]
////public virtual null Coefficient2OfThePartLoadPerformanceCurve { get; set; } = new null;
////[Description("No description available")]
////public virtual null Coefficient3OfThePartLoadPerformanceCurve { get; set; } = new null;
////[Description("No description available")]
////public virtual null Coefficient4OfThePartLoadPerformanceCurve { get; set; } = new null;
////[Description("When autosized the scaling factor is the input field Design Minimum Flow Rate Fraction")]
////public virtual null DesignMinimumFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual choice PumpControlType { get; set; } = new choice;
////[Description("Modifies the rated flow rate of the pump on a time basis. Default is")]
////public virtual object-list PumpFlowRateScheduleName { get; set; } = new object-list;
////[Description("This references any single independent variable polynomial curve in order to")]
////public virtual object-list PumpCurveName { get; set; } = new object-list;
////[Description(""D" in above expression in field A6")]
////public virtual real ImpellerDiameter { get; set; } = new real;
////[Description("No description available")]
////public virtual choice VFDControlType { get; set; } = new choice;
////[Description("Modifies the rpm of the pump on a time basis. Default is")]
////public virtual object-list PumpRPMScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list MinimumPressureSchedule { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list MaximumPressureSchedule { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list MinimumRPMSchedule { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list MaximumRPMSchedule { get; set; } = new object-list;
////[Description("optional, if used pump losses transfered to zone as internal gains")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("optional. If zone identified in previous field then this determines")]
////public virtual real SkinLossRadiativeFraction { get; set; } = new real;
////[Description("Used to indicate which sizing factor is used to calculate Design Power Consumption.")]
////public virtual choice DesignPowerSizingMethod { get; set; } = new choice;
////[Description("Used to size Design Power Consumption from design flow rate")]
////public virtual real DesignElectricPowerPerUnitFlowRate { get; set; } = new real;
////[Description("Used to size Design Power Consumption from design flow rate for head and motor efficiency")]
////public virtual real DesignShaftPowerPerUnitFlowRatePerUnitHead { get; set; } = new real;
////[Description("Used to size Design Minimum Flow Rate")]
////public virtual real DesignMinimumFlowRateFraction { get; set; } = new real;
////[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Subcategory table.")]
////public virtual alpha End-UseSubcategory { get; set; } = new alpha;
////}
////}
