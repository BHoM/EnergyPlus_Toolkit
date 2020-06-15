using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using BH.Engine.Reflection;
using BH.oM.Reflection;
using BH.oM.EnergyPlus;

namespace BH.Engine.EnergyPlus
{
    public static partial class Convert
    {
        public static string ToEnergyPlusString(this LocationAndClimate locationAndClimate)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(locationAndClimate.SiteLocation.ToEnergyPlusString());
            sb.Append(locationAndClimate.RunPeriod.ToEnergyPlusString());
            sb.Append(locationAndClimate.SiteGroundTemperatureBuildingSurface.ToEnergyPlusString());
            sb.Append(locationAndClimate.SiteGroundTemperatureShallow.ToEnergyPlusString());
            sb.Append(locationAndClimate.SiteGroundTemperatureDeep.ToEnergyPlusString());

            return sb.ToString();
        }
    }
}
