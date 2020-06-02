////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class AirTerminal:SingleDuct:ConstantVolume:CooledBeam : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice CooledBeamType { get; set; } = new choice;
////[Description("No description available")]
////public virtual node SupplyAirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node SupplyAirOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node ChilledWaterInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node ChilledWaterOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual real SupplyAirVolumetricFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumTotalChilledWaterVolumetricFlowRate { get; set; } = new real;
////[Description("Number of individual beam units in the zone")]
////public virtual integer NumberOfBeams { get; set; } = new integer;
////[Description("Length of an individual beam unit")]
////public virtual real BeamLength { get; set; } = new real;
////[Description("No description available")]
////public virtual real DesignInletWaterTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual real DesignOutletWaterTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual real CoilSurfaceAreaPerCoilLength { get; set; } = new real;
////[Description("No description available")]
////public virtual real ModelParameterA { get; set; } = new real;
////[Description("No description available")]
////public virtual real ModelParameterN1 { get; set; } = new real;
////[Description("No description available")]
////public virtual real ModelParameterN2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real ModelParameterN3 { get; set; } = new real;
////[Description("Free area of the coil in plan view per unit beam length")]
////public virtual real ModelParameterA0 { get; set; } = new real;
////[Description("No description available")]
////public virtual real ModelParameterK1 { get; set; } = new real;
////[Description("No description available")]
////public virtual real ModelParameterN { get; set; } = new real;
////[Description("No description available")]
////public virtual real CoefficientOfInductionKin { get; set; } = new real;
////[Description("No description available")]
////public virtual real LeavingPipeInsideDiameter { get; set; } = new real;
////}
////}
