////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Controller:MechanicalVentilation : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("If this field is blank, the controller uses the values from the associated Controller:OutdoorAir.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice DemandControlledVentilation { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice SystemOutdoorAirMethod { get; set; } = new choice;
////[Description("No description available")]
////public virtual real ZoneMaximumOutdoorAirFraction { get; set; } = new real;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone1Name { get; set; } = new object-list;
////[Description("If left blank, the name will be taken from the Sizing:Zone object for this zone.")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName1 { get; set; } = new object-list;
////[Description("If left blank, the name will be taken from the Sizing:Zone object for this zone.")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName1 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone2Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName2 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName2 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone3Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName3 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName3 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone4Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName4 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName4 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone5Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName5 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName5 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone6Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName6 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName6 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone7Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName7 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName7 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone8Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName8 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName8 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone9Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName9 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName9 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone10Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName10 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName10 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone11Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName11 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName11 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone12Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName12 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName12 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone13Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName13 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName13 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone14Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName14 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName14 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone15Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName15 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName15 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone16Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName16 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName16 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone17Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName17 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName17 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone18Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName18 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName18 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone19Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName19 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName19 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone20Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName20 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName20 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone21Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName21 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName21 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone22Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName22 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName22 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone23Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName23 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName23 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone24Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName24 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName24 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone25Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName25 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName25 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone26Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName26 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName26 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone27Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName27 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName27 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone28Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName28 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName28 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone29Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName29 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName29 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone30Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName30 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName30 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone31Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName31 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName31 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone32Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName32 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName32 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone33Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName33 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName33 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone34Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName34 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName34 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone35Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName35 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName35 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone36Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName36 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName36 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone37Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName37 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName37 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone38Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName38 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName38 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone39Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName39 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName39 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone40Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName40 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName40 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone41Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName41 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName41 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone42Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName42 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName42 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone43Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName43 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName43 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone44Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName44 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName44 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone45Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName45 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName45 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone46Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName46 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName46 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone47Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName47 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName47 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone48Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName48 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName48 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone49Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName49 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName49 { get; set; } = new object-list;
////[Description("A zone name or a zone list name may be used here")]
////public virtual object-list Zone50Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName50 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list DesignSpecificationZoneAirDistributionObjectName50 { get; set; } = new object-list;
////}
////}
