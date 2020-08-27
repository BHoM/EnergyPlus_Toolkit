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
////public class HVACTemplate:Zone:IdealLoadsAirSystem : BHoMObject
////{
////[Description("Zone name must match a building zone name")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("Enter the name of a HVACTemplate:Thermostat object.")]
////public virtual object-list TemplateThermostatName { get; set; } = new object-list;
////[Description("If blank, always on")]
////public virtual object-list SystemAvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null MaximumHeatingSupplyAirTemperature { get; set; } = new null;
////[Description("No description available")]
////public virtual null MinimumCoolingSupplyAirTemperature { get; set; } = new null;
////[Description("No description available")]
////public virtual null MaximumHeatingSupplyAirHumidityRatio { get; set; } = new null;
////[Description("No description available")]
////public virtual null MinimumCoolingSupplyAirHumidityRatio { get; set; } = new null;
////[Description("No description available")]
////public virtual choice HeatingLimit { get; set; } = new choice;
////[Description("This field is ignored if Heating Limit = NoLimit")]
////public virtual null MaximumHeatingAirFlowRate { get; set; } = new null;
////[Description("This field is ignored if Heating Limit = NoLimit")]
////public virtual null MaximumSensibleHeatingCapacity { get; set; } = new null;
////[Description("No description available")]
////public virtual choice CoolingLimit { get; set; } = new choice;
////[Description("This field is ignored if Cooling Limit = NoLimit")]
////public virtual null MaximumCoolingAirFlowRate { get; set; } = new null;
////[Description("This field is ignored if Cooling Limit = NoLimit")]
////public virtual null MaximumTotalCoolingCapacity { get; set; } = new null;
////[Description("If blank, heating is always available.")]
////public virtual object-list HeatingAvailabilityScheduleName { get; set; } = new object-list;
////[Description("If blank, cooling is always available.")]
////public virtual object-list CoolingAvailabilityScheduleName { get; set; } = new object-list;
////[Description("ConstantSensibleHeatRatio means that the ideal loads system")]
////public virtual choice DehumidificationControlType { get; set; } = new choice;
////[Description("This field is applicable only when Dehumidification Control Type is ConstantSensibleHeatRatio")]
////public virtual null CoolingSensibleHeatRatio { get; set; } = new null;
////[Description("Zone relative humidity setpoint in percent (0 to 100)")]
////public virtual real DehumidificationSetpoint { get; set; } = new real;
////[Description("None means that there is no humidification.")]
////public virtual choice HumidificationControlType { get; set; } = new choice;
////[Description("Zone relative humidity setpoint in percent (0 to 100)")]
////public virtual real HumidificationSetpoint { get; set; } = new real;
////[Description("None means there is no outdoor air and all related fields will be ignored")]
////public virtual choice OutdoorAirMethod { get; set; } = new choice;
////[Description("Default 0.00944 is 20 cfm per person")]
////public virtual null OutdoorAirFlowRatePerPerson { get; set; } = new null;
////[Description("This input is used if the field Outdoor Air Method is")]
////public virtual null OutdoorAirFlowRatePerZoneFloorArea { get; set; } = new null;
////[Description("This input is used if the field Outdoor Air Method is")]
////public virtual real OutdoorAirFlowRatePerZone { get; set; } = new real;
////[Description("When the name of a DesignSpecification:OutdoorAir object is entered, the minimum")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName { get; set; } = new object-list;
////[Description("This field controls how the minimum outdoor air flow rate is calculated.")]
////public virtual choice DemandControlledVentilationType { get; set; } = new choice;
////[Description("DifferentialDryBulb and DifferentialEnthalpy will increase the outdoor air flow rate")]
////public virtual choice OutdoorAirEconomizerType { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice HeatRecoveryType { get; set; } = new choice;
////[Description("No description available")]
////public virtual null SensibleHeatRecoveryEffectiveness { get; set; } = new null;
////[Description("Applicable only if Heat Recovery Type is Enthalpy.")]
////public virtual null LatentHeatRecoveryEffectiveness { get; set; } = new null;
////}
////}
