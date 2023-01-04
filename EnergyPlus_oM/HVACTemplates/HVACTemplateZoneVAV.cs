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
////public class HVACTemplate:Zone:VAV : BHoMObject
////{
////[Description("Zone name must match a building zone name")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("Name of a HVACTemplate:System:VAV or HVACTemplate:System:PackagedVAV")]
////public virtual object-list TemplateVAVSystemName { get; set; } = new object-list;
////[Description("Enter the name of a HVACTemplate:Thermostat object.")]
////public virtual object-list TemplateThermostatName { get; set; } = new object-list;
////[Description("This field may be set to "autosize". If a value is entered, it will be")]
////public virtual null SupplyAirMaximumFlowRate { get; set; } = new null;
////[Description("If blank, value from Sizing:Parameters will be used.")]
////public virtual null ZoneHeatingSizingFactor { get; set; } = new null;
////[Description("If blank, value from Sizing:Parameters will be used.")]
////public virtual null ZoneCoolingSizingFactor { get; set; } = new null;
////[Description("Constant = Constant Minimum Air Flow Fraction (a fraction of Maximum Air Flow Rate)")]
////public virtual choice ZoneMinimumAirFlowInputMethod { get; set; } = new choice;
////[Description("This field is used if the field Zone Minimum Air Flow Input Method is Constant")]
////public virtual null ConstantMinimumAirFlowFraction { get; set; } = new null;
////[Description("This field is used if the field Zone Minimum Air Flow Input Method is FixedFlowRate.")]
////public virtual real FixedMinimumAirFlowRate { get; set; } = new real;
////[Description("This field is used if the field Zone Minimum Air Flow Input Method is Scheduled")]
////public virtual object-list MinimumAirFlowFractionScheduleName { get; set; } = new object-list;
////[Description("Flow/Person, Flow/Zone, Flow/Area, Sum, and Maximum use the values in the next three")]
////public virtual choice OutdoorAirMethod { get; set; } = new choice;
////[Description("Default 0.00944 is 20 cfm per person")]
////public virtual null OutdoorAirFlowRatePerPerson { get; set; } = new null;
////[Description("This input is used if the field Outdoor Air Method is")]
////public virtual null OutdoorAirFlowRatePerZoneFloorArea { get; set; } = new null;
////[Description("This input is used if the field Outdoor Air Method is")]
////public virtual real OutdoorAirFlowRatePerZone { get; set; } = new real;
////[Description("No description available")]
////public virtual choice ReheatCoilType { get; set; } = new choice;
////[Description("If blank, always on")]
////public virtual object-list ReheatCoilAvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice DamperHeatingAction { get; set; } = new choice;
////[Description("Used only when Reheat Coil Object Type = Coil:Heating:Water and Damper Heating Action = Reverse")]
////public virtual real MaximumFlowPerZoneFloorAreaDuringReheat { get; set; } = new real;
////[Description("Used only when Reheat Coil Object Type = Coil:Heating:Water and Damper Heating Action = Reverse")]
////public virtual real MaximumFlowFractionDuringReheat { get; set; } = new real;
////[Description("Specifies the maximum allowable supply air temperature leaving the reheat coil.")]
////public virtual real MaximumReheatAirTemperature { get; set; } = new real;
////[Description("When the name of a DesignSpecification:OutdoorAir object is entered, the terminal")]
////public virtual object-list DesignSpecificationOutdoorAirObjectNameForControl { get; set; } = new object-list;
////[Description("Plenum zone name. Supply plenum runs through only this zone.")]
////public virtual object-list SupplyPlenumName { get; set; } = new object-list;
////[Description("Plenum zone name. Return plenum runs through only this zone.")]
////public virtual object-list ReturnPlenumName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice BaseboardHeatingType { get; set; } = new choice;
////[Description("If blank, always on")]
////public virtual object-list BaseboardHeatingAvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null BaseboardHeatingCapacity { get; set; } = new null;
////[Description("SupplyAirTemperature = use the value from Zone Cooling Design Supply Air Temperature")]
////public virtual choice ZoneCoolingDesignSupplyAirTemperatureInputMethod { get; set; } = new choice;
////[Description("Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design")]
////public virtual real ZoneCoolingDesignSupplyAirTemperature { get; set; } = new real;
////[Description("Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design")]
////public virtual real ZoneCoolingDesignSupplyAirTemperatureDifference { get; set; } = new real;
////[Description("SupplyAirTemperature = use the value from Zone Heating Design Supply Air Temperature")]
////public virtual choice ZoneHeatingDesignSupplyAirTemperatureInputMethod { get; set; } = new choice;
////[Description("Zone Heating Design Supply Air Temperature is only used when Zone Heating Design")]
////public virtual real ZoneHeatingDesignSupplyAirTemperature { get; set; } = new real;
////[Description("Zone Heating Design Supply Air Temperature is only used when Zone Heating Design")]
////public virtual real ZoneHeatingDesignSupplyAirTemperatureDifference { get; set; } = new real;
////[Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
////public virtual object-list DesignSpecificationOutdoorAirObjectNameForSizing { get; set; } = new object-list;
////[Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName { get; set; } = new object-list;
////}
////}



