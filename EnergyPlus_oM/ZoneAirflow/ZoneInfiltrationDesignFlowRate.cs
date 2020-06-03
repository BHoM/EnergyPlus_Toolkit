////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class ZoneInfiltration:DesignFlowRate : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual string ZoneOrZoneListName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual string ScheduleName { get; set; } = new object-list;
////[Description("The entered calculation method is used to create the maximum amount of infiltration")]
////public virtual choice DesignFlowRateCalculationMethod { get; set; } = new choice;
////[Description("No description available")]
////public virtual real DesignFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real FlowPerZoneFloorArea { get; set; } = new real;
////[Description("use key Flow/ExteriorArea for all exterior surface area")]
////public virtual real FlowPerExteriorSurfaceArea { get; set; } = new real;
////[Description("No description available")]
////public virtual real AirChangesPerHour { get; set; } = new real;
////[Description(""A" in Equation")]
////public virtual real ConstantTermCoefficient { get; set; } = new real;
////[Description(""B" in Equation")]
////public virtual real TemperatureTermCoefficient { get; set; } = new real;
////[Description(""C" in Equation")]
////public virtual real VelocityTermCoefficient { get; set; } = new real;
////[Description(""D" in Equation")]
////public virtual real VelocitySquaredTermCoefficient { get; set; } = new real;
////}
////}
