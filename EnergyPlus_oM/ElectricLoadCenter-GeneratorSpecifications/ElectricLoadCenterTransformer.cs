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
//public class ElectricLoadCenter:Transformer : BHoMObject
//{
//[Description("No description available")]
//public virtual null Name { get; set; } = new null;
//[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
//public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
//[Description("A transformer can be used to transfer electric energy from utility grid to")]
//public virtual choice TransformerUsage { get; set; } = new choice;
//[Description("Enter name of zone to receive transformer losses as heat")]
//public virtual object-list ZoneName { get; set; } = new object-list;
//[Description("No description available")]
//public virtual real RadiativeFraction { get; set; } = new real;
//[Description("the unit is VA, instead of kVA as usually shown on transformer nameplates.")]
//public virtual real RatedCapacity { get; set; } = new real;
//[Description("Must be single or three phase transformer.")]
//public virtual choice Phase { get; set; } = new choice;
//[Description("Winding material used by the transformer.")]
//public virtual choice ConductorMaterial { get; set; } = new choice;
//[Description("No description available")]
//public virtual real FullLoadTemperatureRise { get; set; } = new real;
//[Description("No description available")]
//public virtual real FractionOfEddyCurrentLosses { get; set; } = new real;
//[Description("User can define transformer performance by specifying")]
//public virtual choice PerformanceInputMethod { get; set; } = new choice;
//[Description("Only required when RatedLosses is the performance input method")]
//public virtual real RatedNoLoadLoss { get; set; } = new real;
//[Description("Only required when RatedLosses is the performance input method")]
//public virtual real RatedLoadLoss { get; set; } = new real;
//[Description("Only required when NominalEfficiency is the performance input method")]
//public virtual real NameplateEfficiency { get; set; } = new real;
//[Description("Percentage of the rated capacity at which the nameplate efficiency is defined")]
//public virtual real PerUnitLoadForNameplateEfficiency { get; set; } = new real;
//[Description("Conductor operating temperature at which the nameplate efficiency is defined")]
//public virtual real ReferenceTemperatureForNameplateEfficiency { get; set; } = new real;
//[Description("Percentage of the rate capacity at which the maximum efficiency is obtained")]
//public virtual real PerUnitLoadForMaximumEfficiency { get; set; } = new real;
//[Description("Only required when the transformer is used for power in from the utility grid")]
//public virtual choice ConsiderTransformerLossForUtilityCost { get; set; } = new choice;
//[Description("Must be an electric meter (with electricity as the resource type)")]
//public virtual external-list Meter1Name { get; set; } = new external-list;
//[Description("Must be an electric meter (with electricity as the resource type)")]
//public virtual external-list Meter2Name { get; set; } = new external-list;
//[Description("Must be an electric meter (with electricity as the resource type)")]
//public virtual external-list Meter3Name { get; set; } = new external-list;
//[Description("Must be an electric meter (with electricity as the resource type)")]
//public virtual external-list Meter4Name { get; set; } = new external-list;
//[Description("Must be an electric meter (with electricity as the resource type)")]
//public virtual external-list Meter5Name { get; set; } = new external-list;
//[Description("Must be an electric meter (with electricity as the resource type)")]
//public virtual external-list Meter6Name { get; set; } = new external-list;
//[Description("Must be an electric meter (with electricity as the resource type)")]
//public virtual external-list Meter7Name { get; set; } = new external-list;
//[Description("Must be an electric meter (with electricity as the resource type)")]
//public virtual external-list Meter8Name { get; set; } = new external-list;
//[Description("Must be an electric meter (with electricity as the resource type)")]
//public virtual external-list Meter9Name { get; set; } = new external-list;
//[Description("Must be an electric meter (with electricity as the resource type)")]
//public virtual external-list Meter10Name { get; set; } = new external-list;
//}
//}




