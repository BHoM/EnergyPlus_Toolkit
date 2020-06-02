////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class BuildingSurface:Detailed : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual choice SurfaceType { get; set; } = new choice;
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
////[Description("shown with 120 vertex coordinates -- extensible object")]
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
////[Description("No description available")]
////public virtual real Vertex11X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex11Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex11Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex12X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex12Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex12Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex13X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex13Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex13Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex14X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex14Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex14Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex15X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex15Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex15Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex16X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex16Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex16Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex17X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex17Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex17Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex18X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex18Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex18Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex19X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex19Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex19Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex20X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex20Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex20Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex21X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex21Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex21Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex22X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex22Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex22Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex23X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex23Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex23Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex24X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex24Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex24Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex25X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex25Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex25Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex26X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex26Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex26Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex27X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex27Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex27Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex28X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex28Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex28Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex29X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex29Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex29Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex30X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex30Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex30Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex31X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex31Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex31Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex32X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex32Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex32Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex33X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex33Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex33Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex34X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex34Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex34Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex35X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex35Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex35Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex36X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex36Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex36Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex37X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex37Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex37Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex38X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex38Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex38Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex39X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex39Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex39Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex40X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex40Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex40Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex41X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex41Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex41Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex42X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex42Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex42Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex43X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex43Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex43Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex44X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex44Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex44Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex45X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex45Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex45Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex46X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex46Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex46Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex47X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex47Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex47Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex48X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex48Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex48Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex49X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex49Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex49Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex50X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex50Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex50Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex51X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex51Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex51Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex52X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex52Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex52Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex53X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex53Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex53Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex54X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex54Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex54Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex55X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex55Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex55Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex56X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex56Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex56Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex57X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex57Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex57Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex58X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex58Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex58Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex59X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex59Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex59Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex60X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex60Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex60Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex61X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex61Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex61Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex62X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex62Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex62Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex63X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex63Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex63Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex64X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex64Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex64Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex65X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex65Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex65Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex66X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex66Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex66Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex67X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex67Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex67Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex68X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex68Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex68Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex69X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex69Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex69Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex70X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex70Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex70Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex71X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex71Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex71Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex72X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex72Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex72Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex73X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex73Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex73Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex74X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex74Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex74Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex75X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex75Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex75Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex76X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex76Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex76Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex77X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex77Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex77Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex78X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex78Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex78Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex79X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex79Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex79Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex80X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex80Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex80Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex81X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex81Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex81Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex82X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex82Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex82Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex83X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex83Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex83Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex84X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex84Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex84Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex85X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex85Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex85Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex86X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex86Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex86Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex87X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex87Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex87Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex88X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex88Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex88Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex89X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex89Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex89Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex90X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex90Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex90Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex91X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex91Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex91Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex92X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex92Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex92Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex93X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex93Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex93Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex94X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex94Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex94Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex95X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex95Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex95Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex96X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex96Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex96Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex97X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex97Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex97Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex98X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex98Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex98Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex99X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex99Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex99Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex100X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex100Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex100Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex101X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex101Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex101Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex102X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex102Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex102Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex103X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex103Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex103Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex104X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex104Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex104Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex105X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex105Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex105Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex106X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex106Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex106Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex107X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex107Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex107Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex108X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex108Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex108Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex109X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex109Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex109Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex110X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex110Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex110Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex111X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex111Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex111Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex112X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex112Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex112Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex113X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex113Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex113Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex114X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex114Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex114Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex115X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex115Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex115Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex116X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex116Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex116Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex117X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex117Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex117Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex118X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex118Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex118Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex119X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex119Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex119Z-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex120X-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex120Y-coordinate { get; set; } = new real;
////[Description("No description available")]
////public virtual real Vertex120Z-coordinate { get; set; } = new real;
////}
////}
