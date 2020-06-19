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
////public class EvaporativeCooler:Indirect:ResearchSpecial : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("wet operation effectiveness with respect to wetbulb depression")]
////public virtual real CoolerWetbulbDesignEffectiveness { get; set; } = new real;
////[Description("this curve modifies the wetbulb effectiveness in the previous field (eff_wb_design)")]
////public virtual object-list WetbulbEffectivenessFlowRatioModifierCurveName { get; set; } = new object-list;
////[Description("dry operation effectiveness with respect to drybulb temperature difference")]
////public virtual real CoolerDrybulbDesignEffectiveness { get; set; } = new real;
////[Description("this curve modifies the drybulb effectiveness in the previous field (eff_db_design)")]
////public virtual object-list DrybulbEffectivenessFlowRatioModifierCurveName { get; set; } = new object-list;
////[Description("This is the nominal design pump power of water recirculation and spray for evaporation at design air flow")]
////public virtual null RecirculatingWaterPumpDesignPower { get; set; } = new null;
////[Description("This field is used when the previous field is set to autosize. The pump power is scaled with Secondary Air")]
////public virtual real WaterPumpPowerSizingFactor { get; set; } = new real;
////[Description("this curve modifies the pump power in the previous field by multiplying the design power by the result of this curve.")]
////public virtual object-list WaterPumpPowerModifierCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real SecondaryAirDesignFlowRate { get; set; } = new real;
////[Description("This field is used when the previous field is set to autoize. The Primary Design Air Flow Rate is scaled using this factor")]
////public virtual real SecondaryAirFlowScalingFactor { get; set; } = new real;
////[Description("This is the fan design power at Secondary Design Air Flow Rate. This is the nominal design power at full speed.")]
////public virtual real SecondaryAirFanDesignPower { get; set; } = new real;
////[Description("This field is used when the previous field is set to autosize. The fan power is scaled with Secondary Air Design Flow Rate.")]
////public virtual real SecondaryAirFanSizingSpecificPower { get; set; } = new real;
////[Description("this curve modifies the design fan power in the previous field by multiplying the value by the result")]
////public virtual object-list SecondaryAirFanPowerModifierCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node PrimaryAirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node PrimaryAirOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual real PrimaryAirDesignFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real DewpointEffectivenessFactor { get; set; } = new real;
////[Description("No description available")]
////public virtual node SecondaryAirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node SecondaryAirOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node SensorNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node ReliefAirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual object-list WaterSupplyStorageTankName { get; set; } = new object-list;
////[Description("Rate of drift loss as a fraction of evaporated water flow rate.")]
////public virtual real DriftLossFraction { get; set; } = new real;
////[Description("Characterizes the rate of blowdown in the evaporative cooler.")]
////public virtual real BlowdownConcentrationRatio { get; set; } = new real;
////[Description("This input field value defines the secondary air inlet node drybulb temperature")]
////public virtual real EvaporativeOperationMinimumLimitSecondaryAirDrybulbTemperature { get; set; } = new real;
////[Description("This input field value defines the secondary air inlet node wetbulb temperature")]
////public virtual real EvaporativeOperationMaximumLimitOutdoorWetbulbTemperature { get; set; } = new real;
////[Description("This input field value defines the secondary air inlet node drybulb temperature")]
////public virtual real DryOperationMaximumLimitOutdoorDrybulbTemperature { get; set; } = new real;
////}
////}
