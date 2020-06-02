////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Coil:Cooling:Water : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null DesignWaterFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual null DesignAirFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual null DesignInletWaterTemperature { get; set; } = new null;
////[Description("No description available")]
////public virtual null DesignInletAirTemperature { get; set; } = new null;
////[Description("No description available")]
////public virtual null DesignOutletAirTemperature { get; set; } = new null;
////[Description("No description available")]
////public virtual null DesignInletAirHumidityRatio { get; set; } = new null;
////[Description("No description available")]
////public virtual null DesignOutletAirHumidityRatio { get; set; } = new null;
////[Description("No description available")]
////public virtual node WaterInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node WaterOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual choice TypeOfAnalysis { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice HeatExchangerConfiguration { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list CondensateCollectionWaterStorageTankName { get; set; } = new object-list;
////[Description("This input field is optional. If specified, it is used for sizing the Design Water Flow Rate.")]
////public virtual real DesignWaterTemperatureDifference { get; set; } = new real;
////}
////}
