////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class ThermalStorage:Ice:Detailed : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("This includes only the latent storage capacity")]
////public virtual null Capacity { get; set; } = new null;
////[Description("No description available")]
////public virtual node InletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node OutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual choice DischargingCurveVariableSpecifications { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list DischargingCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice ChargingCurveVariableSpecifications { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ChargingCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null TimestepOfTheCurveData { get; set; } = new null;
////[Description("No description available")]
////public virtual null ParasiticElectricLoadDuringDischarging { get; set; } = new null;
////[Description("No description available")]
////public virtual null ParasiticElectricLoadDuringCharging { get; set; } = new null;
////[Description("This is the fraction the total storage capacity that is lost or melts")]
////public virtual null TankLossCoefficient { get; set; } = new null;
////[Description("This temperature is typically 0C for water.")]
////public virtual null FreezingTemperatureOfStorageMedium { get; set; } = new null;
////[Description("This field determines whether the system uses internal or external melt")]
////public virtual choice ThawProcessIndicator { get; set; } = new choice;
////}
////}