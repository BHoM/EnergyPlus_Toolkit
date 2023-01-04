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
////public class CoolingTower:TwoSpeed : BHoMObject
////{
////[Description("Tower Name")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Name of tower Water Inlet Node")]
////public virtual node WaterInletNodeName { get; set; } = new node;
////[Description("Name of tower Water Outlet Node")]
////public virtual node WaterOutletNodeName { get; set; } = new node;
////[Description("Leave field blank if Tower Performance Input Method is NominalCapacity")]
////public virtual real DesignWaterFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real HighFanSpeedAirFlowRate { get; set; } = new real;
////[Description("This is the fan motor electric input power at high speed")]
////public virtual real HighFanSpeedFanPower { get; set; } = new real;
////[Description("Leave field blank if Tower Performance Input Method is NominalCapacity")]
////public virtual real HighFanSpeedU-FactorTimesAreaValue { get; set; } = new real;
////[Description("Low speed air flow rate must be less than high speed air flow rate")]
////public virtual real LowFanSpeedAirFlowRate { get; set; } = new real;
////[Description("This field is only used if the previous field is set to autocalculate.")]
////public virtual real LowFanSpeedAirFlowRateSizingFactor { get; set; } = new real;
////[Description("This is the fan motor electric input power at low speed")]
////public virtual real LowFanSpeedFanPower { get; set; } = new real;
////[Description("This field is only used if the previous field is set to autocalculate.")]
////public virtual real LowFanSpeedFanPowerSizingFactor { get; set; } = new real;
////[Description("Leave field blank if tower Performance Input Method is NominalCapacity")]
////public virtual real LowFanSpeedU-FactorTimesAreaValue { get; set; } = new real;
////[Description("This field is only used if the previous field is set to autocalculate and")]
////public virtual real LowFanSpeedU-FactorTimesAreaSizingFactor { get; set; } = new real;
////[Description("No description available")]
////public virtual real FreeConvectionRegimeAirFlowRate { get; set; } = new real;
////[Description("This field is only used if the previous field is set to autocalculate.")]
////public virtual real FreeConvectionRegimeAirFlowRateSizingFactor { get; set; } = new real;
////[Description("Leave field blank if Tower Performance Input Method is NominalCapacity")]
////public virtual real FreeConvectionRegimeU-FactorTimesAreaValue { get; set; } = new real;
////[Description("This field is only used if the previous field is set to autocalculate and")]
////public virtual real FreeConvectionU-FactorTimesAreaValueSizingFactor { get; set; } = new real;
////[Description("User can define tower thermal performance by specifying the tower UA,")]
////public virtual choice PerformanceInputMethod { get; set; } = new choice;
////[Description("No description available")]
////public virtual real HeatRejectionCapacityAndNominalCapacitySizingRatio { get; set; } = new real;
////[Description("Nominal tower capacity with entering water at 35C (95F), leaving water at")]
////public virtual real HighSpeedNominalCapacity { get; set; } = new real;
////[Description("Nominal tower capacity with entering water at 35C (95F), leaving water at")]
////public virtual real LowSpeedNominalCapacity { get; set; } = new real;
////[Description("This field is only used if the previous field is set to autocalculate")]
////public virtual real LowSpeedNominalCapacitySizingFactor { get; set; } = new real;
////[Description("Tower capacity in free convection regime with entering water at 35C (95F),")]
////public virtual real FreeConvectionNominalCapacity { get; set; } = new real;
////[Description("This field is only used if the previous field is set to autocalculate")]
////public virtual real FreeConvectionNominalCapacitySizingFactor { get; set; } = new real;
////[Description("Enter the tower's design inlet air dry-bulb temperature")]
////public virtual real DesignInletAirDry-BulbTemperature { get; set; } = new real;
////[Description("Enter the tower's design inlet air wet-bulb temperature")]
////public virtual real DesignInletAirWet-BulbTemperature { get; set; } = new real;
////[Description("Enter the approach temperature corresponding to the design inlet air")]
////public virtual real DesignApproachTemperature { get; set; } = new real;
////[Description("Enter the range temperature corresponding to the design inlet air")]
////public virtual real DesignRangeTemperature { get; set; } = new real;
////[Description("This heater maintains the basin water temperature at the basin heater setpoint")]
////public virtual real BasinHeaterCapacity { get; set; } = new real;
////[Description("Enter the outdoor dry-bulb temperature when the basin heater turns on")]
////public virtual real BasinHeaterSetpointTemperature { get; set; } = new real;
////[Description("Schedule values greater than 0 allow the basin heater to operate whenever the outdoor")]
////public virtual object-list BasinHeaterOperatingScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice EvaporationLossMode { get; set; } = new choice;
////[Description("Rate of water evaporated from the cooling tower and lost to the outdoor air [%/K]")]
////public virtual real EvaporationLossFactor { get; set; } = new real;
////[Description("Rate of drift loss as a percentage of circulating condenser water flow rate")]
////public virtual real DriftLossPercent { get; set; } = new real;
////[Description("No description available")]
////public virtual choice BlowdownCalculationMode { get; set; } = new choice;
////[Description("Characterizes the rate of blowdown in the cooling tower.")]
////public virtual real BlowdownConcentrationRatio { get; set; } = new real;
////[Description("Makeup water usage due to blowdown results from occasionally draining some amount")]
////public virtual object-list BlowdownMakeupWaterUsageScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list SupplyWaterStorageTankName { get; set; } = new object-list;
////[Description("Enter the name of an outdoor air node")]
////public virtual node OutdoorAirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual integer NumberOfCells { get; set; } = new integer;
////[Description("No description available")]
////public virtual choice CellControl { get; set; } = new choice;
////[Description("The allowable minimal fraction of the nominal flow rate per cell")]
////public virtual real CellMinimumWaterFlowRateFraction { get; set; } = new real;
////[Description("The allowable maximal fraction of the nominal flow rate per cell")]
////public virtual real CellMaximumWaterFlowRateFraction { get; set; } = new real;
////[Description("Multiplies the autosized capacity and flow rates")]
////public virtual real SizingFactor { get; set; } = new real;
////[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Subcategory table.")]
////public virtual alpha End-UseSubcategory { get; set; } = new alpha;
////}
////}



