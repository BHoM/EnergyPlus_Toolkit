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
////public class ZoneThermalChimney : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("Name of zone that is the thermal chimney")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real WidthOfTheAbsorberWall { get; set; } = new real;
////[Description("No description available")]
////public virtual real CrossSectionalAreaOfAirChannelOutlet { get; set; } = new real;
////[Description("No description available")]
////public virtual real DischargeCoefficient { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list Zone1Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DistanceFromTopOfThermalChimneyToInlet1 { get; set; } = new real;
////[Description("No description available")]
////public virtual real RelativeRatiosOfAirFlowRatesPassingThroughZone1 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CrossSectionalAreasOfAirChannelInlet1 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list Zone2Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DistanceFromTopOfThermalChimneyToInlet2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real RelativeRatiosOfAirFlowRatesPassingThroughZone2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CrossSectionalAreasOfAirChannelInlet2 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list Zone3Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DistanceFromTopOfThermalChimneyToInlet3 { get; set; } = new real;
////[Description("No description available")]
////public virtual real RelativeRatiosOfAirFlowRatesPassingThroughZone3 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CrossSectionalAreasOfAirChannelInlet3 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list Zone4Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DistanceFromTopOfThermalChimneyToInlet4 { get; set; } = new real;
////[Description("No description available")]
////public virtual real RelativeRatiosOfAirFlowRatesPassingThroughZone4 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CrossSectionalAreasOfAirChannelInlet4 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list Zone5Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DistanceFromTopOfThermalChimneyToInlet5 { get; set; } = new real;
////[Description("No description available")]
////public virtual real RelativeRatiosOfAirFlowRatesPassingThroughZone5 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CrossSectionalAreasOfAirChannelInlet5 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list Zone6Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DistanceFromTopOfThermalChimneyToInlet6 { get; set; } = new real;
////[Description("No description available")]
////public virtual real RelativeRatiosOfAirFlowRatesPassingThroughZone6 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CrossSectionalAreasOfAirChannelInlet6 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list Zone7Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DistanceFromTopOfThermalChimneyToInlet7 { get; set; } = new real;
////[Description("No description available")]
////public virtual real RelativeRatiosOfAirFlowRatesPassingThroughZone7 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CrossSectionalAreasOfAirChannelInlet7 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list Zone8Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DistanceFromTopOfThermalChimneyToInlet8 { get; set; } = new real;
////[Description("No description available")]
////public virtual real RelativeRatiosOfAirFlowRatesPassingThroughZone8 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CrossSectionalAreasOfAirChannelInlet8 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list Zone9Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DistanceFromTopOfThermalChimneyToInlet9 { get; set; } = new real;
////[Description("No description available")]
////public virtual real RelativeRatiosOfAirFlowRatesPassingThroughZone9 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CrossSectionalAreasOfAirChannelInlet9 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list Zone10Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DistanceFromTopOfThermalChimneyToInlet10 { get; set; } = new real;
////[Description("No description available")]
////public virtual real RelativeRatiosOfAirFlowRatesPassingThroughZone10 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CrossSectionalAreasOfAirChannelInlet10 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list Zone11Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DistanceFromTopOfThermalChimneyToInlet11 { get; set; } = new real;
////[Description("No description available")]
////public virtual real RelativeRatiosOfAirFlowRatesPassingThroughZone11 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CrossSectionalAreasOfAirChannelInlet11 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list Zone12Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DistanceFromTopOfThermalChimneyToInlet12 { get; set; } = new real;
////[Description("No description available")]
////public virtual real RelativeRatiosOfAirFlowRatesPassingThroughZone12 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CrossSectionalAreasOfAirChannelInlet12 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list Zone13Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DistanceFromTopOfThermalChimneyToInlet13 { get; set; } = new real;
////[Description("No description available")]
////public virtual real RelativeRatiosOfAirFlowRatesPassingThroughZone13 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CrossSectionalAreasOfAirChannelInlet13 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list Zone14Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DistanceFromTopOfThermalChimneyToInlet14 { get; set; } = new real;
////[Description("No description available")]
////public virtual real RelativeRatiosOfAirFlowRatesPassingThroughZone14 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CrossSectionalAreasOfAirChannelInlet14 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list Zone15Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DistanceFromTopOfThermalChimneyToInlet15 { get; set; } = new real;
////[Description("No description available")]
////public virtual real RelativeRatiosOfAirFlowRatesPassingThroughZone15 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CrossSectionalAreasOfAirChannelInlet15 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list Zone16Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DistanceFromTopOfThermalChimneyToInlet16 { get; set; } = new real;
////[Description("No description available")]
////public virtual real RelativeRatiosOfAirFlowRatesPassingThroughZone16 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CrossSectionalAreasOfAirChannelInlet16 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list Zone17Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DistanceFromTopOfThermalChimneyToInlet17 { get; set; } = new real;
////[Description("No description available")]
////public virtual real RelativeRatiosOfAirFlowRatesPassingThroughZone17 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CrossSectionalAreasOfAirChannelInlet17 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list Zone18Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DistanceFromTopOfThermalChimneyToInlet18 { get; set; } = new real;
////[Description("No description available")]
////public virtual real RelativeRatiosOfAirFlowRatesPassingThroughZone18 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CrossSectionalAreasOfAirChannelInlet18 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list Zone19Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DistanceFromTopOfThermalChimneyToInlet19 { get; set; } = new real;
////[Description("No description available")]
////public virtual real RelativeRatiosOfAirFlowRatesPassingThroughZone19 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CrossSectionalAreasOfAirChannelInlet19 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list Zone20Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DistanceFromTopOfThermalChimneyToInlet20 { get; set; } = new real;
////[Description("No description available")]
////public virtual real RelativeRatiosOfAirFlowRatesPassingThroughZone20 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CrossSectionalAreasOfAirChannelInlet20 { get; set; } = new real;
////}
////}
