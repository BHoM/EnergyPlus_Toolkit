////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class HVACTemplate:Plant:Tower : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("No description available")]
////public virtual choice TowerType { get; set; } = new choice;
////[Description("Applicable for tower type SingleSpeed and TwoSpeed")]
////public virtual null HighSpeedNominalCapacity { get; set; } = new null;
////[Description("Applicable for tower type SingleSpeed and TwoSpeed")]
////public virtual null HighSpeedFanPower { get; set; } = new null;
////[Description("Applicable only for Tower Type TwoSpeed")]
////public virtual null LowSpeedNominalCapacity { get; set; } = new null;
////[Description("Applicable only for Tower Type TwoSpeed")]
////public virtual null LowSpeedFanPower { get; set; } = new null;
////[Description("Applicable for Tower Type SingleSpeed and TwoSpeed")]
////public virtual null FreeConvectionCapacity { get; set; } = new null;
////[Description("Applicable for all Tower Types")]
////public virtual null Priority { get; set; } = new null;
////[Description("Multiplies the autosized capacity and flow rates")]
////public virtual real SizingFactor { get; set; } = new real;
////[Description("Specifies if this tower serves a template chilled water loop or mixed water loop")]
////public virtual choice TemplatePlantLoopType { get; set; } = new choice;
////}
////}
