using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class InternalMass : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "InternalMass";
        [Order]
        [Description("No description available")]
        public override string Name { get; set; } = "";
        [Order]
        [Description("To be matched with a construction in this input file")]
        public virtual string ConstructionName { get; set; } = "";
        [Order]
        [Description("Zone the surface is a part of")]
        public virtual List<string> ZoneOrZoneListName { get; set; } = new List<string>();
        [Order]
        [Description("No description available")]
        public virtual double SurfaceArea { get; set; } = 0.0;
}
}
