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
                    return "Ceiling";
                case BHE.PanelType.Floor:
                    return "Floor";
                case BHE.PanelType.Wall:
                case BHE.PanelType.WallInternal:
                case BHE.PanelType.CurtainWall:
                    return "Wall";
                case BHE.PanelType.Roof:
                    return "Roof";
                default:
                    return "Wall";
            }
        }
    }
}
