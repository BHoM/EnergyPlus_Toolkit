////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Coil:Cooling:DX:VariableRefrigerantFlow : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual real GrossRatedTotalCoolingCapacity { get; set; } = new real;
////[Description("Sensible heat ratio excluding supply air fan heat")]
////public virtual real GrossRatedSensibleHeatRatio { get; set; } = new real;
////[Description("Volume flow rate corresponding to rated total cooling capacity")]
////public virtual real RatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list CoolingCapacityRatioModifierFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list CoolingCapacityModifierCurveFunctionOfFlowFractionName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node CoilAirInletNode { get; set; } = new node;
////[Description("No description available")]
////public virtual node CoilAirOutletNode { get; set; } = new node;
////[Description("No description available")]
////public virtual object-list NameOfWaterStorageTankForCondensateCollection { get; set; } = new object-list;
////}
////}
