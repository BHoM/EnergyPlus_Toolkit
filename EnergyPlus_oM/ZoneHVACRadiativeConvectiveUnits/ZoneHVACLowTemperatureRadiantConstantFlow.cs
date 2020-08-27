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
////public class ZoneHVAC:LowTemperatureRadiant:ConstantFlow : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("Name of zone system is serving")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("Identifies surfaces that radiant system is embedded in.")]
////public virtual object-list SurfaceNameOrRadiantSurfaceGroupName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null HydronicTubingInsideDiameter { get; set; } = new null;
////[Description("Total length of pipe embedded in surface")]
////public virtual null HydronicTubingLength { get; set; } = new null;
////[Description("Temperature used to control system")]
////public virtual choice TemperatureControlType { get; set; } = new choice;
////[Description("No description available")]
////public virtual null RatedFlowRate { get; set; } = new null;
////[Description("Modifies the Rated Flow Rate of the pump on a time basis")]
////public virtual object-list PumpFlowRateScheduleName { get; set; } = new object-list;
////[Description("default head is 60 feet")]
////public virtual null RatedPumpHead { get; set; } = new null;
////[Description("No description available")]
////public virtual null RatedPowerConsumption { get; set; } = new null;
////[Description("No description available")]
////public virtual real MotorEfficiency { get; set; } = new real;
////[Description("No description available")]
////public virtual null FractionOfMotorInefficienciesToFluidStream { get; set; } = new null;
////[Description("No description available")]
////public virtual node HeatingWaterInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node HeatingWaterOutletNodeName { get; set; } = new node;
////[Description("Water and control temperatures for heating work together to provide")]
////public virtual object-list HeatingHighWaterTemperatureScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list HeatingLowWaterTemperatureScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list HeatingHighControlTemperatureScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list HeatingLowControlTemperatureScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node CoolingWaterInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node CoolingWaterOutletNodeName { get; set; } = new node;
////[Description("See note for Heating High Water Temperature Schedule above for")]
////public virtual object-list CoolingHighWaterTemperatureScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list CoolingLowWaterTemperatureScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list CoolingHighControlTemperatureScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list CoolingLowControlTemperatureScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice CondensationControlType { get; set; } = new choice;
////[Description("No description available")]
////public virtual null CondensationControlDewpointOffset { get; set; } = new null;
////[Description("No description available")]
////public virtual choice NumberOfCircuits { get; set; } = new choice;
////[Description("No description available")]
////public virtual null CircuitLength { get; set; } = new null;
////}
////}
