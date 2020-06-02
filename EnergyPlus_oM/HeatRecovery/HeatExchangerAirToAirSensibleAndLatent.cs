////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class HeatExchanger:AirToAir:SensibleAndLatent : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real NominalSupplyAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real SensibleEffectivenessAt100%HeatingAirFlow { get; set; } = new real;
////[Description("No description available")]
////public virtual real LatentEffectivenessAt100%HeatingAirFlow { get; set; } = new real;
////[Description("No description available")]
////public virtual real SensibleEffectivenessAt75%HeatingAirFlow { get; set; } = new real;
////[Description("No description available")]
////public virtual real LatentEffectivenessAt75%HeatingAirFlow { get; set; } = new real;
////[Description("No description available")]
////public virtual real SensibleEffectivenessAt100%CoolingAirFlow { get; set; } = new real;
////[Description("No description available")]
////public virtual real LatentEffectivenessAt100%CoolingAirFlow { get; set; } = new real;
////[Description("No description available")]
////public virtual real SensibleEffectivenessAt75%CoolingAirFlow { get; set; } = new real;
////[Description("No description available")]
////public virtual real LatentEffectivenessAt75%CoolingAirFlow { get; set; } = new real;
////[Description("No description available")]
////public virtual node SupplyAirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node SupplyAirOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node ExhaustAirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node ExhaustAirOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual real NominalElectricPower { get; set; } = new real;
////[Description("No description available")]
////public virtual choice SupplyAirOutletTemperatureControl { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice HeatExchangerType { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice FrostControlType { get; set; } = new choice;
////[Description("Supply (outdoor) air inlet temp threshold for exhaust air recirculation and")]
////public virtual real ThresholdTemperature { get; set; } = new real;
////[Description("Fraction of the time when frost control will be invoked at the threshold temperature.")]
////public virtual real InitialDefrostTimeFraction { get; set; } = new real;
////[Description("Rate of increase in defrost time fraction as actual temp falls below threshold temperature.")]
////public virtual real RateOfDefrostTimeFractionIncrease { get; set; } = new real;
////[Description("Yes means that the heat exchanger will be locked out (off)")]
////public virtual choice EconomizerLockout { get; set; } = new choice;
////}
////}
