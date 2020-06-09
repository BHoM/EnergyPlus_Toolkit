using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class Lights : BHoMObject
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "Lights";
        [Order]
        [Description("No description available")]
        public override string Name { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual ZoneList ZoneOrZoneListName { get; set; } = new ZoneList();
        [Order]
        [Description("units in schedule should be fraction applied to design level of lights, generally (0.0 - 1.0)")]
        public virtual string ScheduleName { get; set; } = "";
        [Order]
        [Description("The entered calculation method is used to create the maximum amount of lights")]
        public virtual LightsDesignLevelCalculationMethod DesignLevelCalculationMethod { get; set; } = LightsDesignLevelCalculationMethod.Undefined;
        [Order]
        [Description("No description available")]
        public virtual double LightingLevel { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double WattsPerZoneFloorArea { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double WattsPerPerson { get; set; } = 0.0;
        [Order]
        [Description("Used only for sizing calculation if return-air-fraction")]
        public virtual double ReturnAirFraction { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double FractionRadiant { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double FractionVisible { get; set; } = 0.0;
        [Order]
        [Description("For Daylighting:Controls must be 0 or 1: 0 = no dimming control, 1 = full dimming control")]
        public virtual double FractionReplaceable { get; set; } = 0.0;
        [Order]
        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Subcategory table.")]
        public virtual string EndUseSubcategory { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual bool ReturnAirFractionCalculatedFromPlenumTemperature { get; set; } = false;
        [Order]
        [Description("Used only if Return Air Fraction Is Calculated from Plenum Temperature = Yes")]
        public virtual double ReturnAirFractionFunctionOfPlenumTemperatureCoefficient1 { get; set; } = 0.0;
        [Order]
        [Description("Used only if Return Air Fraction Is Calculated from Plenum Temperature = Yes")]
        public virtual double ReturnAirFractionFunctionOfPlenumTemperatureCoefficient2 { get; set; } = 0.0;
        [Order]
        [Description("Name of the return air node for this heat gain.")]
        public virtual string ReturnAirHeatGainNodeName { get; set; } = "";
    }
}
