////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class AirTerminal:SingleDuct:VAV:NoReheat : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual null MaximumAirFlowRate { get; set; } = new null;
////[Description("Constant = Constant Minimum Air Flow Fraction (a fraction of Maximum Air Flow Rate)")]
////public virtual choice ZoneMinimumAirFlowInputMethod { get; set; } = new choice;
////[Description("This field is used if the field Zone Minimum Air Flow Input Method is Constant")]
////public virtual real ConstantMinimumAirFlowFraction { get; set; } = new real;
////[Description("This field is used if the field Zone Minimum Air Flow Input Method is FixedFlowRate.")]
////public virtual real FixedMinimumAirFlowRate { get; set; } = new real;
////[Description("This field is used if the field Zone Minimum Air Flow Input Method is Scheduled")]
////public virtual object-list MinimumAirFlowFractionScheduleName { get; set; } = new object-list;
////[Description("When the name of a DesignSpecification:OutdoorAir object is entered, the terminal")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName { get; set; } = new object-list;
////}
////}
