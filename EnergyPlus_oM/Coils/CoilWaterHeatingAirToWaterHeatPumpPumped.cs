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
////public class Coil:WaterHeating:AirToWaterHeatPump:Pumped : BHoMObject
////{
////[Description("Unique name for this instance of a heat pump water heater DX coil.")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet")]
////public virtual real RatedHeatingCapacity { get; set; } = new real;
////[Description("Heating coefficient of performance at the rated inlet air temperatures,")]
////public virtual real RatedCOP { get; set; } = new real;
////[Description("Gross air-side sensible heat ratio at the rated inlet air temperatures,")]
////public virtual real RatedSensibleHeatRatio { get; set; } = new real;
////[Description("Evaporator inlet air dry-bulb temperature corresponding to rated coil performance")]
////public virtual real RatedEvaporatorInletAirDry-BulbTemperature { get; set; } = new real;
////[Description("Evaporator inlet air wet-bulb temperature corresponding to rated coil performance")]
////public virtual real RatedEvaporatorInletAirWet-BulbTemperature { get; set; } = new real;
////[Description("Condenser inlet water temperature corresponding to rated coil performance")]
////public virtual real RatedCondenserInletWaterTemperature { get; set; } = new real;
////[Description("Evaporator air flow rate corresponding to rated coil performance")]
////public virtual real RatedEvaporatorAirFlowRate { get; set; } = new real;
////[Description("Condenser water flow rate corresponding to rated coil performance")]
////public virtual real RatedCondenserWaterFlowRate { get; set; } = new real;
////[Description("Select Yes if the evaporator fan power is included in the rated COP. This choice field")]
////public virtual choice EvaporatorFanPowerIncludedInRatedCOP { get; set; } = new choice;
////[Description("Select Yes if the condenser pump power is included in the rated COP. This choice field")]
////public virtual choice CondenserPumpPowerIncludedInRatedCOP { get; set; } = new choice;
////[Description("Select Yes if the condenser pump heat is included in the rated heating capacity and")]
////public virtual choice CondenserPumpHeatIncludedInRatedHeatingCapacityAndRatedCOP { get; set; } = new choice;
////[Description("A warning message will be issued if the ratio of Condenser Water Pump Power to Rated")]
////public virtual real CondenserWaterPumpPower { get; set; } = new real;
////[Description("Fraction of pump heat transferred to the condenser water. The pump is assumed")]
////public virtual real FractionOfCondenserPumpHeatToWater { get; set; } = new real;
////[Description("The node from which the DX coil draws its inlet air.")]
////public virtual node EvaporatorAirInletNodeName { get; set; } = new node;
////[Description("The node to which the DX coil sends its outlet air.")]
////public virtual node EvaporatorAirOutletNodeName { get; set; } = new node;
////[Description("The node from which the DX coil condenser draws its inlet water.")]
////public virtual node CondenserWaterInletNodeName { get; set; } = new node;
////[Description("The node to which the DX coil condenser sends its outlet water.")]
////public virtual node CondenserWaterOutletNodeName { get; set; } = new node;
////[Description("The compressor crankcase heater only operates when the dry-bulb temperature of air")]
////public virtual real CrankcaseHeaterCapacity { get; set; } = new real;
////[Description("The compressor crankcase heater only operates when the dry-bulb temperature of air")]
////public virtual real MaximumAmbientTemperatureForCrankcaseHeaterOperation { get; set; } = new real;
////[Description("Determines temperature type for heating capacity curves and")]
////public virtual choice EvaporatorAirTemperatureTypeForCurveObjects { get; set; } = new choice;
////[Description("Heating capacity modifier curve (function of temperature) should be biquadratic or cubic.")]
////public virtual object-list HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Heating capacity modifier curve (function of air flow fraction) should be quadratic or cubic.")]
////public virtual object-list HeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Heating capacity modifier curve (function of water flow fraction) should be quadratic or cubic.")]
////public virtual object-list HeatingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("Heating COP modifier curve (function of temperature) should be biquadratic or cubic.")]
////public virtual object-list HeatingCOPFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Heating COP modifier curve (function of air flow fraction) should be quadratic or cubic.")]
////public virtual object-list HeatingCOPFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Heating COP modifier curve (function of water flow fraction) should be quadratic or cubic.")]
////public virtual object-list HeatingCOPFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("Part Load Fraction Correlation (function of part load ratio) should be quadratic or cubic.")]
////public virtual object-list PartLoadFractionCorrelationCurveName { get; set; } = new object-list;
////}
////}

