//using BH.oM.Base;
//using System.Collections.Generic;
//using System.ComponentModel;
//
//namespace BH.oM.EnergyPlus
//{
//public class PlantEquipmentOperation:ThermalEnergyStorage : BHoMObject
//{
//[Description("No description available")]
//public virtual null Name { get; set; } = new null;
//[Description("No description available")]
//public virtual object-list On-PeakSchedule { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list ChargingAvailabilitySchedule { get; set; } = new object-list;
//[Description("Single temperature for chiller outlet when not in cooling season")]
//public virtual real Non-ChargingChilledWaterTemperature { get; set; } = new real;
//[Description("Single temperature for chiller outlet when off-peak during cooling")]
//public virtual real ChargingChilledWaterTemperature { get; set; } = new real;
//[Description("This field is the type of object and should either be a chiller or some")]
//public virtual choice Component1ObjectType { get; set; } = new choice;
//[Description("This field is the name of either the chiller or ice storage equipment")]
//public virtual object-list Component1Name { get; set; } = new object-list;
//[Description("This field is the name of the inlet node for the component defined in")]
//public virtual node Component1DemandCalculationNodeName { get; set; } = new node;
//[Description("This field is the name of the outlet node for the component listed above.")]
//public virtual node Component1SetpointNodeName { get; set; } = new node;
//[Description("This field is the flow rate for the component listed above.")]
//public virtual real Component1FlowRate { get; set; } = new real;
//[Description("This field is the operation type for the component listed above. For this")]
//public virtual choice Component1OperationType { get; set; } = new choice;
//[Description("No description available")]
//public virtual choice Component2ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual object-list Component2Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual node Component2DemandCalculationNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual node Component2SetpointNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual real Component2FlowRate { get; set; } = new real;
//[Description("No description available")]
//public virtual choice Component2OperationType { get; set; } = new choice;
//[Description("No description available")]
//public virtual choice Component3ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual object-list Component3Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual node Component3DemandCalculationNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual node Component3SetpointNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual real Component3FlowRate { get; set; } = new real;
//[Description("No description available")]
//public virtual choice Component3OperationType { get; set; } = new choice;
//[Description("No description available")]
//public virtual choice Component4ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual object-list Component4Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual node Component4DemandCalculationNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual node Component4SetpointNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual real Component4FlowRate { get; set; } = new real;
//[Description("No description available")]
//public virtual choice Component4OperationType { get; set; } = new choice;
//[Description("No description available")]
//public virtual choice Component5ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual object-list Component5Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual node Component5DemandCalculationNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual node Component5SetpointNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual real Component5FlowRate { get; set; } = new real;
//[Description("No description available")]
//public virtual choice Component5OperationType { get; set; } = new choice;
//[Description("No description available")]
//public virtual choice Component6ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual object-list Component6Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual node Component6DemandCalculationNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual node Component6SetpointNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual real Component6FlowRate { get; set; } = new real;
//[Description("No description available")]
//public virtual choice Component6OperationType { get; set; } = new choice;
//[Description("No description available")]
//public virtual choice Component7ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual object-list Component7Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual node Component7DemandCalculationNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual node Component7SetpointNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual real Component7FlowRate { get; set; } = new real;
//[Description("No description available")]
//public virtual choice Component7OperationType { get; set; } = new choice;
//[Description("No description available")]
//public virtual choice Component8ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual object-list Component8Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual node Component8DemandCalculationNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual node Component8SetpointNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual real Component8FlowRate { get; set; } = new real;
//[Description("No description available")]
//public virtual choice Component8OperationType { get; set; } = new choice;
//[Description("No description available")]
//public virtual choice Component9ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual object-list Component9Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual node Component9DemandCalculationNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual node Component9SetpointNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual real Component9FlowRate { get; set; } = new real;
//[Description("No description available")]
//public virtual choice Component9OperationType { get; set; } = new choice;
//[Description("No description available")]
//public virtual choice Component10ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual object-list Component10Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual node Component10DemandCalculationNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual node Component10SetpointNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual real Component10FlowRate { get; set; } = new real;
//[Description("No description available")]
//public virtual choice Component10OperationType { get; set; } = new choice;
//}
//}
