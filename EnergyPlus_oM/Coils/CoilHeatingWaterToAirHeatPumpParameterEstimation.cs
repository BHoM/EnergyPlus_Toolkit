////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Coil:Heating:WaterToAirHeatPump:ParameterEstimation : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Parameters 1-4 are as named below.")]
////public virtual choice CompressorType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list RefrigerantType { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real DesignSourceSideFlowRate { get; set; } = new real;
////[Description("Heating capacity not accounting for the effect of supply air fan heat")]
////public virtual real GrossRatedHeatingCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real HighPressureCutoff { get; set; } = new real;
////[Description("No description available")]
////public virtual real LowPressureCutoff { get; set; } = new real;
////[Description("No description available")]
////public virtual node WaterInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node WaterOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("Previously called Parameter 1")]
////public virtual real LoadSideTotalHeatTransferCoefficient { get; set; } = new real;
////[Description("Previously called Parameter 2")]
////public virtual real SuperheatTemperatureAtTheEvaporatorOutlet { get; set; } = new real;
////[Description("Accounts for the loss of work due to mechanical and electrical losses in the compressor.")]
////public virtual real CompressorPowerLosses { get; set; } = new real;
////[Description("Previously called Parameter 4")]
////public virtual real CompressorEfficiency { get; set; } = new real;
////[Description("Use when Compressor Type is Reciprocating or Rotary")]
////public virtual real CompressorPistonDisplacement { get; set; } = new real;
////[Description("Used when Compressor Type is Rotary or Reciprocating")]
////public virtual real CompressorSuction/DischargePressureDrop { get; set; } = new real;
////[Description("Used when Compressor Type is Reciprocating.")]
////public virtual real CompressorClearanceFactor { get; set; } = new real;
////[Description("Use when Compressor Type is Scroll")]
////public virtual real RefrigerantVolumeFlowRate { get; set; } = new real;
////[Description("Use when Compressor Type is Scroll.")]
////public virtual real VolumeRatio { get; set; } = new real;
////[Description("Use when Compressor Type is Scroll.")]
////public virtual real LeakRateCoefficient { get; set; } = new real;
////[Description("Use when Source Side Fluid Name is Water")]
////public virtual real SourceSideHeatTransferCoefficient { get; set; } = new real;
////[Description("Use when Source Side Fluid Name is an antifreeze")]
////public virtual real SourceSideHeatTransferResistance1 { get; set; } = new real;
////[Description("Use when Source Side Fluid Name is an antifreeze")]
////public virtual real SourceSideHeatTransferResistance2 { get; set; } = new real;
////}
////}
