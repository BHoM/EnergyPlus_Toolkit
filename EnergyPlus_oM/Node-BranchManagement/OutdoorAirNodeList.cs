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
//public class OutdoorAir:NodeList : BHoMObject
//{
//[Description("No description available")]
//public virtual node NodeOrNodeListName1 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName2 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName3 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName4 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName5 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName6 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName7 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName8 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName9 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName10 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName11 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName12 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName13 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName14 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName15 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName16 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName17 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName18 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName19 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName20 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName21 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName22 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName23 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName24 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName25 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName26 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName27 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName28 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName29 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName30 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName31 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName32 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName33 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName34 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName35 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName36 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName37 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName38 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName39 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName40 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName41 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName42 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName43 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName44 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName45 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName46 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName47 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName48 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName49 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName50 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName51 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName52 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName53 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName54 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName55 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName56 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName57 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName58 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName59 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName60 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName61 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName62 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName63 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName64 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName65 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName66 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName67 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName68 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName69 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName70 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName71 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName72 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName73 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName74 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName75 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName76 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName77 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName78 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName79 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName80 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName81 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName82 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName83 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName84 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName85 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName86 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName87 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName88 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName89 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName90 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName91 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName92 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName93 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName94 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName95 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName96 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName97 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName98 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName99 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName100 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName101 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName102 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName103 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName104 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName105 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName106 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName107 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName108 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName109 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName110 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName111 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName112 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName113 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName114 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName115 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName116 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName117 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName118 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName119 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName120 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName121 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName122 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName123 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName124 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName125 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName126 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName127 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName128 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName129 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName130 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName131 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName132 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName133 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName134 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName135 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName136 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName137 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName138 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName139 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName140 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName141 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName142 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName143 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName144 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName145 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName146 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName147 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName148 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName149 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName150 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName151 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName152 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName153 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName154 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName155 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName156 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName157 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName158 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName159 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName160 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName161 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName162 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName163 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName164 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName165 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName166 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName167 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName168 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName169 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName170 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName171 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName172 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName173 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName174 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName175 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName176 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName177 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName178 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName179 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName180 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName181 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName182 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName183 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName184 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName185 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName186 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName187 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName188 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName189 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName190 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName191 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName192 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName193 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName194 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName195 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName196 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName197 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName198 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName199 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName200 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName201 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName202 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName203 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName204 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName205 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName206 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName207 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName208 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName209 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName210 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName211 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName212 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName213 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName214 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName215 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName216 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName217 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName218 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName219 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName220 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName221 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName222 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName223 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName224 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName225 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName226 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName227 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName228 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName229 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName230 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName231 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName232 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName233 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName234 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName235 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName236 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName237 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName238 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName239 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName240 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName241 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName242 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName243 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName244 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName245 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName246 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName247 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName248 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName249 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName250 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName251 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName252 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName253 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName254 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName255 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName256 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName257 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName258 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName259 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName260 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName261 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName262 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName263 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName264 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName265 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName266 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName267 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName268 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName269 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName270 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName271 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName272 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName273 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName274 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName275 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName276 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName277 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName278 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName279 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName280 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName281 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName282 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName283 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName284 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName285 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName286 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName287 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName288 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName289 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName290 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName291 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName292 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName293 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName294 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName295 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName296 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName297 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName298 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName299 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName300 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName301 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName302 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName303 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName304 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName305 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName306 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName307 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName308 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName309 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName310 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName311 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName312 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName313 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName314 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName315 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName316 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName317 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName318 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName319 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName320 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName321 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName322 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName323 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName324 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName325 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName326 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName327 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName328 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName329 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName330 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName331 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName332 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName333 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName334 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName335 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName336 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName337 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName338 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName339 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName340 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName341 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName342 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName343 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName344 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName345 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName346 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName347 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName348 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName349 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName350 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName351 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName352 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName353 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName354 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName355 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName356 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName357 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName358 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName359 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName360 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName361 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName362 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName363 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName364 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName365 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName366 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName367 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName368 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName369 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName370 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName371 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName372 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName373 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName374 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName375 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName376 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName377 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName378 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName379 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName380 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName381 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName382 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName383 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName384 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName385 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName386 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName387 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName388 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName389 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName390 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName391 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName392 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName393 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName394 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName395 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName396 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName397 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName398 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName399 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName400 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName401 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName402 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName403 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName404 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName405 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName406 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName407 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName408 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName409 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName410 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName411 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName412 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName413 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName414 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName415 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName416 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName417 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName418 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName419 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName420 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName421 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName422 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName423 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName424 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName425 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName426 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName427 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName428 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName429 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName430 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName431 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName432 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName433 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName434 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName435 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName436 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName437 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName438 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName439 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName440 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName441 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName442 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName443 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName444 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName445 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName446 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName447 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName448 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName449 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName450 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName451 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName452 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName453 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName454 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName455 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName456 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName457 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName458 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName459 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName460 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName461 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName462 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName463 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName464 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName465 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName466 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName467 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName468 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName469 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName470 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName471 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName472 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName473 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName474 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName475 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName476 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName477 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName478 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName479 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName480 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName481 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName482 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName483 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName484 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName485 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName486 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName487 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName488 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName489 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName490 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName491 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName492 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName493 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName494 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName495 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName496 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName497 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName498 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName499 { get; set; } = new node;
//[Description("No description available")]
//public virtual node NodeOrNodeListName500 { get; set; } = new node;
//}
//}


