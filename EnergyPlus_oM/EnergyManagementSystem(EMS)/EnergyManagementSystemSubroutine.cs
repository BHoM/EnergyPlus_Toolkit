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

//using BH.oM.Base;
//using System.Collections.Generic;
//using System.ComponentModel;
//
//namespace BH.oM.EnergyPlus
//{
//public class EnergyManagementSystem:Subroutine : BHoMObject
//{
//[Description("no spaces allowed in name")]
//public virtual alpha Name { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine1 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine2 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine3 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine4 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine5 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine6 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine7 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine8 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine9 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine10 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine11 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine12 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine13 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine14 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine15 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine16 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine17 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine18 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine19 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine20 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine21 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine22 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine23 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine24 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine25 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine26 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine27 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine28 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine29 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine30 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine31 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine32 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine33 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine34 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine35 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine36 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine37 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine38 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine39 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine40 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine41 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine42 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine43 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine44 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine45 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine46 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine47 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine48 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine49 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine50 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine51 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine52 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine53 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine54 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine55 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine56 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine57 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine58 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine59 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine60 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine61 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine62 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine63 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine64 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine65 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine66 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine67 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine68 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine69 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine70 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine71 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine72 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine73 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine74 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine75 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine76 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine77 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine78 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine79 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine80 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine81 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine82 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine83 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine84 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine85 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine86 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine87 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine88 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine89 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine90 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine91 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine92 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine93 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine94 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine95 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine96 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine97 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine98 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine99 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine100 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine101 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine102 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine103 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine104 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine105 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine106 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine107 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine108 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine109 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine110 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine111 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine112 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine113 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine114 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine115 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine116 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine117 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine118 { get; set; } = new alpha;
//[Description("No description available")]
//public virtual alpha ProgramLine119 { get; set; } = new alpha;
//}
//}
