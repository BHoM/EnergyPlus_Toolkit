////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class SetpointManager:ReturnTemperature:ChilledWater : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("This is the name of the supply outlet node for the plant being controlled by this")]
////public virtual node PlantLoopSupplyOutletNode { get; set; } = new node;
////[Description("This is the name of the supply inlet node for the plant being controlled with this")]
////public virtual node PlantLoopSupplyInletNode { get; set; } = new node;
////[Description("This is the minimum chilled water supply temperature setpoint. This is also used as the default")]
////public virtual real MinimumSupplyTemperatureSetpoint { get; set; } = new real;
////[Description("This is the maximum reset temperature for the chilled water supply.")]
////public virtual real MaximumSupplyTemperatureSetpoint { get; set; } = new real;
////[Description("This defines whether the chilled water return temperature target is constant,")]
////public virtual choice ReturnTemperatureSetpointInputType { get; set; } = new choice;
////[Description("This is the desired return temperature target, which is met by adjusting the")]
////public virtual real ReturnTemperatureSetpointConstantValue { get; set; } = new real;
////[Description("This is the desired return temperature target, which is met by adjusting the")]
////public virtual object-list ReturnTemperatureSetpointScheduleName { get; set; } = new object-list;
////}
////}
