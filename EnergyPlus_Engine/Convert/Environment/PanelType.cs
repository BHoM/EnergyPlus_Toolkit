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
        public static string ToEnergyPlus(this BHE.PanelType type)
        {
            switch(type)
            {
                case BHE.PanelType.Ceiling:
                    return "CEILING";
                case BHE.PanelType.Floor:
                    return "FLOOR";
                case BHE.PanelType.Wall:
                case BHE.PanelType.WallInternal:
                case BHE.PanelType.CurtainWall:
                    return "WALL";
                case BHE.PanelType.Roof:
                    return "ROOF";
                default:
                    return "WALL";
            }
        }
    }
}
