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
////public class HVACTemplate:System:DedicatedOutdoorAir : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("If blank, always on; DOAS System always on. Schedule is used in availability manager")]
////public virtual object-list SystemAvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice AirOutletType { get; set; } = new choice;
////[Description("No description available")]
////public virtual null SupplyFanFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual null SupplyFanTotalEfficiency { get; set; } = new null;
////[Description("No description available")]
////public virtual null SupplyFanDeltaPressure { get; set; } = new null;
////[Description("No description available")]
////public virtual null SupplyFanMotorEfficiency { get; set; } = new null;
////[Description("No description available")]
////public virtual null SupplyFanMotorInAirStreamFraction { get; set; } = new null;
////[Description("No description available")]
////public virtual choice SupplyFanPlacement { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice CoolingCoilType { get; set; } = new choice;
////[Description("If blank, always on")]
////public virtual object-list CoolingCoilAvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice CoolingCoilSetpointControlType { get; set; } = new choice;
////[Description("Used for sizing and as constant setpoint if no Cooling Coil Setpoint Schedule Name is specified.")]
////public virtual null CoolingCoilDesignSetpoint { get; set; } = new null;
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
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual null DXCoolingCoilGrossRatedTotalCapacity { get; set; } = new null;
////[Description("Gross SHR")]
////public virtual null DXCoolingCoilGrossRatedSensibleHeatRatio { get; set; } = new null;
////[Description("Gross cooling capacity divided by power input to the compressor and outdoor fan,")]
////public virtual null DXCoolingCoilGrossRatedCOP { get; set; } = new null;
////[Description("No description available")]
////public virtual choice HeatingCoilType { get; set; } = new choice;
////[Description("If blank, always on")]
////public virtual object-list HeatingCoilAvailabilityScheduleName { get; set; } = new object-list;
////[Description("When selecting OutdoorAirTemperatureReset, the Heating Coil Design Setpoint may need to be changed")]
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
////public virtual null GasHeatingCoilEfficiency { get; set; } = new null;
////[Description("No description available")]
////public virtual null GasHeatingCoilParasiticElectricLoad { get; set; } = new null;
////[Description("No description available")]
////public virtual choice HeatRecoveryType { get; set; } = new choice;
////[Description("No description available")]
////public virtual null HeatRecoverySensibleEffectiveness { get; set; } = new null;
////[Description("No description available")]
////public virtual null HeatRecoveryLatentEffectiveness { get; set; } = new null;
////[Description("No description available")]
////public virtual choice HeatRecoveryHeatExchangerType { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice HeatRecoveryFrostControlType { get; set; } = new choice;
////[Description("None = meet sensible load only")]
////public virtual choice DehumidificationControlType { get; set; } = new choice;
////[Description("The supply air humidity ratio for dehumidification control.")]
////public virtual real DehumidificationSetpoint { get; set; } = new real;
////[Description("No description available")]
////public virtual choice HumidifierType { get; set; } = new choice;
////[Description("If blank, always available")]
////public virtual object-list HumidifierAvailabilityScheduleName { get; set; } = new object-list;
////[Description("Moisture output rate at full rated power input.")]
////public virtual real HumidifierRatedCapacity { get; set; } = new real;
////[Description("Electric power input at rated capacity moisture output.")]
////public virtual real HumidifierRatedElectricPower { get; set; } = new real;
////[Description("The supply air humidity ratio for humidification control.")]
////public virtual real HumidifierConstantSetpoint { get; set; } = new real;
////[Description("Leave blank to use constant setpoint specified in Dehumidification Setpoint above.")]
////public virtual object-list DehumidificationSetpointScheduleName { get; set; } = new object-list;
////[Description("Leave blank to use constant setpoint specified in Humidifier Constant Setpoint above.")]
////public virtual object-list HumidifierSetpointScheduleName { get; set; } = new object-list;
////}
////}
