////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Humidifier:Steam:Gas : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("Capacity is m3/s of water at 5.05 C")]
////public virtual real RatedCapacity { get; set; } = new real;
////[Description("if auto-sized, the rated gas use rate is calculated from the rated")]
////public virtual real RatedGasUseRate { get; set; } = new real;
////[Description("Based on the higher heating value of fuel.")]
////public virtual real ThermalEfficiency { get; set; } = new real;
////[Description("Linear, Quadratic and Cubic efficiency curves are solely a function of PLR.")]
////public virtual object-list ThermalEfficiencyModifierCurveName { get; set; } = new object-list;
////[Description("The nominal full capacity electric power input to the blower fan in Watts. If no")]
////public virtual real RatedFanPower { get; set; } = new real;
////[Description("The auxiliary electric power input in watts. This amount of power will be consumed")]
////public virtual real AuxiliaryElectricPower { get; set; } = new real;
////[Description("No description available")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual object-list WaterStorageTankName { get; set; } = new object-list;
////[Description("The inlet water temperature can be fixed at 20C as it is done for electric steam")]
////public virtual choice InletWaterTemperatureOption { get; set; } = new choice;
////}
////}
