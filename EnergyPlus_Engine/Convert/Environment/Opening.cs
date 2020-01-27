using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BH.oM.EnergyPlus.Settings;
using BHE = BH.oM.Environment.Elements;
using BHP = BH.oM.Environment.Fragments;

using BH.Engine.Environment;
using BH.Engine.Geometry;

using BHG = BH.oM.Geometry;

namespace BH.Engine.EnergyPlus
{
    public static partial class Convert
    {
        public static List<string> ToEnergyPlus(this BHE.Opening opening, string hostPanelName, EnergyPlusSettings settings)
        {
            List<string> openingAsString = new List<string>();

            openingAsString.Add("FenestrationSurface:Detailed,");
            openingAsString.Add("\t" + opening.Name.Replace(' ', '_') + ",\t!- Name"); //Name
            openingAsString.Add("\t" + opening.Type.ToEnergyPlus() + ",\t!- Surface Type"); //PanelType
            openingAsString.Add("\t" + opening.OpeningConstruction.UniqueConstructionName().Replace(' ', '_') + ",\t!- Construction Name"); //Construction nam
            openingAsString.Add("\t" + hostPanelName + ",\t!- Surface Name");
            openingAsString.Add("\t,\t!- Outside boundary condition object"); //Outside boundary condition object
            openingAsString.Add("\tautocalculate,\t!- View Factor to Ground"); //View factor to ground
            openingAsString.Add("\t,\t!- Frame and Divider Name"); //Frame and Divider Name
            openingAsString.Add("\t1,\t!- Multiplier Name"); //Multiplier Name
            
            openingAsString.AddRange(opening.Polyline().ToEnergyPlus(settings.DecimalPlaces));

            openingAsString.Add("");
            openingAsString.Add("");

            return openingAsString;
        }
    }
}
