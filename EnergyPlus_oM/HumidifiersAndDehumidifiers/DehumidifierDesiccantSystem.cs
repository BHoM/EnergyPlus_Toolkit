////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Dehumidifier:Desiccant:System : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice DesiccantHeatExchangerObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list DesiccantHeatExchangerName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node SensorNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual choice RegenerationAirFanObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list RegenerationAirFanName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice RegenerationAirFanPlacement { get; set; } = new choice;
////[Description("works with gas, electric, hot water and steam heating coils.")]
////public virtual choice RegenerationAirHeaterObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list RegenerationAirHeaterName { get; set; } = new object-list;
////[Description("This value is also used as regeneration air heater design coil air")]
////public virtual real RegenerationInletAirSetpointTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual choice CompanionCoolingCoilObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list CompanionCoolingCoilName { get; set; } = new object-list;
////[Description("Select Yes if the companion cooling coil is located directly upstream")]
////public virtual choice CompanionCoolingCoilUpstreamOfDehumidifierProcessInlet { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice CompanionCoilRegenerationAirHeating { get; set; } = new choice;
////[Description("No description available")]
////public virtual real ExhaustFanMaximumFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real ExhaustFanMaximumPower { get; set; } = new real;
////[Description("Curve object type must be Curve:Quadratic or Curve:Cubic")]
////public virtual object-list ExhaustFanPowerCurveName { get; set; } = new object-list;
////}
////}
