/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2021, the respective contributors. All rights reserved.
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
////public class Refrigeration:SecondarySystem : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object.")]
////public virtual object-list RefrigeratedCaseOrWalkinOrCaseAndWalkInListName { get; set; } = new object-list;
////[Description("If "FluidAlwaysLiquid" is selected, the fluid properties")]
////public virtual choice CirculatingFluidType { get; set; } = new choice;
////[Description("This must correspond to a name in the FluidProperties:Name object.")]
////public virtual object-list CirculatingFluidName { get; set; } = new object-list;
////[Description("For "FluidAlwaysLiquid", at least one of the two, Evaporator Capacity OR")]
////public virtual real EvaporatorCapacity { get; set; } = new real;
////[Description("For "FluidAlwaysLiquid", at least one of the two, Evaporator Capacity OR")]
////public virtual real EvaporatorFlowRateForSecondaryFluid { get; set; } = new real;
////[Description("This is the evaporating temperature in the heat exchanger")]
////public virtual real EvaporatorEvaporatingTemperature { get; set; } = new real;
////[Description("For "FluidAlwaysLiquid", this is the rated difference between the temperature of the")]
////public virtual real EvaporatorApproachTemperatureDifference { get; set; } = new real;
////[Description("For "FluidAlwaysLiquid", this is the rated difference between the temperature of the")]
////public virtual real EvaporatorRangeTemperatureDifference { get; set; } = new real;
////[Description("No description available")]
////public virtual integer NumberOfPumpsInLoop { get; set; } = new integer;
////[Description("For "FluidAlwaysLiquid",if not input, Evaporator Flow Rate for Secondary Fluid")]
////public virtual real TotalPumpFlowRate { get; set; } = new real;
////[Description("Either the Total Pump Power or the Total Pump Head is required.")]
////public virtual real TotalPumpPower { get; set; } = new real;
////[Description("Either the Total Pump Power or the Total Pump Head is required.")]
////public virtual real TotalPumpHead { get; set; } = new real;
////[Description("This is the total mass flow at the pump divided by the gaseous mass flow")]
////public virtual real PhaseChangeCirculatingRate { get; set; } = new real;
////[Description("No description available")]
////public virtual choice PumpDriveType { get; set; } = new choice;
////[Description("Variable Speed Pump Curve Name is applicable to variable speed pumps")]
////public virtual object-list VariableSpeedPumpCubicCurveName { get; set; } = new object-list;
////[Description("This is the portion of the pump motor heat added to secondary circulating fluid")]
////public virtual real PumpMotorHeatToFluid { get; set; } = new real;
////[Description("Use only if you want to include distribution piping heat gain in refrigeration load.")]
////public virtual real SumUADistributionPiping { get; set; } = new real;
////[Description("This will be used to determine the temperature used for distribution piping heat gain.")]
////public virtual object-list DistributionPipingZoneName { get; set; } = new object-list;
////[Description("Use only if you want to include Receiver/Separator Shell heat gain in refrigeration load.")]
////public virtual real SumUAReceiver/SeparatorShell { get; set; } = new real;
////[Description("This will be used to determine the temperature used for Receiver/Separator Shell heat gain.")]
////public virtual object-list Receiver/SeparatorZoneName { get; set; } = new object-list;
////[Description("This value refers to the refrigerant circulating within the primary system providing")]
////public virtual real EvaporatorRefrigerantInventory { get; set; } = new real;
////[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Subcategory table.")]
////public virtual alpha End-UseSubcategory { get; set; } = new alpha;
////}
////}

