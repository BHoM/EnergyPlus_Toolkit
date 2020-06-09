using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class InternalMass : BHoMObject
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "InternalMass";
        [Order]
        [Description("No description available")]
        public override string Name { get; set; } = "";
        [Order]
        [Description("To be matched with a construction in this input file")]
        public virtual EnergyPlusConstruction ConstructionName { get; set; } = new EnergyPlusConstruction();
        [Order]
        [Description("Zone the surface is a part of")]
        public virtual ZoneList ZoneOrZoneListName { get; set; } = new ZoneList();
        [Order]
        [Description("No description available")]
        public virtual double SurfaceArea { get; set; } = 0.0;
}
}
