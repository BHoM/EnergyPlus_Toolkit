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
////public class EvaporativeFluidCooler:SingleSpeed : BHoMObject
////{
////[Description("Fluid Cooler Name")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Name of Fluid Cooler water inlet node")]
////public virtual node WaterInletNodeName { get; set; } = new node;
////[Description("Name of Fluid Cooler water outlet node")]
////public virtual node WaterOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual real DesignAirFlowRate { get; set; } = new real;
////[Description("This is the fan motor electric input power")]
////public virtual real DesignAirFlowRateFanPower { get; set; } = new real;
////[Description("No description available")]
////public virtual real DesignSprayWaterFlowRate { get; set; } = new real;
////[Description("User can define fluid cooler thermal performance by specifying the fluid cooler UA")]
////public virtual choice PerformanceInputMethod { get; set; } = new choice;
////[Description("Enter the name of an outdoor air node")]
////public virtual node OutdoorAirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual real HeatRejectionCapacityAndNominalCapacitySizingRatio { get; set; } = new real;
////[Description("Standard design capacity with entering water at 35C (95F), leaving water at")]
////public virtual real StandardDesignCapacity { get; set; } = new real;
////[Description("Only used for Performance Input Method = UFactorTimesAreaAndDesignWaterFlowRate;")]
////public virtual real DesignAirFlowRateU-factorTimesAreaValue { get; set; } = new real;
////[Description("Input value is ignored if fluid cooler Performance Input Method= StandardDesignCapacity.")]
////public virtual real DesignWaterFlowRate { get; set; } = new real;
////[Description("Only used for Performance Input Method = UserSpecifiedDesignCapacity;")]
////public virtual real UserSpecifiedDesignCapacity { get; set; } = new real;
////[Description("Only used for Performance Input Method = UserSpecifiedDesignCapacity;")]
////public virtual real DesignEnteringWaterTemperature { get; set; } = new real;
////[Description("Only used for Performance Input Method = UserSpecifiedDesignCapacity;")]
////public virtual real DesignEnteringAirTemperature { get; set; } = new real;
////[Description("Only used for Performance Input Method = UserSpecifiedDesignCapacity;")]
////public virtual real DesignEnteringAirWet-bulbTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual choice CapacityControl { get; set; } = new choice;
////[Description("Multiplies the autosized capacity and flow rates")]
////public virtual real SizingFactor { get; set; } = new real;
////[Description("No description available")]
////public virtual choice EvaporationLossMode { get; set; } = new choice;
////[Description("Rate of water evaporation from the Fluid Cooler and lost to the outdoor air [%/K]")]
////public virtual real EvaporationLossFactor { get; set; } = new real;
////[Description("Rate of drift loss as a percentage of circulating spray water flow rate")]
////public virtual real DriftLossPercent { get; set; } = new real;
////[Description("No description available")]
////public virtual choice BlowdownCalculationMode { get; set; } = new choice;
////[Description("Characterizes the rate of blowdown in the Evaporative Fluid Cooler.")]
////public virtual real BlowdownConcentrationRatio { get; set; } = new real;
////[Description("Makeup water usage due to blowdown results from occasionally draining a small")]
////public virtual object-list BlowdownMakeupWaterUsageScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list SupplyWaterStorageTankName { get; set; } = new object-list;
////}
////}



