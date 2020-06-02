////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class AirLoopHVAC : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Enter the name of an AirLoopHVAC:ControllerList object.")]
////public virtual object-list ControllerListName { get; set; } = new object-list;
////[Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
////public virtual object-list AvailabilityManagerListName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null DesignSupplyAirFlowRate { get; set; } = new null;
////[Description("Name of a BranchList containing all the branches in this air loop")]
////public virtual object-list BranchListName { get; set; } = new object-list;
////[Description("Name of a ConnectorList containing all the splitters and mixers in the loop")]
////public virtual object-list ConnectorListName { get; set; } = new object-list;
////[Description("Name of inlet node where air enters the supply side of the air loop.")]
////public virtual node SupplySideInletNodeName { get; set; } = new node;
////[Description("Name of outlet node where return air leaves the demand side and enters the supply side.")]
////public virtual node DemandSideOutletNodeName { get; set; } = new node;
////[Description("Name of a Node or NodeList containing the inlet node(s) supplying air to zone equipment.")]
////public virtual node DemandSideInletNodeNames { get; set; } = new node;
////[Description("Name of a Node or NodeList containing the outlet node(s) supplying air to the demand side.")]
////public virtual node SupplySideOutletNodeNames { get; set; } = new node;
////[Description("The design return air flow rate as a fraction of supply air flow rate with no exhaust.")]
////public virtual null DesignReturnAirFlowFractionOfSupplyAirFlow { get; set; } = new null;
////}
////}
