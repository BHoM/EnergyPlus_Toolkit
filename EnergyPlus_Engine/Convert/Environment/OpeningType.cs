using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BHE = BH.oM.Environment.Elements;

namespace BH.Engine.EnergyPlus
{
    public static partial class Convert
    {
        public static string ToEnergyPlus(this BHE.OpeningType type)
        {
            switch (type)
            {
                case BHE.OpeningType.CurtainWall:
                case BHE.OpeningType.Window:
                case BHE.OpeningType.WindowWithFrame:
                case BHE.OpeningType.Rooflight:
                case BHE.OpeningType.RooflightWithFrame:
                    return "Window";
                case BHE.OpeningType.Door:
                    return "Door";
                default:
                    return "Window";
            }
        }
    }
}
