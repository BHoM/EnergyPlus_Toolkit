////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Window:Interzone : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("To be matched with a construction in this input file")]
////public virtual object-list ConstructionName { get; set; } = new object-list;
////[Description("Name of Surface (Wall, usually) the Window is on (i.e., Base Surface)")]
////public virtual object-list BuildingSurfaceName { get; set; } = new object-list;
////[Description("Specify a surface name in an adjacent zone for known interior windows.")]
////public virtual object-list OutsideBoundaryConditionObject { get; set; } = new object-list;
////[Description("Used only for Surface Type = WINDOW, GLASSDOOR or DOOR")]
////public virtual null Multiplier { get; set; } = new null;
////[Description("Window starting coordinate is specified relative to the Base Surface origin.")]
////public virtual null StartingXCoordinate { get; set; } = new null;
////[Description("How far up the wall the Window starts. (in 2-d, this would be a Y Coordinate)")]
////public virtual null StartingZCoordinate { get; set; } = new null;
////[Description("No description available")]
////public virtual null Length { get; set; } = new null;
////[Description("No description available")]
////public virtual null Height { get; set; } = new null;
////}
////}