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
////public class PlantComponent:UserDefined : BHoMObject
////{
////[Description("This is the name of the plant component")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual object-list MainModelProgramCallingManagerName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual integer NumberOfPlantLoopConnections { get; set; } = new integer;
////[Description("No description available")]
////public virtual node PlantConnection1InletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node PlantConnection1OutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual choice PlantConnection1LoadingMode { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PlantConnection1LoopFlowRequestMode { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list PlantConnection1InitializationProgramCallingManagerName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list PlantConnection1SimulationProgramCallingManagerName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node PlantConnection2InletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node PlantConnection2OutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual choice PlantConnection2LoadingMode { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PlantConnection2LoopFlowRequestMode { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list PlantConnection2InitializationProgramCallingManagerName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list PlantConnection2SimulationProgramCallingManagerName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node PlantConnection3InletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node PlantConnection3OutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual choice PlantConnection3LoadingMode { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PlantConnection3LoopFlowRequestMode { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list PlantConnection3InitializationProgramCallingManagerName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list PlantConnection3SimulationProgramCallingManagerName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node PlantConnection4InletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node PlantConnection4OutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual choice PlantConnection4LoadingMode { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PlantConnection4LoopFlowRequestMode { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list PlantConnection4InitializationProgramCallingManagerName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list PlantConnection4SimulationProgramCallingManagerName { get; set; } = new object-list;
////[Description("Inlet air used for heat rejection or air source")]
////public virtual node AirConnectionInletNodeName { get; set; } = new node;
////[Description("Outlet air used for heat rejection or air source")]
////public virtual node AirConnectionOutletNodeName { get; set; } = new node;
////[Description("Water use storage tank for alternate source of water consumed by device")]
////public virtual object-list SupplyInletWaterStorageTankName { get; set; } = new object-list;
////[Description("Water use storage tank for collection of condensate by device")]
////public virtual object-list CollectionOutletWaterStorageTankName { get; set; } = new object-list;
////[Description("Used for modeling device losses to surrounding zone")]
////public virtual object-list AmbientZoneName { get; set; } = new object-list;
////}
////}
