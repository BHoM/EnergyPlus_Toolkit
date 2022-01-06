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
////public class HVACTemplate:Plant:ChilledWaterLoop : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("If blank, always available")]
////public virtual object-list PumpScheduleName { get; set; } = new object-list;
////[Description("Applies to both chilled water and condenser loop pumps")]
////public virtual choice PumpControlType { get; set; } = new choice;
////[Description("Default operation type makes all equipment available")]
////public virtual choice ChillerPlantOperationSchemeType { get; set; } = new choice;
////[Description("Name of a PlantEquipmentOperationSchemes object")]
////public virtual object-list ChillerPlantEquipmentOperationSchemesName { get; set; } = new object-list;
////[Description("Leave blank if constant setpoint")]
////public virtual object-list ChilledWaterSetpointScheduleName { get; set; } = new object-list;
////[Description("Used for sizing and as constant setpoint if no Chilled Water Setpoint Schedule Name is specified.")]
////public virtual null ChilledWaterDesignSetpoint { get; set; } = new null;
////[Description("VariablePrimaryNoSecondary - variable flow to chillers and coils")]
////public virtual choice ChilledWaterPumpConfiguration { get; set; } = new choice;
////[Description("default head is 60 feet H2O")]
////public virtual null PrimaryChilledWaterPumpRatedHead { get; set; } = new null;
////[Description("default head is 60 feet H2O")]
////public virtual null SecondaryChilledWaterPumpRatedHead { get; set; } = new null;
////[Description("Default operation type makes all equipment available")]
////public virtual choice CondenserPlantOperationSchemeType { get; set; } = new choice;
////[Description("Name of a CondenserEquipmentOperationSchemes object")]
////public virtual object-list CondenserEquipmentOperationSchemesName { get; set; } = new object-list;
////[Description("May be left blank if not serving any water cooled chillers")]
////public virtual choice CondenserWaterTemperatureControlType { get; set; } = new choice;
////[Description("Leave blank if constant setpoint")]
////public virtual object-list CondenserWaterSetpointScheduleName { get; set; } = new object-list;
////[Description("Used for sizing and as constant setpoint if no Condenser Water Setpoint Schedule Name is specified.")]
////public virtual null CondenserWaterDesignSetpoint { get; set; } = new null;
////[Description("May be left blank if not serving any water cooled chillers")]
////public virtual null CondenserWaterPumpRatedHead { get; set; } = new null;
////[Description("Overrides Chilled Water Setpoint Schedule Name")]
////public virtual choice ChilledWaterSetpointResetType { get; set; } = new choice;
////[Description("Applicable only for OutdoorAirTemperatureReset control.")]
////public virtual null ChilledWaterSetpointAtOutdoorDry-BulbLow { get; set; } = new null;
////[Description("Applicable only for OutdoorAirTemperatureReset control.")]
////public virtual null ChilledWaterResetOutdoorDry-BulbLow { get; set; } = new null;
////[Description("Applicable only for OutdoorAirTemperatureReset control.")]
////public virtual null ChilledWaterSetpointAtOutdoorDry-BulbHigh { get; set; } = new null;
////[Description("Applicable only for OutdoorAirTemperatureReset control.")]
////public virtual null ChilledWaterResetOutdoorDry-BulbHigh { get; set; } = new null;
////[Description("Describes the type of pump configuration used for the primary portion of the chilled water loop.")]
////public virtual choice ChilledWaterPrimaryPumpType { get; set; } = new choice;
////[Description("Describes the type of pump configuration used for the secondary portion of the chilled water loop.")]
////public virtual choice ChilledWaterSecondaryPumpType { get; set; } = new choice;
////[Description("Describes the type of pump configuration used for the condenser water loop.")]
////public virtual choice CondenserWaterPumpType { get; set; } = new choice;
////[Description("Determines if a supply side bypass pipe is present in the chilled water loop.")]
////public virtual choice ChilledWaterSupplySideBypassPipe { get; set; } = new choice;
////[Description("Determines if a demand side bypass pipe is present in the chilled water loop.")]
////public virtual choice ChilledWaterDemandSideBypassPipe { get; set; } = new choice;
////[Description("Determines if a supply side bypass pipe is present in the condenser water loop.")]
////public virtual choice CondenserWaterSupplySideBypassPipe { get; set; } = new choice;
////[Description("Determines if a demand side bypass pipe is present in the condenser water loop.")]
////public virtual choice CondenserWaterDemandSideBypassPipe { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice FluidType { get; set; } = new choice;
////[Description("The temperature difference used in sizing the loop flow rate.")]
////public virtual null LoopDesignDeltaTemperature { get; set; } = new null;
////[Description("The minimum outdoor dry-bulb temperature that the chilled water loops operate.")]
////public virtual null MinimumOutdoorDryBulbTemperature { get; set; } = new null;
////[Description("No description available")]
////public virtual choice ChilledWaterLoadDistributionScheme { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice CondenserWaterLoadDistributionScheme { get; set; } = new choice;
////}
////}


