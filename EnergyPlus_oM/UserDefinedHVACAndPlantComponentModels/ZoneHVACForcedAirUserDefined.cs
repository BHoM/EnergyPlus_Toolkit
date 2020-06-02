////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class ZoneHVAC:ForcedAir:UserDefined : BHoMObject
////{
////[Description("This is the name of the zone unit")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual object-list OverallModelSimulationProgramCallingManagerName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ModelSetupAndSizingProgramCallingManagerName { get; set; } = new object-list;
////[Description("Air inlet node for the unit must be a zone air exhaust Node.")]
////public virtual node PrimaryAirInletNodeName { get; set; } = new node;
////[Description("Air outlet node for the unit must be a zone air inlet node.")]
////public virtual node PrimaryAirOutletNodeName { get; set; } = new node;
////[Description("Inlet air used for heat rejection or air source")]
////public virtual node SecondaryAirInletNodeName { get; set; } = new node;
////[Description("Outlet air used for heat rejection or air source")]
////public virtual node SecondaryAirOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual integer NumberOfPlantLoopConnections { get; set; } = new integer;
////[Description("No description available")]
////public virtual node PlantConnection1InletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node PlantConnection1OutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node PlantConnection2InletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node PlantConnection2OutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node PlantConnection3InletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node PlantConnection3OutletNodeName { get; set; } = new node;
////[Description("Water use storage tank for alternate source of water consumed by device")]
////public virtual object-list SupplyInletWaterStorageTankName { get; set; } = new object-list;
////[Description("Water use storage tank for collection of condensate by device")]
////public virtual object-list CollectionOutletWaterStorageTankName { get; set; } = new object-list;
////[Description("Used for modeling device losses to surrounding zone")]
////public virtual object-list AmbientZoneName { get; set; } = new object-list;
////}
////}
