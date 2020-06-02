////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Coil:Heating:Electric:MultiStage : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("Required if coil is temperature controlled.")]
////public virtual node TemperatureSetpointNodeName { get; set; } = new node;
////[Description("Enter the number of the following sets of data for coil")]
////public virtual integer NumberOfStages { get; set; } = new integer;
////[Description("No description available")]
////public virtual real Stage1Efficiency { get; set; } = new real;
////[Description("No description available")]
////public virtual real Stage1NominalCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Stage2Efficiency { get; set; } = new real;
////[Description("No description available")]
////public virtual real Stage2NominalCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Stage3Efficiency { get; set; } = new real;
////[Description("No description available")]
////public virtual real Stage3NominalCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual real Stage4Efficiency { get; set; } = new real;
////[Description("No description available")]
////public virtual real Stage4NominalCapacity { get; set; } = new real;
////}
////}
