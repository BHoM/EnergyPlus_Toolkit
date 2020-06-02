////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class ZoneHVAC:UnitVentilator : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null MaximumSupplyAirFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual choice OutdoorAirControlType { get; set; } = new choice;
////[Description("No description available")]
////public virtual null MinimumOutdoorAirFlowRate { get; set; } = new null;
////[Description("schedule values multiply the minimum outdoor air flow rate")]
////public virtual object-list MinimumOutdoorAirScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null MaximumOutdoorAirFlowRate { get; set; } = new null;
////[Description("that this depends on the control type as to whether it is a fraction or temperature")]
////public virtual object-list MaximumOutdoorAirFractionOrTemperatureScheduleName { get; set; } = new object-list;
////[Description("Inlet node name must be zone exhaust node name if there is no DOA Mixer, or if the")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("Outlet node name must be zone inlet node name if there is no DOA Mixer, or if the")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("this field is left blank only if the Unit Ventilator is connected to a central")]
////public virtual node OutdoorAirNodeName { get; set; } = new node;
////[Description("this field is left blank only if the Unit Ventilator is connected to a central")]
////public virtual node ExhaustAirNodeName { get; set; } = new node;
////[Description("inlet to coils")]
////public virtual node MixedAirNodeName { get; set; } = new node;
////[Description("Allowable fan types are Fan:ConstantVolume, Fan:OnOff, Fan:VariableVolume, and Fan:SystemModel")]
////public virtual choice SupplyAirFanObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list SupplyAirFanName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice CoilOption { get; set; } = new choice;
////[Description("Enter the name of a schedule that controls fan operation. Schedule")]
////public virtual object-list SupplyAirFanOperatingModeScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice HeatingCoilObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list HeatingCoilName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real HeatingConvergenceTolerance { get; set; } = new real;
////[Description("No description available")]
////public virtual choice CoolingCoilObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list CoolingCoilName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real CoolingConvergenceTolerance { get; set; } = new real;
////[Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
////public virtual object-list AvailabilityManagerListName { get; set; } = new object-list;
////[Description("Enter the name of a DesignSpecificationZoneHVACSizing object.")]
////public virtual object-list DesignSpecificationZoneHVACSizingObjectName { get; set; } = new object-list;
////}
////}
