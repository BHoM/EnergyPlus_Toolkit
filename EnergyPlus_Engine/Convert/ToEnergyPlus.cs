/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2020, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *
 *
 * The BHoM is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation, either version 3.0 of the License, or
 * (at your option) any later version.
 *
 * The BHoM is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.
 */

using BH.Engine.Geometry;
using BH.Engine.Environment;
using BH.oM.Adapters.EnergyPlus;
using BH.oM.Environment.MaterialFragments;
using BH.oM.Geometry;
using BH.oM.Physical.Constructions;
using BH.oM.Physical.Materials;
using BH.oM.Reflection.Attributes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using BHE = BH.oM.Environment.Elements;

using BHM = BH.oM.Environment.MaterialFragments;
using BHP = BH.oM.Physical.Constructions;

namespace BH.Engine.Adapters.EnergyPlus
{
    public static partial class Convert
    {
        [Description("Convert a boolean to an EnergyPlus friendly Yes or No")]
        [Input("value", "A True or False value")]
        [Output("answer", "A Yes or a No")]
        public static string ToEnergyPlus(this bool value)
        {
            return value ? "Yes" : "No";
        }

        [Description("Convert a BHoM Roughness to an EnergyPlus Roughness")]
        [Input("roughness", "BHoM roughness")]
        [Output("roughness", "EnergyPlus Roughness")]
        public static BH.oM.Adapters.EnergyPlus.Roughness ToEnergyPlus(this BHM.Roughness roughness)
        {
            switch (roughness)
            {
                case BHM.Roughness.VerySmooth:
                    return BH.oM.Adapters.EnergyPlus.Roughness.VerySmooth;
                case BHM.Roughness.Smooth:
                    return BH.oM.Adapters.EnergyPlus.Roughness.Smooth;
                case BHM.Roughness.MediumSmooth:
                    return BH.oM.Adapters.EnergyPlus.Roughness.MediumSmooth;
                case BHM.Roughness.MediumRough:
                    return BH.oM.Adapters.EnergyPlus.Roughness.MediumRough;
                case BHM.Roughness.Rough:
                    return BH.oM.Adapters.EnergyPlus.Roughness.Rough;
                case BHM.Roughness.VeryRough:
                    return BH.oM.Adapters.EnergyPlus.Roughness.VeryRough;
                case BHM.Roughness.Undefined:
                    return BH.oM.Adapters.EnergyPlus.Roughness.MediumRough;
                default:
                    return BH.oM.Adapters.EnergyPlus.Roughness.MediumRough;
            }
        }

        [Description("Convert a BHoM GasType to an EnergyPlus GasType")]
        [Input("gasType", "BHoM gas type")]
        [Output("gasType", "EnergyPlus gas type")]
        public static GasType ToEnergyPlus(this BHM.Gas gasType)
        {
            switch (gasType)
            {
                case BHM.Gas.Air:
                    return GasType.Air;
                case BHM.Gas.Argon:
                    return GasType.Argon;
                case BHM.Gas.Krypton:
                    return GasType.Krypton;
                case BHM.Gas.Xenon:
                    return GasType.Xenon;
                case BHM.Gas.Undefined:
                    return GasType.Air;
                default:
                    return GasType.Air;
            }
        }

        [Description("Convert a BHoM OpeningType to an EnergyPlus OpeningType")]
        [Input("type", "BHoM opening type")]
        [Output("type", "EnergyPlus opening type")]
        public static FenestrationSurfaceType ToEnergyPlus(this BHE.OpeningType type)
        {
            switch (type)
            {
                case BHE.OpeningType.Window:
                    return FenestrationSurfaceType.Window;
                case BHE.OpeningType.WindowWithFrame:
                    return FenestrationSurfaceType.Window;
                case BHE.OpeningType.Rooflight:
                    return FenestrationSurfaceType.Window;
                case BHE.OpeningType.RooflightWithFrame:
                    return FenestrationSurfaceType.Window;
                case BHE.OpeningType.Door:
                    return FenestrationSurfaceType.Door;
                case BHE.OpeningType.Undefined:
                    return FenestrationSurfaceType.Window;
                default:
                    return FenestrationSurfaceType.Window;
            }
        }

        [Description("Convert a BHoM PanelType to an EnergyPlus BuildingSurfaceType")]
        [Input("type", "BHoM panel type")]
        [Output("type", "EnergyPlus BuildingSurfaceType")]
        public static BuildingSurfaceType ToEnergyPlus(this BHE.PanelType type)
        {
            switch (type)
            {
                case BHE.PanelType.Ceiling:
                    return BuildingSurfaceType.Ceiling;
                case BHE.PanelType.Floor:
                    return BuildingSurfaceType.Floor;
                case BHE.PanelType.Wall:
                    return BuildingSurfaceType.Wall;
                case BHE.PanelType.WallInternal:
                    return BuildingSurfaceType.Wall;
                case BHE.PanelType.CurtainWall:
                    return BuildingSurfaceType.Wall;
                case BHE.PanelType.Roof:
                    return BuildingSurfaceType.Roof;
                case BHE.PanelType.Undefined:
                    return BuildingSurfaceType.Wall;
                default:
                    return BuildingSurfaceType.Wall;
            }
        }

        [Description("Convert a BHoM SolidMaterial into an EPMaterial object")]
        [Input("solidMaterial", "A BHoM SolidMaterial object")]
        [Input("thickness", "Thickness of material")]
        [Output("energyPlusMaterial", "An EnergyPlus EPMaterial")]
        public static IEnergyPlusMaterial ToEnergyPlus(this SolidMaterial solidMaterial, double thickness)
        {
            Material bhomMaterial = new Material();
            bhomMaterial.Properties.Add(solidMaterial);

            string materialName = solidMaterial.Name == "" ? solidMaterial.BHoM_Guid.ToString() : solidMaterial.Name;

            if (BH.Engine.Environment.Query.IsTransparent(bhomMaterial))
            {
                EPMaterialWindowGlazing eplusMaterial = new EPMaterialWindowGlazing();
                eplusMaterial.Name = materialName;
                eplusMaterial.OpticalDataType = OpticalDataType.SpectralAverage;
                eplusMaterial.Thickness = thickness;
                eplusMaterial.SolarTransmittanceAtNormalIncidence = solidMaterial.SolarTransmittance;
                eplusMaterial.FrontSideSolarReflectanceAtNormalIncidence = solidMaterial.SolarReflectanceExternal;
                eplusMaterial.BackSideSolarReflectanceAtNormalIncidence = solidMaterial.SolarReflectanceInternal;
                eplusMaterial.VisibleTransmittanceAtNormalIncidence = solidMaterial.LightTransmittance;
                eplusMaterial.FrontSideVisibleReflectanceAtNormalIncidence = solidMaterial.LightReflectanceExternal;
                eplusMaterial.BackSideVisibleReflectanceAtNormalIncidence = solidMaterial.LightReflectanceInternal;
                eplusMaterial.FrontSideInfraredHemisphericalEmissivity = solidMaterial.EmissivityExternal;
                eplusMaterial.BackSideInfraredHemisphericalEmissivity = solidMaterial.EmissivityInternal;
                eplusMaterial.Conductivity = solidMaterial.Conductivity;
                return eplusMaterial;
            }
            else
            {
                EPMaterial eplusMaterial = new EPMaterial();
                eplusMaterial.Name = materialName;
                eplusMaterial.Roughness = solidMaterial.Roughness.ToEnergyPlus();
                eplusMaterial.Thickness = thickness;
                eplusMaterial.Conductivity = solidMaterial.Conductivity;
                eplusMaterial.Density = solidMaterial.Density;
                eplusMaterial.SpecificHeat = solidMaterial.SpecificHeat;
                eplusMaterial.ThermalAbsorptance = solidMaterial.EmissivityExternal;
                eplusMaterial.SolarAbsorptance = 1 - solidMaterial.SolarReflectanceExternal;
                eplusMaterial.VisibleAbsorptance = 1 - solidMaterial.LightReflectanceExternal;
                return eplusMaterial;
            }
        }

        [Description("Convert a BHoM GasMaterial into an EnergyPlus EnergyPlusWindowMaterialGas object")]
        [Input("gasMaterial", "A BHoM GasMaterial object")]
        [Input("thickness", "Thickness of material")]
        [Output("energyPlusWindowMaterialGas", "EnergyPlus EnergyPlusWindowMaterialGas")]
        public static EPMaterialWindowGas ToEnergyPlus(this GasMaterial gasMaterial, double thickness)
        {
            Material bhomMaterial = new Material();
            bhomMaterial.Properties.Add(gasMaterial);

            string materialName = gasMaterial.Name == "" ? gasMaterial.BHoM_Guid.ToString() : gasMaterial.Name;

            EPMaterialWindowGas eplusMaterial = new EPMaterialWindowGas();
            eplusMaterial.Name = materialName;
            eplusMaterial.GasType = gasMaterial.Gas.ToEnergyPlus();
            eplusMaterial.Thickness = thickness;
            return eplusMaterial;
        }

        [Description("Convert a BHoM Material into an EnergyPlus Material object")]
        [Input("material", "A BHoM Material object")]
        [Input("thickness", "Thickness of material")]
        [Output("iEnergyPlusClass", "EnergyPlus Material or Gas Material object")]
        public static IEnergyPlusMaterial ToEnergyPlus(this Material material, double thickness)
        {
            if (material.Properties[0].GetType() == typeof(SolidMaterial))
                return ((SolidMaterial)material.Properties[0]).ToEnergyPlus(thickness);
            else if (material.Properties[0].GetType() == typeof(GasMaterial))
                return ((GasMaterial)material.Properties[0]).ToEnergyPlus(thickness);
            else
                return null;
        }

        [Description("Convert a BHoM Layer into an EnergyPlus IEnergyPlusClass object")]
        [Input("layer", "A BHoM Layer object")]
        [Output("iEnergyPlusClass", "EnergyPlus IEnergyPlusClass object")]
        public static IEnergyPlusMaterial ToEnergyPlus(this BHP.Layer layer)
        {
            return layer.Material.ToEnergyPlus(layer.Thickness);
        }

        [Description("Convert a BHoM Construction into a set of EnergyPlus IEnergyPlusClass objects describing construction and materials")]
        [Input("construction", "A BHoM Construction object")]
        [Output("energyPlusClasses", "A list of EnergyPlus objects")]
        public static EPConstruction ToEnergyPlus(this IConstruction construction)
        {
            EPConstruction eplusConstruction = new EPConstruction() { 
                Name = construction.Name == "" ? construction.BHoM_Guid.ToString() : construction.Name
            };

            foreach (Layer layer in ((Construction)construction).Layers)
            {
                IEnergyPlusMaterial cls = layer.ToEnergyPlus();
                eplusConstruction.Layers.Add(cls);
            }

            return eplusConstruction;
        }

        [Description("Convert a BHoM Building to an EnergyPlus Building")]
        [Input("building", "BHoM building")]
        [Output("building", "EnergyPlus building")]
        public static Building ToEnergyPlus(this BHE.Building building)
        {
            Building eplusBdg = new Building
            {
                Name = building.Name == "" ? building.BHoM_Guid.ToString() : building.Name
            };

            return eplusBdg;
        }

        [Description("Convert a BHoM Opening into a set of EnergyPlus IEnergyPlusClass objects describing surfaces, materials and constructions")]
        [Input("opening", "A BHoM Environments Opening object, with assigned construction")]
        [Input("hostName", "Hosting BHoM Environments panel name")]
        [Output("energyPlusClasses", "A list of EnergyPlus IEnergyPlusClass objects")]
        public static FenestrationSurfaceDetailed ToEnergyPlus(this BHE.Opening opening, string parentSurfaceName)
        {
            List<Point> vertices = BH.Engine.Environment.Query.Polyline(opening).ControlPoints();
            vertices.RemoveAt(vertices.Count - 1);
            vertices.Reverse();

            FenestrationSurfaceDetailed fenestrationSurfaceDetailed = new FenestrationSurfaceDetailed
            {
                Name = opening.Name == "" ? opening.BHoM_Guid.ToString() : opening.Name,
                SurfaceType = opening.Type.ToEnergyPlus(),
                Construction = ((Construction)opening.OpeningConstruction).ToEnergyPlus(),
                ParentSurface = parentSurfaceName,
                Vertices = vertices,
                NumberOfVertices = vertices.Count
            };

            return fenestrationSurfaceDetailed;
        }

        [Description("Convert a BHoM Panel into a set of EnergyPlus IEnergyPlusClass objects describing surfaces, materials and constructions")]
        [Input("panel", "A BHoM Environments Panel object, with assigned construction")]
        [Output("energyPlusClasses", "A list of EnergyPlus objects")]
        public static List<IEnergyPlusClass> ToEnergyPlus(this BHE.Panel panel)
        {
            List<IEnergyPlusClass> classes = new List<IEnergyPlusClass>();

            List<Point> vertices = BH.Engine.Environment.Query.Polyline(panel).ControlPoints();
            vertices.RemoveAt(vertices.Count - 1);
            int vertexCount = vertices.Count;
            string panelName = panel.Name == "" ? panel.BHoM_Guid.ToString() : panel.Name;

            if (panel.Type == BHE.PanelType.Shade)
            {
                ShadingBuildingDetailed shadingSurface = new ShadingBuildingDetailed
                {
                    Name = panelName,
                    Vertices = vertices,
                    NumberOfVertices = vertexCount
                };
                classes.Add(shadingSurface);
            }
            else
            {
                if (panel.Construction == null)
                {
                    panel = panel.AssignGenericConstructions(assignOpenings: true);
                }

                BuildingSurfaceDetailed buildingSurface = new BuildingSurfaceDetailed() {
                    Name = panelName,
                    SurfaceType = panel.Type.ToEnergyPlus(),
                    Construction = panel.Construction.ToEnergyPlus(),
                    Zone = new Zone() { Name = panel.ConnectedSpaces[0] },
                    OutsideBoundaryCondition = panel.BoundaryCondition(),
                    OutsideBoundaryConditionObject = panel.BoundaryCondition() == OutsideBoundaryCondition.Zone ? panel.ConnectedSpaces[-1] : "",
                    SunExposure = panel.SunWindExposure() ? "SunExposed" : "NoSun",
                    WindExposure = panel.SunWindExposure() ? "WindExposed" : "NoWind",
                    Vertices = vertices,
                    NumberOfVertices = vertexCount,
                };
                classes.Add(buildingSurface);

                foreach (BHE.Opening opening in panel.Openings)
                {
                    classes.Add(opening.ToEnergyPlus(panel.Name));
                }
            }

            return classes;
        }

        [Description("Convert a BHoM Profile to an EnergyPlus Schedule")]
        [Input("profile", "BHoM Profile")]
        [Input("scheduleTypeLimitsNumericType", "EnergyPlus ScheduleTypeLimitsNumericType")]
        [Input("scheduleTypeLimitsUnitType", "EnergyPlus ScheduleTypeLimitsUnitType")]
        [Output("schedule", "EnergyPlus Schedule")]
        public static List<IEnergyPlusClass> ToEnergyPlus(this BH.oM.Environment.SpaceCriteria.Profile profile, ScheduleTypeLimitsNumericType scheduleTypeLimitsNumericType, ScheduleTypeLimitsUnitType scheduleTypeLimitsUnitType)
        {
            ScheduleTypeLimits scheduleTypeLimits = new ScheduleTypeLimits
            {
                Name = string.Format("{0} TypeLimits", profile.Name).Trim(),
                NumericType = scheduleTypeLimitsNumericType,
                UnitType = scheduleTypeLimitsUnitType
            };
            scheduleTypeLimits.NumericType = scheduleTypeLimitsNumericType;
            scheduleTypeLimits.LowerLimitValue = profile.HourlyValues.Min();
            scheduleTypeLimits.UpperLimitValue = profile.HourlyValues.Max();

            ScheduleDayHourly scheduleDayHourly = new ScheduleDayHourly
            {
                Name = string.Format("{0} Daily", profile.Name).Trim(),
                ScheduleTypeLimitsName = scheduleTypeLimits.Name
            };
            for (int i = 0; i < 24; i++)
            {
                PropertyInfo propertyInfo = scheduleDayHourly.GetType().GetProperty(string.Format("Hour{0}", i + 1));
                propertyInfo.SetValue(scheduleDayHourly, profile.HourlyValues[i]);
            }

            ScheduleWeekDaily scheduleWeekDaily = new ScheduleWeekDaily
            {
                Name = string.Format("{0} Weekly", profile.Name).Trim(),
                SundayScheduleDayName = scheduleDayHourly.Name,
                MondayScheduleDayName = scheduleDayHourly.Name,
                TuesdayScheduleDayName = scheduleDayHourly.Name,
                WednesdayScheduleDayName = scheduleDayHourly.Name,
                ThursdayScheduleDayName = scheduleDayHourly.Name,
                FridayScheduleDayName = scheduleDayHourly.Name,
                SaturdayScheduleDayName = scheduleDayHourly.Name,
                HolidayScheduleDayName = scheduleDayHourly.Name,
                SummerDesignDayScheduleDayName = scheduleDayHourly.Name,
                WinterDesignDayScheduleDayName = scheduleDayHourly.Name,
                CustomDay1ScheduleDayName = scheduleDayHourly.Name,
                CustomDay2ScheduleDayName = scheduleDayHourly.Name
            };

            return new List<IEnergyPlusClass>() { scheduleTypeLimits, scheduleDayHourly, scheduleWeekDaily };
        }
    }
}