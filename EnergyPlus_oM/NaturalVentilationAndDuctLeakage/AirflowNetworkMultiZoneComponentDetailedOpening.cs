////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class AirflowNetwork:MultiZone:Component:DetailedOpening : BHoMObject
////{
////[Description("Enter a unique name for this object.")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Defined at 1 Pa per meter of crack length. Enter the coefficient used in the following")]
////public virtual real AirMassFlowCoefficientWhenOpeningIsClosed { get; set; } = new real;
////[Description("Enter the exponent used in the following equation:")]
////public virtual real AirMassFlowExponentWhenOpeningIsClosed { get; set; } = new real;
////[Description("Select the type of vertical opening: Non-pivoted opening or Horizontally pivoted opening.")]
////public virtual choice TypeOfRectangularLargeVerticalOpening(LVO) { get; set; } = new choice;
////[Description("Extra crack length is used for LVO Non-pivoted type with multiple openable parts.")]
////public virtual real ExtraCrackLengthOrHeightOfPivotingAxis { get; set; } = new real;
////[Description("Enter the number of the following sets of data for opening factor,")]
////public virtual integer NumberOfSetsOfOpeningFactorData { get; set; } = new integer;
////[Description("This value must be specified as 0.")]
////public virtual real OpeningFactor1 { get; set; } = new real;
////[Description("The Discharge Coefficient indicates the fractional effectiveness")]
////public virtual real DischargeCoefficientForOpeningFactor1 { get; set; } = new real;
////[Description("The Width Factor is the opening width divided by the window or door width.")]
////public virtual real WidthFactorForOpeningFactor1 { get; set; } = new real;
////[Description("The Height Factor is the opening height divided by the window or door height.")]
////public virtual real HeightFactorForOpeningFactor1 { get; set; } = new real;
////[Description("The Start Height Factor is the Start Height divided by the window or door height.")]
////public virtual real StartHeightFactorForOpeningFactor1 { get; set; } = new real;
////[Description("If Number of Sets of Opening Factor Data = 2, this value must be 1.0.")]
////public virtual real OpeningFactor2 { get; set; } = new real;
////[Description("The Discharge Coefficient indicates the fractional effectiveness")]
////public virtual real DischargeCoefficientForOpeningFactor2 { get; set; } = new real;
////[Description("The Width Factor is the opening width divided by the window or door width.")]
////public virtual real WidthFactorForOpeningFactor2 { get; set; } = new real;
////[Description("The Height Factor is the opening height divided by the window or door height.")]
////public virtual real HeightFactorForOpeningFactor2 { get; set; } = new real;
////[Description("The Start Height Factor is the Start Height divided by the window or door height.")]
////public virtual real StartHeightFactorForOpeningFactor2 { get; set; } = new real;
////[Description("If Number of Sets of Opening Factor Data = 3, this value must be 1.0.")]
////public virtual real OpeningFactor3 { get; set; } = new real;
////[Description("The Discharge Coefficient indicates the fractional effectiveness")]
////public virtual real DischargeCoefficientForOpeningFactor3 { get; set; } = new real;
////[Description("The Width Factor is the opening width divided by the window or door width.")]
////public virtual real WidthFactorForOpeningFactor3 { get; set; } = new real;
////[Description("The Height Factor is the opening height divided by the window or door height.")]
////public virtual real HeightFactorForOpeningFactor3 { get; set; } = new real;
////[Description("The Start Height Factor is the Start Height divided by the window or door height.")]
////public virtual real StartHeightFactorForOpeningFactor3 { get; set; } = new real;
////[Description("If Number of Sets of Opening Factor Data = 4, this value must be 1.0")]
////public virtual real OpeningFactor4 { get; set; } = new real;
////[Description("The Discharge Coefficient indicates the fractional effectiveness")]
////public virtual real DischargeCoefficientForOpeningFactor4 { get; set; } = new real;
////[Description("The Width Factor is the opening width divided by the window or door width.")]
////public virtual real WidthFactorForOpeningFactor4 { get; set; } = new real;
////[Description("The Height Factor is the opening height divided by the window or door height.")]
////public virtual real HeightFactorForOpeningFactor4 { get; set; } = new real;
////[Description("The Start Height Factor is the Start Height divided by the window or door height.")]
////public virtual real StartHeightFactorForOpeningFactor4 { get; set; } = new real;
////}
////}
