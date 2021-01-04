/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2021, the respective contributors. All rights reserved.
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

using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.Adapters.EnergyPlus
{
    public class People : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "People";
        [Order]
        [Description("Name of the gain")]
        public override string Name { get; set; } = "";
        [Order]
        [Description("List of zones in which gain is present")]
        public virtual ZoneList ZoneOrZoneListName { get; set; } = new ZoneList();
        [Order]
        [Description("The fractional schedule (0.0 - 1.0) applied to number of people in the zone/s specified")]
        public virtual string NumberOfPeopleScheduleName { get; set; } = "";
        [Order]
        [Description("The calculation method is used to create the maximum number of people")]
        public virtual PeopleDesignLevelCalculationMethod NumberOfPeopleCalculationMethod { get; set; } = PeopleDesignLevelCalculationMethod.Undefined;
        [Order]
        [Description("Number of people in zone")]
        public virtual double NumberOfPeople { get; set; } = 0.0;
        [Order]
        [Description("Number of people in zone per floor area")]
        public virtual double PeoplePerZoneFloorArea { get; set; } = 0.0;
        [Order]
        [Description("Floor area per person in zone")]
        public virtual double ZoneFloorAreaPerPerson { get; set; } = 0.0;
        [Order]
        [Description("The radiant fraction of the sensible heat released by people in a zone (0-1)")]
        public virtual double FractionRadiant { get; set; } = 0.0;
        [Order]
        [Description("The fraction of the sensible heat released by people in a zone (0-1)")]
        public virtual double SensibleHeatFraction { get; set; } = 0.0;
        [Order]
        [Description("The activity level schedule applied to heat output of each person in zone. this would, by default, be constant at 1 for typical heat gain per person.")]
        public virtual string ActivityLevelScheduleName { get; set; } = "";
        [Order]
        [Description("CO2 generation rate per unit of activity level.")]
        public virtual double CarbonDioxideGenerationRate { get; set; } = 0.0;
        [Order]
        [Description("Flag to raise comfort warnings during simulation")]
        public virtual bool EnableASHRAE55ComfortWarnings { get; set; } = false;
        [Order]
        [Description("Optional - (only required for thermal comfort runs)")]
        public virtual MeanRadiantTemperatureCalculationType MeanRadiantTemperatureCalculationType { get; set; } = MeanRadiantTemperatureCalculationType.Undefined;
        [Order]
        [Description("Optional - (only required for runs of thermal comfort models: Fanger, Pierce and KSU)")]
        public virtual string SurfaceNameAngleFactorListName { get; set; } = "";
        [Order]
        [Description("Units in schedule are 0.0 to 1.0")]
        public virtual string WorkEfficiencyScheduleName { get; set; } = "";
        [Order]
        [Description("Method used to calculate clothing insulation level")]
        public virtual ClothingInsulationCalculationMethod ClothingInsulationCalculationMethod { get; set; } = ClothingInsulationCalculationMethod.Undefined;
        [Order]
        [Description("Time varying schedule applied to clothing insulation level")]
        public virtual string ClothingInsulationCalculationMethodScheduleName { get; set; } = "";
        [Order]
        [Description("Use \"Clo\" from ASHRAE or Thermal Comfort guides")]
        public virtual string ClothingInsulationScheduleName { get; set; } = "";
        [Order]
        [Description("Time varying schedule applied to clothing insulation level for comfort calculation")]
        public virtual string AirVelocityScheduleName { get; set; } = "";
        [Order]
        [Description("Optional  - (only needed for people thermal comfort results reporting)")]
        public virtual ThermalComfortModelType ThermalComfortModel1Type { get; set; } = ThermalComfortModelType.Undefined;
        [Order]
        [Description("Optional - (second type of thermal comfort model and results reporting)")]
        public virtual ThermalComfortModelType ThermalComfortModel2Type { get; set; } = ThermalComfortModelType.Undefined;
        [Order]
        [Description("Optional - (third thermal comfort model and report type)")]
        public virtual ThermalComfortModelType ThermalComfortModel3Type { get; set; } = ThermalComfortModelType.Undefined;
        [Order]
        [Description("Optional - (fourth thermal comfort model and report type)")]
        public virtual ThermalComfortModelType ThermalComfortModel4Type { get; set; } = ThermalComfortModelType.Undefined;
        [Order]
        [Description("Optional - (fifth thermal comfort model and report type)")]
        public virtual ThermalComfortModelType ThermalComfortModel5Type { get; set; } = ThermalComfortModelType.Undefined;
    }
}

