////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Sizing:Zone : BHoMObject
////{
////[Description("No description available")]
////public virtual string ZoneOrZoneListName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice ZoneCoolingDesignSupplyAirTemperatureInputMethod { get; set; } = new choice;
////[Description("Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design")]
////public virtual real ZoneCoolingDesignSupplyAirTemperature { get; set; } = new real;
////[Description("Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design")]
////public virtual real ZoneCoolingDesignSupplyAirTemperatureDifference { get; set; } = new real;
////[Description("No description available")]
////public virtual choice ZoneHeatingDesignSupplyAirTemperatureInputMethod { get; set; } = new choice;
////[Description("Zone Heating Design Supply Air Temperature is only used when Zone Heating Design")]
////public virtual real ZoneHeatingDesignSupplyAirTemperature { get; set; } = new real;
////[Description("Zone Heating Design Supply Air Temperature is only used when Zone Heating Design")]
////public virtual real ZoneHeatingDesignSupplyAirTemperatureDifference { get; set; } = new real;
////[Description("No description available")]
////public virtual real ZoneCoolingDesignSupplyAirHumidityRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real ZoneHeatingDesignSupplyAirHumidityRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName { get; set; } = new object-list;
////[Description("if blank or zero, global heating sizing factor from Sizing:Parameters is used.")]
////public virtual null ZoneHeatingSizingFactor { get; set; } = new null;
////[Description("if blank or zero, global cooling sizing factor from Sizing:Parameters is used.")]
////public virtual null ZoneCoolingSizingFactor { get; set; } = new null;
////[Description("No description available")]
////public virtual choice CoolingDesignAirFlowMethod { get; set; } = new choice;
////[Description("This input is used if Cooling Design Air Flow Method is Flow/Zone")]
////public virtual real CoolingDesignAirFlowRate { get; set; } = new real;
////[Description("default is .15 cfm/ft2")]
////public virtual real CoolingMinimumAirFlowPerZoneFloorArea { get; set; } = new real;
////[Description("This input is used if Cooling Design Air Flow Method is DesignDayWithLimit")]
////public virtual real CoolingMinimumAirFlow { get; set; } = new real;
////[Description("fraction of the Cooling design Air Flow Rate")]
////public virtual real CoolingMinimumAirFlowFraction { get; set; } = new real;
////[Description("No description available")]
////public virtual choice HeatingDesignAirFlowMethod { get; set; } = new choice;
////[Description("This input is used if Heating Design Air Flow Method is Flow/Zone.")]
////public virtual real HeatingDesignAirFlowRate { get; set; } = new real;
////[Description("default is .40 cfm/ft2")]
////public virtual real HeatingMaximumAirFlowPerZoneFloorArea { get; set; } = new real;
////[Description("default is 300 cfm")]
////public virtual real HeatingMaximumAirFlow { get; set; } = new real;
////[Description("fraction of the Heating Design Air Flow Rate")]
////public virtual real HeatingMaximumAirFlowFraction { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName { get; set; } = new object-list;
////[Description("account for effect of dedicated outdoor air system supplying air directly to the zone")]
////public virtual choice AccountForDedicatedOutdoorAirSystem { get; set; } = new choice;
////[Description("1)supply neutral ventilation air; 2)supply neutral dehumidified and reheated")]
////public virtual choice DedicatedOutdoorAirSystemControlStrategy { get; set; } = new choice;
////[Description("No description available")]
////public virtual real DedicatedOutdoorAirLowSetpointTemperatureForDesign { get; set; } = new real;
////[Description("No description available")]
////public virtual real DedicatedOutdoorAirHighSetpointTemperatureForDesign { get; set; } = new real;
////}
////}
