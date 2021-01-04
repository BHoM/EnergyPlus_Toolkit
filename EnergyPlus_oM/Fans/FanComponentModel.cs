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
////public class Fan:ComponentModel : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("No description available")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null MaximumFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual null MinimumFlowRate { get; set; } = new null;
////[Description("Applied to specified or autosized max fan airflow")]
////public virtual real FanSizingFactor { get; set; } = new real;
////[Description("Diameter of wheel outer circumference")]
////public virtual real FanWheelDiameter { get; set; } = new real;
////[Description("Area at fan outlet plane for determining discharge velocity pressure")]
////public virtual real FanOutletArea { get; set; } = new real;
////[Description("Maximum ratio between power delivered to air and fan shaft input power")]
////public virtual real MaximumFanStaticEfficiency { get; set; } = new real;
////[Description("Euler number (Eu) determined from fan performance data")]
////public virtual real EulerNumberAtMaximumFanStaticEfficiency { get; set; } = new real;
////[Description("Corresponds to maximum ratio between fan airflow and")]
////public virtual real MaximumDimensionlessFanAirflow { get; set; } = new real;
////[Description("Ratio of motor pulley diameter to fan pulley diameter")]
////public virtual real MotorFanPulleyRatio { get; set; } = new real;
////[Description("Maximum torque transmitted by belt")]
////public virtual real BeltMaximumTorque { get; set; } = new real;
////[Description("Applied to specified or autosized max torque transmitted by belt")]
////public virtual real BeltSizingFactor { get; set; } = new real;
////[Description("Region 1 to 2 curve transition for belt normalized efficiency")]
////public virtual real BeltFractionalTorqueTransition { get; set; } = new real;
////[Description("Maximum rotational speed of fan motor shaft")]
////public virtual real MotorMaximumSpeed { get; set; } = new real;
////[Description("Maximum power input to drive belt by motor")]
////public virtual real MaximumMotorOutputPower { get; set; } = new real;
////[Description("Applied to specified or autosized motor output power")]
////public virtual real MotorSizingFactor { get; set; } = new real;
////[Description("0.0 means motor outside air stream")]
////public virtual real MotorInAirstreamFraction { get; set; } = new real;
////[Description("Efficiency depends on fraction of full-load motor speed")]
////public virtual choice VFDEfficiencyType { get; set; } = new choice;
////[Description("Maximum power input to motor by VFD")]
////public virtual real MaximumVFDOutputPower { get; set; } = new real;
////[Description("Applied to specified or autosized VFD output power")]
////public virtual real VFDSizingFactor { get; set; } = new real;
////[Description("Pressure rise depends on volumetric flow, system resistances,")]
////public virtual object-list FanPressureRiseCurveName { get; set; } = new object-list;
////[Description("Function of fan volumetric flow")]
////public virtual object-list DuctStaticPressureResetCurveName { get; set; } = new object-list;
////[Description("xfan <= 0")]
////public virtual object-list NormalizedFanStaticEfficiencyCurveName-Non-StallRegion { get; set; } = new object-list;
////[Description("xfan > 0")]
////public virtual object-list NormalizedFanStaticEfficiencyCurveName-StallRegion { get; set; } = new object-list;
////[Description("xspd <= 0")]
////public virtual object-list NormalizedDimensionlessAirflowCurveName-Non-StallRegion { get; set; } = new object-list;
////[Description("xspd > 0")]
////public virtual object-list NormalizedDimensionlessAirflowCurveName-StallRegion { get; set; } = new object-list;
////[Description("Determines maximum fan drive belt efficiency in log space")]
////public virtual object-list MaximumBeltEfficiencyCurveName { get; set; } = new object-list;
////[Description("Region 1 (0 <= xbelt < xbelt,trans)")]
////public virtual object-list NormalizedBeltEfficiencyCurveName-Region1 { get; set; } = new object-list;
////[Description("Region 2 (xbelt,trans <= xbelt <= 1)")]
////public virtual object-list NormalizedBeltEfficiencyCurveName-Region2 { get; set; } = new object-list;
////[Description("Determines normalized drive belt efficiency Region 3 (xbelt > 1)")]
////public virtual object-list NormalizedBeltEfficiencyCurveName-Region3 { get; set; } = new object-list;
////[Description("Curve should have minimum > 0.0 and maximum of 1.0")]
////public virtual object-list MaximumMotorEfficiencyCurveName { get; set; } = new object-list;
////[Description("Curve should have minimum > 0.0 and maximum of 1.0")]
////public virtual object-list NormalizedMotorEfficiencyCurveName { get; set; } = new object-list;
////[Description("Determines VFD efficiency as function of motor load or speed fraction")]
////public virtual object-list VFDEfficiencyCurveName { get; set; } = new object-list;
////[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Subcategory table.")]
////public virtual alpha End-UseSubcategory { get; set; } = new alpha;
////}
////}

