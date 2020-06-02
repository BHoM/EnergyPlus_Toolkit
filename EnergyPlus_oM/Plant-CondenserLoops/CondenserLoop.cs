//using BH.oM.Base;
//using System.Collections.Generic;
//using System.ComponentModel;
//
//namespace BH.oM.EnergyPlus
//{
//public class CondenserLoop : BHoMObject
//{
//[Description("No description available")]
//public virtual null Name { get; set; } = new null;
//[Description("No description available")]
//public virtual choice FluidType { get; set; } = new choice;
//[Description("This field is only required when Fluid Type is UserDefinedFluidType")]
//public virtual object-list UserDefinedFluidType { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list CondenserEquipmentOperationSchemeName { get; set; } = new object-list;
//[Description("No description available")]
//public virtual node CondenserLoopTemperatureSetpointNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual null MaximumLoopTemperature { get; set; } = new null;
//[Description("No description available")]
//public virtual null MinimumLoopTemperature { get; set; } = new null;
//[Description("No description available")]
//public virtual real MaximumLoopFlowRate { get; set; } = new real;
//[Description("No description available")]
//public virtual real MinimumLoopFlowRate { get; set; } = new real;
//[Description("No description available")]
//public virtual real CondenserLoopVolume { get; set; } = new real;
//[Description("No description available")]
//public virtual node CondenserSideInletNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual node CondenserSideOutletNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual object-list CondenserSideBranchListName { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list CondenserSideConnectorListName { get; set; } = new object-list;
//[Description("No description available")]
//public virtual node DemandSideInletNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual node DemandSideOutletNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual object-list CondenserDemandSideBranchListName { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list CondenserDemandSideConnectorListName { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice LoadDistributionScheme { get; set; } = new choice;
//[Description("No description available")]
//public virtual choice PressureSimulationType { get; set; } = new choice;
//[Description("This field is only used to autocalulate the Condenser Loop Volume.")]
//public virtual real LoopCirculationTime { get; set; } = new real;
//}
//}
