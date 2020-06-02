////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class HeatExchanger:Desiccant:BalancedFlow : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node RegenerationAirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node RegenerationAirOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node ProcessAirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node ProcessAirOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual choice HeatExchangerPerformanceObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list HeatExchangerPerformanceName { get; set; } = new object-list;
////[Description("Yes means that the heat exchanger will be locked out (off)")]
////public virtual choice EconomizerLockout { get; set; } = new choice;
////}
////}
