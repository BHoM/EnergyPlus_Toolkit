using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenStudio;
using BHG = BH.oM.Geometry;
using BH.Engine.Geometry;

namespace BH.Engine.EnergyPlus
{
    public static partial class Convert
    {
        public static List<string> ToEnergyPlus(this BHG.Polyline pLine, int decimalPlaces = 6)
        {
            List<string> polylineAsString = new List<string>();

            polylineAsString.Add("\t" + (pLine.ControlPoints.Count - 1).ToString() + ",\t!- Number of Vertices");
            polylineAsString.AddRange(pLine.ControlPoints.Select(x => x.RoundPoint(decimalPlaces)).Distinct().ToList().ToEnergyPlus());

            return polylineAsString;
        }
    }
}
