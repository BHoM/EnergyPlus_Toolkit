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
////public class AirflowNetwork:MultiZone:Surface : BHoMObject
////{
////[Description("Enter the name of a heat transfer surface.")]
////public virtual object-list SurfaceName { get; set; } = new object-list;
////[Description("Enter the name of an Airflow Network leakage component. A leakage component is")]
////public virtual object-list LeakageComponentName { get; set; } = new object-list;
////[Description("Used if Wind Pressure Coefficient Type = Input in the AirflowNetwork:SimulationControl object,")]
////public virtual object-list ExternalNodeName { get; set; } = new object-list;
////[Description("This field specifies a multiplier for a crack, window, or door.")]
////public virtual real Window/DoorOpeningFactor,OrCrackFactor { get; set; } = new real;
////[Description("When Ventilation Control Mode = Temperature or Enthalpy, the following")]
////public virtual choice VentilationControlMode { get; set; } = new choice;
////[Description("Used only if Ventilation Control Mode = Temperature or Enthalpy.")]
////public virtual object-list VentilationControlZoneTemperatureSetpointScheduleName { get; set; } = new object-list;
////[Description("Used only if Ventilation Control Mode = Temperature or Enthalpy.")]
////public virtual real MinimumVentingOpenFactor { get; set; } = new real;
////[Description("Applicable only if Ventilation Control Mode = Temperature")]
////public virtual real IndoorAndOutdoorTemperatureDifferenceLowerLimitForMaximumVentingOpenFactor { get; set; } = new real;
////[Description("Applicable only if Ventilation Control Mode = Temperature.")]
////public virtual real IndoorAndOutdoorTemperatureDifferenceUpperLimitForMinimumVentingOpenFactor { get; set; } = new real;
////[Description("Applicable only if Ventilation Control Mode = Enthalpy.")]
////public virtual real IndoorAndOutdoorEnthalpyDifferenceLowerLimitForMaximumVentingOpenFactor { get; set; } = new real;
////[Description("Applicable only if Ventilation Control Mode = Enthalpy.")]
////public virtual real IndoorAndOutdoorEnthalpyDifferenceUpperLimitForMinimumVentingOpenFactor { get; set; } = new real;
////[Description("Non-zero schedule value means venting is allowed if other venting control conditions are")]
////public virtual object-list VentingAvailabilityScheduleName { get; set; } = new object-list;
////[Description("Enter the name where Occupancy Ventilation Control is required.")]
////public virtual object-list OccupantVentilationControlName { get; set; } = new object-list;
////[Description("This field is applied to a non-rectangular window or door. The equivalent shape has")]
////public virtual choice EquivalentRectangleMethod { get; set; } = new choice;
////[Description("This field is used when UserDefinedAspectRatio is entered in the Equivalent")]
////public virtual real EquivalentRectangleAspectRatio { get; set; } = new real;
////}
////}
