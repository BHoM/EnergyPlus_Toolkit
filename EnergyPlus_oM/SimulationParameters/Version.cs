using BH.oM.Base;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class Version : BHoMObject
    {
        [Description("Version of EnergyPlus for which simulation is achievable")]
        public virtual string VersionIdentifier { get; set; } = "9.2.0";
    }
}
