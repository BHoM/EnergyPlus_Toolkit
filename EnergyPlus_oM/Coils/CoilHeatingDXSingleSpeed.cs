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
////public class Coil:Heating:DX:SingleSpeed : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("Heating capacity not accounting for the effect of supply air fan heat")]
////public virtual real GrossRatedHeatingCapacity { get; set; } = new real;
////[Description("Rated heating capacity divided by power input to the compressor and outdoor fan,")]
////public virtual real GrossRatedHeatingCOP { get; set; } = new real;
////[Description("Flow rate corresponding to rated total capacity")]
////public virtual real RatedAirFlowRate { get; set; } = new real;
////[Description("Enter the supply fan power per air volume flow rate at the rated test conditions.")]
////public virtual real RatedSupplyFanPowerPerVolumeFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("quadratic curve = a + b*oat + c*oat**2")]
////public virtual object-list HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list HeatingCapacityFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*oat + c*oat**2")]
////public virtual object-list EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*PLR + c*PLR**2")]
////public virtual object-list PartLoadFractionCorrelationCurveName { get; set; } = new object-list;
////[Description("biquadratic curve = a + b*wb + c*wb**2 + d*oat + e*oat**2 + f*wb*oat")]
////public virtual object-list DefrostEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real MinimumOutdoorDry-BulbTemperatureForCompressorOperation { get; set; } = new real;
////[Description("The outdoor temperature when the compressor is automatically turned back on following an")]
////public virtual real OutdoorDry-BulbTemperatureToTurnOnCompressor { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumOutdoorDry-BulbTemperatureForDefrostOperation { get; set; } = new real;
////[Description("No description available")]
////public virtual real CrankcaseHeaterCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumOutdoorDry-BulbTemperatureForCrankcaseHeaterOperation { get; set; } = new real;
////[Description("No description available")]
////public virtual choice DefrostStrategy { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice DefrostControl { get; set; } = new choice;
////[Description("Fraction of time in defrost mode")]
////public virtual real DefrostTimePeriodFraction { get; set; } = new real;
////[Description("only applicable if resistive defrost strategy is specified")]
////public virtual real ResistiveDefrostHeaterCapacity { get; set; } = new real;
////[Description("Standard Region number for which HSPF and other standard ratings are calculated")]
////public virtual integer RegionNumberForCalculatingHSPF { get; set; } = new integer;
////[Description("Enter the name of an outdoor air node. This node name is also specified in")]
////public virtual node EvaporatorAirInletNodeName { get; set; } = new node;
////[Description("This input field is name of a conditioned or unconditioned zone where the secondary")]
////public virtual null ZoneNameForEvaporatorPlacement { get; set; } = new null;
////[Description("This input value is the secondary coil (evaporator) air flow rate when the heat pump")]
////public virtual real SecondaryCoilAirFlowRate { get; set; } = new real;
////[Description("This input field is scaling factor for autosizing the secondary DX coil fan flow rate.")]
////public virtual real SecondaryCoilFanFlowScalingFactor { get; set; } = new real;
////[Description("This input value is the nominal sensible heat ratio used to split the heat extracted by")]
////public virtual real NominalSensibleHeatRatioOfSecondaryCoil { get; set; } = new real;
////[Description("curve = a + b*wb + c*wb**2 + d*db + e*db**2 + f*wb*db")]
////public virtual object-list SensibleHeatRatioModifierFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list SensibleHeatRatioModifierFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////}
////}



