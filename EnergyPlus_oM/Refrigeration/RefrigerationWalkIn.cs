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
////public class Refrigeration:WalkIn : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real RatedCoilCoolingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real OperatingTemperature { get; set; } = new real;
////[Description("If DXEvaporator, use evaporating temperature (saturated suction temperature)")]
////public virtual real RatedCoolingSourceTemperature { get; set; } = new real;
////[Description("Include total for all anti-sweat, door, drip-pan, and floor heater power")]
////public virtual real RatedTotalHeatingPower { get; set; } = new real;
////[Description("Values will be used to multiply the total heating power")]
////public virtual object-list HeatingPowerScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real RatedCoolingCoilFanPower { get; set; } = new real;
////[Description("No description available")]
////public virtual real RatedCirculationFanPower { get; set; } = new real;
////[Description("Enter the total (display + task) installed lighting power.")]
////public virtual real RatedTotalLightingPower { get; set; } = new real;
////[Description("The schedule should contain values between 0 and 1")]
////public virtual object-list LightingScheduleName { get; set; } = new object-list;
////[Description("HotFluid includes either hot gas defrost for a DX system or")]
////public virtual choice DefrostType { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice DefrostControlType { get; set; } = new choice;
////[Description("The schedule values should be 0 (off) or 1 (on)")]
////public virtual object-list DefrostScheduleName { get; set; } = new object-list;
////[Description("The schedule values should be 0 (off) or 1 (on)")]
////public virtual object-list DefrostDrip-DownScheduleName { get; set; } = new object-list;
////[Description("needed for all defrost types except none and offcycle")]
////public virtual real DefrostPower { get; set; } = new real;
////[Description("This is the portion of the defrost energy that is available to melt frost")]
////public virtual real TemperatureTerminationDefrostFractionToIce { get; set; } = new real;
////[Description("Schedule values should be in units of Watts")]
////public virtual object-list RestockingScheduleName { get; set; } = new object-list;
////[Description("This value is only used if the Cooling Source Type is DXEvaporator")]
////public virtual real AverageRefrigerantChargeInventory { get; set; } = new real;
////[Description("floor area of walk-in cooler")]
////public virtual real InsulatedFloorSurfaceArea { get; set; } = new real;
////[Description("The default value corresponds to R18 [ft2-F-hr/Btu]")]
////public virtual real InsulatedFloorU-Value { get; set; } = new real;
////[Description("This must be a controlled zone and appear in a ZoneHVAC:EquipmentConnections object.")]
////public virtual object-list Zone1Name { get; set; } = new object-list;
////[Description("Area should include walls and ceilings, but not doors")]
////public virtual real TotalInsulatedSurfaceAreaFacingZone1 { get; set; } = new real;
////[Description("The default value corresponds to R18 [ft2-F-hr/Btu]")]
////public virtual real InsulatedSurfaceU-ValueFacingZone1 { get; set; } = new real;
////[Description("No description available")]
////public virtual real AreaOfGlassReachInDoorsFacingZone1 { get; set; } = new real;
////[Description("No description available")]
////public virtual real HeightOfGlassReachInDoorsFacingZone1 { get; set; } = new real;
////[Description("The default value corresponds to R5 [ft2-F-hr/Btu]")]
////public virtual real GlassReachInDoorUValueFacingZone1 { get; set; } = new real;
////[Description("Schedule values should all be between 0.0 and 1.0.")]
////public virtual object-list GlassReachInDoorOpeningScheduleNameFacingZone1 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real AreaOfStockingDoorsFacingZone1 { get; set; } = new real;
////[Description("No description available")]
////public virtual real HeightOfStockingDoorsFacingZone1 { get; set; } = new real;
////[Description("The default value corresponds to R15 [ft2-F-hr/Btu]")]
////public virtual real StockingDoorUValueFacingZone1 { get; set; } = new real;
////[Description("Schedule values should all be between 0.0 and 1.0.")]
////public virtual object-list StockingDoorOpeningScheduleNameFacingZone1 { get; set; } = new object-list;
////[Description("Use StripCurtain for hanging strips or airlock vestibules")]
////public virtual choice StockingDoorOpeningProtectionTypeFacingZone1 { get; set; } = new choice;
////[Description("required if more than one zone")]
////public virtual object-list Zone2Name { get; set; } = new object-list;
////[Description("Area should include walls and ceilings, but not doors")]
////public virtual real TotalInsulatedSurfaceAreaFacingZone2 { get; set; } = new real;
////[Description("The default value corresponds to R18 [ft2-F-hr/Btu]")]
////public virtual real InsulatedSurfaceU-ValueFacingZone2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real AreaOfGlassReachInDoorsFacingZone2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real HeightOfGlassReachInDoorsFacingZone2 { get; set; } = new real;
////[Description("The default value corresponds to R5 [ft2-F-hr/Btu]")]
////public virtual real GlassReachInDoorUValueFacingZone2 { get; set; } = new real;
////[Description("Schedule values should all be between 0.0 and 1.0.")]
////public virtual object-list GlassReachInDoorOpeningScheduleNameFacingZone2 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real AreaOfStockingDoorsFacingZone2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real HeightOfStockingDoorsFacingZone2 { get; set; } = new real;
////[Description("The default value corresponds to R15 [ft2-F-hr/Btu]")]
////public virtual real StockingDoorUValueFacingZone2 { get; set; } = new real;
////[Description("Schedule values should all be between 0.0 and 1.0.")]
////public virtual object-list StockingDoorOpeningScheduleNameFacingZone2 { get; set; } = new object-list;
////[Description("Use StripCurtain for hanging strips or airlock vestibules")]
////public virtual choice StockingDoorOpeningProtectionTypeFacingZone2 { get; set; } = new choice;
////[Description("This must be a controlled zone and appear in a ZoneHVAC:EquipmentConnections object.")]
////public virtual object-list Zone3Name { get; set; } = new object-list;
////[Description("required if more than two zones")]
////public virtual real TotalInsulatedSurfaceAreaFacingZone3 { get; set; } = new real;
////[Description("The default value corresponds to R18 [ft2-F-hr/Btu]")]
////public virtual real InsulatedSurfaceU-ValueFacingZone3 { get; set; } = new real;
////[Description("No description available")]
////public virtual real AreaOfGlassReachInDoorsFacingZone3 { get; set; } = new real;
////[Description("No description available")]
////public virtual real HeightOfGlassReachInDoorsFacingZone3 { get; set; } = new real;
////[Description("The default value corresponds to R5 [ft2-F-hr/Btu]")]
////public virtual real GlassReachInDoorUValueFacingZone3 { get; set; } = new real;
////[Description("Schedule values should all be between 0.0 and 1.0.")]
////public virtual object-list GlassReachInDoorOpeningScheduleNameFacingZone3 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real AreaOfStockingDoorsFacingZone3 { get; set; } = new real;
////[Description("No description available")]
////public virtual real HeightOfStockingDoorsFacingZone3 { get; set; } = new real;
////[Description("The default value corresponds to R15 [ft2-F-hr/Btu]")]
////public virtual real StockingDoorUValueFacingZone3 { get; set; } = new real;
////[Description("Schedule values should all be between 0.0 and 1.0.")]
////public virtual object-list StockingDoorOpeningScheduleNameFacingZone3 { get; set; } = new object-list;
////[Description("Use StripCurtain for hanging strips or airlock vestibules")]
////public virtual choice StockingDoorOpeningProtectionTypeFacingZone3 { get; set; } = new choice;
////}
////}

