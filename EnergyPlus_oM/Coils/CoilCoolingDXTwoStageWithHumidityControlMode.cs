////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Coil:Cooling:DX:TwoStageWithHumidityControlMode : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual real CrankcaseHeaterCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumOutdoorDry-BulbTemperatureForCrankcaseHeaterOperation { get; set; } = new real;
////[Description("No description available")]
////public virtual integer NumberOfCapacityStages { get; set; } = new integer;
////[Description("No description available")]
////public virtual integer NumberOfEnhancedDehumidificationModes { get; set; } = new integer;
////[Description("No description available")]
////public virtual choice NormalModeStage1CoilPerformanceObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list NormalModeStage1CoilPerformanceName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice NormalModeStage1+2CoilPerformanceObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list NormalModeStage1+2CoilPerformanceName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice DehumidificationMode1Stage1CoilPerformanceObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list DehumidificationMode1Stage1CoilPerformanceName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice DehumidificationMode1Stage1+2CoilPerformanceObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list DehumidificationMode1Stage1+2CoilPerformanceName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list SupplyWaterStorageTankName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list CondensateCollectionWaterStorageTankName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real MinimumOutdoorDry-BulbTemperatureForCompressorOperation { get; set; } = new real;
////[Description("This field is only used for Condenser Type = EvaporativelyCooled and for periods")]
////public virtual real BasinHeaterCapacity { get; set; } = new real;
////[Description("This field is only used for Condenser Type = EvaporativelyCooled.")]
////public virtual real BasinHeaterSetpointTemperature { get; set; } = new real;
////[Description("This field is only used for Condenser Type = EvaporativelyCooled.")]
////public virtual object-list BasinHeaterOperatingScheduleName { get; set; } = new object-list;
////}
////}
