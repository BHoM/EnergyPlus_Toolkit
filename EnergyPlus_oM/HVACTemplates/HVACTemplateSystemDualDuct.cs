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
////public class HVACTemplate:System:DualDuct : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("If blank, always on; Schedule is used in availability manager")]
////public virtual object-list SystemAvailabilityScheduleName { get; set; } = new object-list;
////[Description("SingleFan - a single supply fan before the split to dual ducts")]
////public virtual choice SystemConfigurationType { get; set; } = new choice;
////[Description("This field may be set to "autosize". If a value is entered, it will *not* be")]
////public virtual null MainSupplyFanMaximumFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual null MainSupplyFanMinimumFlowFraction { get; set; } = new null;
////[Description("No description available")]
////public virtual null MainSupplyFanTotalEfficiency { get; set; } = new null;
////[Description("No description available")]
////public virtual null MainSupplyFanDeltaPressure { get; set; } = new null;
////[Description("No description available")]
////public virtual null MainSupplyFanMotorEfficiency { get; set; } = new null;
////[Description("No description available")]
////public virtual null MainSupplyFanMotorInAirStreamFraction { get; set; } = new null;
////[Description("This field selects a predefined set of fan power coefficients.")]
////public virtual choice MainSupplyFanPart-LoadPowerCoefficients { get; set; } = new choice;
////[Description("This field may be set to "autosize". If a value is entered, it will *not* be")]
////public virtual null ColdDuctSupplyFanMaximumFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual null ColdDuctSupplyFanMinimumFlowFraction { get; set; } = new null;
////[Description("No description available")]
////public virtual null ColdDuctSupplyFanTotalEfficiency { get; set; } = new null;
////[Description("No description available")]
////public virtual null ColdDuctSupplyFanDeltaPressure { get; set; } = new null;
////[Description("No description available")]
////public virtual null ColdDuctSupplyFanMotorEfficiency { get; set; } = new null;
////[Description("No description available")]
////public virtual null ColdDuctSupplyFanMotorInAirStreamFraction { get; set; } = new null;
////[Description("This field selects a predefined set of fan power coefficients.")]
////public virtual choice ColdDuctSupplyFanPart-LoadPowerCoefficients { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice ColdDuctSupplyFanPlacement { get; set; } = new choice;
////[Description("This field may be set to "autosize". If a value is entered, it will *not* be")]
////public virtual null HotDuctSupplyFanMaximumFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual null HotDuctSupplyFanMinimumFlowFraction { get; set; } = new null;
////[Description("No description available")]
////public virtual null HotDuctSupplyFanTotalEfficiency { get; set; } = new null;
////[Description("No description available")]
////public virtual null HotDuctSupplyFanDeltaPressure { get; set; } = new null;
////[Description("No description available")]
////public virtual null HotDuctSupplyFanMotorEfficiency { get; set; } = new null;
////[Description("No description available")]
////public virtual null HotDuctSupplyFanMotorInAirStreamFraction { get; set; } = new null;
////[Description("This field selects a predefined set of fan power coefficients.")]
////public virtual choice HotDuctSupplyFanPart-LoadPowerCoefficients { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice HotDuctSupplyFanPlacement { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice CoolingCoilType { get; set; } = new choice;
////[Description("If blank, always on")]
////public virtual object-list CoolingCoilAvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice CoolingCoilSetpointControlType { get; set; } = new choice;
////[Description("Used for sizing and as constant setpoint if no Cooling Coil Setpoint Schedule Name is specified.")]
////public virtual null CoolingCoilDesignSetpointTemperature { get; set; } = new null;
////[Description("Leave blank if constant setpoint")]
////public virtual object-list CoolingCoilSetpointScheduleName { get; set; } = new object-list;
////[Description("Applicable only for OutdoorAirTemperatureReset control.")]
////public virtual null CoolingCoilSetpointAtOutdoorDry-BulbLow { get; set; } = new null;
////[Description("Applicable only for OutdoorAirTemperatureReset control.")]
////public virtual null CoolingCoilResetOutdoorDry-BulbLow { get; set; } = new null;
////[Description("Applicable only for OutdoorAirTemperatureReset control.")]
////public virtual null CoolingCoilSetpointAtOutdoorDry-BulbHigh { get; set; } = new null;
////[Description("Applicable only for OutdoorAirTemperatureReset control.")]
////public virtual null CoolingCoilResetOutdoorDry-BulbHigh { get; set; } = new null;
////[Description("No description available")]
////public virtual choice HeatingCoilType { get; set; } = new choice;
////[Description("If blank, always on")]
////public virtual object-list HeatingCoilAvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice HeatingCoilSetpointControlType { get; set; } = new choice;
////[Description("Used for sizing and as constant setpoint if no Heating Coil Setpoint Schedule Name is specified.")]
////public virtual null HeatingCoilDesignSetpoint { get; set; } = new null;
////[Description("Leave blank if constant setpoint")]
////public virtual object-list HeatingCoilSetpointScheduleName { get; set; } = new object-list;
////[Description("Applicable only for OutdoorAirTemperatureReset control.")]
////public virtual null HeatingCoilSetpointAtOutdoorDry-BulbLow { get; set; } = new null;
////[Description("Applicable only for OutdoorAirTemperatureReset control.")]
////public virtual null HeatingCoilResetOutdoorDry-BulbLow { get; set; } = new null;
////[Description("Applicable only for OutdoorAirTemperatureReset control.")]
////public virtual null HeatingCoilSetpointAtOutdoorDry-BulbHigh { get; set; } = new null;
////[Description("Applicable only for OutdoorAirTemperatureReset control.")]
////public virtual null HeatingCoilResetOutdoorDry-BulbHigh { get; set; } = new null;
////[Description("No description available")]
////public virtual null HeatingCoilCapacity { get; set; } = new null;
////[Description("No description available")]
////public virtual null GasHeatingCoilEfficiency { get; set; } = new null;
////[Description("No description available")]
////public virtual null GasHeatingCoilParasiticElectricLoad { get; set; } = new null;
////[Description("No description available")]
////public virtual choice PreheatCoilType { get; set; } = new choice;
////[Description("If blank, always on")]
////public virtual object-list PreheatCoilAvailabilityScheduleName { get; set; } = new object-list;
////[Description("Used for sizing and as constant setpoint if no Preheat Coil Setpoint Schedule Name specified.")]
////public virtual null PreheatCoilDesignSetpoint { get; set; } = new null;
////[Description("Leave blank if constant setpoint")]
////public virtual object-list PreheatCoilSetpointScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null GasPreheatCoilEfficiency { get; set; } = new null;
////[Description("No description available")]
////public virtual null GasPreheatCoilParasiticElectricLoad { get; set; } = new null;
////[Description("No description available")]
////public virtual null MaximumOutdoorAirFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual null MinimumOutdoorAirFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual choice MinimumOutdoorAirControlType { get; set; } = new choice;
////[Description("Schedule values multiply the Minimum Outdoor Air Flow Rate")]
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
////[Description("Plenum zone name. Supply plenum serves the cold inlets of all zones on this system.")]
////public virtual object-list ColdSupplyPlenumName { get; set; } = new object-list;
////[Description("Plenum zone name. Supply plenum serves the hot inlets of all zones on this system.")]
////public virtual object-list HotSupplyPlenumName { get; set; } = new object-list;
////[Description("Plenum zone name. Supply plenum serves all zones on this system.")]
////public virtual object-list ReturnPlenumName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice NightCycleControl { get; set; } = new choice;
////[Description("Applicable only if Night Cycle Control is Cycle On Control Zone.")]
////public virtual object-list NightCycleControlZoneName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice HeatRecoveryType { get; set; } = new choice;
////[Description("No description available")]
////public virtual null SensibleHeatRecoveryEffectiveness { get; set; } = new null;
////[Description("No description available")]
////public virtual null LatentHeatRecoveryEffectiveness { get; set; } = new null;
////[Description("No description available")]
////public virtual choice HeatRecoveryHeatExchangerType { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice HeatRecoveryFrostControlType { get; set; } = new choice;
////[Description("None = meet sensible load only")]
////public virtual choice DehumidificationControlType { get; set; } = new choice;
////[Description("Zone name where humidistat is located")]
////public virtual object-list DehumidificationControlZoneName { get; set; } = new object-list;
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
////[Description("This field selects a predefined set of fan power coefficients.")]
////public virtual choice ReturnFanPart-LoadPowerCoefficients { get; set; } = new choice;
////}
////}
