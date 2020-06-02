////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Fan:ZoneExhaust : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real FanTotalEfficiency { get; set; } = new real;
////[Description("No description available")]
////public virtual null PressureRise { get; set; } = new null;
////[Description("No description available")]
////public virtual null MaximumFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Subcategory table.")]
////public virtual alpha End-UseSubcategory { get; set; } = new alpha;
////[Description("If field is used, then when fan runs the exhausted air flow rate is controlled to be the scheduled fraction times the Maximum Flow Rate")]
////public virtual object-list FlowFractionScheduleName { get; set; } = new object-list;
////[Description("Control if fan is to be interlocked with HVAC system Availability Managers or not.")]
////public virtual choice SystemAvailabilityManagerCouplingMode { get; set; } = new choice;
////[Description("If field is used, the exhaust fan will not run if the zone temperature is lower than this limit")]
////public virtual object-list MinimumZoneTemperatureLimitScheduleName { get; set; } = new object-list;
////[Description("Used to control fan's impact on flow at the return air node. Enter the portion of the exhaust that is balanced by simple airflows.")]
////public virtual object-list BalancedExhaustFractionScheduleName { get; set; } = new object-list;
////}
////}
