////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class AirflowNetwork:MultiZone:Zone : BHoMObject
////{
////[Description("Enter the zone name where ventilation control is required.")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("When Ventilation Control Mode = Temperature or Enthalpy, the following")]
////public virtual choice VentilationControlMode { get; set; } = new choice;
////[Description("Used only if Ventilation Control Mode = Temperature or Enthalpy.")]
////public virtual object-list VentilationControlZoneTemperatureSetpointScheduleName { get; set; } = new object-list;
////[Description("Used only if Ventilation Control Mode = Temperature or Enthalpy.")]
////public virtual real MinimumVentingOpenFactor { get; set; } = new real;
////[Description("Applicable only if Ventilation Control Mode = Temperature.")]
////public virtual real IndoorAndOutdoorTemperatureDifferenceLowerLimitForMaximumVentingOpenFactor { get; set; } = new real;
////[Description("Applicable only if Ventilation Control Mode = Temperature.")]
////public virtual real IndoorAndOutdoorTemperatureDifferenceUpperLimitForMinimumVentingOpenFactor { get; set; } = new real;
////[Description("Applicable only if Ventilation Control Mode = Enthalpy.")]
////public virtual real IndoorAndOutdoorEnthalpyDifferenceLowerLimitForMaximumVentingOpenFactor { get; set; } = new real;
////[Description("Applicable only if Ventilation Control Mode = Enthalpy.")]
////public virtual real IndoorAndOutdoorEnthalpyDifferenceUpperLimitForMinimumVentingOpenFactor { get; set; } = new real;
////[Description("Non-zero Schedule value means venting is allowed if other venting control conditions are")]
////public virtual object-list VentingAvailabilityScheduleName { get; set; } = new object-list;
////[Description("Selecting Advanced results in EnergyPlus calculating modified Wind Pressure Coefficients")]
////public virtual choice SingleSidedWindPressureCoefficientAlgorithm { get; set; } = new choice;
////[Description("This is the whole building width along the direction of the facade of this zone.")]
////public virtual real FacadeWidth { get; set; } = new real;
////[Description("Enter the name where Occupancy Ventilation Control is required.")]
////public virtual object-list OccupantVentilationControlName { get; set; } = new object-list;
////}
////}
