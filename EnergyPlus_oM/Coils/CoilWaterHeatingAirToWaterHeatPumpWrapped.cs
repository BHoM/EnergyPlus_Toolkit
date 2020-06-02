////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Coil:WaterHeating:AirToWaterHeatPump:Wrapped : BHoMObject
////{
////[Description("Unique name for this instance of a heat pump water heater DX coil.")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet")]
////public virtual real RatedHeatingCapacity { get; set; } = new real;
////[Description("Heating coefficient of performance at the rated inlet air temperatures,")]
////public virtual real RatedCOP { get; set; } = new real;
////[Description("Gross air-side sensible heat ratio at the rated inlet air temperatures,")]
////public virtual real RatedSensibleHeatRatio { get; set; } = new real;
////[Description("Evaporator inlet air dry-bulb temperature corresponding to rated coil performance")]
////public virtual real RatedEvaporatorInletAirDry-BulbTemperature { get; set; } = new real;
////[Description("Evaporator inlet air wet-bulb temperature corresponding to rated coil performance")]
////public virtual real RatedEvaporatorInletAirWet-BulbTemperature { get; set; } = new real;
////[Description("Condenser inlet water temperature corresponding to rated coil performance")]
////public virtual real RatedCondenserWaterTemperature { get; set; } = new real;
////[Description("Evaporator air flow rate corresponding to rated coil performance")]
////public virtual real RatedEvaporatorAirFlowRate { get; set; } = new real;
////[Description("Select Yes if the evaporator fan power is included in the rated COP. This choice field")]
////public virtual choice EvaporatorFanPowerIncludedInRatedCOP { get; set; } = new choice;
////[Description("The node from which the DX coil draws its inlet air.")]
////public virtual node EvaporatorAirInletNodeName { get; set; } = new node;
////[Description("The node to which the DX coil sends its outlet air.")]
////public virtual node EvaporatorAirOutletNodeName { get; set; } = new node;
////[Description("The compressor crankcase heater only operates when the dry-bulb temperature of air")]
////public virtual real CrankcaseHeaterCapacity { get; set; } = new real;
////[Description("The compressor crankcase heater only operates when the dry-bulb temperature of air")]
////public virtual real MaximumAmbientTemperatureForCrankcaseHeaterOperation { get; set; } = new real;
////[Description("Determines temperature type for heating capacity curves and")]
////public virtual choice EvaporatorAirTemperatureTypeForCurveObjects { get; set; } = new choice;
////[Description("Heating capacity modifier curve (function of temperature) should be biquadratic or cubic.")]
////public virtual object-list HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Heating capacity modifier curve (function of air flow fraction) should be quadratic or cubic.")]
////public virtual object-list HeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Heating COP modifier curve (function of temperature) should be biquadratic or cubic.")]
////public virtual object-list HeatingCOPFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("Heating COP modifier curve (function of air flow fraction) should be quadratic or cubic.")]
////public virtual object-list HeatingCOPFunctionOfAirFlowFractionCurveName { get; set; } = new object-list;
////[Description("Part Load Fraction Correlation (function of part load ratio) should be quadratic or cubic.")]
////public virtual object-list PartLoadFractionCorrelationCurveName { get; set; } = new object-list;
////}
////}
