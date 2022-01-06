/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2022, the respective contributors. All rights reserved.
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
////public class HVACTemplate:System:Unitary : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("If blank, always on; Unitary System always on. Schedule is used in availability manager")]
////public virtual object-list SystemAvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ControlZoneOrThermostatLocationName { get; set; } = new object-list;
////[Description("This field may be set to "autosize". If a value is entered, it will *not* be")]
////public virtual null SupplyFanMaximumFlowRate { get; set; } = new null;
////[Description("Refers to a schedule to specify unitary supply fan operating mode.")]
////public virtual object-list SupplyFanOperatingModeScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null SupplyFanTotalEfficiency { get; set; } = new null;
////[Description("No description available")]
////public virtual null SupplyFanDeltaPressure { get; set; } = new null;
////[Description("No description available")]
////public virtual null SupplyFanMotorEfficiency { get; set; } = new null;
////[Description("No description available")]
////public virtual null SupplyFanMotorInAirStreamFraction { get; set; } = new null;
////[Description("No description available")]
////public virtual choice CoolingCoilType { get; set; } = new choice;
////[Description("If blank, always on")]
////public virtual object-list CoolingCoilAvailabilityScheduleName { get; set; } = new object-list;
////[Description("Used for sizing.")]
////public virtual null CoolingDesignSupplyAirTemperature { get; set; } = new null;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual null CoolingCoilGrossRatedTotalCapacity { get; set; } = new null;
////[Description("Gross SHR")]
////public virtual null CoolingCoilGrossRatedSensibleHeatRatio { get; set; } = new null;
////[Description("Gross cooling capacity divided by power input to the compressor and outdoor fan,")]
////public virtual null CoolingCoilGrossRatedCOP { get; set; } = new null;
////[Description("No description available")]
////public virtual choice HeatingCoilType { get; set; } = new choice;
////[Description("If blank, always on")]
////public virtual object-list HeatingCoilAvailabilityScheduleName { get; set; } = new object-list;
////[Description("Used for sizing.")]
////public virtual null HeatingDesignSupplyAirTemperature { get; set; } = new null;
////[Description("No description available")]
////public virtual null HeatingCoilCapacity { get; set; } = new null;
////[Description("No description available")]
////public virtual null GasHeatingCoilEfficiency { get; set; } = new null;
////[Description("No description available")]
////public virtual null GasHeatingCoilParasiticElectricLoad { get; set; } = new null;
////[Description("No description available")]
////public virtual null MaximumOutdoorAirFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual null MinimumOutdoorAirFlowRate { get; set; } = new null;
////[Description("Schedule values multiply the minimum outdoor air flow rate")]
////public virtual object-list MinimumOutdoorAirScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice EconomizerType { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice EconomizerLockout { get; set; } = new choice;
////[Description("Outdoor temperature above which economizer is disabled and")]
////public virtual null EconomizerUpperTemperatureLimit { get; set; } = new null;
////[Description("Outdoor temperature below which economizer is disabled and")]
////public virtual null EconomizerLowerTemperatureLimit { get; set; } = new null;
////[Description("Outdoor enthalpy above which economizer is disabled and")]
////public virtual null EconomizerUpperEnthalpyLimit { get; set; } = new null;
////[Description("Enter the maximum outdoor dewpoint temperature limit for FixedDewPointAndDryBulb")]
////public virtual real EconomizerMaximumLimitDewpointTemperature { get; set; } = new real;
////[Description("Plenum zone name. Supply plenum serves all zones on this system.")]
////public virtual object-list SupplyPlenumName { get; set; } = new object-list;
////[Description("Plenum zone name. Return plenum serves all zones on this system.")]
////public virtual object-list ReturnPlenumName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice SupplyFanPlacement { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice NightCycleControl { get; set; } = new choice;
////[Description("Applicable only if Night Cycle Control is Cycle On Control Zone.")]
////public virtual object-list NightCycleControlZoneName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice HeatRecoveryType { get; set; } = new choice;
////[Description("No description available")]
////public virtual null SensibleHeatRecoveryEffectiveness { get; set; } = new null;
////[Description("Applicable only if Heat Recovery Type is Enthalpy.")]
////public virtual null LatentHeatRecoveryEffectiveness { get; set; } = new null;
////[Description("None = meet sensible cooling load only")]
////public virtual choice DehumidificationControlType { get; set; } = new choice;
////[Description("Zone relative humidity setpoint in percent (0 to 100)")]
////public virtual real DehumidificationSetpoint { get; set; } = new real;
////[Description("No description available")]
////public virtual choice HumidifierType { get; set; } = new choice;
////[Description("If blank, always available")]
////public virtual object-list HumidifierAvailabilityScheduleName { get; set; } = new object-list;
////[Description("Moisture output rate at full rated power input.")]
////public virtual real HumidifierRatedCapacity { get; set; } = new real;
////[Description("Electric power input at rated capacity moisture output.")]
////public virtual real HumidifierRatedElectricPower { get; set; } = new real;
////[Description("Zone name where humidistat is located")]
////public virtual object-list HumidifierControlZoneName { get; set; } = new object-list;
////[Description("Zone relative humidity setpoint in percent (0 to 100)")]
////public virtual real HumidifierSetpoint { get; set; } = new real;
////[Description("Specifies if the system has a return fan.")]
////public virtual choice ReturnFan { get; set; } = new choice;
////[Description("No description available")]
////public virtual null ReturnFanTotalEfficiency { get; set; } = new null;
////[Description("No description available")]
////public virtual null ReturnFanDeltaPressure { get; set; } = new null;
////[Description("No description available")]
////public virtual null ReturnFanMotorEfficiency { get; set; } = new null;
////[Description("No description available")]
////public virtual null ReturnFanMotorInAirStreamFraction { get; set; } = new null;
////}
////}


