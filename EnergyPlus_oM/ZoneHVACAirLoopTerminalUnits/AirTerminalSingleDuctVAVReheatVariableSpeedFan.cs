////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class AirTerminal:SingleDuct:VAV:Reheat:VariableSpeedFan : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real MaximumCoolingAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumHeatingAirFlowRate { get; set; } = new real;
////[Description("fraction of cooling air flow rate")]
////public virtual null ZoneMinimumAirFlowFraction { get; set; } = new null;
////[Description("The name of the HVAC system node that is the air inlet node for the")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("The name of the HVAC system node that is the air outlet node for the")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual choice FanObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list FanName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice HeatingCoilObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list HeatingCoilName { get; set; } = new object-list;
////[Description("Not used when heating coil type is gas or electric")]
////public virtual real MaximumHotWaterOrSteamFlowRate { get; set; } = new real;
////[Description("Not used when heating coil type is gas or electric")]
////public virtual real MinimumHotWaterOrSteamFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real HeatingConvergenceTolerance { get; set; } = new real;
////}
////}
