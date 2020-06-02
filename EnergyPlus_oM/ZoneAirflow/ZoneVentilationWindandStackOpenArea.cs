////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class ZoneVentilation:WindandStackOpenArea : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("This is the opening area used to calculate stack effect and wind driven ventilation.")]
////public virtual real OpeningArea { get; set; } = new real;
////[Description("This schedule contains the fraction values applied to the opening area given in the previous")]
////public virtual object-list OpeningAreaFractionScheduleName { get; set; } = new object-list;
////[Description("This field is used to calculate wind driven ventilation.")]
////public virtual real OpeningEffectiveness { get; set; } = new real;
////[Description("This field is defined as normal angle of the opening area and is used when input")]
////public virtual real EffectiveAngle { get; set; } = new real;
////[Description("This is the height difference between the midpoint of an opening and")]
////public virtual real HeightDifference { get; set; } = new real;
////[Description("This is the discharge coefficient used to calculate stack effect.")]
////public virtual null DischargeCoefficientForOpening { get; set; } = new null;
////[Description("This is the indoor temperature below which ventilation is shutoff.")]
////public virtual real MinimumIndoorTemperature { get; set; } = new real;
////[Description("This schedule contains the indoor temperature versus time below which")]
////public virtual object-list MinimumIndoorTemperatureScheduleName { get; set; } = new object-list;
////[Description("This is the indoor temperature above which ventilation is shutoff.")]
////public virtual real MaximumIndoorTemperature { get; set; } = new real;
////[Description("This schedule contains the indoor temperature versus time above which")]
////public virtual object-list MaximumIndoorTemperatureScheduleName { get; set; } = new object-list;
////[Description("This is the temperature differential between indoor and outdoor below")]
////public virtual real DeltaTemperature { get; set; } = new real;
////[Description("This schedule contains the temperature differential between indoor and outdoor")]
////public virtual object-list DeltaTemperatureScheduleName { get; set; } = new object-list;
////[Description("This is the outdoor temperature below which ventilation is shutoff.")]
////public virtual real MinimumOutdoorTemperature { get; set; } = new real;
////[Description("This schedule contains the outdoor temperature versus time below which")]
////public virtual object-list MinimumOutdoorTemperatureScheduleName { get; set; } = new object-list;
////[Description("This is the outdoor temperature above which ventilation is shutoff.")]
////public virtual real MaximumOutdoorTemperature { get; set; } = new real;
////[Description("This schedule contains the outdoor temperature versus time above which")]
////public virtual object-list MaximumOutdoorTemperatureScheduleName { get; set; } = new object-list;
////[Description("This is the outdoor wind speed above which ventilation is shutoff.")]
////public virtual real MaximumWindSpeed { get; set; } = new real;
////}
////}
