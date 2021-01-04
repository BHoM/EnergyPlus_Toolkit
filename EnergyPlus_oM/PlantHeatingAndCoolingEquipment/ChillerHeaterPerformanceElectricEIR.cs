/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2021, the respective contributors. All rights reserved.
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
////public class ChillerHeaterPerformance:Electric:EIR : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual real ReferenceCoolingModeEvaporatorCapacity { get; set; } = new real;
////[Description("Efficiency of the chiller compressor (cooling output/compressor energy input).")]
////public virtual real ReferenceCoolingModeCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real ReferenceCoolingModeLeavingChilledWaterTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual real ReferenceCoolingModeEnteringCondenserFluidTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual real ReferenceCoolingModeLeavingCondenserWaterTemperature { get; set; } = new real;
////[Description("During simultaneous cooling-heating mode, this ratio is relative to the Reference Cooling Mode Cooling Capacity")]
////public virtual real ReferenceHeatingModeCoolingCapacityRatio { get; set; } = new real;
////[Description("During simultaneous cooling-heating mode, this ratio is relative to the Reference Cooling Mode COP")]
////public virtual real ReferenceHeatingModeCoolingPowerInputRatio { get; set; } = new real;
////[Description("During simultaneous cooling-heating mode")]
////public virtual real ReferenceHeatingModeLeavingChilledWaterTemperature { get; set; } = new real;
////[Description("During simultaneous cooling-heating mode")]
////public virtual real ReferenceHeatingModeLeavingCondenserWaterTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual real ReferenceHeatingModeEnteringCondenserFluidTemperature { get; set; } = new real;
////[Description("During simultaneous cooling-heating mode")]
////public virtual real HeatingModeEnteringChilledWaterTemperatureLowLimit { get; set; } = new real;
////[Description("Sets chilled water flow rate to either constant or variable.")]
////public virtual choice ChilledWaterFlowModeType { get; set; } = new choice;
////[Description("No description available")]
////public virtual real DesignChilledWaterFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real DesignCondenserWaterFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real DesignHotWaterFlowRate { get; set; } = new real;
////[Description("Fraction of compressor electrical energy that must be rejected by the condenser.")]
////public virtual real CompressorMotorEfficiency { get; set; } = new real;
////[Description("No description available")]
////public virtual choice CondenserType { get; set; } = new choice;
////[Description("Sets the second independent variable in the three temperature dependent performance")]
////public virtual choice CoolingModeTemperatureCurveCondenserWaterIndependentVariable { get; set; } = new choice;
////[Description("Cooling capacity as a function of leaving chilled water temperature")]
////public virtual object-list CoolingModeCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Electric Input Ratio (EIR) as a function of supply (leaving) chilled water temperature")]
////public virtual object-list CoolingModeElectricInputToCoolingOutputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Electric Input Ratio (EIR) as a function of Part Load Ratio (PLR)")]
////public virtual object-list CoolingModeElectricInputToCoolingOutputRatioFunctionOfPartLoadRatioCurveName { get; set; } = new object-list;
////[Description("Optimum part load ratio where the chiller is most efficient.")]
////public virtual real CoolingModeCoolingCapacityOptimumPartLoadRatio { get; set; } = new real;
////[Description("Sets the second independent variable in the three temperature dependent performance")]
////public virtual choice HeatingModeTemperatureCurveCondenserWaterIndependentVariable { get; set; } = new choice;
////[Description("Evaporator (cooling) capacity as a function of leaving chilled water temperature")]
////public virtual object-list HeatingModeCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Electric Input Ratio (EIR) as a function of leaving chilled water temperature when in heating or simultaneous cool/heat mode")]
////public virtual object-list HeatingModeElectricInputToCoolingOutputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Electric Input Ratio (EIR) as a function of Part Load Ratio (PLR) when in heating or simultaneous cool/heat mode")]
////public virtual object-list HeatingModeElectricInputToCoolingOutputRatioFunctionOfPartLoadRatioCurveName { get; set; } = new object-list;
////[Description("Optimum part load ratio where the chiller is most efficient when in heating or simultaneous cool/heat mode.")]
////public virtual real HeatingModeCoolingCapacityOptimumPartLoadRatio { get; set; } = new real;
////[Description("Multiplies the autosized capacity and flow rates")]
////public virtual real SizingFactor { get; set; } = new real;
////}
////}

