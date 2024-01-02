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

////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.Adapters.EnergyPlus
////{
////public class SurfaceConvectionAlgorithm:Inside:AdaptiveModelSelections : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Applies to zone with no HVAC or when HVAC is off")]
////public virtual choice SimpleBuoyancyVerticalWallEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list SimpleBuoyancyVerticalWallUserCurveName { get; set; } = new object-list;
////[Description("Applies to zone with no HVAC or when HVAC is off")]
////public virtual choice SimpleBuoyancyStableHorizontalEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list SimpleBuoyancyStableHorizontalEquationUserCurveName { get; set; } = new object-list;
////[Description("Applies to zone with no HVAC or when HVAC is off")]
////public virtual choice SimpleBuoyancyUnstableHorizontalEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list SimpleBuoyancyUnstableHorizontalEquationUserCurveName { get; set; } = new object-list;
////[Description("Applies to zone with no HVAC or when HVAC is off")]
////public virtual choice SimpleBuoyancyStableTiltedEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list SimpleBuoyancyStableTiltedEquationUserCurveName { get; set; } = new object-list;
////[Description("Applies to zone with no HVAC or when HVAC is off")]
////public virtual choice SimpleBuoyancyUnstableTiltedEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list SimpleBuoyancyUnstableTiltedEquationUserCurveName { get; set; } = new object-list;
////[Description("Applies to zone with no HVAC or when HVAC is off")]
////public virtual choice SimpleBuoyancyWindowsEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list SimpleBuoyancyWindowsEquationUserCurveName { get; set; } = new object-list;
////[Description("Applies to zone with in-floor heating and/or in-ceiling cooling")]
////public virtual choice FloorHeatCeilingCoolVerticalWallEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list FloorHeatCeilingCoolVerticalWallEquationUserCurveName { get; set; } = new object-list;
////[Description("Applies to zone with in-floor heating and/or in-ceiling cooling")]
////public virtual choice FloorHeatCeilingCoolStableHorizontalEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list FloorHeatCeilingCoolStableHorizontalEquationUserCurveName { get; set; } = new object-list;
////[Description("Applies to zone with in-floor heating and/or in-ceiling cooling")]
////public virtual choice FloorHeatCeilingCoolUnstableHorizontalEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list FloorHeatCeilingCoolUnstableHorizontalEquationUserCurveName { get; set; } = new object-list;
////[Description("Applies to zone with in-floor heating and/or in-ceiling cooling")]
////public virtual choice FloorHeatCeilingCoolHeatedFloorEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list FloorHeatCeilingCoolHeatedFloorEquationUserCurveName { get; set; } = new object-list;
////[Description("Applies to zone with in-floor heating and/or in-ceiling cooling")]
////public virtual choice FloorHeatCeilingCoolChilledCeilingEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list FloorHeatCeilingCoolChilledCeilingEquationUserCurveName { get; set; } = new object-list;
////[Description("Applies to zone with in-floor heating and/or in-ceiling cooling")]
////public virtual choice FloorHeatCeilingCoolStableTiltedEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list FloorHeatCeilingCoolStableTiltedEquationUserCurveName { get; set; } = new object-list;
////[Description("Applies to zone with in-floor heating and/or in-ceiling cooling")]
////public virtual choice FloorHeatCeilingCoolUnstableTiltedEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list FloorHeatCeilingCoolUnstableTiltedEquationUserCurveName { get; set; } = new object-list;
////[Description("Applies to zone with in-floor heating and/or in-ceiling cooling")]
////public virtual choice FloorHeatCeilingCoolWindowEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list FloorHeatCeilingCoolWindowEquationUserCurveName { get; set; } = new object-list;
////[Description("Applies to zone with in-wall panel heating")]
////public virtual choice WallPanelHeatingVerticalWallEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list WallPanelHeatingVerticalWallEquationUserCurveName { get; set; } = new object-list;
////[Description("Applies to zone with in-wall panel heating")]
////public virtual choice WallPanelHeatingHeatedWallEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list WallPanelHeatingHeatedWallEquationUserCurveName { get; set; } = new object-list;
////[Description("Applies to zone with in-wall panel heating")]
////public virtual choice WallPanelHeatingStableHorizontalEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list WallPanelHeatingStableHorizontalEquationUserCurveName { get; set; } = new object-list;
////[Description("Applies to zone with in-wall panel heating")]
////public virtual choice WallPanelHeatingUnstableHorizontalEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list WallPanelHeatingUnstableHorizontalEquationUserCurveName { get; set; } = new object-list;
////[Description("Applies to zone with in-wall panel heating")]
////public virtual choice WallPanelHeatingStableTiltedEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list WallPanelHeatingStableTiltedEquationUserCurveName { get; set; } = new object-list;
////[Description("Applies to zone with in-wall panel heating")]
////public virtual choice WallPanelHeatingUnstableTiltedEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list WallPanelHeatingUnstableTiltedEquationUserCurveName { get; set; } = new object-list;
////[Description("Applies to zone with in-wall panel heating")]
////public virtual choice WallPanelHeatingWindowEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list WallPanelHeatingWindowEquationUserCurveName { get; set; } = new object-list;
////[Description("Applies to zone with convective heater")]
////public virtual choice ConvectiveZoneHeaterVerticalWallEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list ConvectiveZoneHeaterVerticalWallEquationUserCurveName { get; set; } = new object-list;
////[Description("Applies to zone with convective heater")]
////public virtual choice ConvectiveZoneHeaterVerticalWallsNearHeaterEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list ConvectiveZoneHeaterVerticalWallsNearHeaterEquationUserCurveName { get; set; } = new object-list;
////[Description("Applies to zone with convective heater")]
////public virtual choice ConvectiveZoneHeaterStableHorizontalEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list ConvectiveZoneHeaterStableHorizontalEquationUserCurveName { get; set; } = new object-list;
////[Description("Applies to zone with convective heater")]
////public virtual choice ConvectiveZoneHeaterUnstableHorizontalEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list ConvectiveZoneHeaterUnstableHorizontalEquationUserCurveName { get; set; } = new object-list;
////[Description("Applies to zone with convective heater")]
////public virtual choice ConvectiveZoneHeaterStableTiltedEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list ConvectiveZoneHeaterStableTiltedEquationUserCurveName { get; set; } = new object-list;
////[Description("Applies to zone with convective heater")]
////public virtual choice ConvectiveZoneHeaterUnstableTiltedEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list ConvectiveZoneHeaterUnstableTiltedEquationUserCurveName { get; set; } = new object-list;
////[Description("Applies to zone with convective heater")]
////public virtual choice ConvectiveZoneHeaterWindowsEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list ConvectiveZoneHeaterWindowsEquationUserCurveName { get; set; } = new object-list;
////[Description("Applies to zone with mechanical forced central air with diffusers")]
////public virtual choice CentralAirDiffuserWallEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list CentralAirDiffuserWallEquationUserCurveName { get; set; } = new object-list;
////[Description("Applies to zone with mechanical forced central air with diffusers")]
////public virtual choice CentralAirDiffuserCeilingEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list CentralAirDiffuserCeilingEquationUserCurveName { get; set; } = new object-list;
////[Description("Applies to zone with mechanical forced central air with diffusers")]
////public virtual choice CentralAirDiffuserFloorEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list CentralAirDiffuserFloorEquationUserCurveName { get; set; } = new object-list;
////[Description("Applies to zone with mechanical forced central air with diffusers")]
////public virtual choice CentralAirDiffuserWindowEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list CentralAirDiffuserWindowEquationUserCurveName { get; set; } = new object-list;
////[Description("reference choice fields")]
////public virtual choice MechanicalZoneFanCirculationVerticalWallEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list MechanicalZoneFanCirculationVerticalWallEquationUserCurveName { get; set; } = new object-list;
////[Description("reference choice fields")]
////public virtual choice MechanicalZoneFanCirculationStableHorizontalEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list MechanicalZoneFanCirculationStableHorizontalEquationUserCurveName { get; set; } = new object-list;
////[Description("reference choice fields")]
////public virtual choice MechanicalZoneFanCirculationUnstableHorizontalEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list MechanicalZoneFanCirculationUnstableHorizontalEquationUserCurveName { get; set; } = new object-list;
////[Description("reference choice fields")]
////public virtual choice MechanicalZoneFanCirculationStableTiltedEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list MechanicalZoneFanCirculationStableTiltedEquationUserCurveName { get; set; } = new object-list;
////[Description("reference choice fields")]
////public virtual choice MechanicalZoneFanCirculationUnstableTiltedEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list MechanicalZoneFanCirculationUnstableTiltedEquationUserCurveName { get; set; } = new object-list;
////[Description("reference choice fields")]
////public virtual choice MechanicalZoneFanCirculationWindowEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list MechanicalZoneFanCirculationWindowEquationUserCurveName { get; set; } = new object-list;
////[Description("reference choice fields")]
////public virtual choice MixedRegimeBuoyancyAssistingFlowOnWallsEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list MixedRegimeBuoyancyAssistingFlowOnWallsEquationUserCurveName { get; set; } = new object-list;
////[Description("reference choice fields")]
////public virtual choice MixedRegimeBuoyancyOpposingFlowOnWallsEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list MixedRegimeBuoyancyOpposingFlowOnWallsEquationUserCurveName { get; set; } = new object-list;
////[Description("reference choice fields")]
////public virtual choice MixedRegimeStableFloorEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list MixedRegimeStableFloorEquationUserCurveName { get; set; } = new object-list;
////[Description("reference choice fields")]
////public virtual choice MixedRegimeUnstableFloorEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list MixedRegimeUnstableFloorEquationUserCurveName { get; set; } = new object-list;
////[Description("reference choice fields")]
////public virtual choice MixedRegimeStableCeilingEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list MixedRegimeStableCeilingEquationUserCurveName { get; set; } = new object-list;
////[Description("reference choice fields")]
////public virtual choice MixedRegimeUnstableCeilingEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list MixedRegimeUnstableCeilingEquationUserCurveName { get; set; } = new object-list;
////[Description("reference choice fields")]
////public virtual choice MixedRegimeWindowEquationSource { get; set; } = new choice;
////[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when the previous field is set to UserCurve")]
////public virtual object-list MixedRegimeWindowEquationUserCurveName { get; set; } = new object-list;
////}
////}




