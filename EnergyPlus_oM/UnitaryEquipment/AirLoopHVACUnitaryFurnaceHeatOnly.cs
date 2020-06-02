////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class AirLoopHVAC:Unitary:Furnace:HeatOnly : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node FurnaceAirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node FurnaceAirOutletNodeName { get; set; } = new node;
////[Description("A fan operating mode schedule value of 0 indicates cycling fan mode (supply air")]
////public virtual object-list SupplyAirFanOperatingModeScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real MaximumSupplyAirTemperature { get; set; } = new real;
////[Description("This value should be > 0 and <= than the fan air flow rate.")]
////public virtual real HeatingSupplyAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list ControllingZoneOrThermostatLocation { get; set; } = new object-list;
////[Description("Fan:ConstantVolume only works with continuous fan operating mode (i.e. fan")]
////public virtual choice SupplyFanObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list SupplyFanName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice FanPlacement { get; set; } = new choice;
////[Description("works with gas, electric, hot water and steam heating coils")]
////public virtual choice HeatingCoilObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list HeatingCoilName { get; set; } = new object-list;
////}
////}
