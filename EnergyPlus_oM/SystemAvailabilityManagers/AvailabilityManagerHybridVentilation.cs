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
////public class AvailabilityManager:HybridVentilation : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Enter the name of an AirLoopHVAC or HVACTemplate:System:* object.")]
////public virtual object-list HVACAirLoopName { get; set; } = new object-list;
////[Description("the zone name should be a zone where a thermostat or humidistat is located")]
////public virtual object-list ControlZoneName { get; set; } = new object-list;
////[Description("The Ventilation control mode contains appropriate integer control types.")]
////public virtual object-list VentilationControlModeScheduleName { get; set; } = new object-list;
////[Description("If True, ventilation is shutoff when there is rain")]
////public virtual choice UseWeatherFileRainIndicators { get; set; } = new choice;
////[Description("this is the wind speed above which ventilation is shutoff")]
////public virtual real MaximumWindSpeed { get; set; } = new real;
////[Description("this is the outdoor temperature below which ventilation is shutoff")]
////public virtual real MinimumOutdoorTemperature { get; set; } = new real;
////[Description("this is the outdoor temperature above which ventilation is shutoff")]
////public virtual real MaximumOutdoorTemperature { get; set; } = new real;
////[Description("this is the outdoor Enthalpy below which ventilation is shutoff")]
////public virtual real MinimumOutdoorEnthalpy { get; set; } = new real;
////[Description("this is the outdoor Enthalpy above which ventilation is shutoff")]
////public virtual real MaximumOutdoorEnthalpy { get; set; } = new real;
////[Description("this is the outdoor temperature below which ventilation is shutoff")]
////public virtual real MinimumOutdoorDewpoint { get; set; } = new real;
////[Description("this is the outdoor dewpoint above which ventilation is shutoff")]
////public virtual real MaximumOutdoorDewpoint { get; set; } = new real;
////[Description("Used only if Ventilation Control Mode = 4")]
////public virtual object-list MinimumOutdoorVentilationAirScheduleName { get; set; } = new object-list;
////[Description("linear curve = a + b*WS")]
////public virtual object-list OpeningFactorFunctionOfWindSpeedCurveName { get; set; } = new object-list;
////[Description("The schedule is used to incorporate operation of AirflowNetwork large opening")]
////public virtual object-list AirflowNetworkControlTypeScheduleName { get; set; } = new object-list;
////[Description("The schedule is used to incorporate operation of simple airflow objects and HVAC")]
////public virtual object-list SimpleAirflowControlTypeScheduleName { get; set; } = new object-list;
////[Description("This field has not been instrumented to work with")]
////public virtual object-list ZoneVentilationObjectName { get; set; } = new object-list;
////[Description("Minimum operation time when HVAC system is forced on.")]
////public virtual real MinimumHVACOperationTime { get; set; } = new real;
////[Description("Minimum ventilation time when natural ventilation is forced on.")]
////public virtual real MinimumVentilationTime { get; set; } = new real;
////}
////}



