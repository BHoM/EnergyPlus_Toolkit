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
////namespace BH.oM.Adapters.EnergyPlus
////{
////public class Coil:Cooling:WaterToAirHeatPump:ParameterEstimation : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Parameters 1-5 are as named below.")]
////public virtual choice CompressorType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list RefrigerantType { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DesignSourceSideFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real NominalCoolingCoilCapacity { get; set; } = new real;
////[Description("The nominal time for condensate to begin leaving the coil's condensate")]
////public virtual real NominalTimeForCondensateRemovalToBegin { get; set; } = new real;
////[Description("Ratio of the initial moisture evaporation rate from the cooling coil (when")]
////public virtual real RatioOfInitialMoistureEvaporationRateAndSteadyStateLatentCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual null HighPressureCutoff { get; set; } = new null;
////[Description("No description available")]
////public virtual real LowPressureCutoff { get; set; } = new real;
////[Description("No description available")]
////public virtual node WaterInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node WaterOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("Previously called Parameter 1")]
////public virtual real LoadSideTotalHeatTransferCoefficient { get; set; } = new real;
////[Description("Previously called Parameter 2")]
////public virtual real LoadSideOutsideSurfaceHeatTransferCoefficient { get; set; } = new real;
////[Description("Previously called Parameter 3")]
////public virtual real SuperheatTemperatureAtTheEvaporatorOutlet { get; set; } = new real;
////[Description("Accounts for the loss of work due to mechanical and electrical losses in the compressor.")]
////public virtual real CompressorPowerLosses { get; set; } = new real;
////[Description("Previously called Parameter 5")]
////public virtual real CompressorEfficiency { get; set; } = new real;
////[Description("Use when Compressor Type is Reciprocating or Rotary")]
////public virtual real CompressorPistonDisplacement { get; set; } = new real;
////[Description("Used when Compressor Type is Rotary or Reciprocating")]
////public virtual real CompressorSuction/DischargePressureDrop { get; set; } = new real;
////[Description("Used when Compressor Type is Reciprocating.")]
////public virtual real CompressorClearanceFactor { get; set; } = new real;
////[Description("Use when Compressor Type is Scroll")]
////public virtual real RefrigerantVolumeFlowRate { get; set; } = new real;
////[Description("Use when Compressor Type is Scroll.")]
////public virtual real VolumeRatio { get; set; } = new real;
////[Description("Use when Compressor Type is Scroll.")]
////public virtual real LeakRateCoefficient { get; set; } = new real;
////[Description("Use when Source Side Fluid Name is Water")]
////public virtual real SourceSideHeatTransferCoefficient { get; set; } = new real;
////[Description("Use when Source Side Fluid Name is an antifreeze")]
////public virtual real SourceSideHeatTransferResistance1 { get; set; } = new real;
////[Description("Use when Source Side Fluid Name is an antifreeze")]
////public virtual real SourceSideHeatTransferResistance2 { get; set; } = new real;
////}
////}
