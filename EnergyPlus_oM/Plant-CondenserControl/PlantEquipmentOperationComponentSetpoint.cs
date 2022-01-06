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

//using BH.oM.Base;
//using System.Collections.Generic;
//using System.ComponentModel;
//
//namespace BH.oM.Adapters.EnergyPlus
//{
//public class PlantEquipmentOperation:ComponentSetpoint : BHoMObject
//{
//[Description("No description available")]
//public virtual null Name { get; set; } = new null;
//[Description("No description available")]
//public virtual alpha Equipment1ObjectType { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha Equipment1Name { get; set; } = new alpha;
//[Description("No description available")]
//public virtual node DemandCalculation1NodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual node Setpoint1NodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual real Component1FlowRate { get; set; } = new real;
//[Description("No description available")]
//public virtual choice Operation1Type { get; set; } = new choice;
//[Description("No description available")]
//public virtual alpha Equipment2ObjectType { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha Equipment2Name { get; set; } = new alpha;
//[Description("No description available")]
//public virtual node DemandCalculation2NodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual node Setpoint2NodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual real Component2FlowRate { get; set; } = new real;
//[Description("No description available")]
//public virtual choice Operation2Type { get; set; } = new choice;
//[Description("No description available")]
//public virtual alpha Equipment3ObjectType { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha Equipment3Name { get; set; } = new alpha;
//[Description("No description available")]
//public virtual node DemandCalculation3NodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual node Setpoint3NodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual real Component3FlowRate { get; set; } = new real;
//[Description("No description available")]
//public virtual choice Operation3Type { get; set; } = new choice;
//[Description("No description available")]
//public virtual alpha Equipment4ObjectType { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha Equipment4Name { get; set; } = new alpha;
//[Description("No description available")]
//public virtual node DemandCalculation4NodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual node Setpoint4NodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual real Component4FlowRate { get; set; } = new real;
//[Description("No description available")]
//public virtual choice Operation4Type { get; set; } = new choice;
//[Description("No description available")]
//public virtual alpha Equipment5ObjectType { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha Equipment5Name { get; set; } = new alpha;
//[Description("No description available")]
//public virtual node DemandCalculation5NodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual node Setpoint5NodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual real Component5FlowRate { get; set; } = new real;
//[Description("No description available")]
//public virtual choice Operation5Type { get; set; } = new choice;
//[Description("No description available")]
//public virtual alpha Equipment6ObjectType { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha Equipment6Name { get; set; } = new alpha;
//[Description("No description available")]
//public virtual node DemandCalculation6NodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual node Setpoint6NodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual real Component6FlowRate { get; set; } = new real;
//[Description("No description available")]
//public virtual choice Operation6Type { get; set; } = new choice;
//[Description("No description available")]
//public virtual alpha Equipment7ObjectType { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha Equipment7Name { get; set; } = new alpha;
//[Description("No description available")]
//public virtual node DemandCalculation7NodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual node Setpoint7NodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual real Component7FlowRate { get; set; } = new real;
//[Description("No description available")]
//public virtual choice Operation7Type { get; set; } = new choice;
//[Description("No description available")]
//public virtual alpha Equipment8ObjectType { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha Equipment8Name { get; set; } = new alpha;
//[Description("No description available")]
//public virtual node DemandCalculation8NodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual node Setpoint8NodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual real Component8FlowRate { get; set; } = new real;
//[Description("No description available")]
//public virtual choice Operation8Type { get; set; } = new choice;
//[Description("No description available")]
//public virtual alpha Equipment9ObjectType { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha Equipment9Name { get; set; } = new alpha;
//[Description("No description available")]
//public virtual node DemandCalculation9NodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual node Setpoint9NodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual real Component9FlowRate { get; set; } = new real;
//[Description("No description available")]
//public virtual choice Operation9Type { get; set; } = new choice;
//[Description("No description available")]
//public virtual alpha Equipment10ObjectType { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha Equipment10Name { get; set; } = new alpha;
//[Description("No description available")]
//public virtual node DemandCalculation10NodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual node Setpoint10NodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual real Component10FlowRate { get; set; } = new real;
//[Description("No description available")]
//public virtual choice Operation10Type { get; set; } = new choice;
//}
//}


