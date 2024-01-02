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
////public class HVACTemplate:System:VRF : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list SystemAvailabilityScheduleName { get; set; } = new object-list;
////[Description("Enter the total cooling capacity in watts at rated conditions or set to autosize.")]
////public virtual real GrossRatedTotalCoolingCapacity { get; set; } = new real;
////[Description("Enter the coefficient of performance at rated conditions or leave blank to use default.")]
////public virtual real GrossRatedCoolingCOP { get; set; } = new real;
////[Description("Enter the minimum outdoor temperature allowed for cooling operation.")]
////public virtual real MinimumOutdoorTemperatureInCoolingMode { get; set; } = new real;
////[Description("Enter the maximum outdoor temperature allowed for cooling operation.")]
////public virtual real MaximumOutdoorTemperatureInCoolingMode { get; set; } = new real;
////[Description("Enter the heating capacity in watts at rated conditions or set to autosize.")]
////public virtual real GrossRatedHeatingCapacity { get; set; } = new real;
////[Description("If the Gross Rated Heating Capacity is autosized, the heating capacity is sized")]
////public virtual real RatedHeatingCapacitySizingRatio { get; set; } = new real;
////[Description("COP includes compressor and condenser fan electrical energy input")]
////public virtual real GrossRatedHeatingCOP { get; set; } = new real;
////[Description("Enter the minimum outdoor temperature allowed for heating operation.")]
////public virtual real MinimumOutdoorTemperatureInHeatingMode { get; set; } = new real;
////[Description("Enter the maximum outdoor temperature allowed for heating operation.")]
////public virtual real MaximumOutdoorTemperatureInHeatingMode { get; set; } = new real;
////[Description("Enter the minimum heat pump part-load ratio (PLR). When the cooling or heating PLR is")]
////public virtual real MinimumHeatPumpPart-LoadRatio { get; set; } = new real;
////[Description("Enter the name of the zone where the master thermostat is located.")]
////public virtual object-list ZoneNameForMasterThermostatLocation { get; set; } = new object-list;
////[Description("Choose a thermostat control logic scheme. If these control types fail to control zone")]
////public virtual choice MasterThermostatPriorityControlType { get; set; } = new choice;
////[Description("this field is required if Master Thermostat Priority Control Type is Scheduled.")]
////public virtual object-list ThermostatPriorityScheduleName { get; set; } = new object-list;
////[Description("This field is reserved for future use. The only valid choice is No.")]
////public virtual choice HeatPumpWasteHeatRecovery { get; set; } = new choice;
////[Description("Enter the equivalent length of the farthest terminal unit from the condenser")]
////public virtual real EquivalentPipingLengthUsedForPipingCorrectionFactorInCoolingMode { get; set; } = new real;
////[Description("Enter the height difference between the highest and lowest terminal unit")]
////public virtual real VerticalHeightUsedForPipingCorrectionFactor { get; set; } = new real;
////[Description("Enter the equivalent length of the farthest terminal unit from the condenser")]
////public virtual real EquivalentPipingLengthUsedForPipingCorrectionFactorInHeatingMode { get; set; } = new real;
////[Description("Enter the value of the resistive heater located in the compressor(s). This heater")]
////public virtual real CrankcaseHeaterPowerPerCompressor { get; set; } = new real;
////[Description("Enter the total number of compressor. This input is used only for crankcase")]
////public virtual integer NumberOfCompressors { get; set; } = new integer;
////[Description("Enter the ratio of the first stage compressor to total compressor capacity.")]
////public virtual real RatioOfCompressorSizeToTotalCompressorCapacity { get; set; } = new real;
////[Description("Enter the maximum outdoor temperature above which the crankcase heaters are disabled.")]
////public virtual real MaximumOutdoorDry-bulbTemperatureForCrankcaseHeater { get; set; } = new real;
////[Description("Select a defrost strategy. Reverse cycle reverses the operating mode from heating to cooling")]
////public virtual choice DefrostStrategy { get; set; } = new choice;
////[Description("Choose a defrost control type. Either use a fixed Timed defrost period or select")]
////public virtual choice DefrostControl { get; set; } = new choice;
////[Description("Fraction of time in defrost mode.")]
////public virtual real DefrostTimePeriodFraction { get; set; } = new real;
////[Description("Enter the size of the resistive defrost heating element.")]
////public virtual real ResistiveDefrostHeaterCapacity { get; set; } = new real;
////[Description("Enter the maximum outdoor temperature above which defrost operation is disabled.")]
////public virtual real MaximumOutdoorDry-bulbTemperatureForDefrostOperation { get; set; } = new real;
////[Description("Select either an air cooled or evaporatively cooled condenser.")]
////public virtual choice CondenserType { get; set; } = new choice;
////[Description("Only used when Condenser Type = WaterCooled.")]
////public virtual real WaterCondenserVolumeFlowRate { get; set; } = new real;
////[Description("Enter the effectiveness of the evaporatively cooled condenser.")]
////public virtual real EvaporativeCondenserEffectiveness { get; set; } = new real;
////[Description("Used to calculate evaporative condenser water use.")]
////public virtual real EvaporativeCondenserAirFlowRate { get; set; } = new real;
////[Description("Rated power consumed by the evaporative condenser's water pump.")]
////public virtual real EvaporativeCondenserPumpRatedPowerConsumption { get; set; } = new real;
////[Description("This field is only used for Condenser Type = EvaporativelyCooled and for periods")]
////public virtual real BasinHeaterCapacity { get; set; } = new real;
////[Description("This field is only used for Condenser Type = EvaporativelyCooled.")]
////public virtual real BasinHeaterSetpointTemperature { get; set; } = new real;
////[Description("This field is only used for Condenser Type = EvaporativelyCooled.")]
////public virtual object-list BasinHeaterOperatingScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice FuelType { get; set; } = new choice;
////[Description("The minimum outdoor temperature below which heat")]
////public virtual real MinimumOutdoorTemperatureInHeatRecoveryMode { get; set; } = new real;
////[Description("The maximum outdoor temperature above which heat")]
////public virtual real MaximumOutdoorTemperatureInHeatRecoveryMode { get; set; } = new real;
////}
////}




