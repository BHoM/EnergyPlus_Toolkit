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
////public class UnitarySystemPerformance:Multispeed : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("Used only for Multi speed coils")]
////public virtual integer NumberOfSpeedsForHeating { get; set; } = new integer;
////[Description("Used only for Multi speed coils")]
////public virtual integer NumberOfSpeedsForCooling { get; set; } = new integer;
////[Description("Controls coil operation during each HVAC timestep.")]
////public virtual choice SingleModeOperation { get; set; } = new choice;
////[Description("Used to define the no load operating air flow rate when the system fan")]
////public virtual real NoLoadSupplyAirFlowRateRatio { get; set; } = new real;
////[Description("Used only for Multi speed coils")]
////public virtual real HeatingSpeed1SupplyAirFlowRatio { get; set; } = new real;
////[Description("Used only for Multi speed coils")]
////public virtual real CoolingSpeed1SupplyAirFlowRatio { get; set; } = new real;
////[Description("Used only for Multi speed coils")]
////public virtual real HeatingSpeed2SupplyAirFlowRatio { get; set; } = new real;
////[Description("Used only for Multi speed coils")]
////public virtual real CoolingSpeed2SupplyAirFlowRatio { get; set; } = new real;
////[Description("Used only for Multi speed coils")]
////public virtual real HeatingSpeed3SupplyAirFlowRatio { get; set; } = new real;
////[Description("Used only for Multi speed coils")]
////public virtual real CoolingSpeed3SupplyAirFlowRatio { get; set; } = new real;
////[Description("Used only for Multi speed coils")]
////public virtual real HeatingSpeed4SupplyAirFlowRatio { get; set; } = new real;
////[Description("Used only for Multi speed coils")]
////public virtual real CoolingSpeed4SupplyAirFlowRatio { get; set; } = new real;
////[Description("Used only for Multi speed coils")]
////public virtual real HeatingSpeed5SupplyAirFlowRatio { get; set; } = new real;
////[Description("Used only for Multi speed coils")]
////public virtual real CoolingSpeed5SupplyAirFlowRatio { get; set; } = new real;
////[Description("Used only for Multi speed coils")]
////public virtual real HeatingSpeed6SupplyAirFlowRatio { get; set; } = new real;
////[Description("Used only for Multi speed coils")]
////public virtual real CoolingSpeed6SupplyAirFlowRatio { get; set; } = new real;
////[Description("Used only for Multi speed coils")]
////public virtual real HeatingSpeed7SupplyAirFlowRatio { get; set; } = new real;
////[Description("Used only for Multi speed coils")]
////public virtual real CoolingSpeed7SupplyAirFlowRatio { get; set; } = new real;
////[Description("Used only for Multi speed coils")]
////public virtual real HeatingSpeed8SupplyAirFlowRatio { get; set; } = new real;
////[Description("Used only for Multi speed coils")]
////public virtual real CoolingSpeed8SupplyAirFlowRatio { get; set; } = new real;
////[Description("Used only for Multi speed coils")]
////public virtual real HeatingSpeed9SupplyAirFlowRatio { get; set; } = new real;
////[Description("Used only for Multi speed coils")]
////public virtual real CoolingSpeed9SupplyAirFlowRatio { get; set; } = new real;
////[Description("Used only for Multi speed coils")]
////public virtual real HeatingSpeed10SupplyAirFlowRatio { get; set; } = new real;
////[Description("Used only for Multi speed coils")]
////public virtual real CoolingSpeed10SupplyAirFlowRatio { get; set; } = new real;
////}
////}
