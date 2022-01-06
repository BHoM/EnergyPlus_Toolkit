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
//public class Connector:Mixer : BHoMObject
//{
//[Description("No description available")]
//public virtual null Name { get; set; } = new null;
//[Description("No description available")]
//public virtual object-list OutletBranchName { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch1Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch2Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch3Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch4Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch5Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch6Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch7Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch8Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch9Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch10Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch11Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch12Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch13Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch14Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch15Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch16Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch17Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch18Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch19Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch20Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch21Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch22Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch23Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch24Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch25Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch26Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch27Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch28Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch29Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch30Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch31Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch32Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch33Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch34Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch35Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch36Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch37Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch38Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch39Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch40Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch41Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch42Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch43Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch44Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch45Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch46Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch47Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch48Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch49Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch50Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch51Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch52Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch53Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch54Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch55Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch56Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch57Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch58Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch59Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch60Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch61Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch62Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch63Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch64Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch65Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch66Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch67Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch68Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch69Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch70Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch71Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch72Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch73Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch74Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch75Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch76Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch77Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch78Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch79Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch80Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch81Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch82Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch83Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch84Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch85Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch86Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch87Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch88Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch89Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch90Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch91Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch92Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch93Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch94Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch95Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch96Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch97Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch98Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch99Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch100Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch101Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch102Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch103Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch104Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch105Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch106Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch107Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch108Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch109Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch110Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch111Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch112Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch113Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch114Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch115Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch116Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch117Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch118Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch119Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch120Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch121Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch122Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch123Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch124Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch125Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch126Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch127Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch128Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch129Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch130Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch131Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch132Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch133Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch134Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch135Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch136Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch137Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch138Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch139Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch140Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch141Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch142Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch143Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch144Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch145Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch146Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch147Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch148Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch149Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch150Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch151Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch152Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch153Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch154Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch155Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch156Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch157Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch158Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch159Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch160Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch161Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch162Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch163Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch164Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch165Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch166Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch167Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch168Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch169Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch170Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch171Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch172Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch173Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch174Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch175Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch176Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch177Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch178Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch179Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch180Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch181Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch182Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch183Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch184Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch185Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch186Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch187Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch188Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch189Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch190Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch191Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch192Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch193Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch194Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch195Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch196Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch197Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch198Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch199Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch200Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch201Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch202Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch203Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch204Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch205Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch206Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch207Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch208Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch209Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch210Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch211Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch212Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch213Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch214Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch215Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch216Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch217Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch218Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch219Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch220Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch221Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch222Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch223Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch224Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch225Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch226Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch227Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch228Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch229Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch230Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch231Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch232Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch233Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch234Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch235Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch236Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch237Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch238Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch239Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch240Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch241Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch242Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch243Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch244Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch245Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch246Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch247Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch248Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch249Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch250Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch251Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch252Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch253Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch254Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch255Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch256Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch257Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch258Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch259Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch260Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch261Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch262Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch263Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch264Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch265Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch266Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch267Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch268Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch269Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch270Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch271Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch272Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch273Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch274Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch275Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch276Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch277Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch278Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch279Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch280Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch281Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch282Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch283Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch284Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch285Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch286Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch287Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch288Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch289Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch290Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch291Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch292Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch293Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch294Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch295Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch296Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch297Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch298Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch299Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch300Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch301Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch302Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch303Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch304Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch305Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch306Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch307Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch308Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch309Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch310Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch311Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch312Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch313Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch314Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch315Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch316Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch317Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch318Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch319Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch320Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch321Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch322Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch323Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch324Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch325Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch326Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch327Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch328Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch329Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch330Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch331Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch332Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch333Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch334Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch335Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch336Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch337Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch338Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch339Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch340Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch341Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch342Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch343Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch344Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch345Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch346Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch347Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch348Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch349Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch350Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch351Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch352Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch353Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch354Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch355Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch356Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch357Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch358Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch359Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch360Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch361Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch362Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch363Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch364Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch365Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch366Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch367Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch368Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch369Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch370Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch371Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch372Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch373Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch374Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch375Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch376Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch377Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch378Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch379Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch380Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch381Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch382Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch383Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch384Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch385Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch386Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch387Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch388Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch389Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch390Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch391Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch392Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch393Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch394Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch395Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch396Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch397Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch398Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch399Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch400Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch401Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch402Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch403Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch404Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch405Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch406Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch407Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch408Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch409Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch410Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch411Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch412Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch413Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch414Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch415Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch416Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch417Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch418Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch419Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch420Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch421Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch422Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch423Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch424Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch425Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch426Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch427Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch428Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch429Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch430Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch431Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch432Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch433Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch434Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch435Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch436Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch437Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch438Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch439Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch440Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch441Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch442Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch443Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch444Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch445Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch446Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch447Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch448Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch449Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch450Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch451Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch452Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch453Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch454Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch455Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch456Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch457Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch458Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch459Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch460Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch461Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch462Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch463Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch464Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch465Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch466Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch467Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch468Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch469Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch470Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch471Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch472Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch473Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch474Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch475Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch476Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch477Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch478Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch479Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch480Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch481Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch482Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch483Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch484Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch485Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch486Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch487Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch488Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch489Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch490Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch491Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch492Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch493Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch494Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch495Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch496Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch497Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch498Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch499Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list InletBranch500Name { get; set; } = new object-list;
//}
//}


