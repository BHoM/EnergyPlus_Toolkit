/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2024, the respective contributors. All rights reserved.
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

using BH.oM.Adapters.EnergyPlus;
using BH.oM.Base.Attributes;
using System.ComponentModel;
using BHE = BH.oM.Environment.Elements;

namespace BH.Engine.Adapters.EnergyPlus
{
    public static partial class Query
    {
        [Description("Query the EnergyPlus equivalent OutsideBoundaryCondition for a BHoM panel object")]
        [Input("panel", "A BHoM Environments panel object")]
        [Output("outsideBoundaryCondition", "An EnergyPlus OutsideBoundaryCondition")]
        public static OutsideBoundaryCondition BoundaryCondition(this BHE.Panel panel)
        {
            if ((panel.Type == BHE.PanelType.Roof) || (panel.Type == BHE.PanelType.WallExternal) || (panel.Type == BHE.PanelType.FloorExposed) || (panel.Type == BHE.PanelType.Wall))
            {
                return OutsideBoundaryCondition.Outdoors;
            }

            if ((panel.Type == BHE.PanelType.SlabOnGrade) || (panel.Type == BHE.PanelType.UndergroundSlab) || (panel.Type == BHE.PanelType.UndergroundWall) || (panel.Type == BHE.PanelType.Floor))
            {
                return OutsideBoundaryCondition.Ground;
            }

            if ((panel.ConnectedSpaces.Count == 2) & ((panel.Type == BHE.PanelType.Ceiling) || (panel.Type == BHE.PanelType.FloorInternal) || (panel.Type == BHE.PanelType.WallInternal)))
            {
                return OutsideBoundaryCondition.Zone;
            }

            return OutsideBoundaryCondition.Undefined;
        }
    }
}



