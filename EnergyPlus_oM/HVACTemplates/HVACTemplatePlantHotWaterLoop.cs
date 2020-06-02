////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class HVACTemplate:Plant:HotWaterLoop : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("If blank, always available")]
////public virtual object-list PumpScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice PumpControlType { get; set; } = new choice;
////[Description("Default operation type makes all equipment available")]
////public virtual choice HotWaterPlantOperationSchemeType { get; set; } = new choice;
////[Description("Name of a PlantEquipmentOperationSchemes object")]
////public virtual object-list HotWaterPlantEquipmentOperationSchemesName { get; set; } = new object-list;
////[Description("Leave blank if constant setpoint")]
////public virtual object-list HotWaterSetpointScheduleName { get; set; } = new object-list;
////[Description("Used for sizing and as constant setpoint if no Setpoint Schedule Name is specified.")]
////public virtual null HotWaterDesignSetpoint { get; set; } = new null;
////[Description("VariableFlow - variable flow to boilers and coils, excess bypassed")]
////public virtual choice HotWaterPumpConfiguration { get; set; } = new choice;
////[Description("Default head is 60 feet H2O")]
////public virtual null HotWaterPumpRatedHead { get; set; } = new null;
////[Description("Overrides Hot Water Setpoint Schedule Name")]
////public virtual choice HotWaterSetpointResetType { get; set; } = new choice;
////[Description("Applicable only for OutdoorAirTemperatureReset control.")]
////public virtual null HotWaterSetpointAtOutdoorDry-BulbLow { get; set; } = new null;
////[Description("Applicable only for OutdoorAirTemperatureReset control.")]
////public virtual null HotWaterResetOutdoorDry-BulbLow { get; set; } = new null;
////[Description("Applicable only for OutdoorAirTemperatureReset control.")]
////public virtual null HotWaterSetpointAtOutdoorDry-BulbHigh { get; set; } = new null;
////[Description("Applicable only for OutdoorAirTemperatureReset control.")]
////public virtual null HotWaterResetOutdoorDry-BulbHigh { get; set; } = new null;
////[Description("Describes the type of pump configuration used for the hot water loop.")]
////public virtual choice HotWaterPumpType { get; set; } = new choice;
////[Description("Determines if a supply side bypass pipe is present in the hot water loop.")]
////public virtual choice SupplySideBypassPipe { get; set; } = new choice;
////[Description("Determines if a demand side bypass pipe is present in the hot water loop.")]
////public virtual choice DemandSideBypassPipe { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice FluidType { get; set; } = new choice;
////[Description("The temperature difference used in sizing the loop flow rate.")]
////public virtual null LoopDesignDeltaTemperature { get; set; } = new null;
////[Description("The maximum outdoor dry-bulb temperature that the hot water loops operate.")]
////public virtual null MaximumOutdoorDryBulbTemperature { get; set; } = new null;
////[Description("No description available")]
////public virtual choice LoadDistributionScheme { get; set; } = new choice;
////}
////}
