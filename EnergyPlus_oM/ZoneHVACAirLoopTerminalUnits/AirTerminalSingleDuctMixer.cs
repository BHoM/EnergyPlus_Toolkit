////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class AirTerminal:SingleDuct:Mixer : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("The type of ZoneHVAC equipment to which this terminal mixer will be connected.")]
////public virtual choice ZoneHVACUnitObjectType { get; set; } = new choice;
////[Description("The name of ZoneHVAC equipment to which this terminal mixer will be connected.")]
////public virtual object-list ZoneHVACUnitObjectName { get; set; } = new object-list;
////[Description("This is the outlet air node name of the mixer. This will be the inlet air node name")]
////public virtual node MixerOutletNodeName { get; set; } = new node;
////[Description("The primary air (treated outdoor air) inlet node name of the mixer. This will be an")]
////public virtual node MixerPrimaryAirInletNodeName { get; set; } = new node;
////[Description("The secondary air (recirculating air) inlet node name of the mixer. This will be")]
////public virtual node MixerSecondaryAirInletNodeName { get; set; } = new node;
////[Description("This input field allows user to specify the mixer connection type. Valid choices")]
////public virtual choice MixerConnectionType { get; set; } = new choice;
////[Description("When the name of a DesignSpecification:OutdoorAir object is entered, the terminal")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName { get; set; } = new object-list;
////[Description("CurrentOccupancy models demand controlled ventilation using the current number of people")]
////public virtual choice PerPersonVentilationRateMode { get; set; } = new choice;
////}
////}