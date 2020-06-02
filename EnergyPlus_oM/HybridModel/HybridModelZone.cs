////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class HybridModel:Zone : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("Use measured zone air temperature to calculate zone internal thermal mass.")]
////public virtual choice CalculateZoneInternalThermalMass { get; set; } = new choice;
////[Description("Use measured temperature data (temperature, humidity ratio, or CO2 concentration) to calculate zone air infiltration air flow rate.")]
////public virtual choice CalculateZoneAirInfiltrationRate { get; set; } = new choice;
////[Description("Use measured humidity ratio data (temperature, humidity ratio, or CO2 concentration) to calculate zone people count.")]
////public virtual choice CalculateZonePeopleCount { get; set; } = new choice;
////[Description("from Schedule:File")]
////public virtual object-list ZoneMeasuredAirTemperatureScheduleName { get; set; } = new object-list;
////[Description("from Schedule:File")]
////public virtual object-list ZoneMeasuredAirHumidityRatioScheduleName { get; set; } = new object-list;
////[Description("from Schedule:File")]
////public virtual object-list ZoneMeasuredAirCO2ConcentrationScheduleName { get; set; } = new object-list;
////[Description("When this field is provided and valid, the default people activity level (used to calculate people count) will be overwritten.")]
////public virtual object-list ZoneInputPeopleActivityScheduleName { get; set; } = new object-list;
////[Description("When this field is provided and valid, the default sensible heat fraction from people (used to calculate people count) will be overwritten.")]
////public virtual object-list ZoneInputPeopleSensibleHeatFractionScheduleName { get; set; } = new object-list;
////[Description("When this field is provided and valid, the default radiant heat portion of the sensible heat from people (used to calculate people count) will be overwritten.")]
////public virtual object-list ZoneInputPeopleRadiantHeatFractionScheduleName { get; set; } = new object-list;
////[Description("When this field is provided and valid, the default people CO2 generation rate (used to calculate people count) will be overwritten.")]
////public virtual object-list ZoneInputPeopleCO2GenerationRateScheduleName { get; set; } = new object-list;
////[Description("from Schedule:File")]
////public virtual object-list ZoneInputSupplyAirTemperatureScheduleName { get; set; } = new object-list;
////[Description("from Schedule:File")]
////public virtual object-list ZoneInputSupplyAirMassFlowRateScheduleName { get; set; } = new object-list;
////[Description("from Schedule:File")]
////public virtual object-list ZoneInputSupplyAirHumidityRatioScheduleName { get; set; } = new object-list;
////[Description("from Schedule:File")]
////public virtual object-list ZoneInputSupplyAirCO2ConcentrationScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual integer BeginMonth { get; set; } = new integer;
////[Description("No description available")]
////public virtual integer BeginDayOfMonth { get; set; } = new integer;
////[Description("No description available")]
////public virtual integer EndMonth { get; set; } = new integer;
////[Description("No description available")]
////public virtual integer EndDayOfMonth { get; set; } = new integer;
////}
////}
