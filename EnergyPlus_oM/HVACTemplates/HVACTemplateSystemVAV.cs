////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class HVACTemplate:System:VAV : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("If blank, always on; VAV System always on. Schedule is used in availability manager")]
////public virtual object-list SystemAvailabilityScheduleName { get; set; } = new object-list;
////[Description("This field may be set to "autosize". If a value is entered, it will *not* be")]
////public virtual null SupplyFanMaximumFlowRate { get; set; } = new null;
////[Description("This field is only used to set a minimum part load on the VAV fan power curve.")]
////public virtual null SupplyFanMinimumFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual null SupplyFanTotalEfficiency { get; set; } = new null;
////[Description("No description available")]
////public virtual null SupplyFanDeltaPressure { get; set; } = new null;
////[Description("No description available")]
////public virtual null SupplyFanMotorEfficiency { get; set; } = new null;
////[Description("No description available")]
////public virtual null SupplyFanMotorInAirStreamFraction { get; set; } = new null;
////[Description("No description available")]
////public virtual choice CoolingCoilType { get; set; } = new choice;
////[Description("If blank, always on")]
////public virtual object-list CoolingCoilAvailabilityScheduleName { get; set; } = new object-list;
////[Description("Leave blank if constant setpoint")]
////public virtual object-list CoolingCoilSetpointScheduleName { get; set; } = new object-list;
////[Description("Used for sizing and as constant setpoint if no Cooling Coil Setpoint Schedule Name is specified.")]
////public virtual null CoolingCoilDesignSetpoint { get; set; } = new null;
////[Description("No description available")]
////public virtual choice HeatingCoilType { get; set; } = new choice;
////[Description("If blank, always on")]
////public virtual object-list HeatingCoilAvailabilityScheduleName { get; set; } = new object-list;
////[Description("Leave blank if constant setpoint")]
////public virtual object-list HeatingCoilSetpointScheduleName { get; set; } = new object-list;
////[Description("Used for sizing and as constant setpoint if no Heating Coil Setpoint Schedule Name is specified.")]
////public virtual null HeatingCoilDesignSetpoint { get; set; } = new null;
////[Description("No description available")]
////public virtual null GasHeatingCoilEfficiency { get; set; } = new null;
////[Description("No description available")]
////public virtual null GasHeatingCoilParasiticElectricLoad { get; set; } = new null;
////[Description("No description available")]
////public virtual choice PreheatCoilType { get; set; } = new choice;
////[Description("If blank, always on")]
////public virtual object-list PreheatCoilAvailabilityScheduleName { get; set; } = new object-list;
////[Description("Leave blank if constant setpoint")]
////public virtual object-list PreheatCoilSetpointScheduleName { get; set; } = new object-list;
////[Description("Used for sizing and as constant setpoint if no Preheat Coil Setpoint Schedule Name specified.")]
////public virtual null PreheatCoilDesignSetpoint { get; set; } = new null;
////[Description("No description available")]
////public virtual null GasPreheatCoilEfficiency { get; set; } = new null;
////[Description("No description available")]
////public virtual null GasPreheatCoilParasiticElectricLoad { get; set; } = new null;
////[Description("No description available")]
////public virtual null MaximumOutdoorAirFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual null MinimumOutdoorAirFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual choice MinimumOutdoorAirControlType { get; set; } = new choice;
////[Description("Schedule values multiply the Minimum Outdoor Air Flow Rate")]
////public virtual object-list MinimumOutdoorAirScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice EconomizerType { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice EconomizerLockout { get; set; } = new choice;
////[Description("Outdoor temperature above which economizer is disabled and")]
////public virtual null EconomizerUpperTemperatureLimit { get; set; } = new null;
////[Description("Outdoor temperature below which economizer is disabled and")]
////public virtual null EconomizerLowerTemperatureLimit { get; set; } = new null;
////[Description("Outdoor enthalpy above which economizer is disabled and")]
////public virtual null EconomizerUpperEnthalpyLimit { get; set; } = new null;
////[Description("Enter the maximum outdoor dewpoint temperature limit for FixedDewPointAndDryBulb")]
////public virtual real EconomizerMaximumLimitDewpointTemperature { get; set; } = new real;
////[Description("Plenum zone name. Supply plenum serves all zones on this system.")]
////public virtual object-list SupplyPlenumName { get; set; } = new object-list;
////[Description("Plenum zone name. Supply plenum serves all zones on this system.")]
////public virtual object-list ReturnPlenumName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice SupplyFanPlacement { get; set; } = new choice;
////[Description("This field selects a predefined set of fan power coefficients.")]
////public virtual choice SupplyFanPart-LoadPowerCoefficients { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice NightCycleControl { get; set; } = new choice;
////[Description("Applicable only if Night Cycle Control is Cycle On Control Zone.")]
////public virtual object-list NightCycleControlZoneName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice HeatRecoveryType { get; set; } = new choice;
////[Description("No description available")]
////public virtual null SensibleHeatRecoveryEffectiveness { get; set; } = new null;
////[Description("No description available")]
////public virtual null LatentHeatRecoveryEffectiveness { get; set; } = new null;
////[Description("Overrides Cooling Coil Setpoint Schedule Name")]
////public virtual choice CoolingCoilSetpointResetType { get; set; } = new choice;
////[Description("Overrides Heating Coil Setpoint Schedule Name")]
////public virtual choice HeatingCoilSetpointResetType { get; set; } = new choice;
////[Description("None = meet sensible load only")]
////public virtual choice DehumidificationControlType { get; set; } = new choice;
////[Description("Zone name where humidistat is located")]
////public virtual object-list DehumidificationControlZoneName { get; set; } = new object-list;
////[Description("Zone relative humidity setpoint in percent (0 to 100)")]
////public virtual real DehumidificationSetpoint { get; set; } = new real;
////[Description("No description available")]
////public virtual choice HumidifierType { get; set; } = new choice;
////[Description("If blank, always available")]
////public virtual object-list HumidifierAvailabilityScheduleName { get; set; } = new object-list;
////[Description("Moisture output rate at full rated power input.")]
////public virtual real HumidifierRatedCapacity { get; set; } = new real;
////[Description("Electric power input at rated capacity moisture output.")]
////public virtual real HumidifierRatedElectricPower { get; set; } = new real;
////[Description("Zone name where humidistat is located")]
////public virtual object-list HumidifierControlZoneName { get; set; } = new object-list;
////[Description("Zone relative humidity setpoint in percent (0 to 100)")]
////public virtual real HumidifierSetpoint { get; set; } = new real;
////[Description("Select whether autosized system supply flow rate is the sum of Coincident or NonCoincident")]
////public virtual choice SizingOption { get; set; } = new choice;
////[Description("Specifies if the system has a return fan.")]
////public virtual choice ReturnFan { get; set; } = new choice;
////[Description("No description available")]
////public virtual null ReturnFanTotalEfficiency { get; set; } = new null;
////[Description("No description available")]
////public virtual null ReturnFanDeltaPressure { get; set; } = new null;
////[Description("No description available")]
////public virtual null ReturnFanMotorEfficiency { get; set; } = new null;
////[Description("No description available")]
////public virtual null ReturnFanMotorInAirStreamFraction { get; set; } = new null;
////[Description("This field selects a predefined set of fan power coefficients.")]
////public virtual choice ReturnFanPart-LoadPowerCoefficients { get; set; } = new choice;
////}
////}