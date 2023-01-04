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
////public class HVACTemplate:System:UnitarySystem : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("If blank, always available. Also see Supply Fan Operating Mode Schedule Name field.")]
////public virtual object-list SystemAvailabilityScheduleName { get; set; } = new object-list;
////[Description("Load control requires a Controlling Zone name.")]
////public virtual choice ControlType { get; set; } = new choice;
////[Description("This field is required if Control Type is Load.")]
////public virtual object-list ControlZoneOrThermostatLocationName { get; set; } = new object-list;
////[Description("Supply air flow rate during cooling operation")]
////public virtual real CoolingSupplyAirFlowRate { get; set; } = new real;
////[Description("Supply air flow rate during heating operation")]
////public virtual real HeatingSupplyAirFlowRate { get; set; } = new real;
////[Description("Supply air flow rate when no cooling or heating is needed")]
////public virtual real NoLoadSupplyAirFlowRate { get; set; } = new real;
////[Description("Refers to a schedule to specify unitary supply fan operating mode.")]
////public virtual object-list SupplyFanOperatingModeScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice SupplyFanPlacement { get; set; } = new choice;
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
////[Description("Used only for Cooling Coil Type = MultiSpeedDX.")]
////public virtual integer NumberOfSpeedsForCooling { get; set; } = new integer;
////[Description("If blank, always on")]
////public virtual object-list CoolingCoilAvailabilityScheduleName { get; set; } = new object-list;
////[Description("Used for sizing.")]
////public virtual null CoolingDesignSupplyAirTemperature { get; set; } = new null;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual null DXCoolingCoilGrossRatedTotalCapacity { get; set; } = new null;
////[Description("Rated sensible heat ratio (gross sensible capacity/gross total capacity)")]
////public virtual null DXCoolingCoilGrossRatedSensibleHeatRatio { get; set; } = new null;
////[Description("Gross cooling capacity divided by power input to the compressor and outdoor fan,")]
////public virtual null DXCoolingCoilGrossRatedCOP { get; set; } = new null;
////[Description("No description available")]
////public virtual choice HeatingCoilType { get; set; } = new choice;
////[Description("Used only for Heating Coil Type = MultiSpeedDXHeatPumpAirSource),")]
////public virtual integer NumberOfSpeedsOrStagesForHeating { get; set; } = new integer;
////[Description("If blank, always on")]
////public virtual object-list HeatingCoilAvailabilityScheduleName { get; set; } = new object-list;
////[Description("Used for sizing.")]
////public virtual null HeatingDesignSupplyAirTemperature { get; set; } = new null;
////[Description("Rated heating capacity excluding the effect of supply air fan heat")]
////public virtual real HeatingCoilGrossRatedCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual null GasHeatingCoilEfficiency { get; set; } = new null;
////[Description("No description available")]
////public virtual null GasHeatingCoilParasiticElectricLoad { get; set; } = new null;
////[Description("Heating Coil Rated Capacity divided by power input to the compressor and outdoor fan,")]
////public virtual null HeatPumpHeatingCoilGrossRatedCOP { get; set; } = new null;
////[Description("No description available")]
////public virtual real HeatPumpHeatingMinimumOutdoorDry-BulbTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual real HeatPumpDefrostMaximumOutdoorDry-BulbTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual choice HeatPumpDefrostStrategy { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice HeatPumpDefrostControl { get; set; } = new choice;
////[Description("Fraction of time in defrost mode")]
////public virtual real HeatPumpDefrostTimePeriodFraction { get; set; } = new real;
////[Description("No description available")]
////public virtual choice SupplementalHeatingOrReheatCoilType { get; set; } = new choice;
////[Description("If blank, always on")]
////public virtual object-list SupplementalHeatingOrReheatCoilAvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null SupplementalHeatingOrReheatCoilCapacity { get; set; } = new null;
////[Description("Supplemental heater will not operate when outdoor temperature exceeds this value.")]
////public virtual real SupplementalHeatingOrReheatCoilMaximumOutdoorDry-BulbTemperature { get; set; } = new real;
////[Description("Applies only if Supplemental Heating Coil Type is Gas")]
////public virtual null SupplementalGasHeatingOrReheatCoilEfficiency { get; set; } = new null;
////[Description("Applies only if Supplemental Heating Coil Type is Gas")]
////public virtual null SupplementalGasHeatingOrReheatCoilParasiticElectricLoad { get; set; } = new null;
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
////[Description("Enter the maximum outdoor dry-bulb temperature limit for FixedDryBulb")]
////public virtual real EconomizerMaximumLimitDry-BulbTemperature { get; set; } = new real;
////[Description("Enter the maximum outdoor enthalpy limit for FixedEnthalpy economizer control type.")]
////public virtual real EconomizerMaximumLimitEnthalpy { get; set; } = new real;
////[Description("Enter the maximum outdoor dewpoint temperature limit for FixedDewPointAndDryBulb")]
////public virtual real EconomizerMaximumLimitDewpointTemperature { get; set; } = new real;
////[Description("Enter the minimum outdoor dry-bulb temperature limit for economizer control.")]
////public virtual real EconomizerMinimumLimitDry-BulbTemperature { get; set; } = new real;
////[Description("Plenum zone name. Supply plenum serves all zones on this system.")]
////public virtual object-list SupplyPlenumName { get; set; } = new object-list;
////[Description("Plenum zone name. Return plenum serves all zones on this system.")]
////public virtual object-list ReturnPlenumName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice HeatRecoveryType { get; set; } = new choice;
////[Description("No description available")]
////public virtual null SensibleHeatRecoveryEffectiveness { get; set; } = new null;
////[Description("Applicable only if Heat Recovery Type is Enthalpy.")]
////public virtual null LatentHeatRecoveryEffectiveness { get; set; } = new null;
////[Description("No description available")]
////public virtual choice HeatRecoveryHeatExchangerType { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice HeatRecoveryFrostControlType { get; set; } = new choice;
////[Description("None = meet sensible load only")]
////public virtual choice DehumidificationControlType { get; set; } = new choice;
////[Description("Zone relative humidity setpoint in percent (0 to 100)")]
////public virtual real DehumidificationRelativeHumiditySetpoint { get; set; } = new real;
////[Description("Leave blank to use constant setpoint specified in Dehumidification Relative Humidity")]
////public virtual object-list DehumidificationRelativeHumiditySetpointScheduleName { get; set; } = new object-list;
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
////[Description("Zone relative humidity setpoint in percent (0 to 100).")]
////public virtual real HumidifierRelativeHumiditySetpoint { get; set; } = new real;
////[Description("Leave blank to use constant setpoint specified in Humidifier Relative Humidity")]
////public virtual object-list HumidifierRelativeHumiditySetpointScheduleName { get; set; } = new object-list;
////[Description("Select whether autosized system supply flow rate is the sum of Coincident or NonCoincident")]
////public virtual choice SizingOption { get; set; } = new choice;
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



