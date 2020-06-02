////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class WaterUse:Connections : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual node InletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node OutletNodeName { get; set; } = new node;
////[Description("If blank, or tank is empty, defaults to fresh water from the mains")]
////public virtual object-list SupplyWaterStorageTankName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ReclamationWaterStorageTankName { get; set; } = new object-list;
////[Description("Defaults to cold water supply temperature")]
////public virtual object-list HotWaterSupplyTemperatureScheduleName { get; set; } = new object-list;
////[Description("Defaults to water temperatures calculated by Site:WaterMainsTemperature object")]
////public virtual object-list ColdWaterSupplyTemperatureScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice DrainWaterHeatExchangerType { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice DrainWaterHeatExchangerDestination { get; set; } = new choice;
////[Description("No description available")]
////public virtual real DrainWaterHeatExchangerU-FactorTimesArea { get; set; } = new real;
////[Description("Enter the name of a WaterUse:Equipment object.")]
////public virtual object-list WaterUseEquipment1Name { get; set; } = new object-list;
////[Description("Enter the name of a WaterUse:Equipment object.")]
////public virtual object-list WaterUseEquipment2Name { get; set; } = new object-list;
////[Description("Enter the name of a WaterUse:Equipment object.")]
////public virtual object-list WaterUseEquipment3Name { get; set; } = new object-list;
////[Description("Enter the name of a WaterUse:Equipment object.")]
////public virtual object-list WaterUseEquipment4Name { get; set; } = new object-list;
////[Description("Enter the name of a WaterUse:Equipment object.")]
////public virtual object-list WaterUseEquipment5Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list WaterUseEquipment6Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list WaterUseEquipment7Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list WaterUseEquipment8Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list WaterUseEquipment9Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list WaterUseEquipment10Name { get; set; } = new object-list;
////}
////}
