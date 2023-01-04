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
////public class ZoneHVAC:HybridUnitaryHVAC : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Enter the availability schedule name for this system. Schedule value > 0 means the system is available. If this field is blank, the system is always available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
////public virtual object-list AvailabilityManagerListName { get; set; } = new object-list;
////[Description("Values in this schedule are used as a constraint in choosing the feasible settings for supply air flow rate and ouside air fraction in each operating mode. If this field is blank, no minimum is imposed.")]
////public virtual object-list MinimumSupplyAirTemperatureScheduleName { get; set; } = new object-list;
////[Description("Values in this schedule are used as a constraint in choosing the feasible settings for supply air flow rate and outdoor air fraction in each operating mode. If this field is blank, no maximum is imposed.")]
////public virtual object-list MaximumSupplyAirTemperatureScheduleName { get; set; } = new object-list;
////[Description("Values in this schedule are used as a constraint in choosing the feasible settings for supply air flow rate and outdoor air fraction in each operating mode. If this field is blank, no minimum is imposed.")]
////public virtual object-list MinimumSupplyAirHumidityRatioScheduleName { get; set; } = new object-list;
////[Description("Values in this schedule are used as a constraint in choosing the feasible settings for supply air flow rate and outdoor air fraction in each operating mode. If this field is blank, no maximum is imposed.")]
////public virtual object-list MaximumSupplyAirHumidityRatioScheduleName { get; set; } = new object-list;
////[Description("Select the method that will be used to choose operating mode(s), supply air flow rate(s), outdoor air fraction(s) and part runtime fraction(s) in each time step. "Automatic" = chooses controlled inputs and part runtime fraction(s) to minimize resource use within each time step while best satisfying requested sensible cooling, dehumidification and ventilation, and subject to constraints. "User Defined" = EMS will be used to choose controlled inputs and part runtime fraction(s) in each time step. If this field is blank, default to "Automatic".")]
////public virtual choice MethodToChooseControlledInputsAndPartRuntimeFraction { get; set; } = new choice;
////[Description("Return air node for the hybrid unit must be a zone exhaust node.")]
////public virtual node ReturnAirNodeName { get; set; } = new node;
////[Description("Outdoor air node for the hybrid unit must be an outdoor air node.")]
////public virtual node OutdoorAirNodeName { get; set; } = new node;
////[Description("Supply air node for the hybrid unit must be a zone air inlet node.")]
////public virtual node SupplyAirNodeName { get; set; } = new node;
////[Description("Relief node for the hybrid unit must be a zone exhaust node, unless flow is being balanced elsewhere.")]
////public virtual node ReliefNodeName { get; set; } = new node;
////[Description("The value in this field represents the maximum supply air volume flow rate among all operating modes. Values of extensive variables in lookup tables are normalized by the system maximum supply air mass flow rate that was used to build performance curves. The value in this field is used to rescale the output from exenstive variables to a desired system size.")]
////public virtual real SystemMaximumSupplyAirFlowRate { get; set; } = new real;
////[Description("Input the external static pressure when the system operates at maximum supply air flow rate. Fan affinity laws are used to scale supply fan power from the values tabulated in lookup tables, to values that match the external static pressure input to this field. If this field is blank, the supply fan power is not scaled from the values tabulated in lookup tables.")]
////public virtual real ExternalStaticPressureAtSystemMaximumSupplyAirFlowRate { get; set; } = new real;
////[Description("The value in this field scales all extensive performance variables including: supply air mass flow rate, fuel uses, and water use. If this field is blank, the default scaling factor is 1.")]
////public virtual real ScalingFactor { get; set; } = new real;
////[Description("The value in this field defines the number of discrete operating modes for the unitary hybrid equipment. Supply air mass flow rate ratio and outdoor air fraction are treated as continuous controlled inputs within each discrete operating mode.")]
////public virtual integer NumberOfOperatingModes { get; set; } = new integer;
////[Description("Any mode selected will not operate for less time than the value input in this field. If the value in this field is larger than each timestep, the mode selected in one time step will persist in later time steps until the minimum time between mode change is satisfied. Supply air mass flow rate and outdoor air fraction within a mode are not subject to minimum runtime and may change in every time step. Mode 0 does not have a minimum time. If this field is blank, the default minimum time between mode change is 10 minutes.")]
////public virtual real MinimumTimeBetweenModeChange { get; set; } = new real;
////[Description("Select the fuel type associated with field: "System Electric Power Lookup Table" in each mode.")]
////public virtual choice FirstFuelType { get; set; } = new choice;
////[Description("Select the fuel type associated with field: "System Second Fuel Consumption Lookup Table" in each mode.")]
////public virtual choice SecondFuelType { get; set; } = new choice;
////[Description("Select the fuel type associated with field: "System Third Fuel Consumption Lookup Table" in each mode.")]
////public virtual choice ThirdFuelType { get; set; } = new choice;
////[Description("In each time step, controlled variables will be chosen to minimize the selection in this field, subject to constraints.")]
////public virtual choice ObjectiveFunctionToMinimize { get; set; } = new choice;
////[Description("Enter the name of a DesignSpecification:OutdoorAir object. Information in that object will be used to compute the minimum outdoor air flow rate in each time step.")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName { get; set; } = new object-list;
////[Description("Enter a name for Mode 0.")]
////public virtual alpha Mode0Name { get; set; } = new alpha;
////[Description("Enter the name of the Supply Air Temperature Lookup Table for Mode 0.")]
////public virtual object-list Mode0SupplyAirTemperatureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Air Humidity Ratio Lookup Table for Mode 0.")]
////public virtual object-list Mode0SupplyAirHumidityRatioLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Electric Power Lookup Table for Mode 0.")]
////public virtual object-list Mode0SystemElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Fan Electric Power Lookup Table for Mode 0.")]
////public virtual object-list Mode0SupplyFanElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the External Static Pressure Lookup Table for Mode 0.")]
////public virtual object-list Mode0ExternalStaticPressureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Second Fuel Consumption Lookup Table for Mode 0.")]
////public virtual object-list Mode0SystemSecondFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Third Fuel Consumption Lookup Table for Mode 0.")]
////public virtual object-list Mode0SystemThirdFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Water Use Lookup Table for Mode 0.")]
////public virtual object-list Mode0SystemWaterUseLookupTableName { get; set; } = new object-list;
////[Description("Enter the outdoor air fraction for Mode 0.")]
////public virtual real Mode0OutdoorAirFraction { get; set; } = new real;
////[Description("Enter the supply air mass flow rate ratio for Mode 0. The value in this field will be used to determine the supply air mass flow rate in Mode 0.")]
////public virtual real Mode0SupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter a name for Mode 1.")]
////public virtual alpha Mode1Name { get; set; } = new alpha;
////[Description("Enter the name of the Supply Air Temperature Lookup Table for Mode 1.")]
////public virtual object-list Mode1SupplyAirTemperatureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Air Humidity Ratio Lookup Table for Mode 1.")]
////public virtual object-list Mode1SupplyAirHumidityRatioLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Electric Power Lookup Table for Mode 1.")]
////public virtual object-list Mode1SystemElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Fan Electric Power Lookup Table for Mode 1.")]
////public virtual object-list Mode1SupplyFanElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the External Static Pressure Lookup Table for Mode 1.")]
////public virtual object-list Mode1ExternalStaticPressureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Second Fuel Consumption Lookup Table for Mode 1.")]
////public virtual object-list Mode1SystemSecondFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Third Fuel Consumption Lookup Table for Mode 1.")]
////public virtual object-list Mode1SystemThirdFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Water Use Lookup Table for Mode 1.")]
////public virtual object-list Mode1SystemWaterUseLookupTableName { get; set; } = new object-list;
////[Description("Enter the minimum outdoor air temperature allowed for Mode 1.")]
////public virtual real Mode1MinimumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the maximum outdoor air temperature allowed for Mode 1.")]
////public virtual real Mode1MaximumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the minimum outdoor humidity ratio allowed for Mode 1.")]
////public virtual real Mode1MinimumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum outdoor air humidity ratio allowed for Mode 1.")]
////public virtual real Mode1MaximumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum outdoor relative humidity allowed for Mode 1.")]
////public virtual real Mode1MinimumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum outdoor air relative humidity allowed for Mode 1.")]
////public virtual real Mode1MaximumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum return air temperature allowed for Mode 1.")]
////public virtual real Mode1MinimumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the maximum return air temperature allowed for Mode 1.")]
////public virtual real Mode1MaximumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the minimum return air humidity ratio allowed for Mode 1.")]
////public virtual real Mode1MinimumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum return air humidity ratio allowed for Mode 1.")]
////public virtual real Mode1MaximumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum return air relative humidity allowed for Mode 1.")]
////public virtual real Mode1MinimumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum return air relative humdity allowed for Mode 1.")]
////public virtual real Mode1MaximumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum outdoor air fraction allowed for Mode 1.")]
////public virtual real Mode1MinimumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the maximum outdoor air fraction allowed for Mode 1.")]
////public virtual real Mode1MaximumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the minimum supply air mass flow rate ratio allowed for Mode 1.")]
////public virtual real Mode1MinimumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter the maximum supply air mass flow rate ratio allowed for Mode 1.")]
////public virtual real Mode1MaximumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter a name for Mode 2.")]
////public virtual alpha Mode2Name { get; set; } = new alpha;
////[Description("Enter the name of the Supply Air Temperature Lookup Table for Mode 2.")]
////public virtual object-list Mode2SupplyAirTemperatureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Air Humidity Ratio Lookup Table for Mode 2.")]
////public virtual object-list Mode2SupplyAirHumidityRatioLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Electric Power Lookup Table for Mode 2.")]
////public virtual object-list Mode2SystemElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Fan Electric Power Lookup Table for Mode 2.")]
////public virtual object-list Mode2SupplyFanElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the External Static Pressure Lookup Table for Mode 2.")]
////public virtual object-list Mode2ExternalStaticPressureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Second Fuel Consumption Lookup Table for Mode 2.")]
////public virtual object-list Mode2SystemSecondFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Third Fuel Consumption Lookup Table for Mode 2.")]
////public virtual object-list Mode2SystemThirdFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Water Use Lookup Table for Mode 2.")]
////public virtual object-list Mode2SystemWaterUseLookupTableName { get; set; } = new object-list;
////[Description("Enter the minimum outdoor air temperature allowed for Mode 2.")]
////public virtual real Mode2MinimumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the maximum outdoor air temperature allowed for Mode 2.")]
////public virtual real Mode2MaximumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the minimum outdoor humidity ratio allowed for Mode 2.")]
////public virtual real Mode2MinimumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum outdoor air humidity ratio allowed for Mode 2.")]
////public virtual real Mode2MaximumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum outdoor relative humidity allowed for Mode 2.")]
////public virtual real Mode2MinimumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum outdoor air relative humidity allowed for Mode 2.")]
////public virtual real Mode2MaximumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum return air temperature allowed for Mode 2.")]
////public virtual real Mode2MinimumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the maximum return air temperature allowed for Mode 2.")]
////public virtual real Mode2MaximumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the minimum return air humidity ratio allowed for Mode 2.")]
////public virtual real Mode2MinimumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum return air humidity ratio allowed for Mode 2.")]
////public virtual real Mode2MaximumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum return air relative humidity allowed for Mode 2.")]
////public virtual real Mode2MinimumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum return air relative humdity allowed for Mode 2.")]
////public virtual real Mode2MaximumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum outdoor air fraction allowed for Mode 2.")]
////public virtual real Mode2MinimumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the maximum outdoor air fraction allowed for Mode 2.")]
////public virtual real Mode2MaximumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the minimum supply air mass flow rate ratio allowed for Mode 2.")]
////public virtual real Mode2MinimumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter the maximum supply air mass flow rate ratio allowed for Mode 2.")]
////public virtual real Mode2MaximumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter a name for Mode 3.")]
////public virtual alpha Mode3Name { get; set; } = new alpha;
////[Description("Enter the name of the Supply Air Temperature Lookup Table for Mode 3.")]
////public virtual object-list Mode3SupplyAirTemperatureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Air Humidity Ratio Lookup Table for Mode 3.")]
////public virtual object-list Mode3SupplyAirHumidityRatioLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Electric Power Lookup Table for Mode 3.")]
////public virtual object-list Mode3SystemElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Fan Electric Power Lookup Table for Mode 3.")]
////public virtual object-list Mode3SupplyFanElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the External Static Pressure Lookup Table for Mode 3.")]
////public virtual object-list Mode3ExternalStaticPressureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Second Fuel Consumption Lookup Table for Mode 3.")]
////public virtual object-list Mode3SystemSecondFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Third Fuel Consumption Lookup Table for Mode 3.")]
////public virtual object-list Mode3SystemThirdFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Water Use Lookup Table for Mode 3.")]
////public virtual object-list Mode3SystemWaterUseLookupTableName { get; set; } = new object-list;
////[Description("Enter the minimum outdoor air temperature allowed for Mode 3.")]
////public virtual real Mode3MinimumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the maximum outdoor air temperature allowed for Mode 3.")]
////public virtual real Mode3MaximumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the minimum outdoor humidity ratio allowed for Mode 3.")]
////public virtual real Mode3MinimumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum outdoor air humidity ratio allowed for Mode 3.")]
////public virtual real Mode3MaximumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum outdoor relative humidity allowed for Mode 3.")]
////public virtual real Mode3MinimumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum outdoor air relative humidity allowed for Mode 3.")]
////public virtual real Mode3MaximumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum return air temperature allowed for Mode 3.")]
////public virtual real Mode3MinimumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the maximum return air temperature allowed for Mode 3.")]
////public virtual real Mode3MaximumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the minimum return air humidity ratio allowed for Mode 3.")]
////public virtual real Mode3MinimumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum return air humidity ratio allowed for Mode 3.")]
////public virtual real Mode3MaximumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum return air relative humidity allowed for Mode 3.")]
////public virtual real Mode3MinimumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum return air relative humdity allowed for Mode 3.")]
////public virtual real Mode3MaximumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum outdoor air fraction allowed for Mode 3.")]
////public virtual real Mode3MinimumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the maximum outdoor air fraction allowed for Mode 3.")]
////public virtual real Mode3MaximumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the minimum supply air mass flow rate ratio allowed for Mode 3.")]
////public virtual real Mode3MinimumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter the maximum supply air mass flow rate ratio allowed for Mode 3.")]
////public virtual real Mode3MaximumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter a name for Mode 4.")]
////public virtual alpha Mode4Name { get; set; } = new alpha;
////[Description("Enter the name of the Supply Air Temperature Lookup Table for Mode 4.")]
////public virtual object-list Mode4SupplyAirTemperatureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Air Humidity Ratio Lookup Table for Mode 4.")]
////public virtual object-list Mode4SupplyAirHumidityRatioLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Electric Power Lookup Table for Mode 4.")]
////public virtual object-list Mode4SystemElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Fan Electric Power Lookup Table for Mode 4.")]
////public virtual object-list Mode4SupplyFanElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the External Static Pressure Lookup Table for Mode 4.")]
////public virtual object-list Mode4ExternalStaticPressureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Second Fuel Consumption Lookup Table for Mode 4.")]
////public virtual object-list Mode4SystemSecondFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Third Fuel Consumption Lookup Table for Mode 4.")]
////public virtual object-list Mode4SystemThirdFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Water Use Lookup Table for Mode 4.")]
////public virtual object-list Mode4SystemWaterUseLookupTableName { get; set; } = new object-list;
////[Description("Enter the minimum outdoor air temperature allowed for Mode 4.")]
////public virtual real Mode4MinimumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the maximum outdoor air temperature allowed for Mode 4.")]
////public virtual real Mode4MaximumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the minimum outdoor humidity ratio allowed for Mode 4.")]
////public virtual real Mode4MinimumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum outdoor air humidity ratio allowed for Mode 4.")]
////public virtual real Mode4MaximumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum outdoor relative humidity allowed for Mode 4.")]
////public virtual real Mode4MinimumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum outdoor air relative humidity allowed for Mode 4.")]
////public virtual real Mode4MaximumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum return air temperature allowed for Mode 4.")]
////public virtual real Mode4MinimumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the maximum return air temperature allowed for Mode 4.")]
////public virtual real Mode4MaximumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the minimum return air humidity ratio allowed for Mode 4.")]
////public virtual real Mode4MinimumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum return air humidity ratio allowed for Mode 4.")]
////public virtual real Mode4MaximumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum return air relative humidity allowed for Mode 4.")]
////public virtual real Mode4MinimumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum return air relative humdity allowed for Mode 4.")]
////public virtual real Mode4MaximumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum outdoor air fraction allowed for Mode 4.")]
////public virtual real Mode4MinimumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the maximum outdoor air fraction allowed for Mode 4.")]
////public virtual real Mode4MaximumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the minimum supply air mass flow rate ratio allowed for Mode 4.")]
////public virtual real Mode4MinimumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter the maximum supply air mass flow rate ratio allowed for Mode 4.")]
////public virtual real Mode4MaximumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter a name for Mode 5.")]
////public virtual alpha Mode5Name { get; set; } = new alpha;
////[Description("Enter the name of the Supply Air Temperature Lookup Table for Mode 5.")]
////public virtual object-list Mode5SupplyAirTemperatureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Air Humidity Ratio Lookup Table for Mode 5.")]
////public virtual object-list Mode5SupplyAirHumidityRatioLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Electric Power Lookup Table for Mode 5.")]
////public virtual object-list Mode5SystemElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Fan Electric Power Lookup Table for Mode 5.")]
////public virtual object-list Mode5SupplyFanElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the External Static Pressure Lookup Table for Mode 5.")]
////public virtual object-list Mode5ExternalStaticPressureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Second Fuel Consumption Lookup Table for Mode 5.")]
////public virtual object-list Mode5SystemSecondFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Third Fuel Consumption Lookup Table for Mode 5.")]
////public virtual object-list Mode5SystemThirdFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Water Use Lookup Table for Mode 5.")]
////public virtual object-list Mode5SystemWaterUseLookupTableName { get; set; } = new object-list;
////[Description("Enter the minimum outdoor air temperature allowed for Mode 5.")]
////public virtual real Mode5MinimumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the maximum outdoor air temperature allowed for Mode 5.")]
////public virtual real Mode5MaximumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the minimum outdoor humidity ratio allowed for Mode 5.")]
////public virtual real Mode5MinimumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum outdoor air humidity ratio allowed for Mode 5.")]
////public virtual real Mode5MaximumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum outdoor relative humidity allowed for Mode 5.")]
////public virtual real Mode5MinimumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum outdoor air relative humidity allowed for Mode 5.")]
////public virtual real Mode5MaximumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum return air temperature allowed for Mode 5.")]
////public virtual real Mode5MinimumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the maximum return air temperature allowed for Mode 5.")]
////public virtual real Mode5MaximumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the minimum return air humidity ratio allowed for Mode 5.")]
////public virtual real Mode5MinimumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum return air humidity ratio allowed for Mode 5.")]
////public virtual real Mode5MaximumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum return air relative humidity allowed for Mode 5.")]
////public virtual real Mode5MinimumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum return air relative humdity allowed for Mode 5.")]
////public virtual real Mode5MaximumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum outdoor air fraction allowed for Mode 5.")]
////public virtual real Mode5MinimumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the maximum outdoor air fraction allowed for Mode 5.")]
////public virtual real Mode5MaximumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the minimum supply air mass flow rate ratio allowed for Mode 5.")]
////public virtual real Mode5MinimumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter the maximum supply air mass flow rate ratio allowed for Mode 5.")]
////public virtual real Mode5MaximumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter a name for Mode 6.")]
////public virtual alpha Mode6Name { get; set; } = new alpha;
////[Description("Enter the name of the Supply Air Temperature Lookup Table for Mode 6.")]
////public virtual object-list Mode6SupplyAirTemperatureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Air Humidity Ratio Lookup Table for Mode 6.")]
////public virtual object-list Mode6SupplyAirHumidityRatioLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Electric Power Lookup Table for Mode 6.")]
////public virtual object-list Mode6SystemElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Fan Electric Power Lookup Table for Mode 6.")]
////public virtual object-list Mode6SupplyFanElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the External Static Pressure Lookup Table for Mode 6.")]
////public virtual object-list Mode6ExternalStaticPressureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Second Fuel Consumption Lookup Table for Mode 6.")]
////public virtual object-list Mode6SystemSecondFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Third Fuel Consumption Lookup Table for Mode 6.")]
////public virtual object-list Mode6SystemThirdFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Water Use Lookup Table for Mode 6.")]
////public virtual object-list Mode6SystemWaterUseLookupTableName { get; set; } = new object-list;
////[Description("Enter the minimum outdoor air temperature allowed for Mode 6.")]
////public virtual real Mode6MinimumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the maximum outdoor air temperature allowed for Mode 6.")]
////public virtual real Mode6MaximumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the minimum outdoor humidity ratio allowed for Mode 6.")]
////public virtual real Mode6MinimumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum outdoor air humidity ratio allowed for Mode 6.")]
////public virtual real Mode6MaximumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum outdoor relative humidity allowed for Mode 6.")]
////public virtual real Mode6MinimumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum outdoor air relative humidity allowed for Mode 6.")]
////public virtual real Mode6MaximumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum return air temperature allowed for Mode 6.")]
////public virtual real Mode6MinimumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the maximum return air temperature allowed for Mode 6.")]
////public virtual real Mode6MaximumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the minimum return air humidity ratio allowed for Mode 6.")]
////public virtual real Mode6MinimumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum return air humidity ratio allowed for Mode 6.")]
////public virtual real Mode6MaximumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum return air relative humidity allowed for Mode 6.")]
////public virtual real Mode6MinimumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum return air relative humdity allowed for Mode 6.")]
////public virtual real Mode6MaximumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum outdoor air fraction allowed for Mode 6.")]
////public virtual real Mode6MinimumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the maximum outdoor air fraction allowed for Mode 6.")]
////public virtual real Mode6MaximumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the minimum supply air mass flow rate ratio allowed for Mode 6.")]
////public virtual real Mode6MinimumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter the maximum supply air mass flow rate ratio allowed for Mode 6.")]
////public virtual real Mode6MaximumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter a name for Mode 7.")]
////public virtual alpha Mode7Name { get; set; } = new alpha;
////[Description("Enter the name of the Supply Air Temperature Lookup Table for Mode 7.")]
////public virtual object-list Mode7SupplyAirTemperatureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Air Humidity Ratio Lookup Table for Mode 7.")]
////public virtual object-list Mode7SupplyAirHumidityRatioLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Electric Power Lookup Table for Mode 7.")]
////public virtual object-list Mode7SystemElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Fan Electric Power Lookup Table for Mode 7.")]
////public virtual object-list Mode7SupplyFanElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the External Static Pressure Lookup Table for Mode 7.")]
////public virtual object-list Mode7ExternalStaticPressureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Second Fuel Consumption Lookup Table for Mode 7.")]
////public virtual object-list Mode7SystemSecondFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Third Fuel Consumption Lookup Table for Mode 7.")]
////public virtual object-list Mode7SystemThirdFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Water Use Lookup Table for Mode 7.")]
////public virtual object-list Mode7SystemWaterUseLookupTableName { get; set; } = new object-list;
////[Description("Enter the minimum outdoor air temperature allowed for Mode 7.")]
////public virtual real Mode7MinimumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the maximum outdoor air temperature allowed for Mode 7.")]
////public virtual real Mode7MaximumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the minimum outdoor humidity ratio allowed for Mode 7.")]
////public virtual real Mode7MinimumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum outdoor air humidity ratio allowed for Mode 7.")]
////public virtual real Mode7MaximumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum outdoor relative humidity allowed for Mode 7.")]
////public virtual real Mode7MinimumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum outdoor air relative humidity allowed for Mode 7.")]
////public virtual real Mode7MaximumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum return air temperature allowed for Mode 7.")]
////public virtual real Mode7MinimumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the maximum return air temperature allowed for Mode 7.")]
////public virtual real Mode7MaximumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the minimum return air humidity ratio allowed for Mode 7.")]
////public virtual real Mode7MinimumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum return air humidity ratio allowed for Mode 7.")]
////public virtual real Mode7MaximumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum return air relative humidity allowed for Mode 7.")]
////public virtual real Mode7MinimumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum return air relative humdity allowed for Mode 7.")]
////public virtual real Mode7MaximumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum outdoor air fraction allowed for Mode 7.")]
////public virtual real Mode7MinimumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the maximum outdoor air fraction allowed for Mode 7.")]
////public virtual real Mode7MaximumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the minimum supply air mass flow rate ratio allowed for Mode 7.")]
////public virtual real Mode7MinimumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter the maximum supply air mass flow rate ratio allowed for Mode 7.")]
////public virtual real Mode7MaximumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter a name for Mode 8.")]
////public virtual alpha Mode8Name { get; set; } = new alpha;
////[Description("Enter the name of the Supply Air Temperature Lookup Table for Mode 8.")]
////public virtual object-list Mode8SupplyAirTemperatureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Air Humidity Ratio Lookup Table for Mode 8.")]
////public virtual object-list Mode8SupplyAirHumidityRatioLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Electric Power Lookup Table for Mode 8.")]
////public virtual object-list Mode8SystemElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Fan Electric Power Lookup Table for Mode 8.")]
////public virtual object-list Mode8SupplyFanElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the External Static Pressure Lookup Table for Mode 8.")]
////public virtual object-list Mode8ExternalStaticPressureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Second Fuel Consumption Lookup Table for Mode 8.")]
////public virtual object-list Mode8SystemSecondFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Third Fuel Consumption Lookup Table for Mode 8.")]
////public virtual object-list Mode8SystemThirdFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Water Use Lookup Table for Mode 8.")]
////public virtual object-list Mode8SystemWaterUseLookupTableName { get; set; } = new object-list;
////[Description("Enter the minimum outdoor air temperature allowed for Mode 8.")]
////public virtual real Mode8MinimumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the maximum outdoor air temperature allowed for Mode 8.")]
////public virtual real Mode8MaximumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the minimum outdoor humidity ratio allowed for Mode 8.")]
////public virtual real Mode8MinimumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum outdoor air humidity ratio allowed for Mode 8.")]
////public virtual real Mode8MaximumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum outdoor relative humidity allowed for Mode 8.")]
////public virtual real Mode8MinimumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum outdoor air relative humidity allowed for Mode 8.")]
////public virtual real Mode8MaximumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum return air temperature allowed for Mode 8.")]
////public virtual real Mode8MinimumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the maximum return air temperature allowed for Mode 8.")]
////public virtual real Mode8MaximumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the minimum return air humidity ratio allowed for Mode 8.")]
////public virtual real Mode8MinimumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum return air humidity ratio allowed for Mode 8.")]
////public virtual real Mode8MaximumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum return air relative humidity allowed for Mode 8.")]
////public virtual real Mode8MinimumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum return air relative humdity allowed for Mode 8.")]
////public virtual real Mode8MaximumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum outdoor air fraction allowed for Mode 8.")]
////public virtual real Mode8MinimumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the maximum outdoor air fraction allowed for Mode 8.")]
////public virtual real Mode8MaximumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the minimum supply air mass flow rate ratio allowed for Mode 8.")]
////public virtual real Mode8MinimumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter the maximum supply air mass flow rate ratio allowed for Mode 8.")]
////public virtual real Mode8MaximumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter a name for Mode 9.")]
////public virtual alpha Mode9Name { get; set; } = new alpha;
////[Description("Enter the name of the Supply Air Temperature Lookup Table for Mode 9.")]
////public virtual object-list Mode9SupplyAirTemperatureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Air Humidity Ratio Lookup Table for Mode 9.")]
////public virtual object-list Mode9SupplyAirHumidityRatioLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Electric Power Lookup Table for Mode 9.")]
////public virtual object-list Mode9SystemElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Fan Electric Power Lookup Table for Mode 9.")]
////public virtual object-list Mode9SupplyFanElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the External Static Pressure Lookup Table for Mode 9.")]
////public virtual object-list Mode9ExternalStaticPressureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Second Fuel Consumption Lookup Table for Mode 9.")]
////public virtual object-list Mode9SystemSecondFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Third Fuel Consumption Lookup Table for Mode 9.")]
////public virtual object-list Mode9SystemThirdFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Water Use Lookup Table for Mode 9.")]
////public virtual object-list Mode9SystemWaterUseLookupTableName { get; set; } = new object-list;
////[Description("Enter the minimum outdoor air temperature allowed for Mode 9.")]
////public virtual real Mode9MinimumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the maximum outdoor air temperature allowed for Mode 9.")]
////public virtual real Mode9MaximumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the minimum outdoor humidity ratio allowed for Mode 9.")]
////public virtual real Mode9MinimumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum outdoor air humidity ratio allowed for Mode 9.")]
////public virtual real Mode9MaximumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum outdoor relative humidity allowed for Mode 9.")]
////public virtual real Mode9MinimumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum outdoor air relative humidity allowed for Mode 9.")]
////public virtual real Mode9MaximumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum return air temperature allowed for Mode 9.")]
////public virtual real Mode9MinimumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the maximum return air temperature allowed for Mode 9.")]
////public virtual real Mode9MaximumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the minimum return air humidity ratio allowed for Mode 9.")]
////public virtual real Mode9MinimumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum return air humidity ratio allowed for Mode 9.")]
////public virtual real Mode9MaximumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum return air relative humidity allowed for Mode 9.")]
////public virtual real Mode9MinimumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum return air relative humdity allowed for Mode 9.")]
////public virtual real Mode9MaximumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum outdoor air fraction allowed for Mode 9.")]
////public virtual real Mode9MinimumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the maximum outdoor air fraction allowed for Mode 9.")]
////public virtual real Mode9MaximumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the minimum supply air mass flow rate ratio allowed for Mode 9.")]
////public virtual real Mode9MinimumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter the maximum supply air mass flow rate ratio allowed for Mode 9.")]
////public virtual real Mode9MaximumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter a name for Mode 10.")]
////public virtual alpha Mode10Name { get; set; } = new alpha;
////[Description("Enter the name of the Supply Air Humidity Ratio Lookup Table for Mode 10.")]
////public virtual object-list Mode10SupplyAirHumidityRatioLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Electric Power Lookup Table for Mode 10.")]
////public virtual object-list Mode10SystemElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Fan Electric Power Lookup Table for Mode 10.")]
////public virtual object-list Mode10SupplyFanElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the External Static Pressure Lookup Table for Mode 10.")]
////public virtual object-list Mode10ExternalStaticPressureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Second Fuel Consumption Lookup Table for Mode 10.")]
////public virtual object-list Mode10SystemSecondFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Third Fuel Consumption Lookup Table for Mode 10.")]
////public virtual object-list Mode10SystemThirdFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Water Use Lookup Table for Mode 10.")]
////public virtual object-list Mode10SystemWaterUseLookupTableName { get; set; } = new object-list;
////[Description("Enter the minimum outdoor air temperature allowed for Mode 10.")]
////public virtual real Mode10MinimumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the maximum outdoor air temperature allowed for Mode 10.")]
////public virtual real Mode10MaximumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the minimum outdoor humidity ratio allowed for Mode 10.")]
////public virtual real Mode10MinimumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum outdoor air humidity ratio allowed for Mode 10.")]
////public virtual real Mode10MaximumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum outdoor relative humidity allowed for Mode 10.")]
////public virtual real Mode10MinimumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum outdoor air relative humidity allowed for Mode 10.")]
////public virtual real Mode10MaximumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum return air temperature allowed for Mode 10.")]
////public virtual real Mode10MinimumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the maximum return air temperature allowed for Mode 10.")]
////public virtual real Mode10MaximumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the minimum return air humidity ratio allowed for Mode 10.")]
////public virtual real Mode10MinimumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum return air humidity ratio allowed for Mode 10.")]
////public virtual real Mode10MaximumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum return air relative humidity allowed for Mode 10.")]
////public virtual real Mode10MinimumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum return air relative humdity allowed for Mode 10.")]
////public virtual real Mode10MaximumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum outdoor air fraction allowed for Mode 10.")]
////public virtual real Mode10MinimumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the maximum outdoor air fraction allowed for Mode 10.")]
////public virtual real Mode10MaximumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the minimum supply air mass flow rate ratio allowed for Mode 10.")]
////public virtual real Mode10MinimumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter the maximum supply air mass flow rate ratio allowed for Mode 10.")]
////public virtual real Mode10MaximumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter a name for Mode 11.")]
////public virtual alpha Mode11Name { get; set; } = new alpha;
////[Description("Enter the name of the Supply Air Temperature Lookup Table for Mode 11.")]
////public virtual object-list Mode11SupplyAirTemperatureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Air Humidity Ratio Lookup Table for Mode 11.")]
////public virtual object-list Mode11SupplyAirHumidityRatioLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Electric Power Lookup Table for Mode 11.")]
////public virtual object-list Mode11SystemElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Fan Electric Power Lookup Table for Mode 11.")]
////public virtual object-list Mode11SupplyFanElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the External Static Pressure Lookup Table for Mode 11.")]
////public virtual object-list Mode11ExternalStaticPressureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Second Fuel Consumption Lookup Table for Mode 11.")]
////public virtual object-list Mode11SystemSecondFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Third Fuel Consumption Lookup Table for Mode 11.")]
////public virtual object-list Mode11SystemThirdFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Water Use Lookup Table for Mode 11.")]
////public virtual object-list Mode11SystemWaterUseLookupTableName { get; set; } = new object-list;
////[Description("Enter the minimum outdoor air temperature allowed for Mode 11.")]
////public virtual real Mode11MinimumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the maximum outdoor air temperature allowed for Mode 11.")]
////public virtual real Mode11MaximumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the minimum outdoor humidity ratio allowed for Mode 11.")]
////public virtual real Mode11MinimumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum outdoor air humidity ratio allowed for Mode 11.")]
////public virtual real Mode11MaximumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum outdoor relative humidity allowed for Mode 11.")]
////public virtual real Mode11MinimumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum outdoor air relative humidity allowed for Mode 11.")]
////public virtual real Mode11MaximumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum return air temperature allowed for Mode 11.")]
////public virtual real Mode11MinimumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the maximum return air temperature allowed for Mode 11.")]
////public virtual real Mode11MaximumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the minimum return air humidity ratio allowed for Mode 11.")]
////public virtual real Mode11MinimumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum return air humidity ratio allowed for Mode 11.")]
////public virtual real Mode11MaximumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum return air relative humidity allowed for Mode 11.")]
////public virtual real Mode11MinimumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum return air relative humdity allowed for Mode 11.")]
////public virtual real Mode11MaximumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum outdoor air fraction allowed for Mode 11.")]
////public virtual real Mode11MinimumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the maximum outdoor air fraction allowed for Mode 11.")]
////public virtual real Mode11MaximumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the minimum supply air mass flow rate ratio allowed for Mode 11.")]
////public virtual real Mode11MinimumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter the maximum supply air mass flow rate ratio allowed for Mode 11.")]
////public virtual real Mode11MaximumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter a name for Mode 12.")]
////public virtual alpha Mode12Name { get; set; } = new alpha;
////[Description("Enter the name of the Supply Air Temperature Lookup Table for Mode 12.")]
////public virtual object-list Mode12SupplyAirTemperatureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Air Humidity Ratio Lookup Table for Mode 12.")]
////public virtual object-list Mode12SupplyAirHumidityRatioLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Electric Power Lookup Table for Mode 12.")]
////public virtual object-list Mode12SystemElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Fan Electric Power Lookup Table for Mode 12.")]
////public virtual object-list Mode12SupplyFanElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the External Static Pressure Lookup Table for Mode 12.")]
////public virtual object-list Mode12ExternalStaticPressureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Second Fuel Consumption Lookup Table for Mode 12.")]
////public virtual object-list Mode12SystemSecondFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Third Fuel Consumption Lookup Table for Mode 12.")]
////public virtual object-list Mode12SystemThirdFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Water Use Lookup Table for Mode 12.")]
////public virtual object-list Mode12SystemWaterUseLookupTableName { get; set; } = new object-list;
////[Description("Enter the minimum outdoor air temperature allowed for Mode 12.")]
////public virtual real Mode12MinimumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the maximum outdoor air temperature allowed for Mode 12.")]
////public virtual real Mode12MaximumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the minimum outdoor humidity ratio allowed for Mode 12.")]
////public virtual real Mode12MinimumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum outdoor air humidity ratio allowed for Mode 12.")]
////public virtual real Mode12MaximumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum outdoor relative humidity allowed for Mode 12.")]
////public virtual real Mode12MinimumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum outdoor air relative humidity allowed for Mode 12.")]
////public virtual real Mode12MaximumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum return air temperature allowed for Mode 12.")]
////public virtual real Mode12MinimumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the maximum return air temperature allowed for Mode 12.")]
////public virtual real Mode12MaximumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the minimum return air humidity ratio allowed for Mode 12.")]
////public virtual real Mode12MinimumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum return air humidity ratio allowed for Mode 12.")]
////public virtual real Mode12MaximumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum return air relative humidity allowed for Mode 12.")]
////public virtual real Mode12MinimumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum return air relative humdity allowed for Mode 12.")]
////public virtual real Mode12MaximumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum outdoor air fraction allowed for Mode 12.")]
////public virtual real Mode12MinimumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the maximum outdoor air fraction allowed for Mode 12.")]
////public virtual real Mode12MaximumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the minimum supply air mass flow rate ratio allowed for Mode 12.")]
////public virtual real Mode12MinimumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter the maximum supply air mass flow rate ratio allowed for Mode 12.")]
////public virtual real Mode12MaximumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter a name for Mode 13.")]
////public virtual alpha Mode13Name { get; set; } = new alpha;
////[Description("Enter the name of the Supply Air Temperature Lookup Table for Mode 13.")]
////public virtual object-list Mode13SupplyAirTemperatureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Air Humidity Ratio Lookup Table for Mode 13.")]
////public virtual object-list Mode13SupplyAirHumidityRatioLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Electric Power Lookup Table for Mode 13.")]
////public virtual object-list Mode13SystemElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Fan Electric Power Lookup Table for Mode 13.")]
////public virtual object-list Mode13SupplyFanElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the External Static Pressure Lookup Table for Mode 13.")]
////public virtual object-list Mode13ExternalStaticPressureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Second Fuel Consumption Lookup Table for Mode 13.")]
////public virtual object-list Mode13SystemSecondFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Third Fuel Consumption Lookup Table for Mode 13.")]
////public virtual object-list Mode13SystemThirdFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Water Use Lookup Table for Mode 13.")]
////public virtual object-list Mode13SystemWaterUseLookupTableName { get; set; } = new object-list;
////[Description("Enter the minimum outdoor air temperature allowed for Mode 13.")]
////public virtual real Mode13MinimumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the maximum outdoor air temperature allowed for Mode 13.")]
////public virtual real Mode13MaximumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the minimum outdoor humidity ratio allowed for Mode 13.")]
////public virtual real Mode13MinimumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum outdoor air humidity ratio allowed for Mode 13.")]
////public virtual real Mode13MaximumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum outdoor relative humidity allowed for Mode 13.")]
////public virtual real Mode13MinimumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum outdoor air relative humidity allowed for Mode 13.")]
////public virtual real Mode13MaximumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum return air temperature allowed for Mode 13.")]
////public virtual real Mode13MinimumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the maximum return air temperature allowed for Mode 13.")]
////public virtual real Mode13MaximumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the minimum return air humidity ratio allowed for Mode 13.")]
////public virtual real Mode13MinimumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum return air humidity ratio allowed for Mode 13.")]
////public virtual real Mode13MaximumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum return air relative humidity allowed for Mode 13.")]
////public virtual real Mode13MinimumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum return air relative humdity allowed for Mode 13.")]
////public virtual real Mode13MaximumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum outdoor air fraction allowed for Mode 13.")]
////public virtual real Mode13MinimumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the maximum outdoor air fraction allowed for Mode 13.")]
////public virtual real Mode13MaximumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the minimum supply air mass flow rate ratio allowed for Mode 13.")]
////public virtual real Mode13MinimumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter the maximum supply air mass flow rate ratio allowed for Mode 13.")]
////public virtual real Mode13MaximumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter a name for Mode 14.")]
////public virtual alpha Mode14Name { get; set; } = new alpha;
////[Description("Enter the name of the Supply Air Temperature Lookup Table for Mode 14.")]
////public virtual object-list Mode14SupplyAirTemperatureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Air Humidity Ratio Lookup Table for Mode 14.")]
////public virtual object-list Mode14SupplyAirHumidityRatioLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Electric Power Lookup Table for Mode 14.")]
////public virtual object-list Mode14SystemElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Fan Electric Power Lookup Table for Mode 14.")]
////public virtual object-list Mode14SupplyFanElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the External Static Pressure Lookup Table for Mode 14.")]
////public virtual object-list Mode14ExternalStaticPressureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Second Fuel Consumption Lookup Table for Mode 14.")]
////public virtual object-list Mode14SystemSecondFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Third Fuel Consumption Lookup Table for Mode 14.")]
////public virtual object-list Mode14SystemThirdFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Water Use Lookup Table for Mode 14.")]
////public virtual object-list Mode14SystemWaterUseLookupTableName { get; set; } = new object-list;
////[Description("Enter the minimum outdoor air temperature allowed for Mode 14.")]
////public virtual real Mode14MinimumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the maximum outdoor air temperature allowed for Mode 14.")]
////public virtual real Mode14MaximumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the minimum outdoor humidity ratio allowed for Mode 14.")]
////public virtual real Mode14MinimumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum outdoor air humidity ratio allowed for Mode 14.")]
////public virtual real Mode14MaximumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum outdoor relative humidity allowed for Mode 14.")]
////public virtual real Mode14MinimumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum outdoor air relative humidity allowed for Mode 14.")]
////public virtual real Mode14MaximumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum return air temperature allowed for Mode 14.")]
////public virtual real Mode14MinimumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the maximum return air temperature allowed for Mode 14.")]
////public virtual real Mode14MaximumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the minimum return air humidity ratio allowed for Mode 14.")]
////public virtual real Mode14MinimumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum return air humidity ratio allowed for Mode 14.")]
////public virtual real Mode14MaximumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum return air relative humidity allowed for Mode 14.")]
////public virtual real Mode14MinimumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum return air relative humdity allowed for Mode 14.")]
////public virtual real Mode14MaximumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum outdoor air fraction allowed for Mode 14.")]
////public virtual real Mode14MinimumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the maximum outdoor air fraction allowed for Mode 14.")]
////public virtual real Mode14MaximumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the minimum supply air mass flow rate ratio allowed for Mode 14.")]
////public virtual real Mode14MinimumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter the maximum supply air mass flow rate ratio allowed for Mode 14.")]
////public virtual real Mode14MaximumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter a name for Mode 15.")]
////public virtual alpha Mode15Name { get; set; } = new alpha;
////[Description("Enter the name of the Supply Air Temperature Lookup Table for Mode 15.")]
////public virtual object-list Mode15SupplyAirTemperatureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Air Humidity Ratio Lookup Table for Mode 15.")]
////public virtual object-list Mode15SupplyAirHumidityRatioLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Electric Power Lookup Table for Mode 15.")]
////public virtual object-list Mode15SystemElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Fan Electric Power Lookup Table for Mode 15.")]
////public virtual object-list Mode15SupplyFanElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the External Static Pressure Lookup Table for Mode 15.")]
////public virtual object-list Mode15ExternalStaticPressureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Second Fuel Consumption Lookup Table for Mode 15.")]
////public virtual object-list Mode15SystemSecondFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Third Fuel Consumption Lookup Table for Mode 15.")]
////public virtual object-list Mode15SystemThirdFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Water Use Lookup Table for Mode 15.")]
////public virtual object-list Mode15SystemWaterUseLookupTableName { get; set; } = new object-list;
////[Description("Enter the minimum outdoor air temperature allowed for Mode 15.")]
////public virtual real Mode15MinimumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the maximum outdoor air temperature allowed for Mode 15.")]
////public virtual real Mode15MaximumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the minimum outdoor humidity ratio allowed for Mode 15.")]
////public virtual real Mode15MinimumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum outdoor air humidity ratio allowed for Mode 15.")]
////public virtual real Mode15MaximumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum outdoor relative humidity allowed for Mode 15.")]
////public virtual real Mode15MinimumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum outdoor air relative humidity allowed for Mode 15.")]
////public virtual real Mode15MaximumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum return air temperature allowed for Mode 15.")]
////public virtual real Mode15MinimumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the maximum return air temperature allowed for Mode 15.")]
////public virtual real Mode15MaximumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the minimum return air humidity ratio allowed for Mode 15.")]
////public virtual real Mode15MinimumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum return air humidity ratio allowed for Mode 15.")]
////public virtual real Mode15MaximumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum return air relative humidity allowed for Mode 15.")]
////public virtual real Mode15MinimumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum return air relative humdity allowed for Mode 15.")]
////public virtual real Mode15MaximumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum outdoor air fraction allowed for Mode 15.")]
////public virtual real Mode15MinimumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the maximum outdoor air fraction allowed for Mode 15.")]
////public virtual real Mode15MaximumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the minimum supply air mass flow rate ratio allowed for Mode 15.")]
////public virtual real Mode15MinimumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter the maximum supply air mass flow rate ratio allowed for Mode 15.")]
////public virtual real Mode15MaximumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter a name for Mode 16.")]
////public virtual alpha Mode16Name { get; set; } = new alpha;
////[Description("Enter the name of the Supply Air Temperature Lookup Table for Mode 16.")]
////public virtual object-list Mode16SupplyAirTemperatureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Air Humidity Ratio Lookup Table for Mode 16.")]
////public virtual object-list Mode16SupplyAirHumidityRatioLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Electric Power Lookup Table for Mode 16.")]
////public virtual object-list Mode16SystemElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Fan Electric Power Lookup Table for Mode 16.")]
////public virtual object-list Mode16SupplyFanElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the External Static Pressure Lookup Table for Mode 16.")]
////public virtual object-list Mode16ExternalStaticPressureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Second Fuel Consumption Lookup Table for Mode 16.")]
////public virtual object-list Mode16SystemSecondFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Third Fuel Consumption Lookup Table for Mode 16.")]
////public virtual object-list Mode16SystemThirdFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Water Use Lookup Table for Mode 16.")]
////public virtual object-list Mode16SystemWaterUseLookupTableName { get; set; } = new object-list;
////[Description("Enter the minimum outdoor air temperature allowed for Mode 16.")]
////public virtual real Mode16MinimumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the maximum outdoor air temperature allowed for Mode 16.")]
////public virtual real Mode16MaximumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the minimum outdoor humidity ratio allowed for Mode 16.")]
////public virtual real Mode16MinimumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum outdoor air humidity ratio allowed for Mode 16.")]
////public virtual real Mode16MaximumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum outdoor relative humidity allowed for Mode 16.")]
////public virtual real Mode16MinimumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum outdoor air relative humidity allowed for Mode 16.")]
////public virtual real Mode16MaximumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum return air temperature allowed for Mode 16.")]
////public virtual real Mode16MinimumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the maximum return air temperature allowed for Mode 16.")]
////public virtual real Mode16MaximumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the minimum return air humidity ratio allowed for Mode 16.")]
////public virtual real Mode16MinimumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum return air humidity ratio allowed for Mode 16.")]
////public virtual real Mode16MaximumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum return air relative humidity allowed for Mode 16.")]
////public virtual real Mode16MinimumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum return air relative humdity allowed for Mode 16.")]
////public virtual real Mode16MaximumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum outdoor air fraction allowed for Mode 16.")]
////public virtual real Mode16MinimumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the maximum outdoor air fraction allowed for Mode 16.")]
////public virtual real Mode16MaximumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the minimum supply air mass flow rate ratio allowed for Mode 16.")]
////public virtual real Mode16MinimumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter the maximum supply air mass flow rate ratio allowed for Mode 16.")]
////public virtual real Mode16MaximumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter a name for Mode 17.")]
////public virtual alpha Mode17Name { get; set; } = new alpha;
////[Description("Enter the name of the Supply Air Temperature Lookup Table for Mode 17.")]
////public virtual object-list Mode17SupplyAirTemperatureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Air Humidity Ratio Lookup Table for Mode 17.")]
////public virtual object-list Mode17SupplyAirHumidityRatioLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Electric Power Lookup Table for Mode 17.")]
////public virtual object-list Mode17SystemElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Fan Electric Power Lookup Table for Mode 17.")]
////public virtual object-list Mode17SupplyFanElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the External Static Pressure Lookup Table for Mode 17.")]
////public virtual object-list Mode17ExternalStaticPressureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Second Fuel Consumption Lookup Table for Mode 17.")]
////public virtual object-list Mode17SystemSecondFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Third Fuel Consumption Lookup Table for Mode 17.")]
////public virtual object-list Mode17SystemThirdFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Water Use Lookup Table for Mode 17.")]
////public virtual object-list Mode17SystemWaterUseLookupTableName { get; set; } = new object-list;
////[Description("Enter the minimum outdoor air temperature allowed for Mode 17.")]
////public virtual real Mode17MinimumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the maximum outdoor air temperature allowed for Mode 17.")]
////public virtual real Mode17MaximumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the minimum outdoor humidity ratio allowed for Mode 17.")]
////public virtual real Mode17MinimumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum outdoor air humidity ratio allowed for Mode 17.")]
////public virtual real Mode17MaximumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum outdoor relative humidity allowed for Mode 17.")]
////public virtual real Mode17MinimumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum outdoor air relative humidity allowed for Mode 17.")]
////public virtual real Mode17MaximumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum return air temperature allowed for Mode 17.")]
////public virtual real Mode17MinimumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the maximum return air temperature allowed for Mode 17.")]
////public virtual real Mode17MaximumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the minimum return air humidity ratio allowed for Mode 17.")]
////public virtual real Mode17MinimumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum return air humidity ratio allowed for Mode 17.")]
////public virtual real Mode17MaximumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum return air relative humidity allowed for Mode 17.")]
////public virtual real Mode17MinimumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum return air relative humdity allowed for Mode 17.")]
////public virtual real Mode17MaximumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum outdoor air fraction allowed for Mode 17.")]
////public virtual real Mode17MinimumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the maximum outdoor air fraction allowed for Mode 17.")]
////public virtual real Mode17MaximumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the minimum supply air mass flow rate ratio allowed for Mode 17.")]
////public virtual real Mode17MinimumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter the maximum supply air mass flow rate ratio allowed for Mode 17.")]
////public virtual real Mode17MaximumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter a name for Mode 18.")]
////public virtual alpha Mode18Name { get; set; } = new alpha;
////[Description("Enter the name of the Supply Air Temperature Lookup Table for Mode 18.")]
////public virtual object-list Mode18SupplyAirTemperatureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Air Humidity Ratio Lookup Table for Mode 18.")]
////public virtual object-list Mode18SupplyAirHumidityRatioLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Electric Power Lookup Table for Mode 18.")]
////public virtual object-list Mode18SystemElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Fan Electric Power Lookup Table for Mode 18.")]
////public virtual object-list Mode18SupplyFanElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the External Static Pressure Lookup Table for Mode 18.")]
////public virtual object-list Mode18ExternalStaticPressureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Second Fuel Consumption Lookup Table for Mode 18.")]
////public virtual object-list Mode18SystemSecondFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Third Fuel Consumption Lookup Table for Mode 18.")]
////public virtual object-list Mode18SystemThirdFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Water Use Lookup Table for Mode 18.")]
////public virtual object-list Mode18SystemWaterUseLookupTableName { get; set; } = new object-list;
////[Description("Enter the minimum outdoor air temperature allowed for Mode 18.")]
////public virtual real Mode18MinimumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the maximum outdoor air temperature allowed for Mode 18.")]
////public virtual real Mode18MaximumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the minimum outdoor humidity ratio allowed for Mode 18.")]
////public virtual real Mode18MinimumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum outdoor air humidity ratio allowed for Mode 18.")]
////public virtual real Mode18MaximumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum outdoor relative humidity allowed for Mode 18.")]
////public virtual real Mode18MinimumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum outdoor air relative humidity allowed for Mode 18.")]
////public virtual real Mode18MaximumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum return air temperature allowed for Mode 18.")]
////public virtual real Mode18MinimumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the maximum return air temperature allowed for Mode 18.")]
////public virtual real Mode18MaximumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the minimum return air humidity ratio allowed for Mode 18.")]
////public virtual real Mode18MinimumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum return air humidity ratio allowed for Mode 18.")]
////public virtual real Mode18MaximumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum return air relative humidity allowed for Mode 18.")]
////public virtual real Mode18MinimumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum return air relative humdity allowed for Mode 18.")]
////public virtual real Mode18MaximumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum outdoor air fraction allowed for Mode 18.")]
////public virtual real Mode18MinimumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the maximum outdoor air fraction allowed for Mode 18.")]
////public virtual real Mode18MaximumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the minimum supply air mass flow rate ratio allowed for Mode 18.")]
////public virtual real Mode18MinimumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter the maximum supply air mass flow rate ratio allowed for Mode 18.")]
////public virtual real Mode18MaximumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter a name for Mode 19.")]
////public virtual alpha Mode19Name { get; set; } = new alpha;
////[Description("Enter the name of the Supply Air Temperature Lookup Table for Mode 19.")]
////public virtual object-list Mode19SupplyAirTemperatureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Air Humidity Ratio Lookup Table for Mode 19.")]
////public virtual object-list Mode19SupplyAirHumidityRatioLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Electric Power Lookup Table for Mode 19.")]
////public virtual object-list Mode19SystemElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Fan Electric Power Lookup Table for Mode 19.")]
////public virtual object-list Mode19SupplyFanElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the External Static Pressure Lookup Table for Mode 19.")]
////public virtual object-list Mode19ExternalStaticPressureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Second Fuel Consumption Lookup Table for Mode 19.")]
////public virtual object-list Mode19SystemSecondFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Third Fuel Consumption Lookup Table for Mode 19.")]
////public virtual object-list Mode19SystemThirdFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Water Use Lookup Table for Mode 19.")]
////public virtual object-list Mode19SystemWaterUseLookupTableName { get; set; } = new object-list;
////[Description("Enter the minimum outdoor air temperature allowed for Mode 19.")]
////public virtual real Mode19MinimumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the maximum outdoor air temperature allowed for Mode 19.")]
////public virtual real Mode19MaximumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the minimum outdoor humidity ratio allowed for Mode 19.")]
////public virtual real Mode19MinimumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum outdoor air humidity ratio allowed for Mode 19.")]
////public virtual real Mode19MaximumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum outdoor relative humidity allowed for Mode 19.")]
////public virtual real Mode19MinimumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum outdoor air relative humidity allowed for Mode 19.")]
////public virtual real Mode19MaximumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum return air temperature allowed for Mode 19.")]
////public virtual real Mode19MinimumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the maximum return air temperature allowed for Mode 19.")]
////public virtual real Mode19MaximumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the minimum return air humidity ratio allowed for Mode 19.")]
////public virtual real Mode19MinimumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum return air humidity ratio allowed for Mode 19.")]
////public virtual real Mode19MaximumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum return air relative humidity allowed for Mode 19.")]
////public virtual real Mode19MinimumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum return air relative humdity allowed for Mode 19.")]
////public virtual real Mode19MaximumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum outdoor air fraction allowed for Mode 19.")]
////public virtual real Mode19MinimumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the maximum outdoor air fraction allowed for Mode 19.")]
////public virtual real Mode19MaximumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the minimum supply air mass flow rate ratio allowed for Mode 19.")]
////public virtual real Mode19MinimumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter the maximum supply air mass flow rate ratio allowed for Mode 19.")]
////public virtual real Mode19MaximumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter a name for Mode 20.")]
////public virtual alpha Mode20Name { get; set; } = new alpha;
////[Description("Enter the name of the Supply Air Temperature Lookup Table for Mode 20.")]
////public virtual object-list Mode20SupplyAirTemperatureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Air Humidity Ratio Lookup Table for Mode 20.")]
////public virtual object-list Mode20SupplyAirHumidityRatioLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Electric Power Lookup Table for Mode 20.")]
////public virtual object-list Mode20SystemElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Fan Electric Power Lookup Table for Mode 20.")]
////public virtual object-list Mode20SupplyFanElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the External Static Pressure Lookup Table for Mode 20.")]
////public virtual object-list Mode20ExternalStaticPressureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Second Fuel Consumption Lookup Table for Mode 20.")]
////public virtual object-list Mode20SystemSecondFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Third Fuel Consumption Lookup Table for Mode 20.")]
////public virtual object-list Mode20SystemThirdFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Water Use Lookup Table for Mode 20.")]
////public virtual object-list Mode20SystemWaterUseLookupTableName { get; set; } = new object-list;
////[Description("Enter the minimum outdoor air temperature allowed for Mode 20.")]
////public virtual real Mode20MinimumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the maximum outdoor air temperature allowed for Mode 20.")]
////public virtual real Mode20MaximumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the minimum outdoor humidity ratio allowed for Mode 20.")]
////public virtual real Mode20MinimumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum outdoor air humidity ratio allowed for Mode 20.")]
////public virtual real Mode20MaximumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum outdoor relative humidity allowed for Mode 20.")]
////public virtual real Mode20MinimumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum outdoor air relative humidity allowed for Mode 20.")]
////public virtual real Mode20MaximumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum return air temperature allowed for Mode 20.")]
////public virtual real Mode20MinimumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the maximum return air temperature allowed for Mode 20.")]
////public virtual real Mode20MaximumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the minimum return air humidity ratio allowed for Mode 20.")]
////public virtual real Mode20MinimumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum return air humidity ratio allowed for Mode 20.")]
////public virtual real Mode20MaximumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum return air relative humidity allowed for Mode 20.")]
////public virtual real Mode20MinimumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum return air relative humdity allowed for Mode 20.")]
////public virtual real Mode20MaximumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum outdoor air fraction allowed for Mode 20.")]
////public virtual real Mode20MinimumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the maximum outdoor air fraction allowed for Mode 20.")]
////public virtual real Mode20MaximumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the minimum supply air mass flow rate ratio allowed for Mode 20.")]
////public virtual real Mode20MinimumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter the maximum supply air mass flow rate ratio allowed for Mode 20.")]
////public virtual real Mode20MaximumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter a name for Mode 21.")]
////public virtual alpha Mode21Name { get; set; } = new alpha;
////[Description("Enter the name of the Supply Air Temperature Lookup Table for Mode 21.")]
////public virtual object-list Mode21SupplyAirTemperatureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Air Humidity Ratio Lookup Table for Mode 21.")]
////public virtual object-list Mode21SupplyAirHumidityRatioLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Electric Power Lookup Table for Mode 21.")]
////public virtual object-list Mode21SystemElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Fan Electric Power Lookup Table for Mode 21.")]
////public virtual object-list Mode21SupplyFanElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the External Static Pressure Lookup Table for Mode 21.")]
////public virtual object-list Mode21ExternalStaticPressureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Second Fuel Consumption Lookup Table for Mode 21.")]
////public virtual object-list Mode21SystemSecondFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Third Fuel Consumption Lookup Table for Mode 21.")]
////public virtual object-list Mode21SystemThirdFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Water Use Lookup Table for Mode 21.")]
////public virtual object-list Mode21SystemWaterUseLookupTableName { get; set; } = new object-list;
////[Description("Enter the minimum outdoor air temperature allowed for Mode 21.")]
////public virtual real Mode21MinimumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the maximum outdoor air temperature allowed for Mode 21.")]
////public virtual real Mode21MaximumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the minimum outdoor humidity ratio allowed for Mode 21.")]
////public virtual real Mode21MinimumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum outdoor air humidity ratio allowed for Mode 21.")]
////public virtual real Mode21MaximumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum outdoor relative humidity allowed for Mode 21.")]
////public virtual real Mode21MinimumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum outdoor air relative humidity allowed for Mode 21.")]
////public virtual real Mode21MaximumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum return air temperature allowed for Mode 21.")]
////public virtual real Mode21MinimumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the maximum return air temperature allowed for Mode 21.")]
////public virtual real Mode21MaximumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the minimum return air humidity ratio allowed for Mode 21.")]
////public virtual real Mode21MinimumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum return air humidity ratio allowed for Mode 21.")]
////public virtual real Mode21MaximumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum return air relative humidity allowed for Mode 21.")]
////public virtual real Mode21MinimumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum return air relative humdity allowed for Mode 21.")]
////public virtual real Mode21MaximumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum outdoor air fraction allowed for Mode 21.")]
////public virtual real Mode21MinimumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the maximum outdoor air fraction allowed for Mode 21.")]
////public virtual real Mode21MaximumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the minimum supply air mass flow rate ratio allowed for Mode 21.")]
////public virtual real Mode21MinimumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter the maximum supply air mass flow rate ratio allowed for Mode 21.")]
////public virtual real Mode21MaximumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter a name for Mode 22.")]
////public virtual alpha Mode22Name { get; set; } = new alpha;
////[Description("Enter the name of the Supply Air Temperature Lookup Table for Mode 22.")]
////public virtual object-list Mode22SupplyAirTemperatureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Air Humidity Ratio Lookup Table for Mode 22.")]
////public virtual object-list Mode22SupplyAirHumidityRatioLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Electric Power Lookup Table for Mode 22.")]
////public virtual object-list Mode22SystemElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Fan Electric Power Lookup Table for Mode 22.")]
////public virtual object-list Mode22SupplyFanElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the External Static Pressure Lookup Table for Mode 22.")]
////public virtual object-list Mode22ExternalStaticPressureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Second Fuel Consumption Lookup Table for Mode 22.")]
////public virtual object-list Mode22SystemSecondFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Third Fuel Consumption Lookup Table for Mode 22.")]
////public virtual object-list Mode22SystemThirdFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Water Use Lookup Table for Mode 22.")]
////public virtual object-list Mode22SystemWaterUseLookupTableName { get; set; } = new object-list;
////[Description("Enter the minimum outdoor air temperature allowed for Mode 22.")]
////public virtual real Mode22MinimumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the maximum outdoor air temperature allowed for Mode 22.")]
////public virtual real Mode22MaximumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the minimum outdoor humidity ratio allowed for Mode 22.")]
////public virtual real Mode22MinimumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum outdoor air humidity ratio allowed for Mode 22.")]
////public virtual real Mode22MaximumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum outdoor relative humidity allowed for Mode 22.")]
////public virtual real Mode22MinimumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum outdoor air relative humidity allowed for Mode 22.")]
////public virtual real Mode22MaximumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum return air temperature allowed for Mode 22.")]
////public virtual real Mode22MinimumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the maximum return air temperature allowed for Mode 22.")]
////public virtual real Mode22MaximumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the minimum return air humidity ratio allowed for Mode 22.")]
////public virtual real Mode22MinimumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum return air humidity ratio allowed for Mode 22.")]
////public virtual real Mode22MaximumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum return air relative humidity allowed for Mode 22.")]
////public virtual real Mode22MinimumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum return air relative humdity allowed for Mode 22.")]
////public virtual real Mode22MaximumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum outdoor air fraction allowed for Mode 22.")]
////public virtual real Mode22MinimumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the maximum outdoor air fraction allowed for Mode 22.")]
////public virtual real Mode22MaximumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the minimum supply air mass flow rate ratio allowed for Mode 22.")]
////public virtual real Mode22MinimumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter the maximum supply air mass flow rate ratio allowed for Mode 22.")]
////public virtual real Mode22MaximumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter a name for Mode 23.")]
////public virtual alpha Mode23Name { get; set; } = new alpha;
////[Description("Enter the name of the Supply Air Temperature Lookup Table for Mode 23.")]
////public virtual object-list Mode23SupplyAirTemperatureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Air Humidity Ratio Lookup Table for Mode 23.")]
////public virtual object-list Mode23SupplyAirHumidityRatioLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Electric Power Lookup Table for Mode 23.")]
////public virtual object-list Mode23SystemElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Fan Electric Power Lookup Table for Mode 23.")]
////public virtual object-list Mode23SupplyFanElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the External Static Pressure Lookup Table for Mode 23.")]
////public virtual object-list Mode23ExternalStaticPressureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Second Fuel Consumption Lookup Table for Mode 23.")]
////public virtual object-list Mode23SystemSecondFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Third Fuel Consumption Lookup Table for Mode 23.")]
////public virtual object-list Mode23SystemThirdFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Water Use Lookup Table for Mode 23.")]
////public virtual object-list Mode23SystemWaterUseLookupTableName { get; set; } = new object-list;
////[Description("Enter the minimum outdoor air temperature allowed for Mode 23.")]
////public virtual real Mode23MinimumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the maximum outdoor air temperature allowed for Mode 23.")]
////public virtual real Mode23MaximumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the minimum outdoor humidity ratio allowed for Mode 23.")]
////public virtual real Mode23MinimumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum outdoor air humidity ratio allowed for Mode 23.")]
////public virtual real Mode23MaximumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum outdoor relative humidity allowed for Mode 23.")]
////public virtual real Mode23MinimumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum outdoor air relative humidity allowed for Mode 23.")]
////public virtual real Mode23MaximumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum return air temperature allowed for Mode 23.")]
////public virtual real Mode23MinimumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the maximum return air temperature allowed for Mode 23.")]
////public virtual real Mode23MaximumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the minimum return air humidity ratio allowed for Mode 23.")]
////public virtual real Mode23MinimumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum return air humidity ratio allowed for Mode 23.")]
////public virtual real Mode23MaximumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum return air relative humidity allowed for Mode 23.")]
////public virtual real Mode23MinimumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum return air relative humdity allowed for Mode 23.")]
////public virtual real Mode23MaximumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum outdoor air fraction allowed for Mode 23.")]
////public virtual real Mode23MinimumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the maximum outdoor air fraction allowed for Mode 23.")]
////public virtual real Mode23MaximumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the minimum supply air mass flow rate ratio allowed for Mode 23.")]
////public virtual real Mode23MinimumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter the maximum supply air mass flow rate ratio allowed for Mode 23.")]
////public virtual real Mode23MaximumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter a name for Mode 24.")]
////public virtual alpha Mode24Name { get; set; } = new alpha;
////[Description("Enter the name of the Supply Air Temperature Lookup Table for Mode 24.")]
////public virtual object-list Mode24SupplyAirTemperatureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Air Humidity Ratio Lookup Table for Mode 24.")]
////public virtual object-list Mode24SupplyAirHumidityRatioLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Electric Power Lookup Table for Mode 24.")]
////public virtual object-list Mode24SystemElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Fan Electric Power Lookup Table for Mode 24.")]
////public virtual object-list Mode24SupplyFanElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the External Static Pressure Lookup Table for Mode 24.")]
////public virtual object-list Mode24ExternalStaticPressureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Second Fuel Consumption Lookup Table for Mode 24.")]
////public virtual object-list Mode24SystemSecondFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Third Fuel Consumption Lookup Table for Mode 24.")]
////public virtual object-list Mode24SystemThirdFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Water Use Lookup Table for Mode 24.")]
////public virtual object-list Mode24SystemWaterUseLookupTableName { get; set; } = new object-list;
////[Description("Enter the minimum outdoor air temperature allowed for Mode 24.")]
////public virtual real Mode24MinimumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the maximum outdoor air temperature allowed for Mode 24.")]
////public virtual real Mode24MaximumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the minimum outdoor humidity ratio allowed for Mode 24.")]
////public virtual real Mode24MinimumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum outdoor air humidity ratio allowed for Mode 24.")]
////public virtual real Mode24MaximumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum outdoor relative humidity allowed for Mode 24.")]
////public virtual real Mode24MinimumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum outdoor air relative humidity allowed for Mode 24.")]
////public virtual real Mode24MaximumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum return air temperature allowed for Mode 24.")]
////public virtual real Mode24MinimumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the maximum return air temperature allowed for Mode 24.")]
////public virtual real Mode24MaximumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the minimum return air humidity ratio allowed for Mode 24.")]
////public virtual real Mode24MinimumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum return air humidity ratio allowed for Mode 24.")]
////public virtual real Mode24MaximumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum return air relative humidity allowed for Mode 24.")]
////public virtual real Mode24MinimumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum return air relative humdity allowed for Mode 24.")]
////public virtual real Mode24MaximumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum outdoor air fraction allowed for Mode 24.")]
////public virtual real Mode24MinimumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the maximum outdoor air fraction allowed for Mode 24.")]
////public virtual real Mode24MaximumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the minimum supply air mass flow rate ratio allowed for Mode 24.")]
////public virtual real Mode24MinimumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter the maximum supply air mass flow rate ratio allowed for Mode 24.")]
////public virtual real Mode24MaximumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter a name for Mode 25.")]
////public virtual alpha Mode25Name { get; set; } = new alpha;
////[Description("Enter the name of the Supply Air Temperature Lookup Table for Mode 25.")]
////public virtual object-list Mode25SupplyAirTemperatureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Air Humidity Ratio Lookup Table for Mode 25.")]
////public virtual object-list Mode25SupplyAirHumidityRatioLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Electric Power Lookup Table for Mode 25.")]
////public virtual object-list Mode25SystemElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the Supply Fan Electric Power Lookup Table for Mode 25.")]
////public virtual object-list Mode25SupplyFanElectricPowerLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the External Static Pressure Lookup Table for Mode 25.")]
////public virtual object-list Mode25ExternalStaticPressureLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Second Fuel Consumption Lookup Table for Mode 25.")]
////public virtual object-list Mode25SystemSecondFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Third Fuel Consumption Lookup Table for Mode 25.")]
////public virtual object-list Mode25SystemThirdFuelConsumptionLookupTableName { get; set; } = new object-list;
////[Description("Enter the name of the System Water Use Lookup Table for Mode 25.")]
////public virtual object-list Mode25SystemWaterUseLookupTableName { get; set; } = new object-list;
////[Description("Enter the minimum outdoor air temperature allowed for Mode 25.")]
////public virtual real Mode25MinimumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the maximum outdoor air temperature allowed for Mode 25.")]
////public virtual real Mode25MaximumOutdoorAirTemperature { get; set; } = new real;
////[Description("Enter the minimum outdoor humidity ratio allowed for Mode 25.")]
////public virtual real Mode25MinimumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum outdoor air humidity ratio allowed for Mode 25.")]
////public virtual real Mode25MaximumOutdoorAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum outdoor relative humidity allowed for Mode 25.")]
////public virtual real Mode25MinimumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum outdoor air relative humidity allowed for Mode 25.")]
////public virtual real Mode25MaximumOutdoorAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum return air temperature allowed for Mode 25.")]
////public virtual real Mode25MinimumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the maximum return air temperature allowed for Mode 25.")]
////public virtual real Mode25MaximumReturnAirTemperature { get; set; } = new real;
////[Description("Enter the minimum return air humidity ratio allowed for Mode 25.")]
////public virtual real Mode25MinimumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the maximum return air humidity ratio allowed for Mode 25.")]
////public virtual real Mode25MaximumReturnAirHumidityRatio { get; set; } = new real;
////[Description("Enter the minimum return air relative humidity allowed for Mode 25.")]
////public virtual real Mode25MinimumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the maximum return air relative humdity allowed for Mode 25.")]
////public virtual real Mode25MaximumReturnAirRelativeHumidity { get; set; } = new real;
////[Description("Enter the minimum outdoor air fraction allowed for Mode 25.")]
////public virtual real Mode25MinimumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the maximum outdoor air fraction allowed for Mode 25.")]
////public virtual real Mode25MaximumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the minimum supply air mass flow rate ratio allowed for Mode 25.")]
////public virtual real Mode25MinimumSupplyAirMassFlowRateRatio { get; set; } = new real;
////[Description("Enter the maximum supply air mass flow rate ratio allowed for Mode 25.")]
////public virtual real Mode25MaximumSupplyAirMassFlowRateRatio { get; set; } = new real;
////}
////}



