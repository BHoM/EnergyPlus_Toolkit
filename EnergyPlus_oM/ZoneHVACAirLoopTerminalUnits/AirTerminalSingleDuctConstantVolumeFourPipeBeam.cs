/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2021, the respective contributors. All rights reserved.
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
////public class AirTerminal:SingleDuct:ConstantVolume:FourPipeBeam : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Primary air is supplied by central air handling unit and must be on for heating or cooling.")]
////public virtual object-list PrimaryAirAvailabilityScheduleName { get; set; } = new object-list;
////[Description("Cooling operation can be controlled separately using this availability schedule.")]
////public virtual object-list CoolingAvailabilityScheduleName { get; set; } = new object-list;
////[Description("Heating operation can be controlled separately using this availability schedule.")]
////public virtual object-list HeatingAvailabilityScheduleName { get; set; } = new object-list;
////[Description("Name of the air system node for primary supply air entering the air distribution unit.")]
////public virtual node PrimaryAirInletNodeName { get; set; } = new node;
////[Description("Name of the air system node for primary supply air leaving the air distribution unit and entering the zone.")]
////public virtual node PrimaryAirOutletNodeName { get; set; } = new node;
////[Description("Name of the plant system node for chilled water entering the beam.")]
////public virtual node ChilledWaterInletNodeName { get; set; } = new node;
////[Description("Name of the plant system node for chilled water leaving the beam.")]
////public virtual node ChilledWaterOutletNodeName { get; set; } = new node;
////[Description("Name of the plant system node for hot water entering the beam.")]
////public virtual node HotWaterInletNodeName { get; set; } = new node;
////[Description("Name of the plant system node for hot water leaving the beam.")]
////public virtual node HotWaterOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual real DesignPrimaryAirVolumeFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real DesignChilledWaterVolumeFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real DesignHotWaterVolumeFlowRate { get; set; } = new real;
////[Description("Sum of the length of all the beam units in the zone represented by this terminal unit.")]
////public virtual real ZoneTotalBeamLength { get; set; } = new real;
////[Description("Primary air supply flow rate normalized by beam length.")]
////public virtual real RatedPrimaryAirFlowRatePerBeamLength { get; set; } = new real;
////[Description("Sensible cooling capacity per meter of beam length at the rating point.")]
////public virtual real BeamRatedCoolingCapacityPerBeamLength { get; set; } = new real;
////[Description("Difference in temperature between the zone air and the entering chilled water at the rating point.")]
////public virtual real BeamRatedCoolingRoomAirChilledWaterTemperatureDifference { get; set; } = new real;
////[Description("The volume flow rate of chilled water per meter of beam length at the rating point.")]
////public virtual real BeamRatedChilledWaterVolumeFlowRatePerBeamLength { get; set; } = new real;
////[Description("Adjusts beam cooling capacity when the temperature difference between entering water and zone air")]
////public virtual object-list BeamCoolingCapacityTemperatureDifferenceModificationFactorCurveName { get; set; } = new object-list;
////[Description("Adjusts beam cooling capacity when the primary air supply flow rate is different")]
////public virtual object-list BeamCoolingCapacityAirFlowModificationFactorCurveName { get; set; } = new object-list;
////[Description("Adjusts beam cooling capacity when the normalized chilled water flow rate is different")]
////public virtual object-list BeamCoolingCapacityChilledWaterFlowModificationFactorCurveName { get; set; } = new object-list;
////[Description("Sensible heating capacity per meter of beam length at the rating point.")]
////public virtual real BeamRatedHeatingCapacityPerBeamLength { get; set; } = new real;
////[Description("Difference in temperature between the zone air and the entering hot water at the rating point.")]
////public virtual real BeamRatedHeatingRoomAirHotWaterTemperatureDifference { get; set; } = new real;
////[Description("The volume flow rate of hoy water per meter of beam length at the rating point.")]
////public virtual real BeamRatedHotWaterVolumeFlowRatePerBeamLength { get; set; } = new real;
////[Description("Adjusts beam heating capacity when the temperature difference between entering water and zone air")]
////public virtual object-list BeamHeatingCapacityTemperatureDifferenceModificationFactorCurveName { get; set; } = new object-list;
////[Description("Adjusts beam heating capacity when the primary air supply flow rate is different")]
////public virtual object-list BeamHeatingCapacityAirFlowModificationFactorCurveName { get; set; } = new object-list;
////[Description("Adjusts beam heating capacity when the normalized hot water flow rate is different")]
////public virtual object-list BeamHeatingCapacityHotWaterFlowModificationFactorCurveName { get; set; } = new object-list;
////}
////}

