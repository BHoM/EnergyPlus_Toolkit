using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class InternalMass : BHoMObject
    {
        [Description("No description available")]
        public virtual string InternalMassName { get; set; } = "";
        [Description("To be matched with a construction in this input file")]
        public virtual string ConstructionName { get; set; } = "";
        [Description("Zone the surface is a part of")]
        public virtual string ZoneOrZoneListName { get; set; } = "";
        [Description("No description available")]
        public virtual double SurfaceArea { get; set; } = 0.0;
}
}
