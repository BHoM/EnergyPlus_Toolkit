////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class ZoneHVAC:EvaporativeCoolerUnit : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
////public virtual object-list AvailabilityManagerListName { get; set; } = new object-list;
////[Description("this is an outdoor air node")]
////public virtual node OutdoorAirInletNodeName { get; set; } = new node;
////[Description("this is a zone inlet node")]
////public virtual node CoolerOutletNodeName { get; set; } = new node;
////[Description("this is a zone exhaust node, optional if flow is being balanced elsewhere")]
////public virtual node ZoneReliefAirNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual choice SupplyAirFanObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list SupplyAirFanName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null DesignSupplyAirFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual choice FanPlacement { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice CoolerUnitControlMethod { get; set; } = new choice;
////[Description("used for ZoneTemperatureDeadbandOnOffCycling hystersis range for thermostatic control")]
////public virtual real ThrottlingRangeTemperatureDifference { get; set; } = new real;
////[Description("Sign convention is that positive values indicate a cooling load")]
////public virtual real CoolingLoadControlThresholdHeatTransferRate { get; set; } = new real;
////[Description("No description available")]
////public virtual choice FirstEvaporativeCoolerObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list FirstEvaporativeCoolerObjectName { get; set; } = new object-list;
////[Description("optional, used for direct/indirect configurations")]
////public virtual choice SecondEvaporativeCoolerObjectType { get; set; } = new choice;
////[Description("optional, used for direct/indirect configurations")]
////public virtual object-list SecondEvaporativeCoolerName { get; set; } = new object-list;
////[Description("Enter the name of a DesignSpecificationZoneHVACSizing object.")]
////public virtual object-list DesignSpecificationZoneHVACSizingObjectName { get; set; } = new object-list;
////}
////}
