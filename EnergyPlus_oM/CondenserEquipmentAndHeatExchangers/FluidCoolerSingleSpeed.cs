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
////public class FluidCooler:SingleSpeed : BHoMObject
////{
////[Description("fluid cooler name")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Name of fluid cooler water inlet node")]
////public virtual node WaterInletNodeName { get; set; } = new node;
////[Description("Name of fluid cooler water outlet node")]
////public virtual node WaterOutletNodeName { get; set; } = new node;
////[Description("User can define fluid cooler thermal performance by specifying the fluid cooler UA")]
////public virtual choice PerformanceInputMethod { get; set; } = new choice;
////[Description("Leave field blank if fluid cooler Performance Input Method is NominalCapacity")]
////public virtual real DesignAirFlowRateU-factorTimesAreaValue { get; set; } = new real;
////[Description("Nominal fluid cooler capacity")]
////public virtual real NominalCapacity { get; set; } = new real;
////[Description("Design Entering Water Temperature must be specified for both the performance input methods and")]
////public virtual real DesignEnteringWaterTemperature { get; set; } = new real;
////[Description("Design Entering Air Temperature must be specified for both the performance input methods and")]
////public virtual real DesignEnteringAirTemperature { get; set; } = new real;
////[Description("Design Entering Air Wet-bulb Temperature must be specified for both the performance input methods and")]
////public virtual real DesignEnteringAirWetbulbTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual real DesignWaterFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real DesignAirFlowRate { get; set; } = new real;
////[Description("This is the fan motor electric input power")]
////public virtual real DesignAirFlowRateFanPower { get; set; } = new real;
////[Description("Enter the name of an outdoor air node")]
////public virtual node OutdoorAirInletNodeName { get; set; } = new node;
////}
////}
