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
////public class ThermalStorage:ChilledWater:Mixed : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual real TankVolume { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list SetpointTemperatureScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DeadbandTemperatureDifference { get; set; } = new real;
////[Description("No description available")]
////public virtual real MinimumTemperatureLimit { get; set; } = new real;
////[Description("No description available")]
////public virtual real NominalCoolingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual choice AmbientTemperatureIndicator { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list AmbientTemperatureScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list AmbientTemperatureZoneName { get; set; } = new object-list;
////[Description("required when field Ambient Temperature Indicator=Outdoors")]
////public virtual node AmbientTemperatureOutdoorAirNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual real HeatGainCoefficientFromAmbientTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual node UseSideInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node UseSideOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual real UseSideHeatTransferEffectiveness { get; set; } = new real;
////[Description("Availability schedule name for use side. Schedule value > 0 means the system is available.")]
////public virtual object-list UseSideAvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real UseSideDesignFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual node SourceSideInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node SourceSideOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual real SourceSideHeatTransferEffectiveness { get; set; } = new real;
////[Description("Availability schedule name for source side. Schedule value > 0 means the system is available.")]
////public virtual object-list SourceSideAvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real SourceSideDesignFlowRate { get; set; } = new real;
////[Description("Parameter for autosizing design flow rates for indirectly cooled water tanks")]
////public virtual real TankRecoveryTime { get; set; } = new real;
////}
////}
