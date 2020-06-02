////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class PlantComponent:UserDefined : BHoMObject
////{
////[Description("This is the name of the plant component")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual object-list MainModelProgramCallingManagerName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual integer NumberOfPlantLoopConnections { get; set; } = new integer;
////[Description("No description available")]
////public virtual node PlantConnection1InletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node PlantConnection1OutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual choice PlantConnection1LoadingMode { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PlantConnection1LoopFlowRequestMode { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list PlantConnection1InitializationProgramCallingManagerName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list PlantConnection1SimulationProgramCallingManagerName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node PlantConnection2InletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node PlantConnection2OutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual choice PlantConnection2LoadingMode { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PlantConnection2LoopFlowRequestMode { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list PlantConnection2InitializationProgramCallingManagerName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list PlantConnection2SimulationProgramCallingManagerName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node PlantConnection3InletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node PlantConnection3OutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual choice PlantConnection3LoadingMode { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PlantConnection3LoopFlowRequestMode { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list PlantConnection3InitializationProgramCallingManagerName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list PlantConnection3SimulationProgramCallingManagerName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node PlantConnection4InletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node PlantConnection4OutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual choice PlantConnection4LoadingMode { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice PlantConnection4LoopFlowRequestMode { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list PlantConnection4InitializationProgramCallingManagerName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list PlantConnection4SimulationProgramCallingManagerName { get; set; } = new object-list;
////[Description("Inlet air used for heat rejection or air source")]
////public virtual node AirConnectionInletNodeName { get; set; } = new node;
////[Description("Outlet air used for heat rejection or air source")]
////public virtual node AirConnectionOutletNodeName { get; set; } = new node;
////[Description("Water use storage tank for alternate source of water consumed by device")]
////public virtual object-list SupplyInletWaterStorageTankName { get; set; } = new object-list;
////[Description("Water use storage tank for collection of condensate by device")]
////public virtual object-list CollectionOutletWaterStorageTankName { get; set; } = new object-list;
////[Description("Used for modeling device losses to surrounding zone")]
////public virtual object-list AmbientZoneName { get; set; } = new object-list;
////}
////}
