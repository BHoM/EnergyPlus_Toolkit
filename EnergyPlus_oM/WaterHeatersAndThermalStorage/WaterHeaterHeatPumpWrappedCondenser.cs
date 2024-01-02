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

////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.Adapters.EnergyPlus
////{
////public class WaterHeater:HeatPump:WrappedCondenser : BHoMObject
////{
////[Description("Unique name for this instance of a heat pump water heater.")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("Defines the cut-out temperature where the heat pump compressor turns off.")]
////public virtual object-list CompressorSetpointTemperatureScheduleName { get; set; } = new object-list;
////[Description("Setpoint temperature minus the dead band temperature difference defines")]
////public virtual real DeadBandTemperatureDifference { get; set; } = new real;
////[Description("Distance from the bottom of the tank to the bottom of the wrapped condenser.")]
////public virtual real CondenserBottomLocation { get; set; } = new real;
////[Description("Distance from the bottom of the tank to the top of the wrapped condenser.")]
////public virtual real CondenserTopLocation { get; set; } = new real;
////[Description("Actual air flow rate across the heat pump's air coil (evaporator).")]
////public virtual real EvaporatorAirFlowRate { get; set; } = new real;
////[Description("Defines the configuration of the airflow path through the air coil and fan section.")]
////public virtual choice InletAirConfiguration { get; set; } = new choice;
////[Description("Zone air exhaust node name if Inlet Air Configuration is ZoneAirOnly or")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("Zone Air Inlet Node Name if Inlet Air Configuration is ZoneAirOnly or")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("Outdoor air node name if inlet air configuration is ZoneAndOutdoorAir")]
////public virtual node OutdoorAirNodeName { get; set; } = new node;
////[Description("Simply a unique Node Name if Inlet Air Configuration is ZoneAndOutdoorAir")]
////public virtual node ExhaustAirNodeName { get; set; } = new node;
////[Description("Used only if Inlet Air Configuration is Schedule, otherwise leave blank.")]
////public virtual object-list InletAirTemperatureScheduleName { get; set; } = new object-list;
////[Description("Used only if Inlet Air Configuration is Schedule, otherwise leave blank.")]
////public virtual object-list InletAirHumidityScheduleName { get; set; } = new object-list;
////[Description("Used only if Inlet Air Configuration is ZoneAirOnly or ZoneAndOutdoorAir.")]
////public virtual object-list InletAirZoneName { get; set; } = new object-list;
////[Description("Specify the type of water heater tank used by this heat pump water heater.")]
////public virtual choice TankObjectType { get; set; } = new choice;
////[Description("Needs to match the name used in the corresponding Water Heater object.")]
////public virtual object-list TankName { get; set; } = new object-list;
////[Description("Used only when the heat pump water heater is connected to a plant loop,")]
////public virtual node TankUseSideInletNodeName { get; set; } = new node;
////[Description("Used only when the heat pump water heater is connected to a plant loop,")]
////public virtual node TankUseSideOutletNodeName { get; set; } = new node;
////[Description("Specify the type of DX coil used by this heat pump water heater. The only")]
////public virtual choice DXCoilObjectType { get; set; } = new choice;
////[Description("Must match the name used in the corresponding Coil:WaterHeating:AirToWaterHeatPump:Wrapped object.")]
////public virtual object-list DXCoilName { get; set; } = new object-list;
////[Description("Heat pump compressor will not operate when the inlet air dry-bulb temperature")]
////public virtual real MinimumInletAirTemperatureForCompressorOperation { get; set; } = new real;
////[Description("Heat pump compressor will not operate when the inlet air dry-bulb temperature")]
////public virtual real MaximumInletAirTemperatureForCompressorOperation { get; set; } = new real;
////[Description("If Zone is selected, Inlet Air Configuration must be ZoneAirOnly or")]
////public virtual choice CompressorLocation { get; set; } = new choice;
////[Description("Used only if Compressor Location is Schedule, otherwise leave field blank.")]
////public virtual object-list CompressorAmbientTemperatureScheduleName { get; set; } = new object-list;
////[Description("Specify the type of fan used by this heat pump water heater. The only")]
////public virtual choice FanObjectType { get; set; } = new choice;
////[Description("Needs to match the name used in the corresponding Fan:SystemModel or Fan:OnOff object.")]
////public virtual object-list FanName { get; set; } = new object-list;
////[Description("BlowThrough means the fan is located before the air coil (upstream).")]
////public virtual choice FanPlacement { get; set; } = new choice;
////[Description("Parasitic electric power consumed when the heat pump compressor operates.")]
////public virtual real OnCycleParasiticElectricLoad { get; set; } = new real;
////[Description("Parasitic electric power consumed when the heat pump compressor is off.")]
////public virtual real OffCycleParasiticElectricLoad { get; set; } = new real;
////[Description("This field determines if the parasitic electric load impacts the zone air")]
////public virtual choice ParasiticHeatRejectionLocation { get; set; } = new choice;
////[Description("Required only if Inlet Air Configuration is ZoneAndOutdoorAir, otherwise")]
////public virtual node InletAirMixerNodeName { get; set; } = new node;
////[Description("Required only if Inlet Air Configuration is ZoneAndOutdoorAir, otherwise")]
////public virtual node OutletAirSplitterNodeName { get; set; } = new node;
////[Description("Required only if Inlet Air Configuration is ZoneAndOutdoorAir, otherwise")]
////public virtual object-list InletAirMixerScheduleName { get; set; } = new object-list;
////[Description("MutuallyExclusive means that once the tank heating element is active the")]
////public virtual choice TankElementControlLogic { get; set; } = new choice;
////[Description("Used to indicate height of control sensor if Tank Object Type is WaterHeater:Stratified")]
////public virtual real ControlSensor1HeightInStratifiedTank { get; set; } = new real;
////[Description("Weight to give Control Sensor 1 temperature")]
////public virtual null ControlSensor1Weight { get; set; } = new null;
////[Description("Used to indicate height of control sensor if Tank Object Type is WaterHeater:Stratified")]
////public virtual real ControlSensor2HeightInStratifiedTank { get; set; } = new real;
////}
////}




