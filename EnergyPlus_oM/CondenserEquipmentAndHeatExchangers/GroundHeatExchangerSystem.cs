////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class GroundHeatExchanger:System : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual node InletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node OutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual real DesignFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual choice UndisturbedGroundTemperatureModelType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list UndisturbedGroundTemperatureModelName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real GroundThermalConductivity { get; set; } = new real;
////[Description("No description available")]
////public virtual real GroundThermalHeatCapacity { get; set; } = new real;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:ResponseFactorsObjectName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:ArrayObjectName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName1 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName2 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName3 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName4 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName5 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName6 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName7 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName8 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName9 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName10 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName11 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName12 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName13 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName14 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName15 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName16 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName17 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName18 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName19 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName20 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName21 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName22 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName23 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName24 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName25 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName26 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName27 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName28 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName29 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName30 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName31 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName32 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName33 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName34 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName35 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName36 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName37 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName38 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName39 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName40 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName41 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName42 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName43 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName44 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName45 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName46 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName47 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName48 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName49 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName50 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName51 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName52 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName53 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName54 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName55 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName56 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName57 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName58 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName59 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName60 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName61 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName62 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName63 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName64 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName65 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName66 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName67 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName68 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName69 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName70 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName71 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName72 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName73 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName74 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName75 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName76 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName77 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName78 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName79 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName80 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName81 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName82 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName83 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName84 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName85 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName86 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName87 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName88 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName89 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName90 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName91 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName92 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName93 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName94 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName95 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName96 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName97 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName98 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName99 { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list GHE:Vertical:SingleObjectName100 { get; set; } = new object-list;
////}
////}
