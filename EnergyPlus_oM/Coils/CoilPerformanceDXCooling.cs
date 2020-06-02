////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class CoilPerformance:DX:Cooling : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual real GrossRatedTotalCoolingCapacity { get; set; } = new real;
////[Description("Rated sensible heat ratio (gross sensible capacity/gross total capacity)")]
////public virtual real GrossRatedSensibleHeatRatio { get; set; } = new real;
////[Description("Gross cooling capacity divided by power input to the compressor and outdoor fan,")]
////public virtual real GrossRatedCoolingCOP { get; set; } = new real;
////[Description("Flow rate corresponding to Rated total Cooling capacity, Rated SHR and Rated COP")]
////public virtual real RatedAirFlowRate { get; set; } = new real;
////[Description("Fraction of Rated Air Flow Rate which bypasses the cooling coil")]
////public virtual real FractionOfAirFlowBypassedAroundCoil { get; set; } = new real;
////[Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb")]
////public virtual object-list TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list TotalCoolingCapacityFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb")]
////public virtual object-list EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*PLR + c*PLR**2")]
////public virtual object-list PartLoadFractionCorrelationCurveName { get; set; } = new object-list;
////[Description("The nominal time for condensate to begin leaving the coil's condensate")]
////public virtual real NominalTimeForCondensateRemovalToBegin { get; set; } = new real;
////[Description("Ratio of the initial moisture evaporation rate from the cooling coil (when")]
////public virtual real RatioOfInitialMoistureEvaporationRateAndSteadyStateLatentCapacity { get; set; } = new real;
////[Description("The maximum on-off cycling rate for the compressor, which occurs at 50% run time")]
////public virtual real MaximumCyclingRate { get; set; } = new real;
////[Description("Time constant for the cooling coil's latent capacity to reach steady state after")]
////public virtual real LatentCapacityTimeConstant { get; set; } = new real;
////[Description("Enter the name of an outdoor air node. This node name is also specified in")]
////public virtual node CondenserAirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual choice CondenserType { get; set; } = new choice;
////[Description("No description available")]
////public virtual real EvaporativeCondenserEffectiveness { get; set; } = new real;
////[Description("Used to calculate evaporative condenser water use")]
////public virtual real EvaporativeCondenserAirFlowRate { get; set; } = new real;
////[Description("Rated power consumed by the evaporative condenser's water pump")]
////public virtual real EvaporativeCondenserPumpRatedPowerConsumption { get; set; } = new real;
////[Description("curve = a + b*wb + c*wb**2 + d*db + e*db**2 + f*wb*db")]
////public virtual object-list SensibleHeatRatioFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("quadratic curve = a + b*ff + c*ff**2")]
////public virtual object-list SensibleHeatRatioFunctionOfFlowFractionCurveName { get; set; } = new object-list;
////}
////}
