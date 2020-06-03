using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class GlobalGeometryRules : BHoMObject
    {
        [Description("Specified as entry for a 4 sided surface/rectangle")]
        public virtual StartingVertexPosition StartingVertexPosition { get; set; } = StartingVertexPosition.UpperLeftCorner;
        [Description("No description available")]
        public virtual VertexEntryDirection VertexEntryDirection { get; set; } = VertexEntryDirection.Counterclockwise;
        [Description("relative -- coordinates are entered relative to zone origin")]
        public virtual CoordinateSystem CoordinateSystem { get; set; } = CoordinateSystem.Relative;
        [Description("Relative -- coordinates are entered relative to zone origin")]
        public virtual CoordinateSystem DaylightingReferencePointCoordinateSystem { get; set; } = CoordinateSystem.Relative;
        [Description("Relative -- Starting corner is entered relative to zone origin")]
        public virtual CoordinateSystem RectangularSurfaceCoordinateSystem { get; set; } = CoordinateSystem.Relative;
    }
}
