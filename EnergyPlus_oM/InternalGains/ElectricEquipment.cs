using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class ElectricEquipment : BHoMObject
    {
        [Description("No description available")]
        public virtual string ElectricEquipmentName { get; set; } = "";
        [Description("No description available")]
        public virtual string ZoneOrZoneListName { get; set; } = "";
        [Description("units in schedule should be fraction applied to design level of electric equipment, generally (0.0 - 1.0)")]
        public virtual string ScheduleName { get; set; } = "";
        [Description("The entered calculation method is used to create the maximum amount of electric equipment")]
        public virtual ElectricEquipmentDesignLevelCalculationMethod DesignLevelCalculationMethod { get; set; } = ElectricEquipmentDesignLevelCalculationMethod.Undefined;
        [Description("No description available")]
        public virtual double DesignLevel { get; set; } = 0.0;
        [Description("No description available")]
        public virtual double WattsPerZoneFloorArea { get; set; } = 0.0;
        [Description("No description available")]
        public virtual double WattsPerPerson { get; set; } = 0.0;
        [Description("No description available")]
        public virtual double FractionLatent { get; set; } = 0.0;
        [Description("No description available")]
        public virtual double FractionRadiant { get; set; } = 0.0;
        [Description("No description available")]
        public virtual double FractionLost { get; set; } = 0.0;
        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Subcategory table.")]
        public virtual string EndUseSubcategory { get; set; } = "";
}
}
