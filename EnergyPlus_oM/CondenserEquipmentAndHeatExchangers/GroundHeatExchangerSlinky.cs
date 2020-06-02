////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class GroundHeatExchanger:Slinky : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("No description available")]
////public virtual node InletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node OutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual real DesignFlowRate { get; set; } = new real;
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
////public virtual real PipeOuterDiameter { get; set; } = new real;
////[Description("No description available")]
////public virtual real PipeThickness { get; set; } = new real;
////[Description("This is the orientation of the heat exchanger")]
////public virtual choice HeatExchangerConfiguration { get; set; } = new choice;
////[Description("This is the diameter of the heat exchanger coil")]
////public virtual real CoilDiameter { get; set; } = new real;
////[Description("This is the center-to-center distance between coils")]
////public virtual real CoilPitch { get; set; } = new real;
////[Description("This is the distance from the ground surface to the")]
////public virtual real TrenchDepth { get; set; } = new real;
////[Description("This is the total length of a single trench")]
////public virtual real TrenchLength { get; set; } = new real;
////[Description("This is the number of parallel trenches that")]
////public virtual integer NumberOfTrenches { get; set; } = new integer;
////[Description("This represents the average horizontal spacing")]
////public virtual real HorizontalSpacingBetweenPipes { get; set; } = new real;
////[Description("No description available")]
////public virtual choice UndisturbedGroundTemperatureModelType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list UndisturbedGroundTemperatureModelName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real MaximumLengthOfSimulation { get; set; } = new real;
////}
////}
