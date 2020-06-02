////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class AirTerminal:DualDuct:VAV:OutdoorAir : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("The outlet node of the terminal unit.")]
////public virtual null AirOutletNodeName { get; set; } = new null;
////[Description("No description available")]
////public virtual node OutdoorAirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node RecirculatedAirInletNodeName { get; set; } = new node;
////[Description("If autosized this is the sum of flow needed for cooling and maximum required outdoor air")]
////public virtual null MaximumTerminalAirFlowRate { get; set; } = new null;
////[Description("When the name of a DesignSpecification:OutdoorAir object is entered, the terminal")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName { get; set; } = new object-list;
////[Description("CurrentOccupancy models demand controlled ventilation using the current number of people")]
////public virtual choice PerPersonVentilationRateMode { get; set; } = new choice;
////}
////}
