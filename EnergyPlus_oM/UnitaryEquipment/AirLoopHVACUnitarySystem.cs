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
////public class AirLoopHVAC:UnitarySystem : BHoMObject
////{
////[Description("Unique name for the Unitary System.")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Load control requires a Controlling Zone name.")]
////public virtual choice ControlType { get; set; } = new choice;
////[Description("Used only for Load based control")]
////public virtual object-list ControllingZoneOrThermostatLocation { get; set; } = new object-list;
////[Description("None = meet sensible load only. Required when Control Type = SingleZoneVAV.")]
////public virtual choice DehumidificationControlType { get; set; } = new choice;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("Enter the node name used as the inlet air node for the unitary system.")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("Enter the node name used as the outlet air node for the unitary system.")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("Enter the type of supply air fan if included in the unitary system.")]
////public virtual choice SupplyFanObjectType { get; set; } = new choice;
////[Description("Enter the name of the supply air fan if included in the unitary system.")]
////public virtual object-list SupplyFanName { get; set; } = new object-list;
////[Description("Enter the type of supply air fan if included in the unitary system.")]
////public virtual choice FanPlacement { get; set; } = new choice;
////[Description("A fan operating mode schedule value of 0 indicates cycling fan mode (supply air")]
////public virtual object-list SupplyAirFanOperatingModeScheduleName { get; set; } = new object-list;
////[Description("Enter the type of heating coil if included in the unitary system.")]
////public virtual choice HeatingCoilObjectType { get; set; } = new choice;
////[Description("Enter the name of the heating coil if included in the unitary system.")]
////public virtual object-list HeatingCoilName { get; set; } = new object-list;
////[Description("Used to adjust heat pump heating capacity with respect to DX cooling capacity")]
////public virtual real DXHeatingCoilSizingRatio { get; set; } = new real;
////[Description("Enter the type of cooling coil if included in the unitary system.")]
////public virtual choice CoolingCoilObjectType { get; set; } = new choice;
////[Description("Enter the name of the cooling coil if included in the unitary system.")]
////public virtual object-list CoolingCoilName { get; set; } = new object-list;
////[Description("If True, the DX cooling coil runs as 100% DOAS DX coil.")]
////public virtual choice UseDOASDXCoolingCoil { get; set; } = new choice;
////[Description("When Use DOAS DX Cooling Coil is specified as Yes, Minimum Supply Air Temperature")]
////public virtual real MinimumSupplyAirTemperature { get; set; } = new real;
////[Description("SensibleOnlyLoadControl is selected when thermostat or SingleZoneVAV control is used.")]
////public virtual choice LatentLoadControl { get; set; } = new choice;
////[Description("Enter the type of supplemental heating or reheat coil if included in the unitary system.")]
////public virtual choice SupplementalHeatingCoilObjectType { get; set; } = new choice;
////[Description("Enter the name of the supplemental heating coil if included in the unitary system.")]
////public virtual object-list SupplementalHeatingCoilName { get; set; } = new object-list;
////[Description("Enter the method used to determine the cooling supply air volume flow rate.")]
////public virtual choice CoolingSupplyAirFlowRateMethod { get; set; } = new choice;
////[Description("Enter the magnitude of the supply air volume flow rate during cooling operation.")]
////public virtual real CoolingSupplyAirFlowRate { get; set; } = new real;
////[Description("Enter the supply air volume flow rate per total floor area fraction.")]
////public virtual real CoolingSupplyAirFlowRatePerFloorArea { get; set; } = new real;
////[Description("Enter the supply air volume flow rate as a fraction of the cooling supply air flow rate.")]
////public virtual real CoolingFractionOfAutosizedCoolingSupplyAirFlowRate { get; set; } = new real;
////[Description("Enter the supply air volume flow rate as a fraction of the cooling capacity.")]
////public virtual real CoolingSupplyAirFlowRatePerUnitOfCapacity { get; set; } = new real;
////[Description("Enter the method used to determine the heating supply air volume flow rate.")]
////public virtual choice HeatingSupplyAirFlowRateMethod { get; set; } = new choice;
////[Description("Enter the magnitude of the supply air volume flow rate during heating operation.")]
////public virtual real HeatingSupplyAirFlowRate { get; set; } = new real;
////[Description("Enter the supply air volume flow rate per total floor area fraction.")]
////public virtual real HeatingSupplyAirFlowRatePerFloorArea { get; set; } = new real;
////[Description("Enter the supply air volume flow rate as a fraction of the heating supply air flow rate.")]
////public virtual real HeatingFractionOfAutosizedHeatingSupplyAirFlowRate { get; set; } = new real;
////[Description("Enter the supply air volume flow rate as a fraction of the heating capacity.")]
////public virtual real HeatingSupplyAirFlowRatePerUnitOfCapacity { get; set; } = new real;
////[Description("Enter the method used to determine the supply air volume flow rate when no cooling or heating is required.")]
////public virtual choice NoLoadSupplyAirFlowRateMethod { get; set; } = new choice;
////[Description("Enter the magnitude of the supply air volume flow rate during when no cooling or heating is required.")]
////public virtual real NoLoadSupplyAirFlowRate { get; set; } = new real;
////[Description("Enter the supply air volume flow rate per total floor area fraction.")]
////public virtual real NoLoadSupplyAirFlowRatePerFloorArea { get; set; } = new real;
////[Description("Enter the supply air volume flow rate as a fraction of the cooling supply air flow rate.")]
////public virtual real NoLoadFractionOfAutosizedCoolingSupplyAirFlowRate { get; set; } = new real;
////[Description("Enter the supply air volume flow rate as a fraction of the heating supply air flow rate.")]
////public virtual real NoLoadFractionOfAutosizedHeatingSupplyAirFlowRate { get; set; } = new real;
////[Description("Enter the supply air volume flow rate as a fraction of the cooling capacity.")]
////public virtual real NoLoadSupplyAirFlowRatePerUnitOfCapacityDuringCoolingOperation { get; set; } = new real;
////[Description("Enter the supply air volume flow rate as a fraction of the heating capacity.")]
////public virtual real NoLoadSupplyAirFlowRatePerUnitOfCapacityDuringHeatingOperation { get; set; } = new real;
////[Description("Enter the maximum supply air temperature leaving the heating coil.")]
////public virtual real MaximumSupplyAirTemperature { get; set; } = new real;
////[Description("Enter the maximum outdoor dry-bulb temperature for supplemental heater operation.")]
////public virtual real MaximumOutdoorDry-BulbTemperatureForSupplementalHeaterOperation { get; set; } = new real;
////[Description("If this field is blank, outdoor temperature from the weather file is used.")]
////public virtual node OutdoorDry-BulbTemperatureSensorNodeName { get; set; } = new node;
////[Description("Used only for water source heat pump.")]
////public virtual real MaximumCyclingRate { get; set; } = new real;
////[Description("Used only for water source heat pump.")]
////public virtual real HeatPumpTimeConstant { get; set; } = new real;
////[Description("Used only for water source heat pump.")]
////public virtual real FractionOfOn-CyclePowerUse { get; set; } = new real;
////[Description("Used only for water source heat pump.")]
////public virtual real HeatPumpFanDelayTime { get; set; } = new real;
////[Description("Enter the value of ancillary electric power for controls or other devices consumed during the on cycle.")]
////public virtual real AncillaryOn-CycleElectricPower { get; set; } = new real;
////[Description("Enter the value of ancillary electric power for controls or other devices consumed during the off cycle.")]
////public virtual real AncillaryOff-CycleElectricPower { get; set; } = new real;
////[Description("If non-zero, then the heat recovery inlet and outlet node names must be entered.")]
////public virtual real DesignHeatRecoveryWaterFlowRate { get; set; } = new real;
////[Description("Enter the maximum heat recovery inlet temperature allowed for heat recovery.")]
////public virtual real MaximumTemperatureForHeatRecovery { get; set; } = new real;
////[Description("Enter the name of the heat recovery water inlet node if plant water loop connections are present.")]
////public virtual node HeatRecoveryWaterInletNodeName { get; set; } = new node;
////[Description("Enter the name of the heat recovery water outlet node if plant water loop connections are present.")]
////public virtual node HeatRecoveryWaterOutletNodeName { get; set; } = new node;
////[Description("Enter the type of performance specification object used to describe the multispeed coil.")]
////public virtual choice DesignSpecificationMultispeedObjectType { get; set; } = new choice;
////[Description("Enter the name of the performance specification object used to describe the multispeed coil.")]
////public virtual object-list DesignSpecificationMultispeedObjectName { get; set; } = new object-list;
////}
////}
