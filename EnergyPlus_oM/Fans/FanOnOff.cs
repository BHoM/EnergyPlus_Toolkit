////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Fan:OnOff : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real FanTotalEfficiency { get; set; } = new real;
////[Description("No description available")]
////public virtual null PressureRise { get; set; } = new null;
////[Description("No description available")]
////public virtual null MaximumFlowRate { get; set; } = new null;
////[Description("No description available")]
////public virtual real MotorEfficiency { get; set; } = new real;
////[Description("0.0 means fan motor outside of air stream, 1.0 means motor inside of air stream")]
////public virtual real MotorInAirstreamFraction { get; set; } = new real;
////[Description("No description available")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual object-list FanPowerRatioFunctionOfSpeedRatioCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list FanEfficiencyRatioFunctionOfSpeedRatioCurveName { get; set; } = new object-list;
////[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Subcategory table.")]
////public virtual alpha End-UseSubcategory { get; set; } = new alpha;
////}
////}
