////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class ZoneHVAC:WindowAirConditioner : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real MaximumSupplyAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumOutdoorAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("currently only one OutdoorAir:Mixer object type is available.")]
////public virtual choice OutdoorAirMixerObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list OutdoorAirMixerName { get; set; } = new object-list;
////[Description("Fan:ConstantVolume only works when continuous fan operation is used the entire")]
////public virtual choice SupplyAirFanObjectType { get; set; } = new choice;
////[Description("Fan type Fan:ConstantVolume is used with continuous fan")]
////public virtual object-list SupplyAirFanName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice CoolingCoilObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list DXCoolingCoilName { get; set; } = new object-list;
////[Description("Enter the name of a schedule that controls fan operation. Schedule Name values of 0 denote")]
////public virtual object-list SupplyAirFanOperatingModeScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice FanPlacement { get; set; } = new choice;
////[Description("No description available")]
////public virtual real CoolingConvergenceTolerance { get; set; } = new real;
////[Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
////public virtual object-list AvailabilityManagerListName { get; set; } = new object-list;
////[Description("Enter the name of a DesignSpecificationZoneHVACSizing object.")]
////public virtual object-list DesignSpecificationZoneHVACSizingObjectName { get; set; } = new object-list;
////}
////}
