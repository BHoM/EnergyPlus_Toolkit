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
////public class CentralHeatPumpSystem : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual choice ControlMethod { get; set; } = new choice;
////[Description("No description available")]
////public virtual alpha CoolingLoopInletNodeName { get; set; } = new alpha;
////[Description("No description available")]
////public virtual alpha CoolingLoopOutletNodeName { get; set; } = new alpha;
////[Description("No description available")]
////public virtual alpha SourceLoopInletNodeName { get; set; } = new alpha;
////[Description("No description available")]
////public virtual alpha SourceLoopOutletNodeName { get; set; } = new alpha;
////[Description("No description available")]
////public virtual alpha HeatingLoopInletNodeName { get; set; } = new alpha;
////[Description("No description available")]
////public virtual alpha HeatingLoopOutletNodeName { get; set; } = new alpha;
////[Description("Power as demanded from any auxiliary controls")]
////public virtual real AncillaryPower { get; set; } = new real;
////[Description("This value from this schedule is multiplied times the Ancillary Power")]
////public virtual object-list AncillaryOperationScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice ChillerHeaterModulesPerformanceComponentObjectType1 { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesPerformanceComponentName1 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesControlScheduleName1 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual integer NumberOfChillerHeaterModules1 { get; set; } = new integer;
////[Description("No description available")]
////public virtual choice ChillerHeaterModulesPerformanceComponentObjectType2 { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesPerformanceComponentName2 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesControlScheduleName2 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual integer NumberOfChillerHeaterModules2 { get; set; } = new integer;
////[Description("No description available")]
////public virtual choice ChillerHeaterPerformanceComponentObjectType3 { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ChillerHeaterPerformanceComponentName3 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesControlScheduleName3 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual integer NumberOfChillerHeaterModules3 { get; set; } = new integer;
////[Description("No description available")]
////public virtual choice ChillerHeaterModulesPerformanceComponentObjectType4 { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesPerformanceComponentName4 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesControlScheduleName4 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual integer NumberOfChillerHeaterModules4 { get; set; } = new integer;
////[Description("No description available")]
////public virtual choice ChillerHeaterModulesPerformanceComponentObjectType5 { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModelsPerformanceComponentName5 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesControlScheduleName5 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual integer NumberOfChillerHeaterModules5 { get; set; } = new integer;
////[Description("No description available")]
////public virtual choice ChillerHeaterModulesPerformanceComponentObjectType6 { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesPerformanceComponentName6 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesControlScheduleName6 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual integer NumberOfChillerHeaterModules6 { get; set; } = new integer;
////[Description("No description available")]
////public virtual choice ChillerHeaterModulesPerformanceComponentObjectType7 { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesPerformanceComponentName7 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesControlScheduleName7 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual integer NumberOfChillerHeaterModules7 { get; set; } = new integer;
////[Description("No description available")]
////public virtual choice ChillerHeaterModulesPerformanceComponentObjectType8 { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesPerformanceComponentName8 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesControlScheduleName8 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual integer NumberOfChillerHeaterModules8 { get; set; } = new integer;
////[Description("No description available")]
////public virtual choice ChillerHeaterModulesPerformanceComponentObjectType9 { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesPerformanceComponentName9 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesControlScheduleName9 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual integer NumberOfChillerHeaterModules9 { get; set; } = new integer;
////[Description("No description available")]
////public virtual choice ChillerHeaterModulesPerformanceComponentObjectType10 { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesPerformanceComponentName10 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesControlScheduleName10 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual integer NumberOfChillerHeaterModules10 { get; set; } = new integer;
////[Description("No description available")]
////public virtual choice ChillerHeaterModulesPerformanceComponentObjectType11 { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesPerformanceComponentName11 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModuleControlScheduleName11 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual integer NumberOfChillerHeaterModules11 { get; set; } = new integer;
////[Description("No description available")]
////public virtual choice ChillerHeaterModulesPerformanceComponentObjectType12 { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesPerformanceComponentName12 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesControlScheduleName12 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual integer NumberOfChillerHeaterModules12 { get; set; } = new integer;
////[Description("No description available")]
////public virtual choice ChillerHeaterModulesPerformanceComponentObjectType13 { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesPerformanceComponentName13 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesControlScheduleName13 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual integer NumberOfChillerHeaterModules13 { get; set; } = new integer;
////[Description("No description available")]
////public virtual choice ChillerHeaterModulesPerformanceComponentObjectType14 { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesPerformanceComponentName14 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesControlScheduleName14 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual integer NumberOfChillerHeaterModules14 { get; set; } = new integer;
////[Description("No description available")]
////public virtual choice ChillerHeaterModulesPerformanceComponentObjectType15 { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesPerformanceComponentName15 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesControlScheduleName15 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual integer NumberOfChillerHeaterModules15 { get; set; } = new integer;
////[Description("No description available")]
////public virtual choice ChillerHeaterModulesPerformanceComponentObjectType16 { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesPerformanceComponentName16 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesControlScheduleName16 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual integer NumberOfChillerHeaterModules16 { get; set; } = new integer;
////[Description("No description available")]
////public virtual choice ChillerHeaterModulesPerformanceComponentObjectType17 { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesPerformanceComponentName17 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesControlScheduleName17 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual integer NumberOfChillerHeaterModules17 { get; set; } = new integer;
////[Description("No description available")]
////public virtual choice ChillerHeaterModulesPerformanceComponentObjectType18 { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesPerformanceComponentName18 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesControlControlScheduleName18 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual integer NumberOfChillerHeaterModules18 { get; set; } = new integer;
////[Description("No description available")]
////public virtual choice ChillerHeaterModulesPerformanceComponentObjectType19 { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesPerformanceComponentName19 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesControlScheduleName19 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual integer NumberOfChillerHeaterModules19 { get; set; } = new integer;
////[Description("No description available")]
////public virtual choice ChillerHeaterModulesPerformanceComponentObjectType20 { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesPerformanceComponentName20 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ChillerHeaterModulesControlScheduleName20 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual integer NumberOfChillerHeaterModules20 { get; set; } = new integer;
////}
////}


