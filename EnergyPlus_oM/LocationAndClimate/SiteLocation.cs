using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class SiteLocation : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "Site:Location";
        [Order]
        [Description("No description available")]
        public override string Name { get; set; } = "DefaultLocation";
        [Order]
        [Description("+ is North, - is South, degree minutes represented in decimal (i.e. 30 minutes is .5)")]
        public virtual double Latitude { get; set; } = 0.0;
        [Order]
        [Description("- is West, + is East, degree minutes represented in decimal (i.e. 30 minutes is .5)")]
        public virtual double Longitude { get; set; } = 0.0;
        [Order]
        [Description("basic these limits on the WorldTimeZone Map (2003)")]
        public virtual double TimeZone { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double Elevation { get; set; } = 0.0;
    }
}
