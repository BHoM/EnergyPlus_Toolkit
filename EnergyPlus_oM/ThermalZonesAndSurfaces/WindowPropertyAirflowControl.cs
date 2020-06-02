////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class WindowProperty:AirflowControl : BHoMObject
////{
////[Description("Name must be that of an exterior window with two or three glass layers.")]
////public virtual object-list Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice AirflowSource { get; set; } = new choice;
////[Description("If ReturnAir is selected, the name of the Return Air Node may be specified below.")]
////public virtual choice AirflowDestination { get; set; } = new choice;
////[Description("Above is m3/s per m of glazing width")]
////public virtual null MaximumFlowRate { get; set; } = new null;
////[Description("ScheduledOnly requires that Airflow Has Multiplier Schedule Name = Yes")]
////public virtual choice AirflowControlType { get; set; } = new choice;
////[Description("If True, then Airflow Multiplier Schedule Name must be specified")]
////public virtual choice AirflowIsScheduled { get; set; } = new choice;
////[Description("Required if Airflow Is Scheduled = Yes.")]
////public virtual object-list AirflowMultiplierScheduleName { get; set; } = new object-list;
////[Description("Name of the return air node for this airflow window if the Airflow Destination is ReturnAir.")]
////public virtual node AirflowReturnAirNodeName { get; set; } = new node;
////}
////}
