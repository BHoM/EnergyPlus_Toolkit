////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Coil:WaterHeating:Desuperheater : BHoMObject
////{
////[Description("Unique name for this instance of a desuperheater water heating coil.")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("Defines the cut-out temperature where the desuperheater water heating coil turns off.")]
////public virtual object-list SetpointTemperatureScheduleName { get; set; } = new object-list;
////[Description("Setpoint temperature minus the dead band temperature difference defines")]
////public virtual real DeadBandTemperatureDifference { get; set; } = new real;
////[Description("Enter the fraction of waste heat reclaimed by the desuperheater water heating coil.")]
////public virtual real RatedHeatReclaimRecoveryEfficiency { get; set; } = new real;
////[Description("The inlet water temperature corresponding to the rated heat reclaim recovery efficiency.")]
////public virtual real RatedInletWaterTemperature { get; set; } = new real;
////[Description("The outdoor air dry-bulb temperature corresponding to the")]
////public virtual real RatedOutdoorAirTemperature { get; set; } = new real;
////[Description("The desuperheater water heating coil is off when the inlet water temperature is above")]
////public virtual real MaximumInletWaterTemperatureForHeatReclaim { get; set; } = new real;
////[Description("A biquadratic curve defining the performance of the desuperheater heating coil.")]
////public virtual object-list HeatReclaimEfficiencyFunctionOfTemperatureCurveName { get; set; } = new object-list;
////[Description("The node from which the desuperheater heating coil draws its inlet water.")]
////public virtual node WaterInletNodeName { get; set; } = new node;
////[Description("The node to which the desuperheater heating coil sends its outlet water.")]
////public virtual node WaterOutletNodeName { get; set; } = new node;
////[Description("Specify the type of water heater tank used by this desuperheater water heating coil.")]
////public virtual choice TankObjectType { get; set; } = new choice;
////[Description("The name of the water heater tank used by this desuperheater water heating coil.")]
////public virtual object-list TankName { get; set; } = new object-list;
////[Description("The type of DX system that is providing waste heat for reclaim.")]
////public virtual choice HeatingSourceObjectType { get; set; } = new choice;
////[Description("The name of the DX system used for heat reclaim.")]
////public virtual object-list HeatingSourceName { get; set; } = new object-list;
////[Description("The operating water flow rate.")]
////public virtual real WaterFlowRate { get; set; } = new real;
////[Description("The water circulation pump electric power.")]
////public virtual real WaterPumpPower { get; set; } = new real;
////[Description("The fraction of pump heat transferred to the water. The pump is assumed to be downstream of")]
////public virtual real FractionOfPumpHeatToWater { get; set; } = new real;
////[Description("Parasitic electric power consumed when the desuperheater water heating coil operates.")]
////public virtual real On-CycleParasiticElectricLoad { get; set; } = new real;
////[Description("Parasitic electric load consumed when the desuperheater water heating coil is off.")]
////public virtual real Off-CycleParasiticElectricLoad { get; set; } = new real;
////}
////}