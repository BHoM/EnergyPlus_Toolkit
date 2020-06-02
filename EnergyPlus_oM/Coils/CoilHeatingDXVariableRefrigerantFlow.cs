////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Coil:Heating:DX:VariableRefrigerantFlow : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilitySchedule { get; set; } = new object-list;
////[Description("Heating capacity not accounting for the effect of supply air fan heat")]
////public virtual real GrossRatedHeatingCapacity { get; set; } = new real;
////[Description("volume flow rate corresponding to rated total capacity")]
////public virtual real RatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual node CoilAirInletNode { get; set; } = new node;
////[Description("No description available")]
////public virtual node CoilAirOutletNode { get; set; } = new node;
////[Description("No description available")]
////public virtual object-list HeatingCapacityRatioModifierFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list HeatingCapacityModifierFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////}
////}
