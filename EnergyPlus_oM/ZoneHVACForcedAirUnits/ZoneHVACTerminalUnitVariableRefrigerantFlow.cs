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
////public class ZoneHVAC:TerminalUnit:VariableRefrigerantFlow : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha ZoneTerminalUnitName { get; set; } = new alpha;
////[Description("The unit is available the entire simulation if this field is left blank")]
////public virtual object-list TerminalUnitAvailabilitySchedule { get; set; } = new object-list;
////[Description("the inlet node to the terminal unit")]
////public virtual node TerminalUnitAirInletNodeName { get; set; } = new node;
////[Description("the outlet node of the terminal unit")]
////public virtual node TerminalUnitAirOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual real CoolingSupplyAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real NoCoolingSupplyAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real HeatingSupplyAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real NoHeatingSupplyAirFlowRate { get; set; } = new real;
////[Description("This field is set to zero flow when the VRF terminal unit is connected to")]
////public virtual real CoolingOutdoorAirFlowRate { get; set; } = new real;
////[Description("This field is set to zero flow when the VRF terminal unit is connected to")]
////public virtual real HeatingOutdoorAirFlowRate { get; set; } = new real;
////[Description("This field is set to zero flow when the VRF terminal unit is connected to")]
////public virtual real NoLoadOutdoorAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list SupplyAirFanOperatingModeScheduleName { get; set; } = new object-list;
////[Description("Select fan placement as either blow through or draw through.")]
////public virtual choice SupplyAirFanPlacement { get; set; } = new choice;
////[Description("Supply Air Fan Object Type must be Fan:SystemModel, Fan:OnOff, or Fan:ConstantVolume")]
////public virtual choice SupplyAirFanObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list SupplyAirFanObjectName { get; set; } = new object-list;
////[Description("Currently only one type OutdoorAir:Mixer object is available.")]
////public virtual choice OutsideAirMixerObjectType { get; set; } = new choice;
////[Description("If this field is blank, the OutdoorAir:Mixer is not used.")]
////public virtual object-list OutsideAirMixerObjectName { get; set; } = new object-list;
////[Description("Cooling Coil Type must be Coil:Cooling:DX:VariableRefrigerantFlow")]
////public virtual choice CoolingCoilObjectType { get; set; } = new choice;
////[Description("Cooling Coil Type must be Coil:Cooling:DX:VariableRefrigerantFlow")]
////public virtual object-list CoolingCoilObjectName { get; set; } = new object-list;
////[Description("Heating Coil Type must be Coil:Heating:DX:VariableRefrigerantFlow")]
////public virtual choice HeatingCoilObjectType { get; set; } = new choice;
////[Description("Heating Coil Type must be Coil:Heating:DX:VariableRefrigerantFlow")]
////public virtual object-list HeatingCoilObjectName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real ZoneTerminalUnitOnParasiticElectricEnergyUse { get; set; } = new real;
////[Description("No description available")]
////public virtual real ZoneTerminalUnitOffParasiticElectricEnergyUse { get; set; } = new real;
////[Description("If this terminal unit's heating coil is autosized, the heating capacity is sized")]
////public virtual real RatedHeatingCapacitySizingRatio { get; set; } = new real;
////[Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
////public virtual object-list AvailabilityManagerListName { get; set; } = new object-list;
////[Description("Enter the name of a DesignSpecificationZoneHVACSizing object.")]
////public virtual object-list DesignSpecificationZoneHVACSizingObjectName { get; set; } = new object-list;
////[Description("works with gas, electric, hot water and steam heating coil.")]
////public virtual choice SupplementalHeatingCoilObjectType { get; set; } = new choice;
////[Description("Needs to match in the supplemental heating coil object.")]
////public virtual object-list SupplementalHeatingCoilName { get; set; } = new object-list;
////[Description("Supply air temperature from the supplemental heater will not exceed this value.")]
////public virtual real MaximumSupplyAirTemperatureFromSupplementalHeater { get; set; } = new real;
////[Description("Supplemental heater will not operate when outdoor temperature exceeds this value.")]
////public virtual real MaximumOutdoorDry-BulbTemperatureForSupplementalHeaterOperation { get; set; } = new real;
////}
////}



