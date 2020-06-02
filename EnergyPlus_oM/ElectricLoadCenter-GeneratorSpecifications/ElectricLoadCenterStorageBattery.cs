//using BH.oM.Base;
//using System.Collections.Generic;
//using System.ComponentModel;
//
//namespace BH.oM.EnergyPlus
//{
//public class ElectricLoadCenter:Storage:Battery : BHoMObject
//{
//[Description("No description available")]
//public virtual alpha Name { get; set; } = new alpha;
//[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
//public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
//[Description("Enter name of zone to receive electrical storage losses as heat")]
//public virtual object-list ZoneName { get; set; } = new object-list;
//[Description("No description available")]
//public virtual real RadiativeFraction { get; set; } = new real;
//[Description("A module usually consists of several cells.")]
//public virtual integer NumberOfBatteryModulesInParallel { get; set; } = new integer;
//[Description("A module usually consists of several cells.")]
//public virtual integer NumberOfBatteryModulesInSeries { get; set; } = new integer;
//[Description("The capacity is for each module.")]
//public virtual real MaximumModuleCapacity { get; set; } = new real;
//[Description("The state of charge is evaluated based on the")]
//public virtual real InitialFractionalStateOfCharge { get; set; } = new real;
//[Description("A model parameter usually derived from test data by curve fitting.")]
//public virtual real FractionOfAvailableChargeCapacity { get; set; } = new real;
//[Description("A model parameter usually derived from test data by curve fitting.")]
//public virtual null ChangeRateFromBoundChargeToAvailableCharge { get; set; } = new null;
//[Description("The voltage is for each battery module.")]
//public virtual real FullyChargedModuleOpenCircuitVoltage { get; set; } = new real;
//[Description("The voltage is for each battery module.")]
//public virtual real FullyDischargedModuleOpenCircuitVoltage { get; set; } = new real;
//[Description("Determines how the open circuit voltage change with state of charge relative to the fully discharged state.")]
//public virtual object-list VoltageChangeCurveNameForCharging { get; set; } = new object-list;
//[Description("Determines how the open circuit voltage change with state of charge relative to the fully charged state.")]
//public virtual object-list VoltageChangeCurveNameForDischarging { get; set; } = new object-list;
//[Description("A model parameter from manufacture or derived from test data.")]
//public virtual real ModuleInternalElectricalResistance { get; set; } = new real;
//[Description("The constraint on discharging current is for each battery module.")]
//public virtual real MaximumModuleDischargingCurrent { get; set; } = new real;
//[Description("The voltage constraint is for each battery module.")]
//public virtual real ModuleCut-offVoltage { get; set; } = new real;
//[Description("units 1/hr")]
//public virtual real ModuleChargeRateLimit { get; set; } = new real;
//[Description("No description available")]
//public virtual choice BatteryLifeCalculation { get; set; } = new choice;
//[Description("Only required when battery life calculation is activated")]
//public virtual integer NumberOfCycleBins { get; set; } = new integer;
//[Description("Determines the number of cycles to failure in relation to cycle range.")]
//public virtual object-list BatteryLifeCurveName { get; set; } = new object-list;
//}
//}
