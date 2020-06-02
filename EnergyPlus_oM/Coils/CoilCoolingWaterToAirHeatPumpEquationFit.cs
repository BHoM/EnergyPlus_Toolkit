////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Coil:Cooling:WaterToAirHeatPump:EquationFit : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual node WaterInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node WaterOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual real RatedAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real RatedWaterFlowRate { get; set; } = new real;
////[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
////public virtual real GrossRatedTotalCoolingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real GrossRatedSensibleCoolingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real GrossRatedCoolingCOP { get; set; } = new real;
////[Description("No description available")]
////public virtual real TotalCoolingCapacityCoefficient1 { get; set; } = new real;
////[Description("No description available")]
////public virtual real TotalCoolingCapacityCoefficient2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real TotalCoolingCapacityCoefficient3 { get; set; } = new real;
////[Description("No description available")]
////public virtual real TotalCoolingCapacityCoefficient4 { get; set; } = new real;
////[Description("No description available")]
////public virtual real TotalCoolingCapacityCoefficient5 { get; set; } = new real;
////[Description("No description available")]
////public virtual real SensibleCoolingCapacityCoefficient1 { get; set; } = new real;
////[Description("No description available")]
////public virtual real SensibleCoolingCapacityCoefficient2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real SensibleCoolingCapacityCoefficient3 { get; set; } = new real;
////[Description("No description available")]
////public virtual real SensibleCoolingCapacityCoefficient4 { get; set; } = new real;
////[Description("No description available")]
////public virtual real SensibleCoolingCapacityCoefficient5 { get; set; } = new real;
////[Description("No description available")]
////public virtual real SensibleCoolingCapacityCoefficient6 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CoolingPowerConsumptionCoefficient1 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CoolingPowerConsumptionCoefficient2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CoolingPowerConsumptionCoefficient3 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CoolingPowerConsumptionCoefficient4 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CoolingPowerConsumptionCoefficient5 { get; set; } = new real;
////[Description("The nominal time for condensate to begin leaving the coil's condensate")]
////public virtual real NominalTimeForCondensateRemovalToBegin { get; set; } = new real;
////[Description("Ratio of the initial moisture evaporation rate from the cooling coil (when")]
////public virtual real RatioOfInitialMoistureEvaporationRateAndSteadyStateLatentCapacity { get; set; } = new real;
////}
////}
