////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Construction:AirBoundary : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("This field controls how the surface is modeled for solar distribution and daylighting calculations.")]
////public virtual choice SolarAndDaylightingMethod { get; set; } = new choice;
////[Description("This field controls how the surface is modeled for radiant exchange calculations.")]
////public virtual choice RadiantExchangeMethod { get; set; } = new choice;
////[Description("This field controls how air exchange is modeled across this boundary.")]
////public virtual choice AirExchangeMethod { get; set; } = new choice;
////[Description("If the Air Exchange Method is SimpleMixing then this field specifies the air changes per hour")]
////public virtual real SimpleMixingAirChangesPerHour { get; set; } = new real;
////[Description("If the Air Exchange Method is SimpleMixing then this field specifies the air exchange schedule.")]
////public virtual object-list SimpleMixingScheduleName { get; set; } = new object-list;
////}
////}
