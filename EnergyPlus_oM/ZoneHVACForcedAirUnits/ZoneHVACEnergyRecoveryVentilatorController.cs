////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class ZoneHVAC:EnergyRecoveryVentilator:Controller : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Enter the maximum outdoor dry-bulb temperature limit for economizer operation.")]
////public virtual real TemperatureHighLimit { get; set; } = new real;
////[Description("Enter the minimum outdoor dry-bulb temperature limit for economizer operation.")]
////public virtual real TemperatureLowLimit { get; set; } = new real;
////[Description("Enter the maximum outdoor enthalpy limit for economizer operation.")]
////public virtual real EnthalpyHighLimit { get; set; } = new real;
////[Description("Enter the maximum outdoor dew point temperature limit for economizer operation.")]
////public virtual real DewpointTemperatureLimit { get; set; } = new real;
////[Description("Enter the name of a quadratic or cubic curve which defines the maximum outdoor")]
////public virtual object-list ElectronicEnthalpyLimitCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice ExhaustAirTemperatureLimit { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice ExhaustAirEnthalpyLimit { get; set; } = new choice;
////[Description("Schedule values greater than 0 indicate economizer operation is active. This")]
////public virtual object-list TimeOfDayEconomizerFlowControlScheduleName { get; set; } = new object-list;
////[Description("Select Yes to modify air flow rates based on a zone humidistat.")]
////public virtual choice HighHumidityControlFlag { get; set; } = new choice;
////[Description("Enter the name of the zone where the humidistat is located.")]
////public virtual object-list HumidistatControlZoneName { get; set; } = new object-list;
////[Description("Enter the ratio of supply (outdoor) air to the maximum supply air flow rate when modified")]
////public virtual real HighHumidityOutdoorAirFlowRatio { get; set; } = new real;
////[Description("If NO is selected, the air flow rate is modified any time indoor relative")]
////public virtual choice ControlHighIndoorHumidityBasedOnOutdoorHumidityRatio { get; set; } = new choice;
////}
////}
