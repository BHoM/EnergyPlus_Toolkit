using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class OutputVariableDictionary : BHoMObject
    {
        [Description("No description available")]
        public virtual OutputVariableDictionaryKeyField KeyField { get; set; } = OutputVariableDictionaryKeyField.IDF;
        [Description("No description available")]
        public virtual OutputVariableDictionarySortOption SortOption { get; set; } = OutputVariableDictionarySortOption.Undefined;
    }
}
