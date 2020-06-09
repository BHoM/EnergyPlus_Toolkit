using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class SurfaceConvectionAlgorithmInside : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]

        public virtual string ClassName { get; set; } = "SurfaceConvectionAlgorithm:Inside";
        [Order]
        [Description("Simple = constant value natural convection (ASHRAE)")]
        public virtual SurfaceConvectionAlgorithmInsideMethod Algorithm { get; set; } = SurfaceConvectionAlgorithmInsideMethod.TARP;
    }
}
