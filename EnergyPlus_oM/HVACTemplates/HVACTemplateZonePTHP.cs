////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class HVACTemplate:Zone:PTHP : BHoMObject
////{
////[Description("Zone name must match a building zone name")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("Enter the name of a HVACTemplate:Thermostat object.")]
////public virtual object-list TemplateThermostatName { get; set; } = new object-list;
////[Description("Supply air flow rate during cooling operation")]
////public virtual real CoolingSupplyAirFlowRate { get; set; } = new real;
////[Description("Supply air flow rate during heating operation")]
////public virtual real HeatingSupplyAirFlowRate { get; set; } = new real;
////[Description("Supply air flow rate when no cooling or heating is needed")]
////public virtual real NoLoadSupplyAirFlowRate { get; set; } = new real;
////[Description("If blank, value from Sizing:Parameters will be used.")]
////public virtual null ZoneHeatingSizingFactor { get; set; } = new null;
////[Description("If blank, value from Sizing:Parameters will be used.")]
////public virtual null ZoneCoolingSizingFactor { get; set; } = new null;
////[Description("Flow/Person, Flow/Zone, Flow/Area, Sum, and Maximum use the values in the next three")]
////public virtual choice OutdoorAirMethod { get; set; } = new choice;
////[Description("Default 0.00944 is 20 cfm per person")]
////public virtual null OutdoorAirFlowRatePerPerson { get; set; } = new null;
////[Description("This input is used if the field Outdoor Air Method is")]
////public virtual null OutdoorAirFlowRatePerZoneFloorArea { get; set; } = new null;
////[Description("This input is used if the field Outdoor Air Method is")]
////public virtual real OutdoorAirFlowRatePerZone { get; set; } = new real;
////[Description("If blank, always on")]
////public virtual object-list SystemAvailabilityScheduleName { get; set; } = new object-list;
////[Description("Refers to a schedule to specify unitary supply fan operating mode.")]
////public virtual object-list SupplyFanOperatingModeScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice SupplyFanPlacement { get; set; } = new choice;
////[Description("No description available")]
////public virtual null SupplyFanTotalEfficiency { get; set; } = new null;
////[Description("No description available")]
////public virtual null SupplyFanDeltaPressure { get; set; } = new null;
////[Description("No description available")]
////public virtual null SupplyFanMotorEfficiency { get; set; } = new null;
////[Description("No description available")]
////public virtual choice CoolingCoilType { get; set; } = new choice;
////[Description("If blank, always on")]
////public virtual object-list CoolingCoilAvailabilityScheduleName { get; set; } = new object-list;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual real CoolingCoilGrossRatedTotalCapacity { get; set; } = new real;
////[Description("Rated sensible heat ratio (gross sensible capacity/gross total capacity)")]
////public virtual real CoolingCoilGrossRatedSensibleHeatRatio { get; set; } = new real;
////[Description("Gross cooling capacity divided by power input to the compressor and outdoor fan,")]
////public virtual real CoolingCoilGrossRatedCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual choice HeatPumpHeatingCoilType { get; set; } = new choice;
////[Description("If blank, always on")]
////public virtual object-list HeatPumpHeatingCoilAvailabilityScheduleName { get; set; } = new object-list;
////[Description("Capacity excluding supply air fan heat")]
////public virtual real HeatPumpHeatingCoilGrossRatedCapacity { get; set; } = new real;
////[Description("Heat Pump Heating Coil Rated Capacity divided by power input to the compressor and outdoor fan,")]
////public virtual null HeatPumpHeatingCoilGrossRatedCOP { get; set; } = new null;
////[Description("No description available")]
////public virtual real HeatPumpHeatingMinimumOutdoorDry-BulbTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual real HeatPumpDefrostMaximumOutdoorDry-BulbTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual choice HeatPumpDefrostStrategy { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice HeatPumpDefrostControl { get; set; } = new choice;
////[Description("Fraction of time in defrost mode")]
////public virtual real HeatPumpDefrostTimePeriodFraction { get; set; } = new real;
////[Description("No description available")]
////public virtual choice SupplementalHeatingCoilType { get; set; } = new choice;
////[Description("If blank, always on")]
////public virtual object-list SupplementalHeatingCoilAvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null SupplementalHeatingCoilCapacity { get; set; } = new null;
////[Description("Supplemental heater will not operate when outdoor temperature exceeds this value.")]
////public virtual real SupplementalHeatingCoilMaximumOutdoorDry-BulbTemperature { get; set; } = new real;
////[Description("Applies only if Supplemental Heating Coil Type is Gas")]
////public virtual null SupplementalGasHeatingCoilEfficiency { get; set; } = new null;
////[Description("Applies only if Supplemental Heating Coil Type is Gas")]
////public virtual null SupplementalGasHeatingCoilParasiticElectricLoad { get; set; } = new null;
////[Description("Enter the name of an HVACTemplate:System:DedicatedOutdoorAir object if this")]
////public virtual object-list DedicatedOutdoorAirSystemName { get; set; } = new object-list;
////[Description("SupplyAirTemperature = use the value from Zone Cooling Design Supply Air Temperature")]
////public virtual choice ZoneCoolingDesignSupplyAirTemperatureInputMethod { get; set; } = new choice;
////[Description("Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design")]
////public virtual real ZoneCoolingDesignSupplyAirTemperature { get; set; } = new real;
////[Description("Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design")]
////public virtual real ZoneCoolingDesignSupplyAirTemperatureDifference { get; set; } = new real;
////[Description("SupplyAirTemperature = use the value from Zone Heating Design Supply Air Temperature")]
////public virtual choice ZoneHeatingDesignSupplyAirTemperatureInputMethod { get; set; } = new choice;
////[Description("Zone Heating Design Supply Air Temperature is only used when Zone Heating Design")]
////public virtual real ZoneHeatingDesignSupplyAirTemperature { get; set; } = new real;
////[Description("Zone Heating Design Supply Air Temperature is only used when Zone Heating Design")]
////public virtual real ZoneHeatingDesignSupplyAirTemperatureDifference { get; set; } = new real;
////[Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName { get; set; } = new object-list;
////[Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice BaseboardHeatingType { get; set; } = new choice;
////[Description("If blank, always on")]
////public virtual object-list BaseboardHeatingAvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null BaseboardHeatingCapacity { get; set; } = new null;
////[Description("No description available")]
////public virtual choice CapacityControlMethod { get; set; } = new choice;
////}
////}
