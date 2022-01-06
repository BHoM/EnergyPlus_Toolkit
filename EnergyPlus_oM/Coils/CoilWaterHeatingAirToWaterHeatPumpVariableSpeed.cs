/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2022, the respective contributors. All rights reserved.
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
////public class Coil:WaterHeating:AirToWaterHeatPump:VariableSpeed : BHoMObject
////{
////[Description("Unique name for this instance of a variable-speed heat pump water heater DX coil.")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual integer NumberOfSpeeds { get; set; } = new integer;
////[Description("must be lower than or equal to the highest speed number")]
////public virtual integer NominalSpeedLevel { get; set; } = new integer;
////[Description("Water Heating capacity at the rated inlet air temperatures, rated condenser inlet")]
////public virtual real RatedWaterHeatingCapacity { get; set; } = new real;
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
////[Description("Table:Lookup object can also be used")]
////public virtual object-list PartLoadFractionCorrelationCurveName { get; set; } = new object-list;
////[Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet")]
////public virtual real RatedWaterHeatingCapacityAtSpeed1 { get; set; } = new real;
////[Description("Heating coefficient of performance at the rated inlet air and water temperatures,")]
////public virtual real RatedWaterHeatingCOPAtSpeed1 { get; set; } = new real;
////[Description("Gross air-side sensible heat ratio at the rated inlet air temperatures,")]
////public virtual real RatedSensibleHeatRatioAtSpeed1 { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed1ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed1ReferenceUnitRatedWaterFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed1ReferenceUnitWaterPumpInputPowerAtRatedConditions { get; set; } = new real;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed1TotalWHCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed1TotalWHCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed1TotalWHCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed1COPFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed1COPFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed1COPFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet")]
////public virtual real RatedWaterHeatingCapacityAtSpeed2 { get; set; } = new real;
////[Description("Heating coefficient of performance at the rated inlet air and water temperatures,")]
////public virtual real RatedWaterHeatingCOPAtSpeed2 { get; set; } = new real;
////[Description("Gross air-side sensible heat ratio at the rated inlet air temperatures,")]
////public virtual real RatedSensibleHeatRatioAtSpeed2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed2ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed2ReferenceUnitRatedWaterFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed2ReferenceUnitWaterPumpInputPowerAtRatedConditions { get; set; } = new real;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed2TotalWHCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed2TotalWHCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed2TotalWHCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed2COPFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed2COPFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed2COPFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet")]
////public virtual real RatedWaterHeatingCapacityAtSpeed3 { get; set; } = new real;
////[Description("Heating coefficient of performance at the rated inlet air and water temperatures,")]
////public virtual real RatedWaterHeatingCOPAtSpeed3 { get; set; } = new real;
////[Description("Gross air-side sensible heat ratio at the rated inlet air temperatures,")]
////public virtual real RatedSensibleHeatRatioAtSpeed3 { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed3ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed3ReferenceUnitRatedWaterFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed3ReferenceUnitWaterPumpInputPowerAtRatedConditions { get; set; } = new real;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed3TotalWHCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed3TotalWHCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed3TotalWHCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed3COPFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed3COPFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed3COPFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet")]
////public virtual real RatedWaterHeatingCapacityAtSpeed4 { get; set; } = new real;
////[Description("Heating coefficient of performance at the rated inlet air and water temperatures,")]
////public virtual real RatedWaterHeatingCOPAtSpeed4 { get; set; } = new real;
////[Description("Gross air-side sensible heat ratio at the rated inlet air temperatures,")]
////public virtual real RatedSensibleHeatRatioAtSpeed4 { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed4ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed4ReferenceUnitRatedWaterFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed4ReferenceUnitWaterPumpInputPowerAtRatedConditions { get; set; } = new real;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed4TotalWHCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed4TotalWHCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed4TotalWHCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed4COPFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed4COPFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed4COPFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet")]
////public virtual real RatedWaterHeatingCapacityAtSpeed5 { get; set; } = new real;
////[Description("Heating coefficient of performance at the rated inlet air and water temperatures,")]
////public virtual real RatedWaterHeatingCOPAtSpeed5 { get; set; } = new real;
////[Description("Gross air-side sensible heat ratio at the rated inlet air temperatures,")]
////public virtual real RatedSensibleHeatRatioAtSpeed5 { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed5ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed5ReferenceUnitRatedWaterFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed5ReferenceUnitWaterPumpInputPowerAtRatedConditions { get; set; } = new real;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed5TotalWHCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed5TotalWHCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed5TotalWHCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed5COPFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed5COPFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed5COPFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet")]
////public virtual real RatedWaterHeatingCapacityAtSpeed6 { get; set; } = new real;
////[Description("Heating coefficient of performance at the rated inlet air and water temperatures,")]
////public virtual real RatedWaterHeatingCOPAtSpeed6 { get; set; } = new real;
////[Description("Gross air-side sensible heat ratio at the rated inlet air temperatures,")]
////public virtual real RatedSensibleHeatRatioAtSpeed6 { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed6ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed6ReferenceUnitRatedWaterFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed6ReferenceUnitWaterPumpInputPowerAtRatedConditions { get; set; } = new real;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed6TotalWHCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed6TotalWHCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed6TotalWHCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed6COPFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed6COPFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed6COPFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet")]
////public virtual real RatedWaterHeatingCapacityAtSpeed7 { get; set; } = new real;
////[Description("Heating coefficient of performance at the rated inlet air and water temperatures,")]
////public virtual real RatedWaterHeatingCOPAtSpeed7 { get; set; } = new real;
////[Description("Gross air-side sensible heat ratio at the rated inlet air temperatures,")]
////public virtual real RatedSensibleHeatRatioAtSpeed7 { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed7ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed7ReferenceUnitRatedWaterFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed7ReferenceUnitWaterPumpInputPowerAtRatedConditions { get; set; } = new real;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed7TotalWHCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed7TotalWHCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed7TotalWHCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed7COPFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed7COPFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed7COPFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet")]
////public virtual real RatedWaterHeatingCapacityAtSpeed8 { get; set; } = new real;
////[Description("Heating coefficient of performance at the rated inlet air and water temperatures,")]
////public virtual real RatedWaterHeatingCOPAtSpeed8 { get; set; } = new real;
////[Description("Gross air-side sensible heat ratio at the rated inlet air temperatures,")]
////public virtual real RatedSensibleHeatRatioAtSpeed8 { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed8ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed8ReferenceUnitRatedWaterFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed8ReferenceUnitWaterPumpInputPowerAtRatedConditions { get; set; } = new real;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed8TotalWHCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed8TotalWHCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed8TotalWHCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed8COPFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed8COPFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed8COPFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet")]
////public virtual real RatedWaterHeatingCapacityAtSpeed9 { get; set; } = new real;
////[Description("Heating coefficient of performance at the rated inlet air and water temperatures,")]
////public virtual real RatedWaterHeatingCOPAtSpeed9 { get; set; } = new real;
////[Description("Gross air-side sensible heat ratio at the rated inlet air temperatures,")]
////public virtual real RatedSensibleHeatRatioAtSpeed9 { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed9ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed9ReferenceUnitRatedWaterFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed9ReferenceUnitWaterPumpInputPowerAtRatedConditions { get; set; } = new real;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed9TotalWHCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed9TotalWHCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed9TotalWHCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed9COPFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed9COPFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed9COPFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet")]
////public virtual real RatedWaterHeatingCapacityAtSpeed10 { get; set; } = new real;
////[Description("Heating coefficient of performance at the rated inlet air and water temperatures,")]
////public virtual real RatedWaterHeatingCOPAtSpeed10 { get; set; } = new real;
////[Description("Gross air-side sensible heat ratio at the rated inlet air temperatures,")]
////public virtual real RatedSensibleHeatRatioAtSpeed10 { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed10ReferenceUnitRatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed10ReferenceUnitRatedWaterFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed10ReferenceUnitWaterPumpInputPowerAtRatedConditions { get; set; } = new real;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed10TotalWHCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed10TotalWHCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed10TotalWHCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed10COPFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed10COPFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Table:Lookup object can also be used")]
////public virtual object-list Speed10COPFunctionOfWaterFlowFractionCurveName { get; set; } = new object-list;
////}
////}


