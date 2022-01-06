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
////public class Sizing:System : BHoMObject
////{
////[Description("No description available")]
////public virtual object-list AirLoopName { get; set; } = new object-list;
////[Description("Specifies the basis for sizing the system supply air flow rate")]
////public virtual choice TypeOfLoadToSizeOn { get; set; } = new choice;
////[Description("No description available")]
////public virtual real DesignOutdoorAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real CentralHeatingMaximumSystemAirFlowRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real PreheatDesignTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual real PreheatDesignHumidityRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real PrecoolDesignTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual real PrecoolDesignHumidityRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real CentralCoolingDesignSupplyAirTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual real CentralHeatingDesignSupplyAirTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual choice TypeOfZoneSumToUse { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice 100%OutdoorAirInCooling { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice 100%OutdoorAirInHeating { get; set; } = new choice;
////[Description("No description available")]
////public virtual real CentralCoolingDesignSupplyAirHumidityRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real CentralHeatingDesignSupplyAirHumidityRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual choice CoolingSupplyAirFlowRateMethod { get; set; } = new choice;
////[Description("This input is used if Cooling Supply Air Flow Rate Method is Flow/System")]
////public virtual real CoolingSupplyAirFlowRate { get; set; } = new real;
////[Description("Enter the cooling supply air volume flow rate per total conditioned floor area.")]
////public virtual real CoolingSupplyAirFlowRatePerFloorArea { get; set; } = new real;
////[Description("Enter the supply air volume flow rate as a fraction of the cooling supply air flow rate.")]
////public virtual real CoolingFractionOfAutosizedCoolingSupplyAirFlowRate { get; set; } = new real;
////[Description("Enter the supply air volume flow rate per unit cooling capacity.")]
////public virtual real CoolingSupplyAirFlowRatePerUnitCoolingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual choice HeatingSupplyAirFlowRateMethod { get; set; } = new choice;
////[Description("Required field when Heating Supply Air Flow Rate Method is Flow/System")]
////public virtual real HeatingSupplyAirFlowRate { get; set; } = new real;
////[Description("Enter the heating supply air volume flow rate per total conditioned floor area.")]
////public virtual real HeatingSupplyAirFlowRatePerFloorArea { get; set; } = new real;
////[Description("Enter the supply air volume flow rate as a fraction of the heating supply air flow rate.")]
////public virtual real HeatingFractionOfAutosizedHeatingSupplyAirFlowRate { get; set; } = new real;
////[Description("Enter the supply air volume flow rate as a fraction of the cooling supply air flow rate.")]
////public virtual real HeatingFractionOfAutosizedCoolingSupplyAirFlowRate { get; set; } = new real;
////[Description("Enter the heating supply air volume flow rate per unit heating capacity.")]
////public virtual real HeatingSupplyAirFlowRatePerUnitHeatingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual choice SystemOutdoorAirMethod { get; set; } = new choice;
////[Description("No description available")]
////public virtual real ZoneMaximumOutdoorAirFraction { get; set; } = new real;
////[Description("Enter the method used to determine the system cooling design capacity for scalable sizing.")]
////public virtual choice CoolingDesignCapacityMethod { get; set; } = new choice;
////[Description("Enter the design cooling capacity.")]
////public virtual real CoolingDesignCapacity { get; set; } = new real;
////[Description("Enter the cooling design capacity per total floor area of cooled zones served by an airloop.")]
////public virtual real CoolingDesignCapacityPerFloorArea { get; set; } = new real;
////[Description("Enter the fraction of auto-sized cooling design capacity. Required field when the cooling")]
////public virtual real FractionOfAutosizedCoolingDesignCapacity { get; set; } = new real;
////[Description("Enter the method used to determine the heating design capacity for scalable sizing.")]
////public virtual choice HeatingDesignCapacityMethod { get; set; } = new choice;
////[Description("Enter the design heating capacity.")]
////public virtual real HeatingDesignCapacity { get; set; } = new real;
////[Description("Enter the heating design capacity per zone floor area. Required field when the heating design")]
////public virtual real HeatingDesignCapacityPerFloorArea { get; set; } = new real;
////[Description("Enter the fraction of auto-sized heating design capacity. Required field when capacity the")]
////public virtual real FractionOfAutosizedHeatingDesignCapacity { get; set; } = new real;
////[Description("Method used to control the coil's output")]
////public virtual choice CentralCoolingCapacityControlMethod { get; set; } = new choice;
////}
////}


