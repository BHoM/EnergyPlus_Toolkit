
using BH.oM.Base;

namespace BH.oM.EnergyPlus
{
    public interface IEnergyPlusClass : IBHoMObject
    {
        string ClassName { get; set; }
    }
}