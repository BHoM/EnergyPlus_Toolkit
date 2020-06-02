////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class AirLoopHVAC:Unitary:Furnace:HeatCool : BHoMObject
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
////[Description("Must be less than or equal to the fan's maximum flow rate.")]
////public virtual real CoolingSupplyAirFlowRate { get; set; } = new real;
////[Description("Must be less than or equal to the fan's maximum flow fate.")]
////public virtual real HeatingSupplyAirFlowRate { get; set; } = new real;
////[Description("Must be less than or equal to the fan's maximum flow rate.")]
////public virtual real NoLoadSupplyAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list ControllingZoneOrThermostatLocation { get; set; } = new object-list;
////[Description("Fan:ConstantVolume only works with continuous fan operating mode (i.e. supply")]
////public virtual choice SupplyFanObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list SupplyFanName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice FanPlacement { get; set; } = new choice;
////[Description("works with gas, electric, hot water and steam heating coils")]
////public virtual choice HeatingCoilObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list HeatingCoilName { get; set; } = new object-list;
////[Description("Only works with DX cooling coil types")]
////public virtual choice CoolingCoilObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list CoolingCoilName { get; set; } = new object-list;
////[Description("None = meet sensible load only")]
////public virtual choice DehumidificationControlType { get; set; } = new choice;
////[Description("Only required if dehumidification control type is "CoolReheat"")]
////public virtual choice ReheatCoilObjectType { get; set; } = new choice;
////[Description("Only required if dehumidification control type is "CoolReheat"")]
////public virtual object-list ReheatCoilName { get; set; } = new object-list;
////}
////}
