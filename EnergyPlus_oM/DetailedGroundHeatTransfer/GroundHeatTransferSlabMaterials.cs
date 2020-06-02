////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class GroundHeatTransfer:Slab:Materials : BHoMObject
////{
////[Description("This field specifies the number of different materials that will be used in the model.")]
////public virtual null NMAT:NumberOfMaterials { get; set; } = new null;
////[Description("Two fields specify the albedo value of the surface: first for no snow coverage days;")]
////public virtual null ALBEDO:SurfaceAlbedo:NoSnow { get; set; } = new null;
////[Description("No description available")]
////public virtual null ALBEDO:SurfaceAlbedo:Snow { get; set; } = new null;
////[Description("EPSLW (No Snow and Snow) specifies the long wavelength (thermal) emissivity of the ground surface.")]
////public virtual null EPSLW:SurfaceEmissivity:NoSnow { get; set; } = new null;
////[Description("No description available")]
////public virtual null EPSLW:SurfaceEmissivity:Snow { get; set; } = new null;
////[Description("fields Z0 (No Snow and Snow) describe the height at which an experimentally velocity profile goes to zero.")]
////public virtual null Z0:SurfaceRoughness:NoSnow { get; set; } = new null;
////[Description("typical value= .05 cm")]
////public virtual null Z0:SurfaceRoughness:Snow { get; set; } = new null;
////[Description("These fields specify the combined convective and radiative heat transfer coefficient between")]
////public virtual null HIN:IndoorHConv:DownwardFlow { get; set; } = new null;
////[Description("typical value= 4-10")]
////public virtual null HIN:IndoorHConv:Upward { get; set; } = new null;
////}
////}
