////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class SetpointManager:OutdoorAirPretreat : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("No description available")]
////public virtual choice ControlVariable { get; set; } = new choice;
////[Description("Applicable only if Control variable is Temperature")]
////public virtual null MinimumSetpointTemperature { get; set; } = new null;
////[Description("Applicable only if Control variable is Temperature")]
////public virtual null MaximumSetpointTemperature { get; set; } = new null;
////[Description("Applicable only if Control variable is")]
////public virtual null MinimumSetpointHumidityRatio { get; set; } = new null;
////[Description("Applicable only if Control variable is")]
////public virtual null MaximumSetpointHumidityRatio { get; set; } = new null;
////[Description("The current setpoint at this node is the")]
////public virtual node ReferenceSetpointNodeName { get; set; } = new node;
////[Description("Name of Mixed Air Node")]
////public virtual node MixedAirStreamNodeName { get; set; } = new node;
////[Description("Name of Outdoor Air Stream Node")]
////public virtual node OutdoorAirStreamNodeName { get; set; } = new node;
////[Description("Name of Return Air Stream Node")]
////public virtual node ReturnAirStreamNodeName { get; set; } = new node;
////[Description("Node(s) at which the temperature or humidity")]
////public virtual node SetpointNodeOrNodeListName { get; set; } = new node;
////}
////}
