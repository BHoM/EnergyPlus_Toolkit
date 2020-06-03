using BH.oM.Base;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class Version : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "Version";
        [Order]
        [Description("Version of EnergyPlus for which simulation is achievable")]
        public virtual string VersionIdentifier { get; set; } = "9.2.0";
    }
}
