////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Coil:Heating:Water : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("UA value under rating conditions")]
////public virtual null U-FactorTimesAreaValue { get; set; } = new null;
////[Description("No description available")]
////public virtual null MaximumWaterFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual node WaterInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node WaterOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual choice PerformanceInputMethod { get; set; } = new choice;
////[Description("No description available")]
////public virtual real RatedCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real RatedInletWaterTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual real RatedInletAirTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual real RatedOutletWaterTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual real RatedOutletAirTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual real RatedRatioForAirAndWaterConvection { get; set; } = new real;
////[Description("This input field is optional. If specified, it is used for sizing the Design Water Flow Rate.")]
////public virtual real DesignWaterTemperatureDifference { get; set; } = new real;
////}
////}
