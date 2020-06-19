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
////public class RoomAir:TemperaturePattern:SurfaceMapping : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("reference this entry in schedule")]
////public virtual integer ControlIntegerForPatternControlScheduleName { get; set; } = new integer;
////[Description("= (Temp at thermostat- Mean Air Temp)")]
////public virtual null ThermostatOffset { get; set; } = new null;
////[Description("= (Tleaving - Mean Air Temp ) deg C")]
////public virtual null ReturnAirOffset { get; set; } = new null;
////[Description("= (Texhaust - Mean Air Temp) deg C")]
////public virtual null ExhaustAirOffset { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list SurfaceNamePair1 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DeltaAdjacentAirTemperaturePair1 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list SurfaceNamePair2 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DeltaAdjacentAirTemperaturePair2 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list SurfaceNamePair3 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DeltaAdjacentAirTemperaturePair3 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list SurfaceNamePair4 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DeltaAdjacentAirTemperaturePair4 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list SurfaceNamePair5 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DeltaAdjacentAirTemperaturePair5 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list SurfaceNamePair6 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DeltaAdjacentAirTemperaturePair6 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list SurfaceNamePair7 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DeltaAdjacentAirTemperaturePair7 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list SurfaceNamePair8 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DeltaAdjacentAirTemperaturePair8 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list SurfaceNamePair9 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DeltaAdjacentAirTemperaturePair9 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list SurfaceNamePair10 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DeltaAdjacentAirTemperaturePair10 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list SurfaceNamePair11 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DeltaAdjacentAirTemperaturePair11 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list SurfaceNamePair12 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DeltaAdjacentAirTemperaturePair12 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list SurfaceNamePair13 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DeltaAdjacentAirTemperaturePair13 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list SurfaceNamePair14 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DeltaAdjacentAirTemperaturePair14 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list SurfaceNamePair15 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DeltaAdjacentAirTemperaturePair15 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list SurfaceNamePair16 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DeltaAdjacentAirTemperaturePair16 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list SurfaceNamePair17 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DeltaAdjacentAirTemperaturePair17 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list SurfaceNamePair18 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DeltaAdjacentAirTemperaturePair18 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list SurfaceNamePair19 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DeltaAdjacentAirTemperaturePair19 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list SurfaceNamePair20 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DeltaAdjacentAirTemperaturePair20 { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list SurfaceNamePair21 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DeltaAdjacentAirTemperaturePair21 { get; set; } = new real;
////}
////}
