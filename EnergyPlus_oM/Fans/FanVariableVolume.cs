////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Fan:VariableVolume : BHoMObject
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
////public virtual choice FanPowerMinimumFlowRateInputMethod { get; set; } = new choice;
////[Description("No description available")]
////public virtual real FanPowerMinimumFlowFraction { get; set; } = new real;
////[Description("No description available")]
////public virtual real FanPowerMinimumAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real MotorEfficiency { get; set; } = new real;
////[Description("0.0 means fan motor outside of air stream, 1.0 means motor inside of air stream")]
////public virtual real MotorInAirstreamFraction { get; set; } = new real;
////[Description("all Fan Power Coefficients should not be 0.0 or no fan power will be consumed.")]
////public virtual null FanPowerCoefficient1 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FanPowerCoefficient2 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FanPowerCoefficient3 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FanPowerCoefficient4 { get; set; } = new null;
////[Description("No description available")]
////public virtual null FanPowerCoefficient5 { get; set; } = new null;
////[Description("No description available")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Subcategory table.")]
////public virtual alpha End-UseSubcategory { get; set; } = new alpha;
////}
////}
