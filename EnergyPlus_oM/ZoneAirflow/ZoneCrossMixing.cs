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
////public class ZoneCrossMixing : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual string ScheduleName { get; set; } = new object-list;
////[Description("The entered calculation method is used to create the maximum amount of ventilation")]
////public virtual choice DesignFlowRateCalculationMethod { get; set; } = new choice;
////[Description("No description available")]
////public virtual real DesignFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real FlowRatePerZoneFloorArea { get; set; } = new real;
////[Description("No description available")]
////public virtual real FlowRatePerPerson { get; set; } = new real;
////[Description("No description available")]
////public virtual real AirChangesPerHour { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list SourceZoneName { get; set; } = new object-list;
////[Description("This field contains the constant temperature differential between source and")]
////public virtual real DeltaTemperature { get; set; } = new real;
////[Description("This schedule contains the temperature differential between source and receiving")]
////public virtual object-list DeltaTemperatureScheduleName { get; set; } = new object-list;
////[Description("This schedule contains the indoor temperature versus time below which")]
////public virtual object-list MinimumZoneTemperatureScheduleName { get; set; } = new object-list;
////[Description("This schedule contains the indoor temperature versus time above which")]
////public virtual object-list MaximumZoneTemperatureScheduleName { get; set; } = new object-list;
////[Description("This schedule contains the source zone dry-bulb temperature versus time below")]
////public virtual object-list MinimumSourceZoneTemperatureScheduleName { get; set; } = new object-list;
////[Description("This schedule contains the source zone dry-bulb temperature versus time above")]
////public virtual object-list MaximumSourceZoneTemperatureScheduleName { get; set; } = new object-list;
////[Description("This schedule contains the outdoor temperature versus time below which")]
////public virtual object-list MinimumOutdoorTemperatureScheduleName { get; set; } = new object-list;
////[Description("This schedule contains the outdoor temperature versus time above which")]
////public virtual object-list MaximumOutdoorTemperatureScheduleName { get; set; } = new object-list;
////}
////}
