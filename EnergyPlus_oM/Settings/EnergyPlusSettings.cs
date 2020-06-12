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

using System;
using System.Collections.Generic;
using BH.oM.Base;

using System.ComponentModel;

namespace BH.oM.EnergyPlus.Settings
{
    public class EnergyPlusSettings : BHoMObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [Description("How many decimal places any rounding function should use. Default to 6. E.g. a number such as 1.12345678 will be rounded to 1.123457 (rounded to 6 decimal places)")]
        public virtual int DecimalPlaces { get; set; } = 6;
        
        // Building
        public virtual double NorthAngle { get; set; } = 0;
        public virtual Terrain Terrain { get; set; } = Terrain.Country;
        public virtual double LoadsConvergenceToleranceValue { get; set; } = 0.04;
        public virtual double TemperatureConvergenceToleranceValue { get; set; } = 0.4;
        public virtual SolarDistribution SolarDistribution { get; set; } = SolarDistribution.FullInteriorAndExteriorWithReflections;
        public virtual int MaximumWarmupDays { get; set; } = 25;
        public virtual int MinimumWarmupDays { get; set; } = 6;

        // Timestep
        public virtual int SimulationTimestep { get; set; } = 6;

        // SimulationControl
        public virtual bool DoZoneSizingCalculation { get; set; } = false;
        public virtual bool DoSystemSizingCalculation { get; set; } = false;
        public virtual bool DoPlantSizingCalculation { get; set; } = false;
        public virtual bool RunSimulationForSizingPeriods { get; set; } = false;
        public virtual bool RunSimulationForWeatherFileRunPeriods { get; set; } = true;

        // ShadowCalculation
        // GroundTemperature object insert here
        public static ShadowCalculation ShadowCalculation = { get; set; } = ShadowCalculation();

        // GroundTemperature
        // GroundTemperature object insert here

        /***************************************************/
    }
}
