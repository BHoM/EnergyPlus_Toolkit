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

////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.Adapters.EnergyPlus
////{
////public class LifeCycleCost:UseAdjustment : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual choice Resource { get; set; } = new choice;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year1Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year2Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year3Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year4Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year5Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year6Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year7Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year8Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year9Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year10Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year11Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year12Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year13Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year14Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year15Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year16Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year17Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year18Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year19Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year20Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year21Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year22Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year23Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year24Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year25Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year26Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year27Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year28Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year29Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year30Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year31Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year32Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year33Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year34Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year35Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year36Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year37Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year38Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year39Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year40Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year41Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year42Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year43Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year44Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year45Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year46Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year47Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year48Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year49Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year50Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year51Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year52Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year53Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year54Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year55Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year56Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year57Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year58Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year59Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year60Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year61Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year62Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year63Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year64Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year65Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year66Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year67Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year68Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year69Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year70Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year71Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year72Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year73Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year74Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year75Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year76Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year77Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year78Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year79Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year80Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year81Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year82Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year83Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year84Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year85Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year86Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year87Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year88Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year89Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year90Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year91Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year92Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year93Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year94Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year95Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year96Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year97Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year98Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year99Multiplier { get; set; } = new real;
////[Description("The multiplier to be applied to the end-use cost for the first year in the service period.")]
////public virtual real Year100Multiplier { get; set; } = new real;
////}
////}


