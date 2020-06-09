using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class ElectricEquipment : BHoMObject
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "ElectricEquipment";
        [Order]
        [Description("No description available")]
        public override string Name { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual ZoneList ZoneOrZoneListName { get; set; } = new ZoneList();
        [Order]
        [Description("units in schedule should be fraction applied to design level of electric equipment, generally (0.0 - 1.0)")]
        public virtual string ScheduleName { get; set; } = "";
        [Order]
        [Description("The entered calculation method is used to create the maximum amount of electric equipment")]
        public virtual ElectricEquipmentDesignLevelCalculationMethod DesignLevelCalculationMethod { get; set; } = ElectricEquipmentDesignLevelCalculationMethod.Undefined;
        [Order]
        [Description("No description available")]
        public virtual double DesignLevel { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double WattsPerZoneFloorArea { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double WattsPerPerson { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double FractionLatent { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double FractionRadiant { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double FractionLost { get; set; } = 0.0;
        [Order]
        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Subcategory table.")]
        public virtual string EndUseSubcategory { get; set; } = "";
}
}
