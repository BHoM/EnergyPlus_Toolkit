////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class GroundHeatExchanger:HorizontalTrench : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("No description available")]
////public virtual node InletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node OutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual real DesignFlowRate { get; set; } = new real;
////[Description("This is the total pipe axial length of the heat exchanger")]
////public virtual real TrenchLengthInPipeAxialDirection { get; set; } = new real;
////[Description("This is the number of horizontal legs that will be used")]
////public virtual integer NumberOfTrenches { get; set; } = new integer;
////[Description("This represents the average horizontal spacing between any two")]
////public virtual real HorizontalSpacingBetweenPipes { get; set; } = new real;
////[Description("No description available")]
////public virtual real PipeInnerDiameter { get; set; } = new real;
////[Description("No description available")]
////public virtual real PipeOuterDiameter { get; set; } = new real;
////[Description("This is the burial depth of the pipes, or the trenches")]
////public virtual real BurialDepth { get; set; } = new real;
////[Description("No description available")]
////public virtual real SoilThermalConductivity { get; set; } = new real;
////[Description("No description available")]
////public virtual real SoilDensity { get; set; } = new real;
////[Description("No description available")]
////public virtual real SoilSpecificHeat { get; set; } = new real;
////[Description("No description available")]
////public virtual real PipeThermalConductivity { get; set; } = new real;
////[Description("No description available")]
////public virtual real PipeDensity { get; set; } = new real;
////[Description("No description available")]
////public virtual real PipeSpecificHeat { get; set; } = new real;
////[Description("No description available")]
////public virtual real SoilMoistureContentPercent { get; set; } = new real;
////[Description("No description available")]
////public virtual real SoilMoistureContentPercentAtSaturation { get; set; } = new real;
////[Description("No description available")]
////public virtual choice UndisturbedGroundTemperatureModelType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list UndisturbedGroundTemperatureModelName { get; set; } = new object-list;
////[Description("This specifies the ground cover effects during evapotranspiration")]
////public virtual real EvapotranspirationGroundCoverParameter { get; set; } = new real;
////}
////}
