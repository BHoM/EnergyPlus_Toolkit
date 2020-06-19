/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2020, the respective contributors. All rights reserved.
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
////namespace BH.oM.EnergyPlus
////{
////public class DesignSpecification:ZoneHVAC:Sizing : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Enter the method used to determine the cooling supply air volume flow rate.")]
////public virtual choice CoolingSupplyAirFlowRateMethod { get; set; } = new choice;
////[Description("Enter the magnitude of supply air volume flow rate during cooling operation.")]
////public virtual real CoolingSupplyAirFlowRate { get; set; } = new real;
////[Description("Enter the cooling supply air volume flow rate per total conditioned floor area.")]
////public virtual real CoolingSupplyAirFlowRatePerFloorArea { get; set; } = new real;
////[Description("Enter the supply air volume flow rate as a fraction of the cooling supply air flow rate.")]
////public virtual real CoolingFractionOfAutosizedCoolingSupplyAirFlowRate { get; set; } = new real;
////[Description("Enter the cooling supply air volume flow rate unit cooling capacity.")]
////public virtual real CoolingSupplyAirFlowRatePerUnitCoolingCapacity { get; set; } = new real;
////[Description("Enter the method used to determine the supply air volume flow rate When No Cooling or Heating")]
////public virtual choice NoLoadSupplyAirFlowRateMethod { get; set; } = new choice;
////[Description("Enter the magnitude of the supply air volume flow rate during when no cooling or heating")]
////public virtual real NoLoadSupplyAirFlowRate { get; set; } = new real;
////[Description("Enter the supply air volume flow rate per total floor area.")]
////public virtual real NoLoadSupplyAirFlowRatePerFloorArea { get; set; } = new real;
////[Description("Enter the supply air volume flow rate as a fraction of the cooling supply air flow rate.")]
////public virtual real NoLoadFractionOfCoolingSupplyAirFlowRate { get; set; } = new real;
////[Description("Enter the supply air volume flow rate as a fraction of the heating supply air flow rate.")]
////public virtual real NoLoadFractionOfHeatingSupplyAirFlowRate { get; set; } = new real;
////[Description("Enter the method used to determine the heating supply air volume flow rate.")]
////public virtual choice HeatingSupplyAirFlowRateMethod { get; set; } = new choice;
////[Description("Enter the magnitude of the supply air volume flow rate during heating operation.")]
////public virtual real HeatingSupplyAirFlowRate { get; set; } = new real;
////[Description("Enter the heating supply air volume flow rate per total conditioned floor area.")]
////public virtual real HeatingSupplyAirFlowRatePerFloorArea { get; set; } = new real;
////[Description("Enter the supply air volume flow rate as a fraction of the heating supply air flow rate.")]
////public virtual real HeatingFractionOfHeatingSupplyAirFlowRate { get; set; } = new real;
////[Description("Enter the supply air volume flow rate per unit heating capacity.")]
////public virtual real HeatingSupplyAirFlowRatePerUnitHeatingCapacity { get; set; } = new real;
////[Description("Enter the method used to determine the cooling design capacity for scalable sizing.")]
////public virtual choice CoolingDesignCapacityMethod { get; set; } = new choice;
////[Description("Enter the design cooling capacity. Required field when the cooling design capacity method")]
////public virtual real CoolingDesignCapacity { get; set; } = new real;
////[Description("Enter the cooling design capacity per zone floor area. Required field when the cooling design")]
////public virtual real CoolingDesignCapacityPerFloorArea { get; set; } = new real;
////[Description("Enter the fraction of auto-sized cooling design capacity. Required field when the cooling")]
////public virtual real FractionOfAutosizedCoolingDesignCapacity { get; set; } = new real;
////[Description("Enter the method used to determine the heating design capacity for scalable sizing.")]
////public virtual choice HeatingDesignCapacityMethod { get; set; } = new choice;
////[Description("Enter the design heating capacity. Required field when the heating design capacity method")]
////public virtual real HeatingDesignCapacity { get; set; } = new real;
////[Description("Enter the heating design capacity per zone floor area. Required field when the heating design")]
////public virtual real HeatingDesignCapacityPerFloorArea { get; set; } = new real;
////[Description("Enter the fraction of auto-sized heating design capacity. Required field when capacity the")]
////public virtual real FractionOfAutosizedHeatingDesignCapacity { get; set; } = new real;
////}
////}
