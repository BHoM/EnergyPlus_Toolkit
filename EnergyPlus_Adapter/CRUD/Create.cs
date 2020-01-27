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
            List<IBHoMObject> bhomObjects = objects.Select(x => (IBHoMObject)x).ToList();

            List<Building> buildings = bhomObjects.Buildings();
            List<Panel> panels = bhomObjects.Panels();
            List<Construction> constructions = panels.UniqueConstructions();
            List<Construction> openingConstructions = panels.OpeningsFromElements().Select(x => x.OpeningConstruction as Construction).ToList();

            foreach (Building b in buildings)
                FileOutput.AddRange(b.ToEnergyPlus(_settings));

            List<List<Panel>> panelsAsSpaces = panels.ToSpaces();
            foreach (List<Panel> space in panelsAsSpaces)
            {
                string connectedName = space.ConnectedSpaceName();
                foreach (Panel p in space)
                    FileOutput.AddRange(p.ToEnergyPlus(connectedName, _settings));
            }

            foreach (Construction c in constructions)
                FileOutput.AddRange(c.ToEnergyPlus(_settings));

            List<List<Layer>> layers = constructions.Select(x => x.Layers).ToList();

            foreach (List<Layer> l1 in layers)
            {
                foreach (Layer l in l1)
                    FileOutput.AddRange(l.ToEnergyPlus(_settings));
            }

            foreach (Construction c in openingConstructions)
                FileOutput.AddRange(c.ToEnergyPlus(_settings));

            List<List<Layer>> openingLayers = openingConstructions.Select(x => x.Layers).ToList();
            foreach (List<Layer> l1 in openingLayers)
            {
                foreach (Layer l in l1)
                    FileOutput.AddRange(l.ToEnergyPlusWindow(_settings));
            }

            return true;
        }
    }
}
