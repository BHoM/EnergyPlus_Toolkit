////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class UtilityCost:Charge:Block : BHoMObject
////{
////[Description("Charge Variable Name")]
////public virtual null UtilityCostChargeBlockName { get; set; } = new null;
////[Description("The name of the UtilityCost:Tariff that is associated with this UtilityCost:Charge:Block.")]
////public virtual object-list TariffName { get; set; } = new object-list;
////[Description("The name of the source used by the UtilityCost:Charge:Block. This is usually the name of the variable")]
////public virtual null SourceVariable { get; set; } = new null;
////[Description("If this is set to annual the calculations are performed for the UtilityCost:Charge:Block for the entire")]
////public virtual choice Season { get; set; } = new choice;
////[Description("This field shows where the charge should be added. The reason to enter this field appropriately is so")]
////public virtual choice CategoryVariableName { get; set; } = new choice;
////[Description("If the blocks do not use all of the energy or demand from the source some energy and demand remains")]
////public virtual null RemainingIntoVariable { get; set; } = new null;
////[Description("The sizes of the blocks are usually used directly but if a value or a variable is entered here the block")]
////public virtual null BlockSizeMultiplierValueOrVariableName { get; set; } = new null;
////[Description("The size of the block of the charges is entered here. For most rates that use multiple blocks this will")]
////public virtual null BlockSize1ValueOrVariableName { get; set; } = new null;
////[Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it can be either a number")]
////public virtual null Block1CostPerUnitValueOrVariableName { get; set; } = new null;
////[Description("The size of the block of the charges is entered here. For most rates that use multiple blocks this will")]
////public virtual null BlockSize2ValueOrVariableName { get; set; } = new null;
////[Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it can be either a number")]
////public virtual null Block2CostPerUnitValueOrVariableName { get; set; } = new null;
////[Description("The size of the block of the charges is entered here. For most rates that use multiple blocks this will")]
////public virtual null BlockSize3ValueOrVariableName { get; set; } = new null;
////[Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it can be either a number")]
////public virtual null Block3CostPerUnitValueOrVariableName { get; set; } = new null;
////[Description("The size of the block of the charges is entered here. For most rates that use multiple blocks this will")]
////public virtual null BlockSize4ValueOrVariableName { get; set; } = new null;
////[Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it can be either a number")]
////public virtual null Block4CostPerUnitValueOrVariableName { get; set; } = new null;
////[Description("The size of the block of the charges is entered here. For most rates that use multiple blocks this will")]
////public virtual null BlockSize5ValueOrVariableName { get; set; } = new null;
////[Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it can be either a number")]
////public virtual null Block5CostPerUnitValueOrVariableName { get; set; } = new null;
////[Description("The size of the block of the charges is entered here. For most rates that use multiple blocks this will")]
////public virtual null BlockSize6ValueOrVariableName { get; set; } = new null;
////[Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it can be either a number")]
////public virtual null Block6CostPerUnitValueOrVariableName { get; set; } = new null;
////[Description("The size of the block of the charges is entered here. For most rates that use multiple blocks this will")]
////public virtual null BlockSize7ValueOrVariableName { get; set; } = new null;
////[Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it can be either a number")]
////public virtual null Block7CostPerUnitValueOrVariableName { get; set; } = new null;
////[Description("The size of the block of the charges is entered here. For most rates that use multiple blocks this will")]
////public virtual null BlockSize8ValueOrVariableName { get; set; } = new null;
////[Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it can be either a number")]
////public virtual null Block8CostPerUnitValueOrVariableName { get; set; } = new null;
////[Description("The size of the block of the charges is entered here. For most rates that use multiple blocks this will")]
////public virtual null BlockSize9ValueOrVariableName { get; set; } = new null;
////[Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it can be either a number")]
////public virtual null Block9CostPerUnitValueOrVariableName { get; set; } = new null;
////[Description("The size of the block of the charges is entered here. For most rates that use multiple blocks this will")]
////public virtual null BlockSize10ValueOrVariableName { get; set; } = new null;
////[Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it can be either a number")]
////public virtual null Block10CostPerUnitValueOrVariableName { get; set; } = new null;
////[Description("The size of the block of the charges is entered here. For most rates that use multiple blocks this will")]
////public virtual null BlockSize11ValueOrVariableName { get; set; } = new null;
////[Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it can be either a number")]
////public virtual null Block11CostPerUnitValueOrVariableName { get; set; } = new null;
////[Description("The size of the block of the charges is entered here. For most rates that use multiple blocks this will")]
////public virtual null BlockSize12ValueOrVariableName { get; set; } = new null;
////[Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it can be either a number")]
////public virtual null Block12CostPerUnitValueOrVariableName { get; set; } = new null;
////[Description("The size of the block of the charges is entered here. For most rates that use multiple blocks this will")]
////public virtual null BlockSize13ValueOrVariableName { get; set; } = new null;
////[Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it can be either a number")]
////public virtual null Block13CostPerUnitValueOrVariableName { get; set; } = new null;
////[Description("The size of the block of the charges is entered here. For most rates that use multiple blocks this will")]
////public virtual null BlockSize14ValueOrVariableName { get; set; } = new null;
////[Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it can be either a number")]
////public virtual null Block14CostPerUnitValueOrVariableName { get; set; } = new null;
////[Description("The size of the block of the charges is entered here. For most rates that use multiple blocks this will")]
////public virtual null BlockSize15ValueOrVariableName { get; set; } = new null;
////[Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it can be either a number")]
////public virtual null Block15CostPerUnitValueOrVariableName { get; set; } = new null;
////}
////}