/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2023, the respective contributors. All rights reserved.
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
////public class Chiller:Absorption:Indirect : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual real NominalCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real NominalPumpingPower { get; set; } = new real;
////[Description("No description available")]
////public virtual node ChilledWaterInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node ChilledWaterOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node CondenserInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node CondenserOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual real MinimumPartLoadRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumPartLoadRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real OptimumPartLoadRatio { get; set; } = new real;
////[Description("Used only when condenser flow rate is autosized.")]
////public virtual real DesignCondenserInletTemperature { get; set; } = new real;
////[Description("Provides warnings when entering condenser temperature is below minimum.")]
////public virtual real CondenserInletTemperatureLowerLimit { get; set; } = new real;
////[Description("Capacity is adjusted when leaving chilled water temperature is below minimum.")]
////public virtual real ChilledWaterOutletTemperatureLowerLimit { get; set; } = new real;
////[Description("For variable flow this is the max flow & for constant flow this is the flow.")]
////public virtual real DesignChilledWaterFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real DesignCondenserWaterFlowRate { get; set; } = new real;
////[Description("Select operating mode for fluid flow through the chiller. "NotModulated" is for")]
////public virtual choice ChillerFlowMode { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list GeneratorHeatInputFunctionOfPartLoadRatioCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list PumpElectricInputFunctionOfPartLoadRatioCurveName { get; set; } = new object-list;
////[Description("Enter the generator inlet node name which connects this chiller to a")]
////public virtual node GeneratorInletNodeName { get; set; } = new node;
////[Description("Enter the generator outlet node name which connects this chiller to a")]
////public virtual node GeneratorOutletNodeName { get; set; } = new node;
////[Description("Curve which shows the change in normalized capacity to changes in condenser temperature.")]
////public virtual object-list CapacityCorrectionFunctionOfCondenserTemperatureCurveName { get; set; } = new object-list;
////[Description("Curve which shows the change in normalized capacity to changes in leaving chilled water temperature.")]
////public virtual object-list CapacityCorrectionFunctionOfChilledWaterTemperatureCurveName { get; set; } = new object-list;
////[Description("Used when generator fluid type is hot water")]
////public virtual object-list CapacityCorrectionFunctionOfGeneratorTemperatureCurveName { get; set; } = new object-list;
////[Description("Curve which shows the change in normalized heat input to changes in condenser temperature.")]
////public virtual object-list GeneratorHeatInputCorrectionFunctionOfCondenserTemperatureCurveName { get; set; } = new object-list;
////[Description("Curve which shows the change in normalized heat input to changes in leaving chilled water temperature.")]
////public virtual object-list GeneratorHeatInputCorrectionFunctionOfChilledWaterTemperatureCurveName { get; set; } = new object-list;
////[Description("The Generator side of the chiller can be connected to a hot water or steam plant where the")]
////public virtual choice GeneratorHeatSourceType { get; set; } = new choice;
////[Description("For variable flow this is the max flow and for constant flow this is the flow.")]
////public virtual real DesignGeneratorFluidFlowRate { get; set; } = new real;
////[Description("Provides warnings when entering generator temperature is below minimum.")]
////public virtual real TemperatureLowerLimitGeneratorInlet { get; set; } = new real;
////[Description("This field is not used when the generator inlet/outlet nodes are not specified or")]
////public virtual real DegreeOfSubcoolingInSteamGenerator { get; set; } = new real;
////[Description("This field is not used when the generator inlet/outlet nodes are not specified or")]
////public virtual real DegreeOfSubcoolingInSteamCondensateLoop { get; set; } = new real;
////[Description("Multiplies the autosized capacity and flow rates")]
////public virtual real SizingFactor { get; set; } = new real;
////}
////}



