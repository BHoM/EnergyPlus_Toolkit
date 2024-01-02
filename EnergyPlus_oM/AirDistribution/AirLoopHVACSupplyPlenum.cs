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
////public class AirLoopHVAC:SupplyPlenum : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node ZoneNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node InletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet1NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet2NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet3NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet4NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet5NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet6NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet7NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet8NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet9NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet10NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet11NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet12NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet13NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet14NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet15NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet16NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet17NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet18NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet19NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet20NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet21NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet22NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet23NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet24NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet25NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet26NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet27NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet28NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet29NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet30NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet31NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet32NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet33NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet34NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet35NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet36NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet37NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet38NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet39NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet40NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet41NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet42NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet43NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet44NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet45NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet46NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet47NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet48NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet49NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet50NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet51NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet52NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet53NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet54NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet55NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet56NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet57NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet58NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet59NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet60NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet61NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet62NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet63NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet64NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet65NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet66NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet67NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet68NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet69NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet70NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet71NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet72NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet73NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet74NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet75NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet76NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet77NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet78NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet79NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet80NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet81NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet82NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet83NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet84NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet85NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet86NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet87NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet88NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet89NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet90NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet91NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet92NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet93NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet94NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet95NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet96NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet97NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet98NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet99NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet100NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet101NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet102NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet103NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet104NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet105NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet106NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet107NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet108NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet109NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet110NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet111NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet112NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet113NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet114NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet115NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet116NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet117NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet118NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet119NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet120NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet121NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet122NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet123NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet124NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet125NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet126NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet127NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet128NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet129NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet130NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet131NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet132NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet133NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet134NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet135NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet136NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet137NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet138NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet139NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet140NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet141NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet142NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet143NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet144NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet145NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet146NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet147NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet148NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet149NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet150NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet151NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet152NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet153NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet154NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet155NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet156NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet157NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet158NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet159NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet160NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet161NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet162NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet163NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet164NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet165NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet166NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet167NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet168NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet169NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet170NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet171NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet172NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet173NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet174NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet175NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet176NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet177NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet178NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet179NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet180NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet181NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet182NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet183NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet184NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet185NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet186NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet187NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet188NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet189NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet190NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet191NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet192NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet193NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet194NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet195NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet196NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet197NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet198NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet199NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet200NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet201NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet202NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet203NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet204NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet205NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet206NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet207NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet208NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet209NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet210NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet211NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet212NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet213NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet214NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet215NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet216NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet217NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet218NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet219NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet220NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet221NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet222NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet223NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet224NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet225NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet226NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet227NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet228NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet229NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet230NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet231NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet232NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet233NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet234NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet235NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet236NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet237NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet238NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet239NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet240NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet241NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet242NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet243NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet244NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet245NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet246NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet247NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet248NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet249NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet250NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet251NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet252NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet253NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet254NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet255NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet256NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet257NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet258NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet259NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet260NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet261NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet262NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet263NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet264NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet265NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet266NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet267NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet268NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet269NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet270NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet271NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet272NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet273NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet274NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet275NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet276NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet277NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet278NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet279NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet280NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet281NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet282NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet283NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet284NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet285NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet286NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet287NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet288NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet289NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet290NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet291NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet292NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet293NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet294NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet295NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet296NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet297NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet298NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet299NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet300NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet301NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet302NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet303NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet304NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet305NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet306NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet307NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet308NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet309NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet310NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet311NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet312NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet313NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet314NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet315NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet316NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet317NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet318NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet319NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet320NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet321NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet322NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet323NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet324NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet325NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet326NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet327NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet328NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet329NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet330NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet331NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet332NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet333NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet334NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet335NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet336NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet337NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet338NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet339NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet340NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet341NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet342NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet343NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet344NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet345NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet346NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet347NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet348NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet349NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet350NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet351NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet352NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet353NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet354NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet355NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet356NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet357NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet358NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet359NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet360NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet361NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet362NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet363NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet364NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet365NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet366NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet367NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet368NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet369NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet370NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet371NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet372NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet373NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet374NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet375NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet376NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet377NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet378NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet379NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet380NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet381NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet382NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet383NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet384NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet385NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet386NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet387NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet388NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet389NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet390NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet391NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet392NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet393NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet394NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet395NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet396NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet397NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet398NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet399NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet400NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet401NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet402NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet403NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet404NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet405NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet406NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet407NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet408NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet409NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet410NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet411NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet412NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet413NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet414NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet415NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet416NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet417NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet418NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet419NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet420NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet421NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet422NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet423NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet424NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet425NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet426NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet427NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet428NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet429NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet430NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet431NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet432NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet433NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet434NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet435NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet436NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet437NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet438NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet439NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet440NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet441NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet442NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet443NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet444NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet445NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet446NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet447NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet448NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet449NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet450NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet451NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet452NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet453NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet454NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet455NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet456NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet457NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet458NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet459NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet460NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet461NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet462NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet463NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet464NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet465NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet466NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet467NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet468NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet469NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet470NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet471NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet472NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet473NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet474NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet475NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet476NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet477NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet478NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet479NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet480NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet481NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet482NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet483NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet484NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet485NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet486NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet487NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet488NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet489NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet490NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet491NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet492NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet493NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet494NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet495NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet496NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet497NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet498NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet499NodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node Outlet500NodeName { get; set; } = new node;
////}
////}




