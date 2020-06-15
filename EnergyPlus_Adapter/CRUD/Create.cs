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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BH.oM.Base;
using BH.Engine.EnergyPlus;
using BH.oM.EnergyPlus.Settings;

using System.IO;
using BH.oM.Environment.Elements;

using BH.Engine.Environment;
using BH.Engine.Base;

using BH.oM.Physical.Constructions;

using BH.oM.Adapter;

namespace BH.Adapter.EnergyPlus
{
    public partial class EnergyPlusAdapter : BHoMAdapter
    {
        protected override bool ICreate<T>(IEnumerable<T> objects, ActionConfig actionConfig = null)
        {
            //List<IBHoMObject> bhomObjects = objects.Select(x => (IBHoMObject)x).ToList();

            //List<Building> buildings = bhomObjects.Buildings();
            //List<Panel> panels = bhomObjects.Panels();
            //List<Construction> constructions = panels.UniqueConstructions();
            //List<Construction> openingConstructions = panels.OpeningsFromElements().Select(x => x.OpeningConstruction as Construction).ToList();

            //foreach (Building b in buildings)
            //    FileOutput.AddRange(b.ToEnergyPlus(_settings));

            //List<List<Panel>> panelsAsSpaces = panels.ToSpaces();
            //foreach (List<Panel> space in panelsAsSpaces)
            //{
            //    string connectedName = space.ConnectedSpaceName();
            //    foreach (Panel p in space)
            //        FileOutput.AddRange(p.ToEnergyPlus(connectedName, _settings));
            //}

            //foreach (Construction c in constructions)
            //    FileOutput.AddRange(c.ToEnergyPlus(_settings));

            //List<List<Layer>> layers = constructions.Select(x => x.Layers).ToList();

            //foreach (List<Layer> l1 in layers)
            //{
            //    foreach (Layer l in l1)
            //        FileOutput.AddRange(l.ToEnergyPlus(_settings));
            //}

            //foreach (Construction c in openingConstructions)
            //    FileOutput.AddRange(c.ToEnergyPlus(_settings));

            //List<List<Layer>> openingLayers = openingConstructions.Select(x => x.Layers).ToList();
            //foreach (List<Layer> l1 in openingLayers)
            //{
            //    foreach (Layer l in l1)
            //        FileOutput.AddRange(l.ToEnergyPlusWindow(_settings));
            //}

            return true;
        }
    }
}
