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
////public class ZoneHVAC:EquipmentList : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("No description available")]
////public virtual choice LoadDistributionScheme { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice ZoneEquipment1ObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ZoneEquipment1Name { get; set; } = new object-list;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment1CoolingSequence { get; set; } = new integer;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment1HeatingOrNo-LoadSequence { get; set; } = new integer;
////[Description("The fraction of the remaining cooling load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment1SequentialCoolingFractionScheduleName { get; set; } = new object-list;
////[Description("The fraction of the remaining heating load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment1SequentialHeatingFractionScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice ZoneEquipment2ObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ZoneEquipment2Name { get; set; } = new object-list;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment2CoolingSequence { get; set; } = new integer;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment2HeatingOrNo-LoadSequence { get; set; } = new integer;
////[Description("The fraction of the remaining cooling load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment2SequentialCoolingFractionScheduleName { get; set; } = new object-list;
////[Description("The fraction of the remaining heating load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment2SequentialHeatingFractionScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice ZoneEquipment3ObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ZoneEquipment3Name { get; set; } = new object-list;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment3CoolingSequence { get; set; } = new integer;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment3HeatingOrNo-LoadSequence { get; set; } = new integer;
////[Description("The fraction of the remaining cooling load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment3SequentialCoolingFractionScheduleName { get; set; } = new object-list;
////[Description("The fraction of the remaining heating load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment3SequentialHeatingFractionScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice ZoneEquipment4ObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ZoneEquipment4Name { get; set; } = new object-list;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment4CoolingSequence { get; set; } = new integer;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment4HeatingOrNo-LoadSequence { get; set; } = new integer;
////[Description("The fraction of the remaining cooling load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment4SequentialCoolingFractionScheduleName { get; set; } = new object-list;
////[Description("The fraction of the remaining heating load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment4SequentialHeatingFractionScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice ZoneEquipment5ObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ZoneEquipment5Name { get; set; } = new object-list;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment5CoolingSequence { get; set; } = new integer;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment5HeatingOrNo-LoadSequence { get; set; } = new integer;
////[Description("The fraction of the remaining cooling load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment5SequentialCoolingFractionScheduleName { get; set; } = new object-list;
////[Description("The fraction of the remaining heating load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment5SequentialHeatingFractionScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice ZoneEquipment6ObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ZoneEquipment6Name { get; set; } = new object-list;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment6CoolingSequence { get; set; } = new integer;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment6HeatingOrNo-LoadSequence { get; set; } = new integer;
////[Description("The fraction of the remaining cooling load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment6SequentialCoolingFractionScheduleName { get; set; } = new object-list;
////[Description("The fraction of the remaining heating load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment6SequentialHeatingFractionScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice ZoneEquipment7ObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ZoneEquipment7Name { get; set; } = new object-list;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment7CoolingSequence { get; set; } = new integer;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment7HeatingOrNo-LoadSequence { get; set; } = new integer;
////[Description("The fraction of the remaining cooling load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment7SequentialCoolingFractionScheduleName { get; set; } = new object-list;
////[Description("The fraction of the remaining heating load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment7SequentialHeatingFractionScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice ZoneEquipment8ObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ZoneEquipment8Name { get; set; } = new object-list;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment8CoolingSequence { get; set; } = new integer;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment8HeatingOrNo-LoadSequence { get; set; } = new integer;
////[Description("The fraction of the remaining cooling load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment8SequentialCoolingFractionScheduleName { get; set; } = new object-list;
////[Description("The fraction of the remaining heating load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment8SequentialHeatingFractionScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice ZoneEquipment9ObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ZoneEquipment9Name { get; set; } = new object-list;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment9CoolingSequence { get; set; } = new integer;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment9HeatingOrNo-LoadSequence { get; set; } = new integer;
////[Description("The fraction of the remaining cooling load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment9SequentialCoolingFractionScheduleName { get; set; } = new object-list;
////[Description("The fraction of the remaining heating load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment9SequentialHeatingFractionScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice ZoneEquipment10ObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ZoneEquipment10Name { get; set; } = new object-list;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment10CoolingSequence { get; set; } = new integer;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment10HeatingOrNo-LoadSequence { get; set; } = new integer;
////[Description("The fraction of the remaining cooling load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment10SequentialCoolingFractionScheduleName { get; set; } = new object-list;
////[Description("The fraction of the remaining heating load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment10SequentialHeatingFractionScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice ZoneEquipment11ObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ZoneEquipment11Name { get; set; } = new object-list;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment11CoolingSequence { get; set; } = new integer;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment11HeatingOrNo-LoadSequence { get; set; } = new integer;
////[Description("The fraction of the remaining cooling load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment11SequentialCoolingFractionScheduleName { get; set; } = new object-list;
////[Description("The fraction of the remaining heating load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment11SequentialHeatingFractionScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice ZoneEquipment12ObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ZoneEquipment12Name { get; set; } = new object-list;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment12CoolingSequence { get; set; } = new integer;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment12HeatingOrNo-LoadSequence { get; set; } = new integer;
////[Description("The fraction of the remaining cooling load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment12SequentialCoolingFractionScheduleName { get; set; } = new object-list;
////[Description("The fraction of the remaining heating load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment12SequentialHeatingFractionScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice ZoneEquipment13ObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ZoneEquipment13Name { get; set; } = new object-list;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment13CoolingSequence { get; set; } = new integer;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment13HeatingOrNo-LoadSequence { get; set; } = new integer;
////[Description("The fraction of the remaining cooling load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment13SequentialCoolingFractionScheduleName { get; set; } = new object-list;
////[Description("The fraction of the remaining heating load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment13SequentialHeatingFractionScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice ZoneEquipment14ObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ZoneEquipment14Name { get; set; } = new object-list;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment14CoolingSequence { get; set; } = new integer;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment14HeatingOrNo-LoadSequence { get; set; } = new integer;
////[Description("The fraction of the remaining cooling load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment14SequentialCoolingFractionScheduleName { get; set; } = new object-list;
////[Description("The fraction of the remaining heating load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment14SequentialHeatingFractionScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice ZoneEquipment15ObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ZoneEquipment15Name { get; set; } = new object-list;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment15CoolingSequence { get; set; } = new integer;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment15HeatingOrNo-LoadSequence { get; set; } = new integer;
////[Description("The fraction of the remaining cooling load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment15SequentialCoolingFractionScheduleName { get; set; } = new object-list;
////[Description("The fraction of the remaining heating load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment15SequentialHeatingFractionScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice ZoneEquipment16ObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ZoneEquipment16Name { get; set; } = new object-list;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment16CoolingSequence { get; set; } = new integer;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment16HeatingOrNo-LoadSequence { get; set; } = new integer;
////[Description("The fraction of the remaining cooling load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment16SequentialCoolingFractionScheduleName { get; set; } = new object-list;
////[Description("The fraction of the remaining heating load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment16SequentialHeatingFractionScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice ZoneEquipment17ObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ZoneEquipment17Name { get; set; } = new object-list;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment17CoolingSequence { get; set; } = new integer;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment17HeatingOrNo-LoadSequence { get; set; } = new integer;
////[Description("The fraction of the remaining cooling load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment17SequentialCoolingFractionScheduleName { get; set; } = new object-list;
////[Description("The fraction of the remaining heating load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment17SequentialHeatingFractionScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice ZoneEquipment18ObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ZoneEquipment18Name { get; set; } = new object-list;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment18CoolingSequence { get; set; } = new integer;
////[Description("Specifies the zone equipment simulation order")]
////public virtual integer ZoneEquipment18HeatingOrNo-LoadSequence { get; set; } = new integer;
////[Description("The fraction of the remaining cooling load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment18SequentialCoolingFractionScheduleName { get; set; } = new object-list;
////[Description("The fraction of the remaining heating load this equipment will attempt to serve")]
////public virtual object-list ZoneEquipment18SequentialHeatingFractionScheduleName { get; set; } = new object-list;
////}
////}



