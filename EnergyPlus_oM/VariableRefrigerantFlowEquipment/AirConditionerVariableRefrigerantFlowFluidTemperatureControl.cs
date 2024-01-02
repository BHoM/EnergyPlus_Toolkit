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
////public class AirConditioner:VariableRefrigerantFlow:FluidTemperatureControl : BHoMObject
////{
////[Description("Enter a unique name for this variable refrigerant flow heat pump")]
////public virtual alpha HeatPumpName { get; set; } = new alpha;
////[Description("Enter the name of a schedule that defines the availability of the unit")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("Enter the name of a ZoneTerminalUnitList. This list connects zone terminal units to this")]
////public virtual object-list ZoneTerminalUnitListName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list RefrigerantType { get; set; } = new object-list;
////[Description("Enter the total evaporative capacity in watts at rated conditions")]
////public virtual real RatedEvaporativeCapacity { get; set; } = new real;
////[Description("Enter the rated compressor power per Watt of rated evaporative capacity [W/W]")]
////public virtual real RatedCompressorPowerPerUnitOfRatedEvaporativeCapacity { get; set; } = new real;
////[Description("Enter the minimum outdoor temperature allowed for cooling operation")]
////public virtual real MinimumOutdoorAirTemperatureInCoolingMode { get; set; } = new real;
////[Description("Enter the maximum outdoor temperature allowed for cooling operation")]
////public virtual real MaximumOutdoorAirTemperatureInCoolingMode { get; set; } = new real;
////[Description("Enter the minimum outdoor temperature allowed for heating operation")]
////public virtual real MinimumOutdoorAirTemperatureInHeatingMode { get; set; } = new real;
////[Description("Enter the maximum outdoor temperature allowed for heating operation")]
////public virtual real MaximumOutdoorAirTemperatureInHeatingMode { get; set; } = new real;
////[Description("No description available")]
////public virtual real ReferenceOutdoorUnitSuperheating { get; set; } = new real;
////[Description("No description available")]
////public virtual real ReferenceOutdoorUnitSubcooling { get; set; } = new real;
////[Description("No description available")]
////public virtual choice RefrigerantTemperatureControlAlgorithmForIndoorUnit { get; set; } = new choice;
////[Description("This field is used if Refrigerant Temperature Control Algorithm")]
////public virtual real ReferenceEvaporatingTemperatureForIndoorUnit { get; set; } = new real;
////[Description("This field is used if Refrigerant Temperature Control Algorithm")]
////public virtual real ReferenceCondensingTemperatureForIndoorUnit { get; set; } = new real;
////[Description("This field is used if Refrigerant Temperature Control Algorithm")]
////public virtual real VariableEvaporatingTemperatureMinimumForIndoorUnit { get; set; } = new real;
////[Description("This field is used if Refrigerant Temperature Control Algorithm")]
////public virtual real VariableEvaporatingTemperatureMaximumForIndoorUnit { get; set; } = new real;
////[Description("This field is used if Refrigerant Temperature Control Algorithm")]
////public virtual real VariableCondensingTemperatureMinimumForIndoorUnit { get; set; } = new real;
////[Description("This field is used if Refrigerant Temperature Control Algorithm")]
////public virtual real VariableCondensingTemperatureMaximumForIndoorUnit { get; set; } = new real;
////[Description("Enter the outdoor unit fan power per Watt of rated evaporative capacity [W/W]")]
////public virtual real OutdoorUnitFanPowerPerUnitOfRatedEvaporativeCapacity { get; set; } = new real;
////[Description("This field is only used if the previous is set to autocalculate and performance input method is NominalCapacity")]
////public virtual real OutdoorUnitFanFlowRatePerUnitOfRatedEvaporativeCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list OutdoorUnitEvaporatingTemperatureFunctionOfSuperheatingCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list OutdoorUnitCondensingTemperatureFunctionOfSubcoolingCurveName { get; set; } = new object-list;
////[Description("used to calculate the piping loss")]
////public virtual real DiameterOfMainPipeConnectingOutdoorUnitToTheFirstBranchJoint { get; set; } = new real;
////[Description("used to calculate the heat loss of the main pipe")]
////public virtual real LengthOfMainPipeConnectingOutdoorUnitToTheFirstBranchJoint { get; set; } = new real;
////[Description("used to calculate the refrigerant pressure drop of the main pipe")]
////public virtual real EquivalentLengthOfMainPipeConnectingOutdoorUnitToTheFirstBranchJoint { get; set; } = new real;
////[Description("Difference between outdoor unit height and indoor unit height")]
////public virtual real HeightDifferenceBetweenOutdoorUnitAndIndoorUnits { get; set; } = new real;
////[Description("No description available")]
////public virtual real MainPipeInsulationThickness { get; set; } = new real;
////[Description("No description available")]
////public virtual real MainPipeInsulationThermalConductivity { get; set; } = new real;
////[Description("Enter the value of the resistive heater located in the compressor(s). This heater")]
////public virtual real CrankcaseHeaterPowerPerCompressor { get; set; } = new real;
////[Description("Enter the total number of compressor. This input is used only for crankcase")]
////public virtual integer NumberOfCompressors { get; set; } = new integer;
////[Description("Enter the ratio of the first stage compressor to total compressor capacity")]
////public virtual real RatioOfCompressorSizeToTotalCompressorCapacity { get; set; } = new real;
////[Description("Enter the maximum outdoor temperature above which the crankcase heaters are disabled")]
////public virtual real MaximumOutdoorDry-BulbTemperatureForCrankcaseHeater { get; set; } = new real;
////[Description("Select a defrost strategy.")]
////public virtual choice DefrostStrategy { get; set; } = new choice;
////[Description("Choose a defrost control type")]
////public virtual choice DefrostControl { get; set; } = new choice;
////[Description("A valid performance curve must be used if ReverseCycle defrost strategy is selected")]
////public virtual object-list DefrostEnergyInputRatioModifierFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Fraction of time in defrost mode")]
////public virtual real DefrostTimePeriodFraction { get; set; } = new real;
////[Description("Enter the size of the resistive defrost heating element")]
////public virtual real ResistiveDefrostHeaterCapacity { get; set; } = new real;
////[Description("Enter the maximum outdoor temperature above which the defrost operation is disabled")]
////public virtual real MaximumOutdoorDry-bulbTemperatureForDefrostOperation { get; set; } = new real;
////[Description("No description available")]
////public virtual real CompressorMaximumDeltaPressure { get; set; } = new real;
////[Description("First index represents minimal capacity operation")]
////public virtual integer NumberOfCompressorLoadingIndexEntries { get; set; } = new integer;
////[Description("Minimum compressor speed")]
////public virtual real CompressorSpeedAtLoadingIndex1 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list LoadingIndex1EvaporativeCapacityMultiplierFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list LoadingIndex1CompressorPowerMultiplierFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real CompressorSpeedAtLoadingIndex2 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list LoadingIndex2EvaporativeCapacityMultiplierFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list LoadingIndex2CompressorPowerMultiplierFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real CompressorSpeedAtLoadingIndex3 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list LoadingIndex3EvaporativeCapacityMultiplierFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list LoadingIndex3CompressorPowerMultiplierFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real CompressorSpeedAtLoadingIndex4 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list LoadingIndex4EvaporativeCapacityMultiplierFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list LoadingIndex4CompressorPowerMultiplierFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real CompressorSpeedAtLoadingIndex5 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list LoadingIndex5EvaporativeCapacityMultiplierFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list LoadingIndex5CompressorPowerMultiplierFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real CompressorSpeedAtLoadingIndex6 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list LoadingIndex6EvaporativeCapacityMultiplierFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list LoadingIndex6CompressorPowerMultiplierFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real CompressorSpeedAtLoadingIndex7 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list LoadingIndex7EvaporativeCapacityMultiplierFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null LoadingIndex7List { get; set; } = new null;
////[Description("No description available")]
////public virtual real CompressorSpeedAtLoadingIndex8 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list LoadingIndex8EvaporativeCapacityMultiplierFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list LoadingIndex8CompressorPowerMultiplierFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real CompressorSpeedAtLoadingIndex9 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list LoadingIndex9EvaporativeCapacityMultiplierFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list LoadingIndex9CompressorPowerMultiplierFunctionOfTemperatureCurveName { get; set; } = new object-list;
////}
////}




