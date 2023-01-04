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
////public class Refrigeration:AirChiller : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("In each case, select the rating option that corresponds to the expected service conditions.")]
////public virtual choice CapacityRatingType { get; set; } = new choice;
////[Description("The sensible cooling capacity in watts (W/C) at rated conditions.")]
////public virtual real RatedUnitLoadFactor { get; set; } = new real;
////[Description("This value is only used if the Capacity Rating Type is NOT UnitLoadFactorSensibleOnly.")]
////public virtual real RatedCapacity { get; set; } = new real;
////[Description("This field is ONLY used if the Capacity Rating Type is CapacityTotalSpecificConditions and")]
////public virtual real RatedRelativeHumidity { get; set; } = new real;
////[Description("If DXEvaporator, use evaporating temperature (saturated suction temperature)")]
////public virtual real RatedCoolingSourceTemperature { get; set; } = new real;
////[Description("The rated difference between the air entering the refrigeration chiller and the")]
////public virtual real RatedTemperatureDifferenceDT1 { get; set; } = new real;
////[Description("The maximum difference between the air entering the refrigeration chiller and the")]
////public virtual real MaximumTemperatureDifferenceBetweenInletAirAndEvaporatingTemperature { get; set; } = new real;
////[Description("This is the manufacturer's correction factor for coil material corresponding to rating")]
////public virtual real CoilMaterialCorrectionFactor { get; set; } = new real;
////[Description("This is the manufacturer's correction factor for refrigerant corresponding to rating")]
////public virtual real RefrigerantCorrectionFactor { get; set; } = new real;
////[Description("In each case, select the correction curve type that corresponds to the rating type.")]
////public virtual choice CapacityCorrectionCurveType { get; set; } = new choice;
////[Description("Should be blank for LinearSHR60 correction curve type")]
////public virtual object-list CapacityCorrectionCurveName { get; set; } = new object-list;
////[Description("only used when the capacity correction curve type is LinearSHR60")]
////public virtual real SHR60CorrectionFactor { get; set; } = new real;
////[Description("Include total for all heater power")]
////public virtual real RatedTotalHeatingPower { get; set; } = new real;
////[Description("Values will be used to multiply the total heating power")]
////public virtual object-list HeatingPowerScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice FanSpeedControlType { get; set; } = new choice;
////[Description("No description available")]
////public virtual real RatedFanPower { get; set; } = new real;
////[Description("No description available")]
////public virtual real RatedAirFlow { get; set; } = new real;
////[Description("Minimum air flow fraction through fan")]
////public virtual real MinimumFanAirFlowRatio { get; set; } = new real;
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
////[Description("No description available")]
////public virtual choice VerticalLocation { get; set; } = new choice;
////[Description("This value is only used if the Cooling Source Type is DXEvaporator")]
////public virtual real AverageRefrigerantChargeInventory { get; set; } = new real;
////}
////}



