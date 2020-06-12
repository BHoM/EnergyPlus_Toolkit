////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class ZoneHVAC:IdealLoadsAirSystem : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("Must match a zone air inlet node name.")]
////public virtual node ZoneSupplyAirNodeName { get; set; } = new node;
////[Description("Should match a zone air exhaust node name.")]
////public virtual node ZoneExhaustAirNodeName { get; set; } = new node;
////[Description("This field is only required when the Ideal Loads Air System is connected to an")]
////public virtual node SystemInletAirNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual null MaximumHeatingSupplyAirTemperature { get; set; } = new null;
////[Description("No description available")]
////public virtual null MinimumCoolingSupplyAirTemperature { get; set; } = new null;
////[Description("No description available")]
////public virtual null MaximumHeatingSupplyAirHumidityRatio { get; set; } = new null;
////[Description("No description available")]
////public virtual null MinimumCoolingSupplyAirHumidityRatio { get; set; } = new null;
////[Description("No description available")]
////public virtual choice HeatingLimit { get; set; } = new choice;
////[Description("This field is ignored if Heating Limit = NoLimit")]
////public virtual null MaximumHeatingAirFlowRate { get; set; } = new null;
////[Description("This field is ignored if Heating Limit = NoLimit")]
////public virtual null MaximumSensibleHeatingCapacity { get; set; } = new null;
////[Description("No description available")]
////public virtual choice CoolingLimit { get; set; } = new choice;
////[Description("This field is ignored if Cooling Limit = NoLimit")]
////public virtual null MaximumCoolingAirFlowRate { get; set; } = new null;
////[Description("This field is ignored if Cooling Limit = NoLimit")]
////public virtual null MaximumTotalCoolingCapacity { get; set; } = new null;
////[Description("If blank, heating is always available.")]
////public virtual object-list HeatingAvailabilityScheduleName { get; set; } = new object-list;
////[Description("If blank, cooling is always available.")]
////public virtual object-list CoolingAvailabilityScheduleName { get; set; } = new object-list;
////[Description("ConstantSensibleHeatRatio means that the ideal loads system")]
////public virtual choice DehumidificationControlType { get; set; } = new choice;
////[Description("This field is applicable only when Dehumidification Control Type is ConstantSensibleHeatRatio")]
////public virtual null CoolingSensibleHeatRatio { get; set; } = new null;
////[Description("None means that there is no humidification.")]
////public virtual choice HumidificationControlType { get; set; } = new choice;
////[Description("When the name of a DesignSpecification:OutdoorAir object is entered, the minimum")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName { get; set; } = new object-list;
////[Description("This field is required if the system provides outdoor air")]
////public virtual node OutdoorAirInletNodeName { get; set; } = new node;
////[Description("This field controls how the minimum outdoor air flow rate is calculated.")]
////public virtual choice DemandControlledVentilationType { get; set; } = new choice;
////[Description("DifferentialDryBulb and DifferentialEnthalpy will increase the outdoor air flow rate")]
////public virtual choice OutdoorAirEconomizerType { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice HeatRecoveryType { get; set; } = new choice;
////[Description("No description available")]
////public virtual null SensibleHeatRecoveryEffectiveness { get; set; } = new null;
////[Description("Applicable only if Heat Recovery Type is Enthalpy.")]
////public virtual null LatentHeatRecoveryEffectiveness { get; set; } = new null;
////[Description("Enter the name of a DesignSpecificationZoneHVACSizing object.")]
////public virtual object-list DesignSpecificationZoneHVACSizingObjectName { get; set; } = new object-list;
////}
////}