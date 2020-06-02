////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class AirflowNetwork:Distribution:Component:Duct : BHoMObject
////{
////[Description("Enter a unique name for this object.")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Enter the length of the duct.")]
////public virtual real DuctLength { get; set; } = new real;
////[Description("Enter the hydraulic diameter of the duct.")]
////public virtual real HydraulicDiameter { get; set; } = new real;
////[Description("Enter the cross section area of the duct.")]
////public virtual real CrossSectionArea { get; set; } = new real;
////[Description("Enter the inside surface roughness of the duct.")]
////public virtual real SurfaceRoughness { get; set; } = new real;
////[Description("Enter the coefficient used to calculate dynamic losses of fittings (e.g. elbows).")]
////public virtual real CoefficientForLocalDynamicLossDueToFitting { get; set; } = new real;
////[Description("conduction only")]
////public virtual real HeatTransmittanceCoefficient(U-Factor)ForDuctWallConstruction { get; set; } = new real;
////[Description("Enter the overall moisture transmittance coefficient")]
////public virtual real OverallMoistureTransmittanceCoefficientFromAirToAir { get; set; } = new real;
////[Description("optional. convection coefficient calculated automatically, unless specified")]
////public virtual real OutsideConvectionCoefficient { get; set; } = new real;
////[Description("optional. convection coefficient calculated automatically, unless specified")]
////public virtual real InsideConvectionCoefficient { get; set; } = new real;
////}
////}
