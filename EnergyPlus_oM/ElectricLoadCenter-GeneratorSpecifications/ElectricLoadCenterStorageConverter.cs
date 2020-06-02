//using BH.oM.Base;
//using System.Collections.Generic;
//using System.ComponentModel;
//
//namespace BH.oM.EnergyPlus
//{
//public class ElectricLoadCenter:Storage:Converter : BHoMObject
//{
//[Description("No description available")]
//public virtual null Name { get; set; } = new null;
//[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
//public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
//[Description("SimpleFixed indicates power conversion losses are based on Simple Fixed Efficiency")]
//public virtual choice PowerConversionEfficiencyMethod { get; set; } = new choice;
//[Description("Constant efficiency for conversion of AC to DC at all power levels.")]
//public virtual real SimpleFixedEfficiency { get; set; } = new real;
//[Description("Required field when Power Conversion Efficiency Method is set to FunctionOfPower.")]
//public virtual real DesignMaximumContinuousInputPower { get; set; } = new real;
//[Description("Curve or table with a single independent variable that describes efficiency as a function of normalized power.")]
//public virtual object-list EfficiencyFunctionOfPowerCurveName { get; set; } = new object-list;
//[Description("Optional standby power consumed when converter is available but no power is being conditioned.")]
//public virtual real AncillaryPowerConsumedInStandby { get; set; } = new real;
//[Description("enter name of zone to receive converter losses as heat")]
//public virtual object-list ZoneName { get; set; } = new object-list;
//[Description("fraction of zone heat gains treated as thermal radiation")]
//public virtual null RadiativeFraction { get; set; } = new null;
//}
//}
