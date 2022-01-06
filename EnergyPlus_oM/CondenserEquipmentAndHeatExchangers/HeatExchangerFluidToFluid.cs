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
////public class HeatExchanger:FluidToFluid : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("This connection is to the demand side of a loop and is the inlet to the heat exchanger")]
////public virtual node LoopDemandSideInletNodeName { get; set; } = new node;
////[Description("This connection is to the demand side of a loop")]
////public virtual node LoopDemandSideOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual real LoopDemandSideDesignFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual node LoopSupplySideInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node LoopSupplySideOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual real LoopSupplySideDesignFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual choice HeatExchangeModelType { get; set; } = new choice;
////[Description("No description available")]
////public virtual real HeatExchangerU-FactorTimesAreaValue { get; set; } = new real;
////[Description("No description available")]
////public virtual choice ControlType { get; set; } = new choice;
////[Description("Setpoint node is needed with any Control Type that is "*Setpoint*"")]
////public virtual node HeatExchangerSetpointNodeName { get; set; } = new node;
////[Description("Tolerance between control temperatures used to determine if heat exchanger should run.")]
////public virtual real MinimumTemperatureDifferenceToActivateHeatExchanger { get; set; } = new real;
////[Description("This field controls end use reporting for heat transfer meters")]
////public virtual choice HeatTransferMeteringEndUseType { get; set; } = new choice;
////[Description("This field is only used if Control Type is set to CoolingSetpointOnOffWithComponentOverride")]
////public virtual node ComponentOverrideLoopSupplySideInletNodeName { get; set; } = new node;
////[Description("This field is only used if Control Type is set to CoolingSetpointOnOffWithComponentOverride")]
////public virtual node ComponentOverrideLoopDemandSideInletNodeName { get; set; } = new node;
////[Description("This field is only used if Control Type is set to CoolingSetpointOnOffWithComponentOverride")]
////public virtual choice ComponentOverrideCoolingControlTemperatureMode { get; set; } = new choice;
////[Description("Multiplies the autosized flow rates for this device")]
////public virtual real SizingFactor { get; set; } = new real;
////[Description("Lower limit on inlet temperatures, heat exchanger will not operate if either inlet is below this limit")]
////public virtual real OperationMinimumTemperatureLimit { get; set; } = new real;
////[Description("Upper limit on inlet temperatures, heat exchanger will not operate if either inlet is above this limit")]
////public virtual real OperationMaximumTemperatureLimit { get; set; } = new real;
////}
////}


