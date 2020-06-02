////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class CoilSystem:IntegratedHeatPump:AirSource : BHoMObject
////{
////[Description("Unique name for this instance of an air-source integrated heat pump.")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual node SupplyHotWaterFlowSensorNodeName { get; set; } = new node;
////[Description("Must match the name used in the corresponding Coil:Cooling:DX:VariableSpeed object.")]
////public virtual object-list SpaceCoolingCoilName { get; set; } = new object-list;
////[Description("Must match the name used in the corresponding Coil:Heating:DX:VariableSpeed object.")]
////public virtual object-list SpaceHeatingCoilName { get; set; } = new object-list;
////[Description("Must match the name used in the corresponding Coil:WaterHeating:AirToWaterHeatPump:VariableSpeed object.")]
////public virtual object-list DedicatedWaterHeatingCoilName { get; set; } = new object-list;
////[Description("Must match the name used in the corresponding Coil:WaterHeating:AirToWaterHeatPump:VariableSpeed object.")]
////public virtual object-list SCWHCoilName { get; set; } = new object-list;
////[Description("Must match the name used in the corresponding Coil:Cooling:DX:VariableSpeed object.")]
////public virtual object-list SCDWHCoolingCoilName { get; set; } = new object-list;
////[Description("Must match the name used in the corresponding Coil:WaterHeating:AirToWaterHeatPump:VariableSpeed object.")]
////public virtual object-list SCDWHWaterHeatingCoilName { get; set; } = new object-list;
////[Description("Must match the name used in the corresponding Coil:Heating:DX:VariableSpeed object.")]
////public virtual object-list SHDWHHeatingCoilName { get; set; } = new object-list;
////[Description("Must match the name used in the corresponding Coil:WaterHeating:AirToWaterHeatPump:VariableSpeed object.")]
////public virtual object-list SHDWHWaterHeatingCoilName { get; set; } = new object-list;
////[Description("Indoor Temperature above which Indoor Overcooling is Allowed during Cooling Operation")]
////public virtual real IndoorTemperatureLimitForSCWHMode { get; set; } = new real;
////[Description("Ambient Temperature above which Indoor Overcooling is Allowed during Cooling Operation")]
////public virtual real AmbientTemperatureLimitForSCWHMode { get; set; } = new real;
////[Description("Indoor Temperature above which Water Heating has the higher priority and Space Heating Call Can be ignored.")]
////public virtual real IndoorTemperatureAboveWhichWHHasHigherPriority { get; set; } = new real;
////[Description("Ambient Temperature above which Water Heating has the higher priority and Space Heating Call Can be ignored.")]
////public virtual real AmbientTemperatureAboveWhichWHHasHigherPriority { get; set; } = new real;
////[Description("0: match space cooling load in SCWH mode, 1: match water heating load in SCWH mode")]
////public virtual integer FlagToIndicateLoadControlInSCWHMode { get; set; } = new integer;
////[Description("No description available")]
////public virtual integer MinimumSpeedLevelForSCWHMode { get; set; } = new integer;
////[Description("No description available")]
////public virtual real MaximumWaterFlowVolumeBeforeSwitchingFromSCDWHToSCWHMode { get; set; } = new real;
////[Description("No description available")]
////public virtual integer MinimumSpeedLevelForSCDWHMode { get; set; } = new integer;
////[Description("No description available")]
////public virtual real MaximumRunningTimeBeforeAllowingElectricResistanceHeatUseDuringSHDWHMode { get; set; } = new real;
////[Description("No description available")]
////public virtual integer MinimumSpeedLevelForSHDWHMode { get; set; } = new integer;
////}
////}
