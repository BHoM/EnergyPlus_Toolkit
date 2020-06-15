using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class OutputVariableDictionary : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "Output:VariableDictionary";
        [Order]
        [Description("No description available")]
        public virtual OutputVariableDictionaryKeyField KeyField { get; set; } = OutputVariableDictionaryKeyField.IDF;
        [Order]
        [Description("No description available")]
        public virtual OutputVariableDictionarySortOption SortOption { get; set; } = OutputVariableDictionarySortOption.Name;
    }
}
