using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class SurfaceConvectionAlgorithmOutside : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]

        public virtual string ClassName { get; set; } = "SurfaceConvectionAlgorithm:Outside";
        [Order][Description("SimpleCombined = Combined radiation and convection coefficient using simple ASHRAE model")]
        public virtual SurfaceConvectionAlgorithmOutsideMethod Algorithm { get; set; } = SurfaceConvectionAlgorithmOutsideMethod.DOE2;
    }
}
