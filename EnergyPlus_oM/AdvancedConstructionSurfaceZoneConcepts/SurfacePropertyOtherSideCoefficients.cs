////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class SurfaceProperty:OtherSideCoefficients : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("if>0, this field becomes the exterior convective/radiative film coefficient")]
////public virtual real CombinedConvective/RadiativeFilmCoefficient { get; set; } = new real;
////[Description("This parameter will be overwritten by the values from the Constant Temperature Schedule Name (below) if one is present")]
////public virtual real ConstantTemperature { get; set; } = new real;
////[Description("This coefficient is used even with a Schedule. It should normally be 1.0 in that case.")]
////public virtual null ConstantTemperatureCoefficient { get; set; } = new null;
////[Description("No description available")]
////public virtual real ExternalDry-BulbTemperatureCoefficient { get; set; } = new real;
////[Description("No description available")]
////public virtual real GroundTemperatureCoefficient { get; set; } = new real;
////[Description("No description available")]
////public virtual real WindSpeedCoefficient { get; set; } = new real;
////[Description("No description available")]
////public virtual real ZoneAirTemperatureCoefficient { get; set; } = new real;
////[Description("Name of schedule for values of constant temperature.")]
////public virtual object-list ConstantTemperatureScheduleName { get; set; } = new object-list;
////[Description("Optionally used to vary Constant Temperature Coefficient with unitary sine wave")]
////public virtual choice SinusoidalVariationOfConstantTemperatureCoefficient { get; set; } = new choice;
////[Description("Use with sinusoidal variation to define the time period")]
////public virtual real PeriodOfSinusoidalVariation { get; set; } = new real;
////[Description("This coefficient multiplies the other side temperature result from the")]
////public virtual real PreviousOtherSideTemperatureCoefficient { get; set; } = new real;
////[Description("This field specifies a lower limit for the other side temperature result.")]
////public virtual real MinimumOtherSideTemperatureLimit { get; set; } = new real;
////[Description("This field specifies an upper limit for the other side temperature result.")]
////public virtual real MaximumOtherSideTemperatureLimit { get; set; } = new real;
////}
////}
