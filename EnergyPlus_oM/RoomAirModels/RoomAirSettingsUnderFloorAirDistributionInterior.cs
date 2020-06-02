////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class RoomAirSettings:UnderFloorAirDistributionInterior : BHoMObject
////{
////[Description("Name of Zone with underfloor air distribution")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("Total number of diffusers in this zone")]
////public virtual real NumberOfDiffusers { get; set; } = new real;
////[Description("No description available")]
////public virtual real PowerPerPlume { get; set; } = new real;
////[Description("No description available")]
////public virtual real DesignEffectiveAreaOfDiffuser { get; set; } = new real;
////[Description("No description available")]
////public virtual real DiffuserSlotAngleFromVertical { get; set; } = new real;
////[Description("Height of thermostat/temperature control sensor above floor")]
////public virtual real ThermostatHeight { get; set; } = new real;
////[Description("Height at which air temperature is calculated for comfort purposes")]
////public virtual real ComfortHeight { get; set; } = new real;
////[Description("Minimum temperature difference between predicted upper and lower layer")]
////public virtual real TemperatureDifferenceThresholdForReporting { get; set; } = new real;
////[Description("No description available")]
////public virtual choice FloorDiffuserType { get; set; } = new choice;
////[Description("user-specified height above floor of boundary between occupied and upper subzones")]
////public virtual real TransitionHeight { get; set; } = new real;
////[Description("Coefficient A in Formula Kc = A*Gamma**B + C + D*Gamma + E*Gamma**2")]
////public virtual real CoefficientA { get; set; } = new real;
////[Description("Coefficient B in Formula Kc = A*Gamma**B + C + D*Gamma + E*Gamma**2")]
////public virtual real CoefficientB { get; set; } = new real;
////[Description("Coefficient C in Formula Kc = A*Gamma**B + C + D*Gamma + E*Gamma**2")]
////public virtual real CoefficientC { get; set; } = new real;
////[Description("Coefficient D in Formula Kc = A*Gamma**B + C + D*Gamma + E*Gamma**2")]
////public virtual real CoefficientD { get; set; } = new real;
////[Description("Coefficient E in Formula Kc = A*Gamma**B + C + D*Gamma + E*Gamma**2")]
////public virtual real CoefficientE { get; set; } = new real;
////}
////}
