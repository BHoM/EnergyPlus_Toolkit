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
////public class Refrigeration:Case : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("This must be a controlled zone and appear in a ZoneHVAC:EquipmentConnections object.")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real RatedAmbientTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual real RatedAmbientRelativeHumidity { get; set; } = new real;
////[Description("No description available")]
////public virtual real RatedTotalCoolingCapacityPerUnitLength { get; set; } = new real;
////[Description("No description available")]
////public virtual real RatedLatentHeatRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real RatedRuntimeFraction { get; set; } = new real;
////[Description("No description available")]
////public virtual real CaseLength { get; set; } = new real;
////[Description("No description available")]
////public virtual real CaseOperatingTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual choice LatentCaseCreditCurveType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list LatentCaseCreditCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real StandardCaseFanPowerPerUnitLength { get; set; } = new real;
////[Description("No description available")]
////public virtual real OperatingCaseFanPowerPerUnitLength { get; set; } = new real;
////[Description("No description available")]
////public virtual real StandardCaseLightingPowerPerUnitLength { get; set; } = new real;
////[Description("default set equal to Standard Case Lighting Power per Unit Length")]
////public virtual real InstalledCaseLightingPowerPerUnitLength { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list CaseLightingScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real FractionOfLightingEnergyToCase { get; set; } = new real;
////[Description("No description available")]
////public virtual real CaseAnti-SweatHeaterPowerPerUnitLength { get; set; } = new real;
////[Description("This field is only applicable to the Linear, Dewpoint Method, and")]
////public virtual real MinimumAnti-SweatHeaterPowerPerUnitLength { get; set; } = new real;
////[Description("No description available")]
////public virtual choice Anti-SweatHeaterControlType { get; set; } = new choice;
////[Description("This field is only applicable to Linear AS heater control type")]
////public virtual real HumidityAtZeroAnti-SweatHeaterEnergy { get; set; } = new real;
////[Description("This field only applicable to Heat Balance Method AS heater control type")]
////public virtual real CaseHeight { get; set; } = new real;
////[Description("No description available")]
////public virtual real FractionOfAnti-SweatHeaterEnergyToCase { get; set; } = new real;
////[Description("Used to evaluate load on case as well as power or heat consumption")]
////public virtual real CaseDefrostPowerPerUnitLength { get; set; } = new real;
////[Description("No description available")]
////public virtual choice CaseDefrostType { get; set; } = new choice;
////[Description("A case defrost schedule name is required unless case defrost type = None")]
////public virtual object-list CaseDefrostScheduleName { get; set; } = new object-list;
////[Description("If left blank, the defrost schedule will be used")]
////public virtual object-list CaseDefrostDrip-DownScheduleName { get; set; } = new object-list;
////[Description("Case Temperature, Relative Humidity, and Dewpoint Method are applicable to case defrost")]
////public virtual choice DefrostEnergyCorrectionCurveType { get; set; } = new choice;
////[Description("Defrost Energy Correction Curve Name is applicable to case defrost types")]
////public virtual object-list DefrostEnergyCorrectionCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real UnderCaseHVACReturnAirFraction { get; set; } = new real;
////[Description("Schedule values should be in units of Watts per unit case length (W/m)")]
////public virtual object-list RefrigeratedCaseRestockingScheduleName { get; set; } = new object-list;
////[Description("Schedule values should be from 0 to 1")]
////public virtual object-list CaseCreditFractionScheduleName { get; set; } = new object-list;
////[Description("Required for detailed refrigeration system, not for compressor rack")]
////public virtual real DesignEvaporatorTemperatureOrBrineInletTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual real AverageRefrigerantChargeInventory { get; set; } = new real;
////[Description("Name of the return air node for this case.")]
////public virtual node UnderCaseHVACReturnAirNodeName { get; set; } = new node;
////}
////}

