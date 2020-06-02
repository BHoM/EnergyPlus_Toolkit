////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class ElectricEquipment:ITE:AirCooled : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("The specified method is used to calculate the IT inlet temperature and zone return")]
////public virtual choice AirFlowCalculationMethod { get; set; } = new choice;
////[Description("The entered calculation method is used to specify the design power input")]
////public virtual choice DesignPowerInputCalculationMethod { get; set; } = new choice;
////[Description("No description available")]
////public virtual real WattsPerUnit { get; set; } = new real;
////[Description("No description available")]
////public virtual real NumberOfUnits { get; set; } = new real;
////[Description("No description available")]
////public virtual real WattsPerZoneFloorArea { get; set; } = new real;
////[Description("Operating schedule for this equipment, fraction applied to the design power input,")]
////public virtual object-list DesignPowerInputScheduleName { get; set; } = new object-list;
////[Description("CPU loading schedule for this equipment as a fraction from 0.0 (idle) to 1.0 (full load).")]
////public virtual object-list CPULoadingScheduleName { get; set; } = new object-list;
////[Description("The name of a two-variable curve or table lookup object which modifies the CPU power")]
////public virtual object-list CPUPowerInputFunctionOfLoadingAndAirTemperatureCurveName { get; set; } = new object-list;
////[Description("The fraction of the total power input at design conditions which is for the cooling fan(s)")]
////public virtual real DesignFanPowerInputFraction { get; set; } = new real;
////[Description("The cooling fan air flow rate per total electric power input at design conditions")]
////public virtual real DesignFanAirFlowRatePerPowerInput { get; set; } = new real;
////[Description("The name of a two-variable curve or table lookup object which modifies the cooling")]
////public virtual object-list AirFlowFunctionOfLoadingAndAirTemperatureCurveName { get; set; } = new object-list;
////[Description("The name of a single-variable curve or table lookup object which modifies the cooling")]
////public virtual object-list FanPowerInputFunctionOfFlowCurveName { get; set; } = new object-list;
////[Description("The entering air temperature at design conditions.")]
////public virtual real DesignEnteringAirTemperature { get; set; } = new real;
////[Description("Specifies the allowable operating conditions for the air inlet conditions.")]
////public virtual choice EnvironmentalClass { get; set; } = new choice;
////[Description("Specifies the type of connection between the zone and the ITE air inlet node.")]
////public virtual choice AirInletConnectionType { get; set; } = new choice;
////[Description("Name of a RoomAir:Node object which is connected to the ITE air inlet.")]
////public virtual object-list AirInletRoomAirModelNodeName { get; set; } = new object-list;
////[Description("Name of a RoomAir:Node object which is connected to the ITE air outlet.")]
////public virtual object-list AirOutletRoomAirModelNodeName { get; set; } = new object-list;
////[Description("Name of the supply air inlet node serving this ITE. Required if the")]
////public virtual node SupplyAirNodeName { get; set; } = new node;
////[Description("The recirculation fraction for this equipment at design conditions. This field is used only")]
////public virtual real DesignRecirculationFraction { get; set; } = new real;
////[Description("The name of a two-variable curve or table lookup object which modifies the recirculation")]
////public virtual object-list RecirculationFunctionOfLoadingAndSupplyTemperatureCurveName { get; set; } = new object-list;
////[Description("The efficiency of the power supply system serving this ITE")]
////public virtual real DesignElectricPowerSupplyEfficiency { get; set; } = new real;
////[Description("The name of a single-variable curve or table lookup object which modifies the electric")]
////public virtual object-list ElectricPowerSupplyEfficiencyFunctionOfPartLoadRatioCurveName { get; set; } = new object-list;
////[Description("Fraction of the electric power supply losses which are a heat gain to the zone")]
////public virtual real FractionOfElectricPowerSupplyLossesToZone { get; set; } = new real;
////[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Subcategory table.")]
////public virtual alpha CPUEnd-UseSubcategory { get; set; } = new alpha;
////[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Subcategory table.")]
////public virtual alpha FanEnd-UseSubcategory { get; set; } = new alpha;
////[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Subcategory table.")]
////public virtual alpha ElectricPowerSupplyEnd-UseSubcategory { get; set; } = new alpha;
////[Description("The difference of the IT inlet temperature from the AHU supply air temperature.")]
////public virtual real SupplyTemperatureDifference { get; set; } = new real;
////[Description("The difference schedule of the IT inlet temperature from the AHU supply air temperature.")]
////public virtual object-list SupplyTemperatureDifferenceSchedule { get; set; } = new object-list;
////[Description("The difference of the the actual AHU return air temperature to the IT equipment outlet temperature.")]
////public virtual real ReturnTemperatureDifference { get; set; } = new real;
////[Description("The difference schedule of the actual AHU return air temperature to the IT equipment outlet temperature.")]
////public virtual object-list ReturnTemperatureDifferenceSchedule { get; set; } = new object-list;
////}
////}
