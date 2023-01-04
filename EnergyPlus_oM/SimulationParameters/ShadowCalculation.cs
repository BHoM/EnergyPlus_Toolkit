/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2023, the respective contributors. All rights reserved.
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
    public class ShadowCalculation : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]

        public virtual string ClassName { get; set; } = "ShadowCalculation";
        [Order]
        [Description("choose calculation method. note that TimestepFrequency is only needed for certain cases")]
        public virtual ShadowCalculationMethod CalculationMethod { get; set; } = ShadowCalculationMethod.AverageOverDaysInFrequency;
        [Order]
        [Description("Frequency at which calculation will be made. For AverageOverDaysInFrequency this rekates to number of days. For TimestepFrequency this relates to each discrete simulation timestep.")]
        public virtual int CalculationFrequency { get; set; } = 20;
        [Order]
        [Description("Number of allowable figures in shadow overlap calculations")]
        public virtual int MaximumFiguresInShadowOverlapCalculations { get; set; } = 15000;
        [Order]
        [Description("Advanced Feature. Internal default is SutherlandHodgman")]
        public virtual PolygonClippingAlgorithm PolygonClippingAlgorithm { get; set; } = PolygonClippingAlgorithm.SutherlandHodgman;
        [Order]
        [Description("Advanced Feature. Internal default is SimpleSkyDiffuseModeling")]
        public virtual SkyDiffuseModelingAlgorithm SkyDiffuseModelingAlgorithm { get; set; } = SkyDiffuseModelingAlgorithm.SimpleSkyDiffuseModeling;
        [Order]
        [Description("If ScheduledShading is chosen, the External Shading Fraction Schedule Name is required")]
        public virtual ExternalShadingCalculationMethod ExternalShadingCalculationMethod { get; set; } = ExternalShadingCalculationMethod.InternalCalculation;
        [Order]
        [Description("If True is chosen, the calculated external shading fraction results will be saved to an external CSV file with surface names as the column headers.")]
        public virtual bool OutputExternalShadingCalculationResults { get; set; } = false;
        [Order]
        [Description("If True, self-shading will be disabled from all exterior surfaces in a given Shading Zone Group to surfaces within")]
        public virtual bool DisableSelfShadingWithinShadingZoneGroups { get; set; } = false;
        [Order]
        [Description("If True, self-shading will be disabled from all exterior surfaces in a given Shading Zone Group to all other zones in the model.")]
        public virtual bool DisableSelfShadingFromShadingZoneGroupsToOtherZones { get; set; } = false;
        [Order]
        [Description("Specifies a group of zones which are controlled by the Disable Self-Shading fields.")]
        public virtual string ShadingZoneGroup1ZoneListName { get; set; } = "";
        [Order]
        [Description("Specifies a group of zones which are controlled by the Disable Self-Shading fields.")]
        public virtual string ShadingZoneGroup2ZoneListName { get; set; } = "";
        [Order]
        [Description("Specifies a group of zones which are controlled by the Disable Self-Shading fields.")]
        public virtual string ShadingZoneGroup3ZoneListName { get; set; } = "";
        [Order]
        [Description("Specifies a group of zones which are controlled by the Disable Self-Shading fields.")]
        public virtual string ShadingZoneGroup4ZoneListName { get; set; } = "";
        [Order]
        [Description("Specifies a group of zones which are controlled by the Disable Self-Shading fields.")]
        public virtual string ShadingZoneGroup5ZoneListName { get; set; } = "";
        [Order]
        [Description("Specifies a group of zones which are controlled by the Disable Self-Shading fields.")]
        public virtual string ShadingZoneGroup6ZoneListName { get; set; } = "";
    }
}



