////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class AirTerminal:SingleDuct:SeriesPIU:Reheat : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real MaximumAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumPrimaryAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real MinimumPrimaryAirFlowFraction { get; set; } = new real;
////[Description("No description available")]
////public virtual node SupplyAirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node SecondaryAirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node OutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node ReheatCoilAirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual object-list ZoneMixerName { get; set; } = new object-list;
////[Description("Fan type must be Fan:SystemModel or Fan:ConstantVolume")]
////public virtual object-list FanName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice ReheatCoilObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ReheatCoilName { get; set; } = new object-list;
////[Description("Not used when reheat coil type is gas or electric")]
////public virtual real MaximumHotWaterOrSteamFlowRate { get; set; } = new real;
////[Description("Not used when reheat coil type is gas or electric")]
////public virtual real MinimumHotWaterOrSteamFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real ConvergenceTolerance { get; set; } = new real;
////}
////}
