////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class DemandManager:Ventilation : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this demand manager. Schedule value > 0 means the demand manager is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice LimitControl { get; set; } = new choice;
////[Description("If blank, duration defaults to the timestep")]
////public virtual integer MinimumLimitDuration { get; set; } = new integer;
////[Description("Used in case when Limit strategy is set to FixedRate")]
////public virtual real FixedRate { get; set; } = new real;
////[Description("Used in case when Limit Control is set to ReductionRatio")]
////public virtual real ReductionRatio { get; set; } = new real;
////[Description("Not yet implemented")]
////public virtual real LimitStepChange { get; set; } = new real;
////[Description("No description available")]
////public virtual choice SelectionControl { get; set; } = new choice;
////[Description("If blank, duration defaults to the timestep")]
////public virtual integer RotationDuration { get; set; } = new integer;
////[Description("Enter the name of a Controller:OutdoorAir object.")]
////public virtual object-list ControllerOutdoorAir1Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ControllerOutdoorAir2Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ControllerOutdoorAir3Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ControllerOutdoorAir4Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ControllerOutdoorAir5Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ControllerOutdoorAir6Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ControllerOutdoorAir7Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ControllerOutdoorAir8Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ControllerOutdoorAir9Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ControllerOutdoorAir10Name { get; set; } = new object-list;
////}
////}
