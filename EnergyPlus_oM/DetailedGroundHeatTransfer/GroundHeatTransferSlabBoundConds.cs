////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class GroundHeatTransfer:Slab:BoundConds : BHoMObject
////{
////[Description("This field specifies whether or not to use the evapotransporation model.")]
////public virtual choice EVTR:IsSurfaceEvapotranspirationModeled { get; set; } = new choice;
////[Description("This field permits using a fixed temperature at the lower surface of the model")]
////public virtual choice FIXBC:IsTheLowerBoundaryAtAFixedTemperature { get; set; } = new choice;
////[Description("User input lower boundary temperature if FIXBC is TRUE")]
////public virtual null TDEEPin { get; set; } = new null;
////[Description("This field flags the use of a user specified heat transfer coefficient")]
////public virtual choice USRHflag:IsTheGroundSurfaceHSpecifiedByTheUser? { get; set; } = new choice;
////[Description("Used only if USRHflag is TRUE and the heat transfer coefficient value is")]
////public virtual null USERH:UserSpecifiedGroundSurfaceHeatTransferCoefficient { get; set; } = new null;
////}
////}
