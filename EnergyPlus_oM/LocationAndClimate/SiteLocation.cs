using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class SiteLocation : BHoMObject
    {
        [Description("No description available")]
        public virtual string SiteName { get; set; } = "";
        [Description("+ is North, - is South, degree minutes represented in decimal (i.e. 30 minutes is .5)")]
        public virtual double Latitude { get; set; } = 0.0;
        [Description("- is West, + is East, degree minutes represented in decimal (i.e. 30 minutes is .5)")]
        public virtual double Longitude { get; set; } = 0.0;
        [Description("basic these limits on the WorldTimeZone Map (2003)")]
        public virtual double TimeZone { get; set; } = 0.0;
        [Description("No description available")]
        public virtual double Elevation { get; set; } = 0.0;
    }
}
