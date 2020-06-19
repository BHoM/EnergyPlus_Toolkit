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
////public class GroundHeatExchanger:ResponseFactors : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:PropertiesObjectName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual integer NumberOfBoreholes { get; set; } = new integer;
////[Description("No description available")]
////public virtual real G-FunctionReferenceRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value1 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue1 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value3 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue3 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value4 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue4 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value5 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue5 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value6 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue6 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value7 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue7 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value8 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue8 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value9 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue9 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value10 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue10 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value11 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue11 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value12 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue12 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value13 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue13 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value14 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue14 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value15 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue15 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value16 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue16 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value17 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue17 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value18 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue18 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value19 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue19 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value20 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue20 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value21 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue21 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value22 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue22 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value23 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue23 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value24 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue24 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value25 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue25 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value26 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue26 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value27 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue27 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value28 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue28 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value29 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue29 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value30 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue30 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value31 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue31 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value32 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue32 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value33 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue33 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value34 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue34 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value35 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue35 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value36 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue36 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value37 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue37 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value38 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue38 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value39 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue39 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value40 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue40 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value41 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue41 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value42 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue42 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value43 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue43 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value44 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue44 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value45 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue45 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value46 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue46 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value47 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue47 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value48 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue48 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value49 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue49 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value50 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue50 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value51 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue51 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value52 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue52 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value53 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue53 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value54 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue54 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value55 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue55 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value56 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue56 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value57 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue57 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value58 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue58 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value59 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue59 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value60 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue60 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value61 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue61 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value62 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue62 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value63 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue63 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value64 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue64 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value65 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue65 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value66 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue66 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value67 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue67 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value68 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue68 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value69 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue69 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value70 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue70 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value71 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue71 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value72 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue72 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value73 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue73 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value74 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue74 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value75 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue75 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value76 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue76 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value77 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue77 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value78 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue78 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value79 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue79 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value80 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue80 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value81 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue81 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value82 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue82 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value83 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue83 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value84 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue84 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value85 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue85 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value86 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue86 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value87 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue87 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value88 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue88 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value89 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue89 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value90 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue90 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value91 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue91 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value92 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue92 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value93 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue93 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value94 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue94 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value95 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue95 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value96 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue96 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value97 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue97 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value98 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue98 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value99 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue99 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionLn(T/Ts)Value100 { get; set; } = new real;
////[Description("No description available")]
////public virtual real G-FunctionGValue100 { get; set; } = new real;
////}
////}
