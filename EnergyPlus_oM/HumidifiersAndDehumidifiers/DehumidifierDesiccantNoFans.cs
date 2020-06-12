////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Dehumidifier:Desiccant:NoFans : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("This is the node entering the process side of the desiccant wheel.")]
////public virtual node ProcessAirInletNodeName { get; set; } = new node;
////[Description("This is the node leaving the process side of the desiccant wheel.")]
////public virtual node ProcessAirOutletNodeName { get; set; } = new node;
////[Description("This is the node entering the regeneration side of the desiccant wheel")]
////public virtual node RegenerationAirInletNodeName { get; set; } = new node;
////[Description("Node for air entering the regeneration fan, mass flow is set")]
////public virtual node RegenerationFanInletNodeName { get; set; } = new node;
////[Description("Type of setpoint control:")]
////public virtual choice ControlType { get; set; } = new choice;
////[Description("Fixed setpoint for maximum process air leaving humidity ratio")]
////public virtual real LeavingMaximumHumidityRatioSetpoint { get; set; } = new real;
////[Description("Process air flow rate at nominal conditions")]
////public virtual real NominalProcessAirFlowRate { get; set; } = new real;
////[Description("Process air velocity at nominal flow")]
////public virtual real NominalProcessAirVelocity { get; set; } = new real;
////[Description("Power input to wheel rotor motor")]
////public virtual real RotorPower { get; set; } = new real;
////[Description("heating coil type")]
////public virtual choice RegenerationCoilObjectType { get; set; } = new choice;
////[Description("Name of heating coil object for regeneration air")]
////public virtual object-list RegenerationCoilName { get; set; } = new object-list;
////[Description("Type of fan object for regeneration air. When using the Default")]
////public virtual choice RegenerationFanObjectType { get; set; } = new choice;
////[Description("Name of fan object for regeneration air")]
////public virtual object-list RegenerationFanName { get; set; } = new object-list;
////[Description("Specifies whether the default performance model or user-specified")]
////public virtual choice PerformanceModelType { get; set; } = new choice;
////[Description("Leaving dry-bulb of process air as a function of entering dry-bulb")]
////public virtual object-list LeavingDry-BulbFunctionOfEnteringDry-BulbAndHumidityRatioCurveName { get; set; } = new object-list;
////[Description("Leaving dry-bulb of process air as a function of air velocity,")]
////public virtual object-list LeavingDry-BulbFunctionOfAirVelocityCurveName { get; set; } = new object-list;
////[Description("Leaving humidity ratio of process air as a function of entering dry-bulb")]
////public virtual object-list LeavingHumidityRatioFunctionOfEnteringDry-BulbAndHumidityRatioCurveName { get; set; } = new object-list;
////[Description("Leaving humidity ratio of process air as a function of")]
////public virtual object-list LeavingHumidityRatioFunctionOfAirVelocityCurveName { get; set; } = new object-list;
////[Description("Regeneration energy [J/kg of water removed] as a function of")]
////public virtual object-list RegenerationEnergyFunctionOfEnteringDry-BulbAndHumidityRatioCurveName { get; set; } = new object-list;
////[Description("Regeneration energy [J/kg of water removed] as a function of")]
////public virtual object-list RegenerationEnergyFunctionOfAirVelocityCurveName { get; set; } = new object-list;
////[Description("Regeneration velocity [m/s] as a function of")]
////public virtual object-list RegenerationVelocityFunctionOfEnteringDry-BulbAndHumidityRatioCurveName { get; set; } = new object-list;
////[Description("Regeneration velocity [m/s] as a function of")]
////public virtual object-list RegenerationVelocityFunctionOfAirVelocityCurveName { get; set; } = new object-list;
////[Description("Nominal regen temperature upon which the regen energy modifier")]
////public virtual real NominalRegenerationTemperature { get; set; } = new real;
////}
////}