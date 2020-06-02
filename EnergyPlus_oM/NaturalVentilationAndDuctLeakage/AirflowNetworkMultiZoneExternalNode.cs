////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class AirflowNetwork:MultiZone:ExternalNode : BHoMObject
////{
////[Description("Enter a unique name for this object.")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Designates the reference height used to calculate relative pressure.")]
////public virtual real ExternalNodeHeight { get; set; } = new real;
////[Description("The name of the AirflowNetwork:MultiZone:WindPressureCoefficientValues, curve, or table object specifying the wind pressure coefficient.")]
////public virtual object-list WindPressureCoefficientCurveName { get; set; } = new object-list;
////[Description("Specify whether the pressure curve is symmetric or not.")]
////public virtual choice SymmetricWindPressureCoefficientCurve { get; set; } = new choice;
////[Description("Specify whether the angle used to compute the wind pressure coefficient is absolute or relative")]
////public virtual choice WindAngleType { get; set; } = new choice;
////}
////}
