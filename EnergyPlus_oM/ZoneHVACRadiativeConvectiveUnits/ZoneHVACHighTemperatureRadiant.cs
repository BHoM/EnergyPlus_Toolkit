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
////public class ZoneHVAC:HighTemperatureRadiant : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("Name of zone system is serving")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("Enter the method used to determine the maximum heating power input capacity.")]
////public virtual choice HeatingDesignCapacityMethod { get; set; } = new choice;
////[Description("Enter the design heating capacity.Required field when the heating design capacity method")]
////public virtual real HeatingDesignCapacity { get; set; } = new real;
////[Description("Enter the heating design capacity per zone floor area.Required field when the heating design")]
////public virtual real HeatingDesignCapacityPerFloorArea { get; set; } = new real;
////[Description("Enter the fraction of auto - sized heating design capacity.Required field when capacity the")]
////public virtual real FractionOfAutosizedHeatingDesignCapacity { get; set; } = new real;
////[Description("Natural gas or electricity")]
////public virtual choice FuelType { get; set; } = new choice;
////[Description("Not used for non-gas radiant heaters")]
////public virtual null CombustionEfficiency { get; set; } = new null;
////[Description("Radiant+latent+lost fractions must sum to 1 or less, remainder is considered convective heat")]
////public virtual null FractionOfInputConvertedToRadiantEnergy { get; set; } = new null;
////[Description("No description available")]
////public virtual null FractionOfInputConvertedToLatentEnergy { get; set; } = new null;
////[Description("Fraction of input vented to outdoor environment")]
////public virtual null FractionOfInputThatIsLost { get; set; } = new null;
////[Description("Temperature type used to control unit")]
////public virtual choice TemperatureControlType { get; set; } = new choice;
////[Description("No description available")]
////public virtual null HeatingThrottlingRange { get; set; } = new null;
////[Description("This setpoint is an "operative temperature" setpoint")]
////public virtual object-list HeatingSetpointTemperatureScheduleName { get; set; } = new object-list;
////[Description("This will affect thermal comfort but from an energy balance standpoint this value")]
////public virtual null FractionOfRadiantEnergyIncidentOnPeople { get; set; } = new null;
////[Description("Radiant energy may be distributed to specific surfaces")]
////public virtual object-list Surface1Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface1 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface2Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface2 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface3Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface3 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface4Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface4 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface5Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface5 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface6Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface6 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface7Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface7 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface8Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface8 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface9Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface9 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface10Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface10 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface11Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface11 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface12Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface12 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface13Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface13 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface14Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface14 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface15Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface15 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface16Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface16 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface17Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface17 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface18Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface18 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface19Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface19 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface20Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface20 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface21Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface21 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface22Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface22 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface23Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface23 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface24Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface24 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface25Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface25 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface26Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface26 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface27Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface27 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface28Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface28 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface29Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface29 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface30Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface30 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface31Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface31 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface32Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface32 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface33Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface33 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface34Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface34 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface35Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface35 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface36Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface36 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface37Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface37 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface38Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface38 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface39Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface39 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface40Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface40 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface41Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface41 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface42Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface42 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface43Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface43 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface44Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface44 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface45Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface45 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface46Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface46 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface47Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface47 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface48Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface48 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface49Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface49 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface50Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface50 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface51Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface51 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface52Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface52 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface53Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface53 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface54Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface54 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface55Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface55 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface56Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface56 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface57Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface57 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface58Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface58 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface59Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface59 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface60Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface60 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface61Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface61 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface62Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface62 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface63Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface63 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface64Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface64 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface65Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface65 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface66Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface66 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface67Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface67 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface68Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface68 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface69Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface69 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface70Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface70 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface71Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface71 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface72Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface72 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface73Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface73 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface74Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface74 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface75Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface75 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface76Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface76 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface77Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface77 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface78Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface78 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface79Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface79 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface80Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface80 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface81Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface81 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface82Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface82 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface83Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface83 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface84Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface84 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface85Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface85 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface86Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface86 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface87Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface87 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface88Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface88 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface89Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface89 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface90Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface90 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface91Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface91 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface92Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface92 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface93Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface93 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface94Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface94 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface95Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface95 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface96Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface96 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface97Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface97 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface98Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface98 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface99Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface99 { get; set; } = new null;
////[Description("No description available")]
////public virtual object-list Surface100Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FractionOfRadiantEnergyToSurface100 { get; set; } = new null;
////}
////}




