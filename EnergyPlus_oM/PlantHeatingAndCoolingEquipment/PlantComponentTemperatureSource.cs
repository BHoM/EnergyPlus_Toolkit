////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class PlantComponent:TemperatureSource : BHoMObject
////{
////[Description("Component Name")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Name of the source inlet node")]
////public virtual node InletNode { get; set; } = new node;
////[Description("Name of the source outlet node")]
////public virtual node OutletNode { get; set; } = new node;
////[Description("The design volumetric flow rate for this source")]
////public virtual real DesignVolumeFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual choice TemperatureSpecificationType { get; set; } = new choice;
////[Description("Used if Temperature Specification Type = Constant")]
////public virtual real SourceTemperature { get; set; } = new real;
////[Description("Used if Temperature Specification Type = Scheduled")]
////public virtual object-list SourceTemperatureScheduleName { get; set; } = new object-list;
////}
////}
