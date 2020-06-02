////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class EvaporativeCooler:Direct:ResearchSpecial : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("effectiveness with respect to wet-bulb depression")]
////public virtual real CoolerDesignEffectiveness { get; set; } = new real;
////[Description("this curve modifies the design effectiveness in the previous field")]
////public virtual object-list EffectivenessFlowRatioModifierCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real PrimaryAirDesignFlowRate { get; set; } = new real;
////[Description("This is the design water pump or spray for evaporation at the primary air design air flow rates")]
////public virtual null RecirculatingWaterPumpDesignPower { get; set; } = new null;
////[Description("This field is used when the previous field is set to autosize. The pump power is scaled with Primary Air")]
////public virtual real WaterPumpPowerSizingFactor { get; set; } = new real;
////[Description("this curve modifies the pump power in the previous field by multiplying the design power by the result of this curve.")]
////public virtual object-list WaterPumpPowerModifierCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node SensorNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual object-list WaterSupplyStorageTankName { get; set; } = new object-list;
////[Description("Rate of drift loss as a fraction of evaporated water flow rate")]
////public virtual real DriftLossFraction { get; set; } = new real;
////[Description("Characterizes the rate of blowdown in the evaporative cooler.")]
////public virtual real BlowdownConcentrationRatio { get; set; } = new real;
////[Description("This numeric field defines the evaporative cooler air inlet node drybulb temperature minimum")]
////public virtual real EvaporativeOperationMinimumDrybulbTemperature { get; set; } = new real;
////[Description("when outdoor wetbulb temperature rises above this limit the cooler shuts down.")]
////public virtual real EvaporativeOperationMaximumLimitWetbulbTemperature { get; set; } = new real;
////[Description("This numeric field defines the evaporative cooler air inlet node dry-bulb temperature maximum")]
////public virtual real EvaporativeOperationMaximumLimitDrybulbTemperature { get; set; } = new real;
////}
////}
