////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class ZoneHVAC:UnitHeater : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("Allowable fan types are Fan:ConstantVolume, Fan:OnOff, Fan:VariableVolume and Fan:SystemModel")]
////public virtual choice SupplyAirFanObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list SupplyAirFanName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null MaximumSupplyAirFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual choice HeatingCoilObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list HeatingCoilName { get; set; } = new object-list;
////[Description("Enter the name of a schedule that controls fan operation. Schedule")]
////public virtual object-list SupplyAirFanOperatingModeScheduleName { get; set; } = new object-list;
////[Description("This choice field allows the user to define how the unit heater will operate")]
////public virtual choice SupplyAirFanOperationDuringNoHeating { get; set; } = new choice;
////[Description("Not used when heating coil is gas or electric")]
////public virtual null MaximumHotWaterOrSteamFlowRate { get; set; } = new null;
////[Description("Not used when heating coil is gas or electric")]
////public virtual null MinimumHotWaterOrSteamFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual real HeatingConvergenceTolerance { get; set; } = new real;
////[Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
////public virtual object-list AvailabilityManagerListName { get; set; } = new object-list;
////[Description("Enter the name of a DesignSpecificationZoneHVACSizing object.")]
////public virtual object-list DesignSpecificationZoneHVACSizingObjectName { get; set; } = new object-list;
////}
////}
