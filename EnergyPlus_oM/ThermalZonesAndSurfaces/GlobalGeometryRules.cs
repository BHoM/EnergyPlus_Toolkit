using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class GlobalGeometryRules : BHoMObject
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "GlobalGeometryRules";
        [Order]
        [Description("Specified as entry for a 4 sided surface/rectangle")]
        public virtual StartingVertexPosition StartingVertexPosition { get; set; } = StartingVertexPosition.UpperLeftCorner;
        [Order]
        [Description("No description available")]
        public virtual VertexEntryDirection VertexEntryDirection { get; set; } = VertexEntryDirection.Counterclockwise;
        [Order]
        [Description("relative -- coordinates are entered relative to zone origin")]
        public virtual CoordinateSystem CoordinateSystem { get; set; } = CoordinateSystem.Relative;
        [Order]
        [Description("Relative -- coordinates are entered relative to zone origin")]
        public virtual CoordinateSystem DaylightingReferencePointCoordinateSystem { get; set; } = CoordinateSystem.Relative;
        [Order]
        [Description("Relative -- Starting corner is entered relative to zone origin")]
        public virtual CoordinateSystem RectangularSurfaceCoordinateSystem { get; set; } = CoordinateSystem.Relative;
    }
}
