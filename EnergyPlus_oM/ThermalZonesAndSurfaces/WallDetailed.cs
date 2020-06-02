////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Wall:Detailed : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("To be matched with a construction in this input file")]
////public virtual object-list ConstructionName { get; set; } = new object-list;
////[Description("Zone the surface is a part of")]
////public virtual object-list ZoneName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice OutsideBoundaryCondition { get; set; } = new choice;
////[Description("Non-blank only if the field Outside Boundary Condition is Surface,")]
////public virtual object-list OutsideBoundaryConditionObject { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice SunExposure { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice WindExposure { get; set; } = new choice;
////[Description("From the exterior of the surface")]
////public virtual real ViewFactorToGround { get; set; } = new real;
////[Description("shown with 10 vertex coordinates -- extensible object")]
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
////[Description("No description available")]
////public virtual real Vertex4X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex4Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex4Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex5X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex5Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex5Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex6X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex6Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex6Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex7X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex7Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex7Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex8X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex8Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex8Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex9X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex9Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex9Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex10X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex10Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex10Z-coordinate { get; set; } = new real;
////}
////}
