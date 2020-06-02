////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Coil:Heating:Steam : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null MaximumSteamFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual null DegreeOfSubCooling { get; set; } = new null;
////[Description("No description available")]
////public virtual null DegreeOfLoopSubCooling { get; set; } = new null;
////[Description("No description available")]
////public virtual node WaterInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node WaterOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("Use ZoneLoadControl if the coil is contained within another component such as an air")]
////public virtual choice CoilControlType { get; set; } = new choice;
////[Description("Required if Coil Control Type is TemperatureSetpointControl")]
////public virtual node TemperatureSetpointNodeName { get; set; } = new node;
////}
////}
