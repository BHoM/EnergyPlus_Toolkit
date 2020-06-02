using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class SurfaceConvectionAlgorithmOutside : BHoMObject
    {
        [Description("SimpleCombined = Combined radiation and convection coefficient using simple ASHRAE model")]
        public virtual SurfaceConvectionAlgorithmOutsideMethod Algorithm { get; set; } = SurfaceConvectionAlgorithmOutsideMethod.DOE2;
    }
}
