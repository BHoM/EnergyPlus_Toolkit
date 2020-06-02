////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class WaterHeater:Sizing : BHoMObject
////{
////[Description("No description available")]
////public virtual object-list WaterHeaterName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice DesignMode { get; set; } = new choice;
////[Description("Only used for Design Mode = PeakDraw")]
////public virtual real TimeStorageCanMeetPeakDraw { get; set; } = new real;
////[Description("Only used for Design Mode = PeakDraw")]
////public virtual real TimeForTankRecovery { get; set; } = new real;
////[Description("Only used if Design Mode = PeakDraw and the water heater also")]
////public virtual real NominalTankVolumeForAutosizingPlantConnections { get; set; } = new real;
////[Description("Only used for Design Mode = ResidentialHUD-FHAMinimum")]
////public virtual integer NumberOfBedrooms { get; set; } = new integer;
////[Description("Only used for Design Mode = ResidentialHUD-FHAMinimum")]
////public virtual integer NumberOfBathrooms { get; set; } = new integer;
////[Description("Only used for Design Mode = PerPerson")]
////public virtual real StorageCapacityPerPerson { get; set; } = new real;
////[Description("Only used for Design Mode = PerPerson")]
////public virtual real RecoveryCapacityPerPerson { get; set; } = new real;
////[Description("Only used for Design Mode = PerFloorArea")]
////public virtual real StorageCapacityPerFloorArea { get; set; } = new real;
////[Description("Only used for Design Mode = PerFloorArea")]
////public virtual real RecoveryCapacityPerFloorArea { get; set; } = new real;
////[Description("Only used for Design Mode = PerUnit")]
////public virtual real NumberOfUnits { get; set; } = new real;
////[Description("Only used for Design Mode = PerUnit")]
////public virtual real StorageCapacityPerUnit { get; set; } = new real;
////[Description("Only used for Design Mode = PerUnit")]
////public virtual real RecoveryCapacityPerUnit { get; set; } = new real;
////[Description("Only used for Design Mode = PerSolarCollectorArea")]
////public virtual real StorageCapacityPerCollectorArea { get; set; } = new real;
////[Description("only used if for WaterHeater:Stratified")]
////public virtual real HeightAspectRatio { get; set; } = new real;
////}
////}
