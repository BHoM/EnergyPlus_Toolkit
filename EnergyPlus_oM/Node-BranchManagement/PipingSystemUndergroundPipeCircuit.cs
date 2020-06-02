//using BH.oM.Base;
//using System.Collections.Generic;
//using System.ComponentModel;
//
//namespace BH.oM.EnergyPlus
//{
//public class PipingSystem:Underground:PipeCircuit : BHoMObject
//{
//[Description("No description available")]
//public virtual alpha Name { get; set; } = new alpha;
//[Description("No description available")]
//public virtual real PipeThermalConductivity { get; set; } = new real;
//[Description("No description available")]
//public virtual real PipeDensity { get; set; } = new real;
//[Description("No description available")]
//public virtual real PipeSpecificHeat { get; set; } = new real;
//[Description("No description available")]
//public virtual real PipeInnerDiameter { get; set; } = new real;
//[Description("No description available")]
//public virtual real PipeOuterDiameter { get; set; } = new real;
//[Description("No description available")]
//public virtual real DesignFlowRate { get; set; } = new real;
//[Description("No description available")]
//public virtual node CircuitInletNode { get; set; } = new node;
//[Description("No description available")]
//public virtual node CircuitOutletNode { get; set; } = new node;
//[Description("No description available")]
//public virtual real ConvergenceCriterionForTheInnerRadialIterationLoop { get; set; } = new real;
//[Description("No description available")]
//public virtual integer MaximumIterationsInTheInnerRadialIterationLoop { get; set; } = new integer;
//[Description("No description available")]
//public virtual integer NumberOfSoilNodesInTheInnerRadialNearPipeMeshRegion { get; set; } = new integer;
//[Description("Required because it must be selected by user instead of being")]
//public virtual real RadialThicknessOfInnerRadialNearPipeMeshRegion { get; set; } = new real;
//[Description("No description available")]
//public virtual integer NumberOfPipeSegmentsEnteredForThisPipeCircuit { get; set; } = new integer;
//[Description("Name of a pipe segment to be included in this pipe circuit")]
//public virtual object-list PipeSegment1 { get; set; } = new object-list;
//[Description("optional")]
//public virtual object-list PipeSegment2 { get; set; } = new object-list;
//[Description("optional")]
//public virtual object-list PipeSegment3 { get; set; } = new object-list;
//[Description("optional")]
//public virtual object-list PipeSegment4 { get; set; } = new object-list;
//[Description("optional")]
//public virtual object-list PipeSegment5 { get; set; } = new object-list;
//[Description("optional")]
//public virtual object-list PipeSegment6 { get; set; } = new object-list;
//}
//}
