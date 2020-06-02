////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class HVACTemplate:Plant:Boiler : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("No description available")]
////public virtual choice BoilerType { get; set; } = new choice;
////[Description("No description available")]
////public virtual null Capacity { get; set; } = new null;
////[Description("Not applicable if Boiler Type is DistrictHotWater")]
////public virtual null Efficiency { get; set; } = new null;
////[Description("Not applicable if Boiler Type is DistrictHotWater")]
////public virtual choice FuelType { get; set; } = new choice;
////[Description("If Hot Water Plant Operation Scheme Type=Default")]
////public virtual null Priority { get; set; } = new null;
////[Description("Multiplies the autosized capacity and flow rates")]
////public virtual real SizingFactor { get; set; } = new real;
////[Description("No description available")]
////public virtual real MinimumPartLoadRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumPartLoadRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real OptimumPartLoadRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real WaterOutletUpperTemperatureLimit { get; set; } = new real;
////[Description("Specifies if this boiler serves a template hot water loop or mixed water loop")]
////public virtual choice TemplatePlantLoopType { get; set; } = new choice;
////}
////}
