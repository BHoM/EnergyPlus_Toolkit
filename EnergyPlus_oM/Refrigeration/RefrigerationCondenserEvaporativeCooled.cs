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
////public class Refrigeration:Condenser:EvaporativeCooled : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Rating as per ARI 490")]
////public virtual real RatedEffectiveTotalHeatRejectionRate { get; set; } = new real;
////[Description("must correspond to rating given for total heat rejection effect")]
////public virtual real RatedSubcoolingTemperatureDifference { get; set; } = new real;
////[Description("No description available")]
////public virtual choice FanSpeedControlType { get; set; } = new choice;
////[Description("Power for condenser fan(s) corresponding to rated total heat rejection effect.")]
////public virtual real RatedFanPower { get; set; } = new real;
////[Description("Minimum air flow fraction through condenser fan")]
////public virtual real MinimumFanAirFlowRatio { get; set; } = new real;
////[Description("A1 in delta T = A1 + A2(hrcf) + A3/(hrcf) + A4(Twb)")]
////public virtual real ApproachTemperatureConstantTerm { get; set; } = new real;
////[Description("A2 in delta T = A1 + A2(hrcf) +A3/(hrcf) +A4(Twb)")]
////public virtual real ApproachTemperatureCoefficient2 { get; set; } = new real;
////[Description("A3 in delta T = A1 + A2(hrcf) +A3/(hrcf) +A4(Twb)")]
////public virtual real ApproachTemperatureCoefficient3 { get; set; } = new real;
////[Description("A4 in deltaT=A1 + A2(hrcf) +A3/(hrcf) +A4(Twb)")]
////public virtual real ApproachTemperatureCoefficient4 { get; set; } = new real;
////[Description("taken from manufacturer's Heat Rejection Capacity Factor Table")]
////public virtual real MinimumCapacityFactor { get; set; } = new real;
////[Description("taken from manufacturer's Heat Rejection Capacity Factor Table")]
////public virtual real MaximumCapacityFactor { get; set; } = new real;
////[Description("If field is left blank,")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("Used to calculate evaporative condenser water use and fan energy use.")]
////public virtual real RatedAirFlowRate { get; set; } = new real;
////[Description("This field is only used for periods")]
////public virtual real BasinHeaterCapacity { get; set; } = new real;
////[Description("Enter the outdoor dry-bulb temperature at which the basin heater turns on.")]
////public virtual real BasinHeaterSetpointTemperature { get; set; } = new real;
////[Description("Design recirculating water pump power.")]
////public virtual real RatedWaterPumpPower { get; set; } = new real;
////[Description("If blank, water supply is from Mains.")]
////public virtual object-list EvaporativeWaterSupplyTankName { get; set; } = new object-list;
////[Description("Schedule values greater than 0 indicate that evaporative cooling of the")]
////public virtual object-list EvaporativeCondenserAvailabilityScheduleName { get; set; } = new object-list;
////[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Subcategory table.")]
////public virtual alpha End-UseSubcategory { get; set; } = new alpha;
////[Description("optional input")]
////public virtual real CondenserRefrigerantOperatingChargeInventory { get; set; } = new real;
////[Description("optional input")]
////public virtual real CondensateReceiverRefrigerantInventory { get; set; } = new real;
////[Description("optional input")]
////public virtual real CondensatePipingRefrigerantInventory { get; set; } = new real;
////}
////}
