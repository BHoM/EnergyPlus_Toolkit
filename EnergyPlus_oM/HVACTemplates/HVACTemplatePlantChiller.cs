////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class HVACTemplate:Plant:Chiller : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("No description available")]
////public virtual choice ChillerType { get; set; } = new choice;
////[Description("No description available")]
////public virtual null Capacity { get; set; } = new null;
////[Description("Not applicable if Chiller Type is DistrictChilledWater")]
////public virtual null NominalCOP { get; set; } = new null;
////[Description("Not applicable if Chiller Type is DistrictChilledWater")]
////public virtual choice CondenserType { get; set; } = new choice;
////[Description("If Chiller Plant Operation Scheme Type=Default")]
////public virtual null Priority { get; set; } = new null;
////[Description("Multiplies the autosized capacity and flow rates")]
////public virtual real SizingFactor { get; set; } = new real;
////[Description("Part load ratio below which the chiller starts cycling on/off to meet the load.")]
////public virtual real MinimumPartLoadRatio { get; set; } = new real;
////[Description("Maximum allowable part load ratio. Must be greater than or equal to Minimum Part Load Ratio.")]
////public virtual real MaximumPartLoadRatio { get; set; } = new real;
////[Description("Optimum part load ratio where the chiller is most efficient.")]
////public virtual real OptimumPartLoadRatio { get; set; } = new real;
////[Description("Part load ratio where the chiller can no longer unload and false loading begins.")]
////public virtual real MinimumUnloadingRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real LeavingChilledWaterLowerTemperatureLimit { get; set; } = new real;
////}
////}
