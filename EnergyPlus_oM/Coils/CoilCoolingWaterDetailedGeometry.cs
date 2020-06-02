////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Coil:Cooling:Water:DetailedGeometry : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual null MaximumWaterFlowRate { get; set; } = new null;
////[Description("Tube Primary Surface Area")]
////public virtual null TubeOutsideSurfaceArea { get; set; } = new null;
////[Description("Total tube inside surface area")]
////public virtual null TotalTubeInsideArea { get; set; } = new null;
////[Description("No description available")]
////public virtual null FinSurfaceArea { get; set; } = new null;
////[Description("No description available")]
////public virtual null MinimumAirflowArea { get; set; } = new null;
////[Description("No description available")]
////public virtual null CoilDepth { get; set; } = new null;
////[Description("Fin diameter or the coil height")]
////public virtual null FinDiameter { get; set; } = new null;
////[Description("No description available")]
////public virtual real FinThickness { get; set; } = new real;
////[Description("Inner diameter of tubes")]
////public virtual null TubeInsideDiameter { get; set; } = new null;
////[Description("Outer diameter of tubes")]
////public virtual null TubeOutsideDiameter { get; set; } = new null;
////[Description("No description available")]
////public virtual real TubeThermalConductivity { get; set; } = new real;
////[Description("No description available")]
////public virtual real FinThermalConductivity { get; set; } = new real;
////[Description("Fin spacing or distance")]
////public virtual null FinSpacing { get; set; } = new null;
////[Description("No description available")]
////public virtual null TubeDepthSpacing { get; set; } = new null;
////[Description("No description available")]
////public virtual null NumberOfTubeRows { get; set; } = new null;
////[Description("No description available")]
////public virtual null NumberOfTubesPerRow { get; set; } = new null;
////[Description("No description available")]
////public virtual node WaterInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node WaterOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual object-list CondensateCollectionWaterStorageTankName { get; set; } = new object-list;
////[Description("This input field is optional. If specified, it is used for sizing the Design Water Flow Rate.")]
////public virtual real DesignWaterTemperatureDifference { get; set; } = new real;
////}
////}
