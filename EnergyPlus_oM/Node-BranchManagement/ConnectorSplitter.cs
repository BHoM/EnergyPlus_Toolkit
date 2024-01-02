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

//using BH.oM.Base;
//using System.Collections.Generic;
//using System.ComponentModel;
//
//namespace BH.oM.Adapters.EnergyPlus
//{
//public class Connector:Splitter : BHoMObject
//{
//[Description("No description available")]
//public virtual null Name { get; set; } = new null;
//[Description("No description available")]
//public virtual object-list InletBranchName { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch1Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch2Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch3Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch4Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch5Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch6Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch7Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch8Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch9Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch10Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch11Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch12Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch13Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch14Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch15Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch16Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch17Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch18Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch19Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch20Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch21Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch22Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch23Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch24Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch25Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch26Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch27Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch28Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch29Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch30Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch31Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch32Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch33Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch34Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch35Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch36Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch37Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch38Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch39Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch40Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch41Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch42Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch43Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch44Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch45Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch46Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch47Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch48Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch49Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch50Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch51Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch52Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch53Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch54Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch55Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch56Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch57Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch58Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch59Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch60Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch61Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch62Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch63Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch64Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch65Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch66Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch67Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch68Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch69Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch70Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch71Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch72Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch73Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch74Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch75Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch76Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch77Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch78Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch79Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch80Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch81Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch82Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch83Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch84Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch85Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch86Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch87Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch88Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch89Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch90Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch91Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch92Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch93Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch94Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch95Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch96Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch97Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch98Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch99Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch100Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch101Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch102Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch103Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch104Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch105Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch106Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch107Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch108Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch109Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch110Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch111Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch112Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch113Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch114Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch115Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch116Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch117Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch118Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch119Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch120Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch121Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch122Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch123Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch124Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch125Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch126Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch127Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch128Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch129Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch130Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch131Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch132Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch133Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch134Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch135Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch136Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch137Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch138Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch139Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch140Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch141Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch142Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch143Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch144Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch145Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch146Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch147Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch148Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch149Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch150Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch151Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch152Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch153Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch154Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch155Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch156Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch157Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch158Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch159Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch160Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch161Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch162Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch163Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch164Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch165Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch166Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch167Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch168Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch169Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch170Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch171Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch172Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch173Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch174Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch175Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch176Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch177Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch178Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch179Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch180Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch181Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch182Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch183Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch184Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch185Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch186Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch187Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch188Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch189Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch190Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch191Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch192Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch193Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch194Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch195Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch196Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch197Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch198Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch199Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch200Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch201Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch202Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch203Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch204Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch205Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch206Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch207Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch208Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch209Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch210Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch211Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch212Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch213Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch214Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch215Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch216Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch217Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch218Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch219Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch220Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch221Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch222Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch223Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch224Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch225Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch226Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch227Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch228Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch229Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch230Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch231Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch232Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch233Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch234Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch235Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch236Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch237Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch238Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch239Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch240Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch241Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch242Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch243Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch244Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch245Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch246Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch247Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch248Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch249Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch250Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch251Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch252Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch253Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch254Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch255Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch256Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch257Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch258Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch259Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch260Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch261Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch262Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch263Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch264Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch265Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch266Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch267Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch268Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch269Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch270Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch271Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch272Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch273Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch274Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch275Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch276Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch277Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch278Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch279Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch280Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch281Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch282Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch283Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch284Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch285Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch286Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch287Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch288Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch289Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch290Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch291Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch292Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch293Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch294Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch295Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch296Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch297Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch298Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch299Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch300Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch301Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch302Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch303Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch304Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch305Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch306Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch307Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch308Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch309Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch310Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch311Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch312Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch313Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch314Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch315Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch316Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch317Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch318Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch319Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch320Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch321Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch322Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch323Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch324Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch325Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch326Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch327Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch328Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch329Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch330Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch331Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch332Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch333Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch334Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch335Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch336Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch337Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch338Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch339Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch340Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch341Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch342Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch343Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch344Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch345Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch346Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch347Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch348Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch349Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch350Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch351Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch352Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch353Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch354Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch355Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch356Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch357Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch358Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch359Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch360Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch361Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch362Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch363Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch364Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch365Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch366Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch367Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch368Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch369Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch370Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch371Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch372Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch373Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch374Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch375Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch376Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch377Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch378Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch379Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch380Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch381Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch382Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch383Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch384Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch385Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch386Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch387Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch388Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch389Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch390Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch391Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch392Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch393Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch394Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch395Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch396Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch397Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch398Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch399Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch400Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch401Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch402Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch403Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch404Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch405Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch406Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch407Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch408Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch409Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch410Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch411Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch412Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch413Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch414Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch415Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch416Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch417Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch418Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch419Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch420Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch421Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch422Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch423Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch424Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch425Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch426Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch427Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch428Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch429Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch430Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch431Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch432Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch433Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch434Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch435Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch436Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch437Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch438Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch439Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch440Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch441Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch442Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch443Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch444Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch445Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch446Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch447Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch448Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch449Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch450Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch451Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch452Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch453Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch454Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch455Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch456Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch457Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch458Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch459Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch460Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch461Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch462Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch463Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch464Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch465Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch466Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch467Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch468Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch469Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch470Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch471Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch472Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch473Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch474Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch475Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch476Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch477Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch478Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch479Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch480Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch481Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch482Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch483Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch484Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch485Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch486Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch487Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch488Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch489Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch490Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch491Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch492Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch493Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch494Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch495Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch496Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch497Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch498Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch499Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list OutletBranch500Name { get; set; } = new object-list;
//}
//}




