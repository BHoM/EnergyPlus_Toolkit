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
        public static string ToEnergyPlusString(this ThermalZonesAndSurfaces thermalZonesAndSurfaces)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(thermalZonesAndSurfaces.GlobalGeometryRules);

            foreach (Zone zone in thermalZonesAndSurfaces.Zones)
            {
                sb.Append(zone.ToEnergyPlusString());
            }

            foreach (ZoneList zoneList in thermalZonesAndSurfaces.ZoneLists)
            {
                sb.Append(zoneList.ToEnergyPlusString());
            }

            foreach (BuildingSurfaceDetailed buildingSurfaceDetailed in thermalZonesAndSurfaces.BuildingSurfaces)
            {
                sb.Append(buildingSurfaceDetailed.ToEnergyPlusString());
            }

            foreach (FenestrationSurfaceDetailed fenestrationSurfaceDetailed in thermalZonesAndSurfaces.FenestrationSurfaces)
            {
                sb.Append(fenestrationSurfaceDetailed.ToEnergyPlusString());
            }

            foreach (ShadingBuildingDetailed shadingBuildingDetailed in thermalZonesAndSurfaces.ShadingSurfaces)
            {
                sb.Append(shadingBuildingDetailed.ToEnergyPlusString());
            }

            return sb.ToString();
        }
    }
}
