////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Fan:SystemModel : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("Availability schedule name for this fan. Schedule value > 0 means the fan is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual real DesignMaximumAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual choice SpeedControlMethod { get; set; } = new choice;
////[Description("No description available")]
////public virtual real ElectricPowerMinimumFlowRateFraction { get; set; } = new real;
////[Description("No description available")]
////public virtual real DesignPressureRise { get; set; } = new real;
////[Description("No description available")]
////public virtual real MotorEfficiency { get; set; } = new real;
////[Description("0.0 means fan motor outside of air stream, 1.0 means motor inside of air stream")]
////public virtual real MotorInAirStreamFraction { get; set; } = new real;
////[Description("Fan power consumption at maximum air flow rate.")]
////public virtual real DesignElectricPowerConsumption { get; set; } = new real;
////[Description("No description available")]
////public virtual choice DesignPowerSizingMethod { get; set; } = new choice;
////[Description("No description available")]
////public virtual real ElectricPowerPerUnitFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real ElectricPowerPerUnitFlowRatePerUnitPressure { get; set; } = new real;
////[Description("No description available")]
////public virtual real FanTotalEfficiency { get; set; } = new real;
////[Description("independent variable is normalized flow rate, current flow divided by Design Maximum Air Flow Rate.")]
////public virtual object-list ElectricPowerFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("Total system fan pressure rise at the fan when in night mode using AvailabilityManager:NightVentilation")]
////public virtual real NightVentilationModePressureRise { get; set; } = new real;
////[Description("Fraction of Design Maximum Air Flow Rate to use when in night mode using AvailabilityManager:NightVentilation")]
////public virtual real NightVentilationModeFlowFraction { get; set; } = new real;
////[Description("optional, if used fan motor heat losses that not added to air stream are transferred to zone as internal gains")]
////public virtual object-list MotorLossZoneName { get; set; } = new object-list;
////[Description("optional. If zone identified in previous field then this determines")]
////public virtual real MotorLossRadiativeFraction { get; set; } = new real;
////[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Subcategory table.")]
////public virtual alpha End-UseSubcategory { get; set; } = new alpha;
////[Description("number of different speed levels available when Speed Control Method is set to Discrete")]
////public virtual integer NumberOfSpeeds { get; set; } = new integer;
////[Description("No description available")]
////public virtual real Speed1FlowFraction { get; set; } = new real;
////[Description("if left blank then use Electric Power Function of Flow Fraction Curve")]
////public virtual real Speed1ElectricPowerFraction { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed2FlowFraction { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed2ElectricPowerFraction { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed3FlowFraction { get; set; } = new real;
////[Description("No description available")]
////public virtual real Speed3ElectricPowerFraction { get; set; } = new real;
////[Description("No description available")]
////public virtual real SpeedNFlowFraction { get; set; } = new real;
////[Description("No description available")]
////public virtual real SpeedNElectricPowerFraction { get; set; } = new real;
////}
////}
