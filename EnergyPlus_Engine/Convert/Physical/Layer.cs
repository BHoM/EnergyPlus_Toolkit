using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BHE = BH.oM.Environment.Elements;
using BHM = BH.oM.Physical.Materials;
using BHP = BH.oM.Physical.Constructions;
using BH.oM.EnergyPlus.Settings;

using BH.oM.Environment.MaterialFragments;
using BH.Engine.Environment;

namespace BH.Engine.EnergyPlus
{
    public static partial class Convert
    {
        public static List<string> ToEnergyPlus(this BHP.Layer layer, EnergyPlusSettings settings)
        {
            List<string> layerAsString = new List<string>();

            layerAsString.Add("Material,"); //EnergyPlus does not do layers the same way as BHoM, the material has a thickness property, so the title is Material
            layerAsString.Add("\t" + layer.Name + ",\t!- Name");

            IEnvironmentMaterial envMaterial = layer.Material.Properties.Where(x => x is IEnvironmentMaterial).FirstOrDefault() as IEnvironmentMaterial;

            if (envMaterial != null)
            {
                layerAsString.Add("\t" + envMaterial.Roughness.ToEnergyPlus() + ",\t!- Roughness");
                layerAsString.Add("\t" + Math.Round(layer.Thickness, settings.DecimalPlaces).ToString() + ",\t!- Thickness {m}");
                layerAsString.Add("\t" + Math.Round(envMaterial.Conductivity, settings.DecimalPlaces).ToString() + ",\t!- Conductivity {W/m-K}");
                layerAsString.Add("\t" + Math.Round(envMaterial.Density, settings.DecimalPlaces).ToString() + ",\t!- Density {kg/m3}");
                layerAsString.Add("\t" + Math.Round(envMaterial.SpecificHeat, settings.DecimalPlaces).ToString() + ",\t!- Specific Heat {J/kg-K}");

                //ToDo: Add Thermal and Solar Absortpance properly
                layerAsString.Add("\t0.0,");
                layerAsString.Add("\t0.0,");
                layerAsString.Add("\t0.0,");
            }

            layerAsString[layerAsString.Count - 1] = layerAsString[layerAsString.Count - 1].Replace(',', ';');
            layerAsString.Add("");
            layerAsString.Add("");

            return layerAsString;
        }

        public static List<string> ToEnergyPlusWindow(this BHP.Layer layer, EnergyPlusSettings settings)
        {
            List<string> layerAsString = new List<string>();

            layerAsString.Add("WindowMaterial:"); //Glazing or gas will be set later when we've identified the type of layer this is
            layerAsString.Add("\t" + layer.Material.Name + ",\t!- Name");
            layerAsString.Add("\t,\t!- Window Glass Spectral Data Set Name");
            
            SolidMaterial transparentProperties = layer.FindMaterial<SolidMaterial>(typeof(SolidMaterial));

            if (transparentProperties != null)
            {
                layerAsString[0] = layerAsString[0] + "Glazing,";
                layerAsString.Add("\t" + Math.Round(layer.Thickness, settings.DecimalPlaces).ToString() + ",\t!- Thickness {m}");
                layerAsString.Add("\t" + Math.Round(transparentProperties.SolarTransmittance, settings.DecimalPlaces).ToString() + ",\t!- Solar Transmittance at Normal Incidence");
                layerAsString.Add("\t" + Math.Round(transparentProperties.SolarReflectanceExternal, settings.DecimalPlaces).ToString() + ",\t!- Front side solar reflectance at normal incidence");
                layerAsString.Add("\t" + Math.Round(transparentProperties.SolarReflectanceInternal, settings.DecimalPlaces).ToString() + ",\t!- Back side solar reflectance at normal incidence");
                layerAsString.Add("\t" + Math.Round(transparentProperties.LightTransmittance, settings.DecimalPlaces).ToString() + ",\t!- Visible transmittance at normal incidence");
                layerAsString.Add("\t" + Math.Round(transparentProperties.LightReflectanceExternal, settings.DecimalPlaces).ToString() + ",\t!- Front side visible reflectance at normal incidence");
                layerAsString.Add("\t" + Math.Round(transparentProperties.LightReflectanceInternal, settings.DecimalPlaces).ToString() + ",\t!- Back side visible reflectance at normal incidence");

                //ToDo: Figure out infrared transmittance if required
                layerAsString.Add("\t0.0,\t!- Infrared transmittance at normal incidence");
                layerAsString.Add("\t0.0,\t!- Front Side Infrared Hemispherical Emissivity");
                layerAsString.Add("\t0.0,\t!- Back Side Infrared Hemispherical Emissivity");

                layerAsString.Add("\t" + Math.Round(transparentProperties.Conductivity, settings.DecimalPlaces).ToString() + ",\t!- Conductivity {W/m-K}");
                layerAsString.Add("\t1,\t!- Dirt correction factor for solar and visible transmittance");
                layerAsString.Add("\tNo,");
            }
            else
            {
                GasMaterial gasProperties = layer.FindMaterial<GasMaterial>(typeof(GasMaterial));
                if(gasProperties != null)
                {
                    layerAsString[0] = layerAsString[0] + "Gas,";
                    layerAsString.Add("\t" + gasProperties.Gas.ToEnergyPlus() + ",\t!- Gas Type");
                    layerAsString.Add("\t" + Math.Round(layer.Thickness, settings.DecimalPlaces).ToString() + ",\t!- Thickness {m}");
                }
            }

            layerAsString[layerAsString.Count - 1] = layerAsString[layerAsString.Count - 1].Replace(',', ';');
            layerAsString.Add("");
            layerAsString.Add("");

            return layerAsString;
        }
    }
}
