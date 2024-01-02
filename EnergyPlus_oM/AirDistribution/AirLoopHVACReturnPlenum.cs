/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2024, the respective contributors. All rights reserved.
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
////public class AirLoopHVAC:ReturnPlenum : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node ZoneNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node OutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node InducedAirOutletNodeOrNodeListName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet1NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet2NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet3NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet4NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet5NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet6NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet7NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet8NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet9NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet10NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet11NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet12NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet13NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet14NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet15NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet16NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet17NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet18NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet19NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet20NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet21NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet22NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet23NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet24NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet25NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet26NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet27NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet28NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet29NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet30NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet31NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet32NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet33NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet34NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet35NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet36NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet37NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet38NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet39NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet40NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet41NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet42NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet43NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet44NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet45NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet46NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet47NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet48NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet49NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet50NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet51NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet52NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet53NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet54NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet55NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet56NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet57NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet58NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet59NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet60NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet61NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet62NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet63NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet64NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet65NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet66NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet67NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet68NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet69NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet70NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet71NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet72NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet73NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet74NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet75NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet76NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet77NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet78NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet79NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet80NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet81NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet82NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet83NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet84NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet85NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet86NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet87NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet88NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet89NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet90NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet91NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet92NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet93NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet94NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet95NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet96NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet97NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet98NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet99NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet100NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet101NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet102NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet103NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet104NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet105NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet106NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet107NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet108NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet109NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet110NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet111NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet112NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet113NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet114NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet115NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet116NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet117NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet118NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet119NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet120NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet121NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet122NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet123NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet124NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet125NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet126NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet127NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet128NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet129NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet130NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet131NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet132NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet133NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet134NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet135NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet136NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet137NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet138NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet139NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet140NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet141NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet142NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet143NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet144NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet145NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet146NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet147NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet148NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet149NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet150NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet151NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet152NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet153NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet154NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet155NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet156NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet157NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet158NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet159NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet160NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet161NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet162NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet163NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet164NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet165NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet166NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet167NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet168NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet169NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet170NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet171NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet172NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet173NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet174NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet175NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet176NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet177NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet178NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet179NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet180NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet181NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet182NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet183NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet184NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet185NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet186NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet187NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet188NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet189NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet190NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet191NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet192NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet193NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet194NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet195NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet196NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet197NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet198NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet199NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet200NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet201NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet202NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet203NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet204NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet205NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet206NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet207NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet208NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet209NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet210NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet211NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet212NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet213NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet214NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet215NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet216NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet217NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet218NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet219NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet220NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet221NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet222NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet223NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet224NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet225NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet226NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet227NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet228NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet229NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet230NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet231NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet232NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet233NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet234NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet235NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet236NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet237NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet238NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet239NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet240NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet241NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet242NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet243NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet244NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet245NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet246NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet247NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet248NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet249NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet250NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet251NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet252NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet253NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet254NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet255NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet256NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet257NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet258NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet259NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet260NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet261NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet262NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet263NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet264NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet265NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet266NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet267NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet268NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet269NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet270NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet271NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet272NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet273NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet274NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet275NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet276NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet277NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet278NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet279NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet280NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet281NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet282NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet283NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet284NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet285NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet286NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet287NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet288NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet289NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet290NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet291NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet292NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet293NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet294NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet295NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet296NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet297NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet298NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet299NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet300NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet301NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet302NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet303NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet304NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet305NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet306NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet307NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet308NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet309NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet310NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet311NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet312NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet313NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet314NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet315NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet316NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet317NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet318NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet319NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet320NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet321NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet322NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet323NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet324NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet325NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet326NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet327NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet328NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet329NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet330NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet331NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet332NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet333NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet334NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet335NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet336NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet337NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet338NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet339NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet340NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet341NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet342NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet343NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet344NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet345NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet346NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet347NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet348NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet349NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet350NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet351NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet352NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet353NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet354NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet355NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet356NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet357NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet358NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet359NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet360NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet361NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet362NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet363NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet364NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet365NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet366NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet367NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet368NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet369NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet370NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet371NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet372NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet373NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet374NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet375NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet376NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet377NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet378NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet379NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet380NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet381NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet382NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet383NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet384NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet385NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet386NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet387NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet388NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet389NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet390NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet391NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet392NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet393NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet394NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet395NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet396NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet397NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet398NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet399NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet400NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet401NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet402NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet403NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet404NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet405NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet406NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet407NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet408NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet409NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet410NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet411NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet412NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet413NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet414NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet415NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet416NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet417NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet418NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet419NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet420NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet421NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet422NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet423NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet424NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet425NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet426NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet427NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet428NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet429NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet430NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet431NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet432NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet433NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet434NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet435NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet436NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet437NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet438NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet439NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet440NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet441NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet442NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet443NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet444NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet445NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet446NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet447NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet448NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet449NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet450NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet451NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet452NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet453NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet454NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet455NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet456NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet457NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet458NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet459NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet460NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet461NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet462NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet463NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet464NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet465NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet466NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet467NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet468NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet469NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet470NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet471NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet472NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet473NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet474NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet475NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet476NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet477NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet478NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet479NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet480NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet481NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet482NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet483NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet484NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet485NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet486NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet487NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet488NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet489NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet490NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet491NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet492NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet493NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet494NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet495NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet496NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet497NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet498NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet499NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Inlet500NodeName { get; set; } = new node;
////}
////}




