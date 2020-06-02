////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class AirTerminal:SingleDuct:VAV:HeatAndCool:Reheat : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("the outlet node of the damper and the inlet node of the reheat coil")]
////public virtual node DamperAirOutletNodeName { get; set; } = new node;
////[Description("the inlet node to the terminal unit and the damper")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual null MaximumAirFlowRate { get; set; } = new null;
////[Description("fraction of maximum air flow")]
////public virtual null ZoneMinimumAirFlowFraction { get; set; } = new null;
////[Description("No description available")]
////public virtual choice ReheatCoilObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ReheatCoilName { get; set; } = new object-list;
////[Description("Not used when reheat coil type is gas or electric")]
////public virtual null MaximumHotWaterOrSteamFlowRate { get; set; } = new null;
////[Description("Not used when reheat coil type is gas or electric")]
////public virtual null MinimumHotWaterOrSteamFlowRate { get; set; } = new null;
////[Description("The outlet node of the terminal unit and the reheat coil.")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual real ConvergenceTolerance { get; set; } = new real;
////[Description("Specifies the maximum allowable supply air temperature leaving the reheat coil.")]
////public virtual real MaximumReheatAirTemperature { get; set; } = new real;
////}
////}
