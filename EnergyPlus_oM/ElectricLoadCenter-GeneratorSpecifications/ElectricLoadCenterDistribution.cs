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

//using BH.oM.Base;
//using System.Collections.Generic;
//using System.ComponentModel;
//
//namespace BH.oM.Adapters.EnergyPlus
//{
//public class ElectricLoadCenter:Distribution : BHoMObject
//{
//[Description("No description available")]
//public virtual null Name { get; set; } = new null;
//[Description("Name of an ElectricLoadCenter:Generators object")]
//public virtual object-list GeneratorListName { get; set; } = new object-list;
//[Description("Determines how generators are to be controlled")]
//public virtual choice GeneratorOperationSchemeType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real GeneratorDemandLimitSchemePurchasedElectricDemandLimit { get; set; } = new real;
//[Description("required when Generator Operation Scheme Type=TrackSchedule")]
//public virtual object-list GeneratorTrackScheduleNameSchemeScheduleName { get; set; } = new object-list;
//[Description("required when Generator Operation Scheme Type=TrackMeter")]
//public virtual external-list GeneratorTrackMeterSchemeMeterName { get; set; } = new external-list;
//[Description("No description available")]
//public virtual choice ElectricalBussType { get; set; } = new choice;
//[Description("required when Electrical Buss Type=DirectCurrentWithInverter, DirectCurrentWithInverterDCStorage,")]
//public virtual object-list InverterName { get; set; } = new object-list;
//[Description("required when Electrical Buss Type=AlternatingCurrentWithStorage, DirectCurrentWithInverterDCStorage,")]
//public virtual object-list ElectricalStorageObjectName { get; set; } = new object-list;
//[Description("required when power needs to be output from on-site generation or storage to the grid via transformer")]
//public virtual object-list TransformerObjectName { get; set; } = new object-list;
//[Description("Select method to govern how storage charge and discharge is controlled")]
//public virtual choice StorageOperationScheme { get; set; } = new choice;
//[Description("required when Storage Operation Scheme is set to TrackMeterDemandStoreExcessOnSite.")]
//public virtual external-list StorageControlTrackMeterName { get; set; } = new external-list;
//[Description("Name of an ElectricLoadCenter:Storage:Converter used to convert AC to DC when charging DC storage from grid supply.")]
//public virtual object-list StorageConverterObjectName { get; set; } = new object-list;
//[Description("Fraction of storage capacity used as upper limit for controlling charging, for all storage operation schemes.")]
//public virtual real MaximumStorageStateOfChargeFraction { get; set; } = new real;
//[Description("Fraction of storage capacity used as lower limit for controlling discharging, for all storage operation schemes.")]
//public virtual real MinimumStorageStateOfChargeFraction { get; set; } = new real;
//[Description("Maximum rate that electric power can be charged into storage.")]
//public virtual real DesignStorageControlChargePower { get; set; } = new real;
//[Description("Controls timing and magnitude of charging storage.")]
//public virtual object-list StorageChargePowerFractionScheduleName { get; set; } = new object-list;
//[Description("Maximum rate that electric power can be discharged from storage.")]
//public virtual real DesignStorageControlDischargePower { get; set; } = new real;
//[Description("Controls timing and magnitude of discharging storage")]
//public virtual object-list StorageDischargePowerFractionScheduleName { get; set; } = new object-list;
//[Description("Target utility service demand power for discharge control. Storage draws are adjusted upwards for conversion losses.")]
//public virtual real StorageControlUtilityDemandTarget { get; set; } = new real;
//[Description("Modifies the target utility service demand power over time.")]
//public virtual object-list StorageControlUtilityDemandTargetFractionScheduleName { get; set; } = new object-list;
//}
//}




