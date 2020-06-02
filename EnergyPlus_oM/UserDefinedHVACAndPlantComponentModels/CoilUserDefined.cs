////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Coil:UserDefined : BHoMObject
////{
////[Description("This is the name of the coil")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual object-list OverallModelSimulationProgramCallingManagerName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ModelSetupAndSizingProgramCallingManagerName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual integer NumberOfAirConnections { get; set; } = new integer;
////[Description("Inlet air for primary air stream")]
////public virtual node AirConnection1InletNodeName { get; set; } = new node;
////[Description("Outlet air for primary air stream")]
////public virtual node AirConnection1OutletNodeName { get; set; } = new node;
////[Description("Inlet air for secondary air stream")]
////public virtual node AirConnection2InletNodeName { get; set; } = new node;
////[Description("Outlet air for secondary air stream")]
////public virtual node AirConnection2OutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual choice PlantConnectionIsUsed { get; set; } = new choice;
////[Description("No description available")]
////public virtual node PlantConnectionInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node PlantConnectionOutletNodeName { get; set; } = new node;
////[Description("Water use storage tank for alternate source of water consumed by device")]
////public virtual object-list SupplyInletWaterStorageTankName { get; set; } = new object-list;
////[Description("Water use storage tank for collection of condensate by device")]
////public virtual object-list CollectionOutletWaterStorageTankName { get; set; } = new object-list;
////[Description("Used for modeling device losses to surrounding zone")]
////public virtual object-list AmbientZoneName { get; set; } = new object-list;
////}
////}
