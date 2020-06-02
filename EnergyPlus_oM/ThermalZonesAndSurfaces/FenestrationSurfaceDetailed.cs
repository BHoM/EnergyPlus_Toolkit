////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class FenestrationSurface:Detailed : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual choice SurfaceType { get; set; } = new choice;
////[Description("To be matched with a construction in this input file")]
////public virtual object-list ConstructionName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list BuildingSurfaceName { get; set; } = new object-list;
////[Description("Non-blank only if base surface field Outside Boundary Condition is")]
////public virtual object-list OutsideBoundaryConditionObject { get; set; } = new object-list;
////[Description("From the exterior of the surface")]
////public virtual real ViewFactorToGround { get; set; } = new real;
////[Description("Enter the name of a WindowProperty:FrameAndDivider object")]
////public virtual object-list FrameAndDividerName { get; set; } = new object-list;
////[Description("Used only for Surface Type = WINDOW, GLASSDOOR or DOOR")]
////public virtual null Multiplier { get; set; } = new null;
////[Description("vertices are given in GlobalGeometryRules coordinates -- if relative, all surface coordinates")]
////public virtual null NumberOfVertices { get; set; } = new null;
////[Description("No description available")]
////public virtual real Vertex1X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex1Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex1Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex2X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex2Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex2Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex3X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex3Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex3Z-coordinate { get; set; } = new real;
////[Description("Not used for triangles")]
////public virtual real Vertex4X-coordinate { get; set; } = new real;
////[Description("Not used for triangles")]
////public virtual real Vertex4Y-coordinate { get; set; } = new real;
////[Description("Not used for triangles")]
////public virtual real Vertex4Z-coordinate { get; set; } = new real;
////}
////}
