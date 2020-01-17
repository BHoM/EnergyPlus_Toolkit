using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenStudio;
using BHG = BH.oM.Geometry;

namespace BH.Engine.EnergyPlus
{
    public static partial class Convert
    {
        public static List<string> ToEnergyPlus(this BHG.Point pnt, int decimalPlaces = 6)
        {
            List<string> pointAsString = new List<string>();

            pointAsString.Add(Math.Round(pnt.X, decimalPlaces).ToString() + ",");
            pointAsString.Add(Math.Round(pnt.Y, decimalPlaces).ToString() + ",");
            pointAsString.Add(Math.Round(pnt.Z, decimalPlaces).ToString() + ",");

            return pointAsString;
        }

        public static List<string> ToEnergyPlus(this List<BHG.Point> pnts, int decimalPlaces = 6)
        {
            List<string> pointsAsString = new List<string>();

            for(int x = 0; x < pnts.Count; x++)
                pointsAsString.AddRange(pnts[x].ToEnergyPlus(decimalPlaces));

            pointsAsString[pointsAsString.Count - 1] = pointsAsString[pointsAsString.Count - 1].Replace(',', ';');

            return pointsAsString;
        }
    }
}
