////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class AirTerminal:SingleDuct:ConstantVolume:NoReheat : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("The air-inlet node name that connects the air splitter to the individual zone air distribution")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("This is an air outlet node from the air distribution unit. This node name should be one of the")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual null MaximumAirFlowRate { get; set; } = new null;
////[Description("This field is used to modulate the terminal unit flow rate based on the specified outdoor air")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName { get; set; } = new object-list;
////[Description("CurrentOccupancy uses current number of people in the zone which may vary")]
////public virtual choice PerPersonVentilationRateMode { get; set; } = new choice;
////}
////}
