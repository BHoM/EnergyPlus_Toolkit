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

//using BH.oM.Base;
//using System.Collections.Generic;
//using System.ComponentModel;
//
//namespace BH.oM.Adapters.EnergyPlus
//{
//public class Generator:MicroTurbine : BHoMObject
//{
//[Description("No description available")]
//public virtual alpha Name { get; set; } = new alpha;
//[Description("No description available")]
//public virtual real ReferenceElectricalPowerOutput { get; set; } = new real;
//[Description("No description available")]
//public virtual real MinimumFullLoadElectricalPowerOutput { get; set; } = new real;
//[Description("If left blank, Maximum Full Load Electrical Power Output will be set")]
//public virtual real MaximumFullLoadElectricalPowerOutput { get; set; } = new real;
//[Description("Electric power output divided by fuel energy input (LHV basis)")]
//public virtual real ReferenceElectricalEfficiencyUsingLowerHeatingValue { get; set; } = new real;
//[Description("No description available")]
//public virtual real ReferenceCombustionAirInletTemperature { get; set; } = new real;
//[Description("No description available")]
//public virtual real ReferenceCombustionAirInletHumidityRatio { get; set; } = new real;
//[Description("No description available")]
//public virtual real ReferenceElevation { get; set; } = new real;
//[Description("curve = a + b*T + c*T**2 + d*Elev + e*Elev**2 + f*T*Elev")]
//public virtual object-list ElectricalPowerFunctionOfTemperatureAndElevationCurveName { get; set; } = new object-list;
//[Description("Quadratic curve = a + b*T + c*T**2")]
//public virtual object-list ElectricalEfficiencyFunctionOfTemperatureCurveName { get; set; } = new object-list;
//[Description("Quadratic curve = a + b*PLR + c*PLR**2")]
//public virtual object-list ElectricalEfficiencyFunctionOfPartLoadRatioCurveName { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice FuelType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real FuelHigherHeatingValue { get; set; } = new real;
//[Description("No description available")]
//public virtual real FuelLowerHeatingValue { get; set; } = new real;
//[Description("Electric power consumed when the generator is available but not being called")]
//public virtual real StandbyPower { get; set; } = new real;
//[Description("Electric power consumed by ancillary equipment (e.g., external fuel pressurization pump).")]
//public virtual real AncillaryPower { get; set; } = new real;
//[Description("Quadratic curve = a + b*mdot + c*mdot**2")]
//public virtual object-list AncillaryPowerFunctionOfFuelInputCurveName { get; set; } = new object-list;
//[Description("No description available")]
//public virtual node HeatRecoveryWaterInletNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual node HeatRecoveryWaterOutletNodeName { get; set; } = new node;
//[Description("Reference thermal efficiency (heat recovery to water) based on the")]
//public virtual real ReferenceThermalEfficiencyUsingLowerHeatValue { get; set; } = new real;
//[Description("No description available")]
//public virtual real ReferenceInletWaterTemperature { get; set; } = new real;
//[Description("PlantControl means the heat recovery water flow rate is determined by the plant,")]
//public virtual choice HeatRecoveryWaterFlowOperatingMode { get; set; } = new choice;
//[Description("No description available")]
//public virtual real ReferenceHeatRecoveryWaterFlowRate { get; set; } = new real;
//[Description("curve = a + b*T + c*T**2 + d*Pnet + e*Pnet + f*T*Pnet")]
//public virtual object-list HeatRecoveryWaterFlowRateFunctionOfTemperatureAndPowerCurveName { get; set; } = new object-list;
//[Description("Bicubic curve = a + b*T + c*T**2 + d*Elev + e*Elev**2 + f*T*Elev + g*T**3 + h*Elev**3 + i*T**2*Elev + j*T*Elev**2")]
//public virtual object-list ThermalEfficiencyFunctionOfTemperatureAndElevationCurveName { get; set; } = new object-list;
//[Description("Quadratic curve = a + b*PLR + c*PLR**2")]
//public virtual object-list HeatRecoveryRateFunctionOfPartLoadRatioCurveName { get; set; } = new object-list;
//[Description("Quadratic curve = a + b*T + c*T**2")]
//public virtual object-list HeatRecoveryRateFunctionOfInletWaterTemperatureCurveName { get; set; } = new object-list;
//[Description("Quadratic curve = a + b*Flow + c*Flow**2")]
//public virtual object-list HeatRecoveryRateFunctionOfWaterFlowRateCurveName { get; set; } = new object-list;
//[Description("No description available")]
//public virtual real MinimumHeatRecoveryWaterFlowRate { get; set; } = new real;
//[Description("No description available")]
//public virtual real MaximumHeatRecoveryWaterFlowRate { get; set; } = new real;
//[Description("No description available")]
//public virtual real MaximumHeatRecoveryWaterTemperature { get; set; } = new real;
//[Description("Must be an outdoor air node.")]
//public virtual node CombustionAirInletNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual node CombustionAirOutletNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual real ReferenceExhaustAirMassFlowRate { get; set; } = new real;
//[Description("Quadratic curve = a + b*T + c*T**2")]
//public virtual object-list ExhaustAirFlowRateFunctionOfTemperatureCurveName { get; set; } = new object-list;
//[Description("Quadratic curve = a + b*PLR + c*PLR**2")]
//public virtual object-list ExhaustAirFlowRateFunctionOfPartLoadRatioCurveName { get; set; } = new object-list;
//[Description("Exhaust air outlet temperature at reference conditions.")]
//public virtual real NominalExhaustAirOutletTemperature { get; set; } = new real;
//[Description("Quadratic curve = a + b*T + c*T**2")]
//public virtual object-list ExhaustAirTemperatureFunctionOfTemperatureCurveName { get; set; } = new object-list;
//[Description("Quadratic curve = a + b*PLR + c*PLR**2")]
//public virtual object-list ExhaustAirTemperatureFunctionOfPartLoadRatioCurveName { get; set; } = new object-list;
//}
//}




