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
////namespace BH.oM.EnergyPlus
////{
////public class Refrigeration:CompressorRack : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual choice HeatRejectionLocation { get; set; } = new choice;
////[Description("It is important that this COP correspond to the lowest saturated suction")]
////public virtual real DesignCompressorRackCOP { get; set; } = new real;
////[Description("It is important that this COP curve correspond to the lowest saturated suction")]
////public virtual object-list CompressorRackCOPFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Design power for condenser fan(s).")]
////public virtual real DesignCondenserFanPower { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list CondenserFanPowerFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Applicable only when Heat Rejection Location is Outdoors.")]
////public virtual choice CondenserType { get; set; } = new choice;
////[Description("No description available")]
////public virtual node Water-CooledCondenserInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Water-CooledCondenserOutletNodeName { get; set; } = new node;
////[Description("Applicable only when Condenser Type is WaterCooled.")]
////public virtual choice Water-CooledLoopFlowType { get; set; } = new choice;
////[Description("Applicable only when loop Flow type is VariableFlow.")]
////public virtual object-list Water-CooledCondenserOutletTemperatureScheduleName { get; set; } = new object-list;
////[Description("Applicable only when loop flow type is ConstantFlow.")]
////public virtual real Water-CooledCondenserDesignFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Water-CooledCondenserMaximumFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Water-CooledCondenserMaximumWaterOutletTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual real Water-CooledCondenserMinimumWaterInletTemperature { get; set; } = new real;
////[Description("This field is only used for Condenser Type = EvaporativelyCooled.")]
////public virtual object-list EvaporativeCondenserAvailabilityScheduleName { get; set; } = new object-list;
////[Description("Applicable only for Condenser Type = EvaporativlyCooled.")]
////public virtual real EvaporativeCondenserEffectiveness { get; set; } = new real;
////[Description("Applicable only for Condenser Type = EvaporativelyCooled.")]
////public virtual real EvaporativeCondenserAirFlowRate { get; set; } = new real;
////[Description("This field is only used for Condenser Type = EvaporativelyCooled and for periods")]
////public virtual real BasinHeaterCapacity { get; set; } = new real;
////[Description("Enter the outdoor dry-bulb temperature at which the basin heater turns on.")]
////public virtual real BasinHeaterSetpointTemperature { get; set; } = new real;
////[Description("Design recirc water pump power for Condenser Type = EvaporativelyCooled.")]
////public virtual real DesignEvaporativeCondenserWaterPumpPower { get; set; } = new real;
////[Description("If blank, water supply is from Mains.")]
////public virtual object-list EvaporativeWaterSupplyTankName { get; set; } = new object-list;
////[Description("Applicable only when Heat Rejection Location is Outdoors and Condenser Type is")]
////public virtual node CondenserAirInletNodeName { get; set; } = new node;
////[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Subcategory table.")]
////public virtual alpha End-UseSubcategory { get; set; } = new alpha;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:Walkin or")]
////public virtual object-list RefrigerationCaseNameOrWalkInNameOrCaseAndWalkInListName { get; set; } = new object-list;
////[Description("This must be a controlled zone and appear in a ZoneHVAC:EquipmentConnections object.")]
////public virtual object-list HeatRejectionZoneName { get; set; } = new object-list;
////}
////}
