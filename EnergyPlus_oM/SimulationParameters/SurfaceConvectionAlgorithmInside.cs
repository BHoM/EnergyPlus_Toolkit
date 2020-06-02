using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class SurfaceConvectionAlgorithmInside : BHoMObject
    {
        [Description("Simple = constant value natural convection (ASHRAE)")]
        public virtual SurfaceConvectionAlgorithmInsideMethod Algorithm { get; set; } = SurfaceConvectionAlgorithmInsideMethod.TARP;
    }
}
