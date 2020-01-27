using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BHE = BH.oM.Environment.Elements;
using BHM = BH.oM.Physical.Materials;
using BHP = BH.oM.Physical.Constructions;
using BH.oM.EnergyPlus.Settings;

using BH.Engine.Environment;

namespace BH.Engine.EnergyPlus
{
    public static partial class Convert
    {
        public static List<string> ToEnergyPlus(this BHP.Construction construction, EnergyPlusSettings settings)
        {
            List<string> constructionAsString = new List<string>();

            constructionAsString.Add("Construction,");
            constructionAsString.Add("\t" + construction.UniqueConstructionName().Replace(' ', '_') + ",\t!- Name");

            foreach (BHP.Layer l in construction.Layers)
                constructionAsString.Add("\t" + l.Name + ",\t!- Layer");

            constructionAsString[constructionAsString.Count - 1] = constructionAsString[constructionAsString.Count - 1].Replace(',', ';');
            constructionAsString.Add("");
            constructionAsString.Add("");

            return constructionAsString;
        }
    }
}
