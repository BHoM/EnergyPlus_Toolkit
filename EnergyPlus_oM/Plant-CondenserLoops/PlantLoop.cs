//using BH.oM.Base;
//using System.Collections.Generic;
//using System.ComponentModel;
//
//namespace BH.oM.EnergyPlus
//{
//public class PlantLoop : BHoMObject
//{
//[Description("No description available")]
//public virtual null Name { get; set; } = new null;
//[Description("No description available")]
//public virtual choice FluidType { get; set; } = new choice;
//[Description("This field is only required when Fluid Type is UserDefinedFluidType")]
//public virtual object-list UserDefinedFluidType { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list PlantEquipmentOperationSchemeName { get; set; } = new object-list;
//[Description("No description available")]
//public virtual node LoopTemperatureSetpointNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual null MaximumLoopTemperature { get; set; } = new null;
//[Description("No description available")]
//public virtual null MinimumLoopTemperature { get; set; } = new null;
//[Description("No description available")]
//public virtual real MaximumLoopFlowRate { get; set; } = new real;
//[Description("No description available")]
//public virtual real MinimumLoopFlowRate { get; set; } = new real;
//[Description("No description available")]
//public virtual real PlantLoopVolume { get; set; } = new real;
//[Description("No description available")]
//public virtual node PlantSideInletNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual node PlantSideOutletNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual object-list PlantSideBranchListName { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list PlantSideConnectorListName { get; set; } = new object-list;
//[Description("No description available")]
//public virtual node DemandSideInletNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual node DemandSideOutletNodeName { get; set; } = new node;
//[Description("No description available")]
//public virtual object-list DemandSideBranchListName { get; set; } = new object-list;
//[Description("No description available")]
//public virtual object-list DemandSideConnectorListName { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice LoadDistributionScheme { get; set; } = new choice;
//[Description("No description available")]
//public virtual object-list AvailabilityManagerListName { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice PlantLoopDemandCalculationScheme { get; set; } = new choice;
//[Description("Specifies a primary-secondary loop configuration. The plant side is the")]
//public virtual choice CommonPipeSimulation { get; set; } = new choice;
//[Description("No description available")]
//public virtual choice PressureSimulationType { get; set; } = new choice;
//[Description("This field is only used to autocalulate the Plant Loop Volume.")]
//public virtual real LoopCirculationTime { get; set; } = new real;
//}
//}