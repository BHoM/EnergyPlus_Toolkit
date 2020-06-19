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
////namespace BH.oM.EnergyPlus
////{
////public class HVACTemplate:Plant:MixedWaterLoop : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("If blank, always available")]
////public virtual object-list PumpScheduleName { get; set; } = new object-list;
////[Description("Applies to both chilled water and condenser loop pumps")]
////public virtual choice PumpControlType { get; set; } = new choice;
////[Description("Default operation type makes all equipment available")]
////public virtual choice OperationSchemeType { get; set; } = new choice;
////[Description("Name of a PlantEquipmentOperationSchemes object")]
////public virtual object-list EquipmentOperationSchemesName { get; set; } = new object-list;
////[Description("Leave blank if constant setpoint")]
////public virtual object-list HighTemperatureSetpointScheduleName { get; set; } = new object-list;
////[Description("Used for sizing and as constant setpoint if no Setpoint Schedule Name is specified.")]
////public virtual null HighTemperatureDesignSetpoint { get; set; } = new null;
////[Description("Leave blank if constant setpoint")]
////public virtual object-list LowTemperatureSetpointScheduleName { get; set; } = new object-list;
////[Description("Used for sizing and as constant setpoint if no Condenser Water Setpoint Schedule Name is specified.")]
////public virtual null LowTemperatureDesignSetpoint { get; set; } = new null;
////[Description("VariableFlow - variable flow to boilers and coils, excess bypassed")]
////public virtual choice WaterPumpConfiguration { get; set; } = new choice;
////[Description("May be left blank if not serving any water cooled chillers")]
////public virtual null WaterPumpRatedHead { get; set; } = new null;
////[Description("Describes the type of pump configuration used for the mixed water loop.")]
////public virtual choice WaterPumpType { get; set; } = new choice;
////[Description("Determines if a supply side bypass pipe is present in the hot water loop.")]
////public virtual choice SupplySideBypassPipe { get; set; } = new choice;
////[Description("Determines if a demand side bypass pipe is present in the hot water loop.")]
////public virtual choice DemandSideBypassPipe { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice FluidType { get; set; } = new choice;
////[Description("The temperature difference used in sizing the loop flow rate.")]
////public virtual null LoopDesignDeltaTemperature { get; set; } = new null;
////[Description("No description available")]
////public virtual choice LoadDistributionScheme { get; set; } = new choice;
////}
////}
