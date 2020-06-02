////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class AirflowNetwork:OccupantVentilationControl : BHoMObject
////{
////[Description("Enter the name where the advanced thermal comfort control is required.")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual real MinimumOpeningTime { get; set; } = new real;
////[Description("No description available")]
////public virtual real MinimumClosingTime { get; set; } = new real;
////[Description("Enter a curve name that represents thermal comfort temperature as a")]
////public virtual object-list ThermalComfortLowTemperatureCurveName { get; set; } = new object-list;
////[Description("This point is used to allow separate low and high thermal comfort temperature")]
////public virtual real ThermalComfortTemperatureBoundaryPoint { get; set; } = new real;
////[Description("Enter a curve name that represents thermal comfort temperature as a")]
////public virtual object-list ThermalComfortHighTemperatureCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real MaximumThresholdForPersonsDissatisfiedPPD { get; set; } = new real;
////[Description("If True, occupancy check will be performed as part of the opening probability check.")]
////public virtual choice OccupancyCheck { get; set; } = new choice;
////[Description("If this field is blank, the opening probability check is bypassed and opening is true.")]
////public virtual object-list OpeningProbabilityScheduleName { get; set; } = new object-list;
////[Description("If this field is blank, the closing probability check is bypassed and closing is true.")]
////public virtual object-list ClosingProbabilityScheduleName { get; set; } = new object-list;
////}
////}
