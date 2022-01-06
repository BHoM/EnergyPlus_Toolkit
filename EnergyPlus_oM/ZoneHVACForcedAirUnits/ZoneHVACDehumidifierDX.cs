/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2022, the respective contributors. All rights reserved.
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
////public class ZoneHVAC:Dehumidifier:DX : BHoMObject
////{
////[Description("Unique name for this direct expansion (DX) zone dehumidifier object.")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("Air inlet node for the dehumidifier must be a zone air exhaust node.")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("Air outlet node for the dehumidifier must be a zone air inlet node.")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("Rating point: air entering dehumidifier at 26.7 C (80 F) dry-bulb and 60% relative humidity.")]
////public virtual real RatedWaterRemoval { get; set; } = new real;
////[Description("Rating point: air entering dehumidifier at 26.7 C (80 F) dry-bulb and 60% relative humidity.")]
////public virtual real RatedEnergyFactor { get; set; } = new real;
////[Description("No description available")]
////public virtual real RatedAirFlowRate { get; set; } = new real;
////[Description("Name of a curve that describes the water removal rate (normalized to rated conditions)")]
////public virtual object-list WaterRemovalCurveName { get; set; } = new object-list;
////[Description("Name of a curve that describes the energy factor (normalized to rated conditions)")]
////public virtual object-list EnergyFactorCurveName { get; set; } = new object-list;
////[Description("Name of a curve that describes the part load fraction (PLF) of the system as")]
////public virtual object-list PartLoadFractionCorrelationCurveName { get; set; } = new object-list;
////[Description("Dehumidifier shut off if inlet air (zone) temperature is below this value.")]
////public virtual real MinimumDry-BulbTemperatureForDehumidifierOperation { get; set; } = new real;
////[Description("Dehumidifier shut off if inlet air (zone) temperature is above this value.")]
////public virtual real MaximumDry-BulbTemperatureForDehumidifierOperation { get; set; } = new real;
////[Description("Parasitic electric power consumed when the dehumidifier is available to operate, but")]
////public virtual real Off-CycleParasiticElectricLoad { get; set; } = new real;
////[Description("Name of storage tank used to collect water removed by the dehumidifier.")]
////public virtual object-list CondensateCollectionWaterStorageTankName { get; set; } = new object-list;
////}
////}


