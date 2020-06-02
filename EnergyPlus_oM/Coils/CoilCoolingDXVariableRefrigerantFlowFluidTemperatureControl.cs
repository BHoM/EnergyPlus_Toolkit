////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Coil:Cooling:DX:VariableRefrigerantFlow:FluidTemperatureControl : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Enter the name of a schedule that defines the availability of the coil")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("the inlet node to the coil")]
////public virtual node CoilAirInletNode { get; set; } = new node;
////[Description("the outlet node to the coil")]
////public virtual node CoilAirOutletNode { get; set; } = new node;
////[Description("Supply air fan heat is not included")]
////public virtual real RatedTotalCoolingCapacity { get; set; } = new real;
////[Description("Supply air fan heat is not included")]
////public virtual real RatedSensibleHeatRatio { get; set; } = new real;
////[Description("No description available")]
////public virtual real IndoorUnitReferenceSuperheating { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list IndoorUnitEvaporatingTemperatureFunctionOfSuperheatingCurveName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list NameOfWaterStorageTankForCondensateCollection { get; set; } = new object-list;
////}
////}
