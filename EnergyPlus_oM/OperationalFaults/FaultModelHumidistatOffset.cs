////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class FaultModel:HumidistatOffset : BHoMObject
////{
////[Description("Enter the name of the fault")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Enter the name of a ZoneControl:Humidistat object.")]
////public virtual object-list HumidistatName { get; set; } = new object-list;
////[Description("Two types are available:")]
////public virtual choice HumidistatOffsetType { get; set; } = new choice;
////[Description("This field is applicable for Type ThermostatOffsetIndependent")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("This field is applicable for Type ThermostatOffsetIndependent")]
////public virtual object-list SeverityScheduleName { get; set; } = new object-list;
////[Description("Required field for Type ThermostatOffsetIndependent")]
////public virtual real ReferenceHumidistatOffset { get; set; } = new real;
////[Description("Enter the name of a FaultModel:ThermostatOffset object")]
////public virtual object-list RelatedThermostatOffsetFaultName { get; set; } = new object-list;
////}
////}
