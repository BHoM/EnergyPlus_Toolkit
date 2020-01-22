using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BHE = BH.oM.Environment.Elements;
using BH.oM.EnergyPlus.Settings;

namespace BH.Engine.EnergyPlus
{
    public static partial class Convert
    {
        public static List<string> ToEnergyPlus(this BHE.Building building, EnergyPlusSettings settings)
        {
            List<string> buildingAsString = new List<string>();

            buildingAsString.Add("Building,");
            buildingAsString.Add("\t" + building.Name.Replace(' ', '_') + ",\t!- Name");
            buildingAsString.Add("\t0.0,\t!- North Axis {deg}");
            buildingAsString.Add("\tCity,\t!- Terrain");
            buildingAsString.Add("\t,\t!- Loads Convergency Tolerance Value");
            buildingAsString.Add("\t,\t!- Temperature Convergence Tolerance Value {deltaC}");
            buildingAsString.Add("\tFullInteriorAndExteriorWithReflections,\t!- Solar Distribution or maybe FullExterior");
            buildingAsString.Add("\t,\t!- Maximum Number of Warmup Days");
            buildingAsString.Add("\t;\t!- Minimum Number of Warmup Days");
            buildingAsString.Add("");
            buildingAsString.Add("");

            return buildingAsString;
        }
    }
}
