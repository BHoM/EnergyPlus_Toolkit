////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class AirTerminal:SingleDuct:ConstantVolume:FourPipeInduction : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real MaximumTotalAirFlowRate { get; set; } = new real;
////[Description("ratio of induced air flow rate to primary air flow rate")]
////public virtual real InductionRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual node SupplyAirInletNodeName { get; set; } = new node;
////[Description("should be a zone exhaust node, also the heating coil inlet node")]
////public virtual node InducedAirInletNodeName { get; set; } = new node;
////[Description("should be a zone inlet node")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual choice HeatingCoilObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list HeatingCoilName { get; set; } = new object-list;
////[Description("Not used when heating coil type is gas or electric")]
////public virtual real MaximumHotWaterFlowRate { get; set; } = new real;
////[Description("Not used when heating coil type is gas or electric")]
////public virtual real MinimumHotWaterFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real HeatingConvergenceTolerance { get; set; } = new real;
////[Description("No description available")]
////public virtual choice CoolingCoilObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list CoolingCoilName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real MaximumColdWaterFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real MinimumColdWaterFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real CoolingConvergenceTolerance { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list ZoneMixerName { get; set; } = new object-list;
////}
////}
