////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class SetpointManager:MixedAir : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("No description available")]
////public virtual choice ControlVariable { get; set; } = new choice;
////[Description("No description available")]
////public virtual node ReferenceSetpointNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node FanInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node FanOutletNodeName { get; set; } = new node;
////[Description("Node(s) at which the temperature will be set")]
////public virtual node SetpointNodeOrNodeListName { get; set; } = new node;
////[Description("Optional field used to limit economizer operation to prevent freezing of DX cooling coil.")]
////public virtual node CoolingCoilInletNodeName { get; set; } = new node;
////[Description("Optional field used to limit economizer operation to prevent freezing of DX cooling coil.")]
////public virtual node CoolingCoilOutletNodeName { get; set; } = new node;
////[Description("Optional field used to limit economizer operation to prevent freezing of DX cooling coil.")]
////public virtual real MinimumTemperatureAtCoolingCoilOutletNode { get; set; } = new real;
////}
////}
