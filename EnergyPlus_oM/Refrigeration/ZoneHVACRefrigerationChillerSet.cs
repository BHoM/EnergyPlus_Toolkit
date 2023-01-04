/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2023, the respective contributors. All rights reserved.
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
////public class ZoneHVAC:RefrigerationChillerSet : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("This must be a controlled zone and appear in a ZoneHVAC:EquipmentConnections object.")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("Not used - reserved for future use")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("Not used - reserved for future use")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller1Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller2Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller3Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller4Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller5Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller6Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller7Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller8Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller9Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller10Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller11Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller12Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller13Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller14Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller15Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller16Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller17Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller18Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller19Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller20Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller21Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller22Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller23Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller24Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller25Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller26Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller27Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller28Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller29Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller30Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller31Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller32Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller33Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller34Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller35Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller36Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller37Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller38Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller39Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller40Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller41Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller42Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller43Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller44Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller45Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller46Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller47Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller48Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller49Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller50Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller51Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller52Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller53Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller54Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller55Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller56Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller57Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller58Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller59Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller60Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller61Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller62Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller63Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller64Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller65Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller66Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller67Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller68Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller69Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller70Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller71Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller72Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller73Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller74Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller75Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller76Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller77Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller78Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller79Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller80Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller81Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller82Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller83Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller84Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller85Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller86Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller87Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller88Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller89Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller90Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller91Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller92Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller93Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller94Name { get; set; } = new object-list;
////[Description("This is the first chiller turned on to meet the zone load")]
////public virtual object-list AirChiller95Name { get; set; } = new object-list;
////}
////}



