////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class HVACTemplate:Zone:VAV:FanPowered : BHoMObject
////{
////[Description("Zone Name must match a building zone name")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("Enter the name of a HVACTemplate:System:VAV or HVACTemplate:System:PackagedVAV")]
////public virtual object-list TemplateVAVSystemName { get; set; } = new object-list;
////[Description("Enter the name of a HVACTemplate:Thermostat object.")]
////public virtual object-list TemplateThermostatName { get; set; } = new object-list;
////[Description("This field may be set to "autosize". If a value is entered, it will be")]
////public virtual null PrimarySupplyAirMaximumFlowRate { get; set; } = new null;
////[Description("If blank, value from Sizing:Parameters will be used.")]
////public virtual null ZoneHeatingSizingFactor { get; set; } = new null;
////[Description("If blank, value from Sizing:Parameters will be used.")]
////public virtual null ZoneCoolingSizingFactor { get; set; } = new null;
////[Description("No description available")]
////public virtual null PrimarySupplyAirMinimumFlowFraction { get; set; } = new null;
////[Description("This field may be set to "autosize". If a value is entered, it will be")]
////public virtual null SecondarySupplyAirMaximumFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual choice FlowType { get; set; } = new choice;
////[Description("The fraction of the primary air flow at which fan turns on")]
////public virtual null ParallelFanOnFlowFraction { get; set; } = new null;
////[Description("Flow/Person, Flow/Zone, Flow/Area, Sum, and Maximum use the values in the next three")]
////public virtual choice OutdoorAirMethod { get; set; } = new choice;
////[Description("Default 0.00944 is 20 cfm per person")]
////public virtual null OutdoorAirFlowRatePerPerson { get; set; } = new null;
////[Description("This input is used if the field Outdoor Air Method is")]
////public virtual null OutdoorAirFlowRatePerZoneFloorArea { get; set; } = new null;
////[Description("This input is used if the field Outdoor Air Method is")]
////public virtual real OutdoorAirFlowRatePerZone { get; set; } = new real;
////[Description("No description available")]
////public virtual choice ReheatCoilType { get; set; } = new choice;
////[Description("If blank, always on")]
////public virtual object-list ReheatCoilAvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null FanTotalEfficiency { get; set; } = new null;
////[Description("No description available")]
////public virtual null FanDeltaPressure { get; set; } = new null;
////[Description("No description available")]
////public virtual null FanMotorEfficiency { get; set; } = new null;
////[Description("Plenum zone name. Supply plenum runs through only this zone.")]
////public virtual object-list SupplyPlenumName { get; set; } = new object-list;
////[Description("Plenum zone name. Return plenum runs through only this zone.")]
////public virtual object-list ReturnPlenumName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice BaseboardHeatingType { get; set; } = new choice;
////[Description("If blank, always on")]
////public virtual object-list BaseboardHeatingAvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null BaseboardHeatingCapacity { get; set; } = new null;
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
////[Description("This is the operating schedule for the zone PIU fan.")]
////public virtual object-list ZonePIUFanScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName { get; set; } = new object-list;
////}
////}
