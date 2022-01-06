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
////public class LifeCycleCost:UsePriceEscalation : BHoMObject
////{
////[Description("The identifier used for the object. The name usually identifies the location (such as the")]
////public virtual alpha LCCPriceEscalationName { get; set; } = new alpha;
////[Description("No description available")]
////public virtual choice Resource { get; set; } = new choice;
////[Description("This field and the Escalation Start Month define the time that corresponds to Year 1 Escalation")]
////public virtual integer EscalationStartYear { get; set; } = new integer;
////[Description("This field and the Escalation Start Year define the time that corresponds to Year 1 Escalation")]
////public virtual choice EscalationStartMonth { get; set; } = new choice;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year1Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year2Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year3Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year4Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year5Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year6Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year7Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year8Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year9Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year10Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year11Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year12Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year13Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year14Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year15Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year16Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year17Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year18Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year19Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year20Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year21Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year22Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year23Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year24Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year25Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year26Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year27Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year28Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year29Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year30Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year31Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year32Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year33Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year34Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year35Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year36Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year37Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year38Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year39Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year40Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year41Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year42Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year43Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year44Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year45Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year46Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year47Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year48Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year49Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year50Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year51Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year52Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year53Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year54Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year55Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year56Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year57Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year58Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year59Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year60Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year61Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year62Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year63Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year64Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year65Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year66Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year67Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year68Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year69Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year70Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year71Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year72Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year73Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year74Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year75Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year76Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year77Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year78Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year79Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year80Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year81Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year82Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year83Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year84Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year85Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year86Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year87Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year88Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year89Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year90Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year91Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year92Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year93Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year94Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year95Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year96Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year97Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year98Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year99Escalation { get; set; } = new real;
////[Description("The escalation in price of the energy or water use for the first year expressed as a decimal.")]
////public virtual real Year100Escalation { get; set; } = new real;
////}
////}


