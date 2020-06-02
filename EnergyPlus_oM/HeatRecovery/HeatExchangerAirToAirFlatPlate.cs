////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class HeatExchanger:AirToAir:FlatPlate : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice FlowArrangementType { get; set; } = new choice;
////[Description("Yes means that the heat exchanger will be locked out (off)")]
////public virtual choice EconomizerLockout { get; set; } = new choice;
////[Description("Ratio of h*A for supply side to h*A for exhaust side")]
////public virtual real RatioOfSupplyToSecondaryHAValues { get; set; } = new real;
////[Description("No description available")]
////public virtual real NominalSupplyAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real NominalSupplyAirInletTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual real NominalSupplyAirOutletTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual real NominalSecondaryAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real NominalSecondaryAirInletTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual real NominalElectricPower { get; set; } = new real;
////[Description("No description available")]
////public virtual node SupplyAirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node SupplyAirOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node SecondaryAirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node SecondaryAirOutletNodeName { get; set; } = new node;
////}
////}
