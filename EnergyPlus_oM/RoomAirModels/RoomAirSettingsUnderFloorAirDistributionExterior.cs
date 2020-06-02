////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class RoomAirSettings:UnderFloorAirDistributionExterior : BHoMObject
////{
////[Description("Name of Zone being described. Any existing zone name")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real NumberOfDiffusersPerZone { get; set; } = new real;
////[Description("No description available")]
////public virtual real PowerPerPlume { get; set; } = new real;
////[Description("No description available")]
////public virtual real DesignEffectiveAreaOfDiffuser { get; set; } = new real;
////[Description("No description available")]
////public virtual real DiffuserSlotAngleFromVertical { get; set; } = new real;
////[Description("Height of thermostat/temperature control sensor above floor")]
////public virtual real ThermostatHeight { get; set; } = new real;
////[Description("Height at which Air temperature is calculated for comfort purposes")]
////public virtual real ComfortHeight { get; set; } = new real;
////[Description("Minimum temperature difference between upper and lower layer")]
////public virtual real TemperatureDifferenceThresholdForReporting { get; set; } = new real;
////[Description("No description available")]
////public virtual choice FloorDiffuserType { get; set; } = new choice;
////[Description("User-specified height above floor of boundary between occupied and upper subzones")]
////public virtual real TransitionHeight { get; set; } = new real;
////[Description("Kc is the fraction of the total zone load attributable to the lower subzone")]
////public virtual real CoefficientAInFormulaKc=A*Gamma**B+C+D*Gamma+E*Gamma**2 { get; set; } = new real;
////[Description("Kc is the fraction of the total zone load attributable to the lower subzone")]
////public virtual real CoefficientBInFormulaKc=A*Gamma**B+C+D*Gamma+E*Gamma**2 { get; set; } = new real;
////[Description("Kc is the fraction of the total zone load attributable to the lower subzone")]
////public virtual real CoefficientCInFormulaKc=A*Gamma**B+C+D*Gamma+E*Gamma**2 { get; set; } = new real;
////[Description("Kc is the fraction of the total zone load attributable to the lower subzone")]
////public virtual real CoefficientDInFormulaKc=A*Gamma**B+C+D*Gamma+E*Gamma**2 { get; set; } = new real;
////[Description("Kc is the fraction of the total zone load attributable to the lower subzone")]
////public virtual real CoefficientEInFormulaKc=A*Gamma**B+C+D*Gamma+E*Gamma**2 { get; set; } = new real;
////}
////}
