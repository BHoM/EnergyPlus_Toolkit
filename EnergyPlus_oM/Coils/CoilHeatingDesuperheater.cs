////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Coil:Heating:Desuperheater : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real HeatReclaimRecoveryEfficiency { get; set; } = new real;
////[Description("No description available")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual choice HeatingSourceObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list HeatingSourceName { get; set; } = new object-list;
////[Description("Required if coil is temperature controlled.")]
////public virtual node TemperatureSetpointNodeName { get; set; } = new node;
////[Description("parasitic electric load associated with the desuperheater coil operation")]
////public virtual real ParasiticElectricLoad { get; set; } = new real;
////}
////}
