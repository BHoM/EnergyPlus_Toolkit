//using BH.oM.Base;
//using System.Collections.Generic;
//using System.ComponentModel;
//
//namespace BH.oM.EnergyPlus
//{
//public class EnergyManagementSystem:MeteredOutputVariable : BHoMObject
//{
//[Description("No description available")]
//public virtual alpha Name { get; set; } = new alpha;
//[Description("must be an acceptable EMS variable, no spaces")]
//public virtual alpha EMSVariableName { get; set; } = new alpha;
//[Description("No description available")]
//public virtual choice UpdateFrequency { get; set; } = new choice;
//[Description("optional for global scope variables, required for local scope variables")]
//public virtual alpha EMSProgramOrSubroutineName { get; set; } = new alpha;
//[Description("choose the type of fuel, water, electricity, pollution or heat rate that should be metered.")]
//public virtual choice ResourceType { get; set; } = new choice;
//[Description("choose a general classification, building (internal services), HVAC (air systems), or plant (hydronic systems), or system")]
//public virtual choice GroupType { get; set; } = new choice;
//[Description("choose how the metered output should be classified for end-use category")]
//public virtual choice End-UseCategory { get; set; } = new choice;
//[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Subcategory table.")]
//public virtual alpha End-UseSubcategory { get; set; } = new alpha;
//[Description("optional but will result in dimensionless units for blank")]
//public virtual alpha Units { get; set; } = new alpha;
//}
//}
