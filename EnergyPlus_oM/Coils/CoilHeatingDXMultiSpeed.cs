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
////public class Coil:Heating:DX:MultiSpeed : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual real MinimumOutdoorDry-BulbTemperatureForCompressorOperation { get; set; } = new real;
////[Description("The outdoor temperature when the compressor is automatically turned back on following an")]
////public virtual real OutdoorDry-BulbTemperatureToTurnOnCompressor { get; set; } = new real;
////[Description("No description available")]
////public virtual real CrankcaseHeaterCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumOutdoorDry-BulbTemperatureForCrankcaseHeaterOperation { get; set; } = new real;
////[Description("biquadratic curve = a + b*wb + c*wb**2 + d*oat + e*oat**2 + f*wb*oat")]
////public virtual object-list DefrostEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real MaximumOutdoorDry-BulbTemperatureForDefrostOperation { get; set; } = new real;
////[Description("No description available")]
////public virtual choice DefrostStrategy { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice DefrostControl { get; set; } = new choice;
////[Description("Fraction of time in defrost mode")]
////public virtual real DefrostTimePeriodFraction { get; set; } = new real;
////[Description("only applicable if resistive defrost strategy is specified")]
////public virtual real ResistiveDefrostHeaterCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual choice ApplyPartLoadFractionToSpeedsGreaterThan1 { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice FuelType { get; set; } = new choice;
////[Description("Standard Region number for which HSPF and other standard ratings are calculated")]
////public virtual integer RegionNumberForCalculatingHSPF { get; set; } = new integer;
////[Description("Enter the number of the following sets of data for coil capacity, COP,")]
////public virtual integer NumberOfSpeeds { get; set; } = new integer;
////[Description("Heating capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed1GrossRatedHeatingCapacity { get; set; } = new real;
////[Description("Rated heating capacity divided by power input to the compressor and outdoor fan,")]
////public virtual real Speed1GrossRatedHeatingCOP { get; set; } = new real;
////[Description("Flow rate corresponding to rated total capacity")]
////public virtual real Speed1RatedAirFlowRate { get; set; } = new real;
////[Description("Enter the supply air fan power per air volume flow rate at the rated speed 1 test conditions.")]
////public virtual real Speed1RatedSupplyAirFanPowerPerVolumeFlowRate { get; set; } = new real;
////[Description("quadratic curve = a + b*oat + c*oat**2")]
////public virtual object-list Speed1HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list Speed1HeatingCapacityFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*oat + c*oat**2")]
////public virtual object-list Speed1EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list Speed1EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*PLR + c*PLR**2")]
////public virtual object-list Speed1PartLoadFractionCorrelationCurveName { get; set; } = new object-list;
////[Description("recoverable waste heat at full load and rated conditions")]
////public virtual real Speed1RatedWasteHeatFractionOfPowerInput { get; set; } = new real;
////[Description("curve = a + b*odb + c*odb**2 + d*db + e*db**2 + f*odb*db")]
////public virtual object-list Speed1WasteHeatFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Heating capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed2GrossRatedHeatingCapacity { get; set; } = new real;
////[Description("Rated heating capacity divided by power input to the compressor and outdoor fan,")]
////public virtual real Speed2GrossRatedHeatingCOP { get; set; } = new real;
////[Description("Flow rate corresponding to rated total capacity")]
////public virtual real Speed2RatedAirFlowRate { get; set; } = new real;
////[Description("Enter the supply air fan power per air volume flow rate at the rated speed 2 test conditions.")]
////public virtual real Speed2RatedSupplyAirFanPowerPerVolumeFlowRate { get; set; } = new real;
////[Description("quadratic curve = a + b*oat + c*oat**2")]
////public virtual object-list Speed2HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list Speed2HeatingCapacityFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*oat + c*oat**2")]
////public virtual object-list Speed2EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list Speed2EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*PLR + c*PLR**2")]
////public virtual object-list Speed2PartLoadFractionCorrelationCurveName { get; set; } = new object-list;
////[Description("recoverable waste heat at full load and rated conditions")]
////public virtual real Speed2RatedWasteHeatFractionOfPowerInput { get; set; } = new real;
////[Description("curve = a + b*odb + c*odb**2 + d*db + e*db**2 + f*odb*db")]
////public virtual object-list Speed2WasteHeatFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Heating capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed3GrossRatedHeatingCapacity { get; set; } = new real;
////[Description("Rated heating capacity divided by power input to the compressor and outdoor fan,")]
////public virtual real Speed3GrossRatedHeatingCOP { get; set; } = new real;
////[Description("Flow rate corresponding to rated total capacity")]
////public virtual real Speed3RatedAirFlowRate { get; set; } = new real;
////[Description("Enter the supply air fan power per air volume flow rate at the rated speed 3 test conditions.")]
////public virtual real Speed3RatedSupplyAirFanPowerPerVolumeFlowRate { get; set; } = new real;
////[Description("quadratic curve = a + b*oat + c*oat**2")]
////public virtual object-list Speed3HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list Speed3HeatingCapacityFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*oat + c*oat**2")]
////public virtual object-list Speed3EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list Speed3EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*PLR + c*PLR**2")]
////public virtual object-list Speed3PartLoadFractionCorrelationCurveName { get; set; } = new object-list;
////[Description("recoverable waste heat at full load and rated conditions")]
////public virtual real Speed3RatedWasteHeatFractionOfPowerInput { get; set; } = new real;
////[Description("curve = a + b*odb + c*odb**2 + d*db + e*db**2 + f*odb*db")]
////public virtual object-list Speed3WasteHeatFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Heating capacity not accounting for the effect of supply air fan heat")]
////public virtual real Speed4GrossRatedHeatingCapacity { get; set; } = new real;
////[Description("Rated heating capacity divided by power input to the compressor and outdoor fan,")]
////public virtual real Speed4GrossRatedHeatingCOP { get; set; } = new real;
////[Description("Flow rate corresponding to rated total capacity")]
////public virtual real Speed4RatedAirFlowRate { get; set; } = new real;
////[Description("Enter the supply air fan power per air volume flow rate at the rated speed 4 test conditions.")]
////public virtual real Speed4RatedSupplyAirFanPowerPerVolumeFlowRate { get; set; } = new real;
////[Description("quadratic curve = a + b*oat + c*oat**2")]
////public virtual object-list Speed4HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list Speed4HeatingCapacityFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*oat + c*oat**2")]
////public virtual object-list Speed4EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list Speed4EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*PLR + c*PLR**2")]
////public virtual object-list Speed4PartLoadFractionCorrelationCurveName { get; set; } = new object-list;
////[Description("recoverable waste heat at full load and rated conditions")]
////public virtual real Speed4RatedWasteHeatFractionOfPowerInput { get; set; } = new real;
////[Description("curve = a + b*odb + c*odb**2 + d*db + e*db**2 + f*odb*db")]
////public virtual object-list Speed4WasteHeatFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("This input field is name of a conditioned or unconditioned zone where the secondary")]
////public virtual null ZoneNameForEvaporatorPlacement { get; set; } = new null;
////[Description("This input value is the secondary coil (evaporator) air flow rate when the heat pump")]
////public virtual real Speed1SecondaryCoilAirFlowRate { get; set; } = new real;
////[Description("This input field is scaling factor for autosizing the secondary DX coil fan flow rate.")]
////public virtual real Speed1SecondaryCoilFanFlowScalingFactor { get; set; } = new real;
////[Description("This input value is the nominal sensible heat ratio used to split the heat extracted by")]
////public virtual real Speed1NominalSensibleHeatRatioOfSecondaryCoil { get; set; } = new real;
////[Description("curve = a + b*wb + c*wb**2 + d*db + e*db**2 + f*wb*db")]
////public virtual object-list Speed1SensibleHeatRatioModifierFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list Speed1SensibleHeatRatioModifierFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("This input value is the secondary coil (evaporator) air flow rate when the heat pump")]
////public virtual real Speed2SecondaryCoilAirFlowRate { get; set; } = new real;
////[Description("This input field is scaling factor for autosizing the secondary DX coil fan flow rate.")]
////public virtual real Speed2SecondaryCoilFanFlowScalingFactor { get; set; } = new real;
////[Description("This input value is the nominal sensible heat ratio used to split the heat extracted by")]
////public virtual real Speed2NominalSensibleHeatRatioOfSecondaryCoil { get; set; } = new real;
////[Description("curve = a + b*wb + c*wb**2 + d*db + e*db**2 + f*wb*db")]
////public virtual object-list Speed2SensibleHeatRatioModifierFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list Speed2SensibleHeatRatioModifierFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("This input value is the secondary coil (evaporator) air flow rate when the heat pump")]
////public virtual real Speed3SecondaryCoilAirFlowRate { get; set; } = new real;
////[Description("This input field is scaling factor for autosizing the secondary DX coil fan flow rate.")]
////public virtual real Speed3SecondaryCoilFanFlowScalingFactor { get; set; } = new real;
////[Description("This input value is the nominal sensible heat ratio used to split the heat extracted by")]
////public virtual real Speed3NominalSensibleHeatRatioOfSecondaryCoil { get; set; } = new real;
////[Description("curve = a + b*wb + c*wb**2 + d*db + e*db**2 + f*wb*db")]
////public virtual object-list Speed3SensibleHeatRatioModifierFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list Speed3SensibleHeatRatioModifierFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("This input value is the secondary coil (evaporator) air flow rate when the heat pump")]
////public virtual real Speed4SecondaryCoilAirFlowRate { get; set; } = new real;
////[Description("This input field is scaling factor for autosizing the secondary DX coil fan flow rate.")]
////public virtual real Speed4SecondaryCoilFanFlowScalingFactor { get; set; } = new real;
////[Description("This input value is the nominal sensible heat ratio used to split the heat extracted by")]
////public virtual real Speed4NominalSensibleHeatRatioOfSecondaryCoil { get; set; } = new real;
////[Description("curve = a + b*wb + c*wb**2 + d*db + e*db**2 + f*wb*db")]
////public virtual object-list Speed4SensibleHeatRatioModifierFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list Speed4SensibleHeatRatioModifierFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////}
////}
