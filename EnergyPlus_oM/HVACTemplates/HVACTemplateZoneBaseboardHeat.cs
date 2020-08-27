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
////public class HVACTemplate:Zone:BaseboardHeat : BHoMObject
////{
////[Description("Zone name must match a building zone name")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("Enter the name of a HVACTemplate:Thermostat object.")]
////public virtual object-list TemplateThermostatName { get; set; } = new object-list;
////[Description("If blank, value from Sizing:Parameters will be used.")]
////public virtual null ZoneHeatingSizingFactor { get; set; } = new null;
////[Description("No description available")]
////public virtual choice BaseboardHeatingType { get; set; } = new choice;
////[Description("If blank, always on")]
////public virtual object-list BaseboardHeatingAvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null BaseboardHeatingCapacity { get; set; } = new null;
////[Description("Enter the name of an HVACTemplate:System:DedicatedOutdoorAir object if this")]
////public virtual object-list DedicatedOutdoorAirSystemName { get; set; } = new object-list;
////[Description("Flow/Person, Flow/Zone, Flow/Area, Sum, and Maximum use the values in the next three")]
////public virtual choice OutdoorAirMethod { get; set; } = new choice;
////[Description("Default 0.00944 is 20 cfm per person")]
////public virtual null OutdoorAirFlowRatePerPerson { get; set; } = new null;
////[Description("This input is used if the field Outdoor Air Method is")]
////public virtual null OutdoorAirFlowRatePerZoneFloorArea { get; set; } = new null;
////[Description("This input is used if the field Outdoor Air Method is")]
////public virtual real OutdoorAirFlowRatePerZone { get; set; } = new real;
////[Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName { get; set; } = new object-list;
////[Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName { get; set; } = new object-list;
////}
////}
