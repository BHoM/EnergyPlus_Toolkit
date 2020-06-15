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
        public static string ToEnergyPlusString(this SimulationParameters simulationParameters)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(simulationParameters.Version.ToEnergyPlusString());
            sb.Append(simulationParameters.SimulationControl.ToEnergyPlusString());
            sb.Append(simulationParameters.Building.ToEnergyPlusString());
            sb.Append(simulationParameters.ShadowCalculation.ToEnergyPlusString());
            sb.Append(simulationParameters.SurfaceConvectionAlgorithmInside.ToEnergyPlusString());
            sb.Append(simulationParameters.SurfaceConvectionAlgorithmOutside.ToEnergyPlusString());
            sb.Append(simulationParameters.HeatBalanceAlgorithm.ToEnergyPlusString());
            sb.Append(simulationParameters.HeatBalanceSettingsConductionFiniteDifference.ToEnergyPlusString());
            sb.Append(simulationParameters.ZoneAirHeatBalanceAlgorithm.ToEnergyPlusString());
            sb.Append(simulationParameters.Timestep.ToEnergyPlusString());

            return sb.ToString();
        }
    }
}
