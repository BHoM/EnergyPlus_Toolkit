using System;
using System.Collections.Generic;
using BH.oM.Base;

using System.ComponentModel;

namespace BH.oM.EnergyPlus.Settings
{
    public class EnergyPlusSettings : BHoMObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/


        [Description("How many decimal places any rounding function should use. Default to 6. E.g. a number such as 1.12345678 will be rounded to 1.123457 (rounded to 6 decimal places)")]
        public int DecimalPlaces { get; set; } = 6;

        /***************************************************/
    }
}
