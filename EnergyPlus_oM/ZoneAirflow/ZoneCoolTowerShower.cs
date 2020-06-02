////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class ZoneCoolTower:Shower : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("In case of stand alone tank or underground water, leave this input blank")]
////public virtual object-list WaterSupplyStorageTankName { get; set; } = new object-list;
////[Description("Water flow schedule should be selected when the water flow rate is known.")]
////public virtual choice FlowControlType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list PumpFlowRateScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real MaximumWaterFlowRate { get; set; } = new real;
////[Description("This field is from either the spray or the wet pad to the top of the outlet.")]
////public virtual real EffectiveTowerHeight { get; set; } = new real;
////[Description("User have to specify effective area when outlet area is relatively bigger than the cross sectional area")]
////public virtual real AirflowOutletArea { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumAirFlowRate { get; set; } = new real;
////[Description("This field is to specify the indoor temperature below which cooltower is shutoff.")]
////public virtual real MinimumIndoorTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual null FractionOfWaterLoss { get; set; } = new null;
////[Description("No description available")]
////public virtual null FractionOfFlowSchedule { get; set; } = new null;
////[Description("No description available")]
////public virtual real RatedPowerConsumption { get; set; } = new real;
////}
////}
