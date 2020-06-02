//using BH.oM.Base;
//using System.Collections.Generic;
//using System.ComponentModel;
//
//namespace BH.oM.EnergyPlus
//{
//public class ElectricLoadCenter:Generators : BHoMObject
//{
//[Description("No description available")]
//public virtual null Name { get; set; } = new null;
//[Description("No description available")]
//public virtual object-list Generator1Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice Generator1ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real Generator1RatedElectricPowerOutput { get; set; } = new real;
//[Description("Availability schedule name for this generator. Schedule value > 0 means the generator is available.")]
//public virtual object-list Generator1AvailabilityScheduleName { get; set; } = new object-list;
//[Description("Required field when generator is used by an ElectricLoadCenter:Distribution object with Generator Operation Scheme set to FollowThermal or FollowThermalLimitElectrical")]
//public virtual real Generator1RatedThermalToElectricalPowerRatio { get; set; } = new real;
//[Description("No description available")]
//public virtual object-list Generator2Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice Generator2ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real Generator2RatedElectricPowerOutput { get; set; } = new real;
//[Description("Availability schedule name for this generator. Schedule value > 0 means the generator is available.")]
//public virtual object-list Generator2AvailabilityScheduleName { get; set; } = new object-list;
//[Description("Required field when generator is used by an ElectricLoadCenter:Distribution object with Generator Operation Scheme set to FollowThermal or FollowThermalLimitElectrical")]
//public virtual real Generator2RatedThermalToElectricalPowerRatio { get; set; } = new real;
//[Description("No description available")]
//public virtual object-list Generator3Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice Generator3ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real Generator3RatedElectricPowerOutput { get; set; } = new real;
//[Description("Availability schedule name for this generator. Schedule value > 0 means the generator is available.")]
//public virtual object-list Generator3AvailabilityScheduleName { get; set; } = new object-list;
//[Description("Required field when generator is used by an ElectricLoadCenter:Distribution object with Generator Operation Scheme set to FollowThermal or FollowThermalLimitElectrical")]
//public virtual real Generator3RatedThermalToElectricalPowerRatio { get; set; } = new real;
//[Description("No description available")]
//public virtual object-list Generator4Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice Generator4ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real Generator4RatedElectricPowerOutput { get; set; } = new real;
//[Description("Availability schedule name for this generator. Schedule value > 0 means the generator is available.")]
//public virtual object-list Generator4AvailabilityScheduleName { get; set; } = new object-list;
//[Description("Required field when generator is used by an ElectricLoadCenter:Distribution object with Generator Operation Scheme set to FollowThermal or FollowThermalLimitElectrical")]
//public virtual real Generator4RatedThermalToElectricalPowerRatio { get; set; } = new real;
//[Description("No description available")]
//public virtual object-list Generator5Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice Generator5ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real Generator5RatedElectricPowerOutput { get; set; } = new real;
//[Description("Availability schedule name for this generator. Schedule value > 0 means the generator is available.")]
//public virtual object-list Generator5AvailabilityScheduleName { get; set; } = new object-list;
//[Description("Required field when generator is used by an ElectricLoadCenter:Distribution object with Generator Operation Scheme set to FollowThermal or FollowThermalLimitElectrical")]
//public virtual real Generator5RatedThermalToElectricalPowerRatio { get; set; } = new real;
//[Description("No description available")]
//public virtual object-list Generator6Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice Generator6ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real Generator6RatedElectricPowerOutput { get; set; } = new real;
//[Description("Availability schedule name for this generator. Schedule value > 0 means the generator is available.")]
//public virtual object-list Generator6AvailabilityScheduleName { get; set; } = new object-list;
//[Description("Required field when generator is used by an ElectricLoadCenter:Distribution object with Generator Operation Scheme set to FollowThermal or FollowThermalLimitElectrical")]
//public virtual real Generator6RatedThermalToElectricalPowerRatio { get; set; } = new real;
//[Description("No description available")]
//public virtual object-list Generator7Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice Generator7ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real Generator7RatedElectricPowerOutput { get; set; } = new real;
//[Description("Availability schedule name for this generator. Schedule value > 0 means the generator is available.")]
//public virtual object-list Generator7AvailabilityScheduleName { get; set; } = new object-list;
//[Description("Required field when generator is used by an ElectricLoadCenter:Distribution object with Generator Operation Scheme set to FollowThermal or FollowThermalLimitElectrical")]
//public virtual real Generator7RatedThermalToElectricalPowerRatio { get; set; } = new real;
//[Description("No description available")]
//public virtual object-list Generator8Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice Generator8ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real Generator8RatedElectricPowerOutput { get; set; } = new real;
//[Description("Availability schedule name for this generator. Schedule value > 0 means the generator is available.")]
//public virtual object-list Generator8AvailabilityScheduleName { get; set; } = new object-list;
//[Description("Required field when generator is used by an ElectricLoadCenter:Distribution object with Generator Operation Scheme set to FollowThermal or FollowThermalLimitElectrical")]
//public virtual real Generator8RatedThermalToElectricalPowerRatio { get; set; } = new real;
//[Description("No description available")]
//public virtual object-list Generator9Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice Generator9ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real Generator9RatedElectricPowerOutput { get; set; } = new real;
//[Description("Availability schedule name for this generator. Schedule value > 0 means the generator is available.")]
//public virtual object-list Generator9AvailabilityScheduleName { get; set; } = new object-list;
//[Description("Required field when generator is used by an ElectricLoadCenter:Distribution object with Generator Operation Scheme set to FollowThermal or FollowThermalLimitElectrical")]
//public virtual real Generator9RatedThermalToElectricalPowerRatio { get; set; } = new real;
//[Description("No description available")]
//public virtual object-list Generator10Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice Generator10ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real Generator10RatedElectricPowerOutput { get; set; } = new real;
//[Description("Availability schedule name for this generator. Schedule value > 0 means the generator is available.")]
//public virtual object-list Generator10AvailabilityScheduleName { get; set; } = new object-list;
//[Description("Required field when generator is used by an ElectricLoadCenter:Distribution object with Generator Operation Scheme set to FollowThermal or FollowThermalLimitElectrical")]
//public virtual real Generator10RatedThermalToElectricalPowerRatio { get; set; } = new real;
//[Description("No description available")]
//public virtual object-list Generator11Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice Generator11ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real Generator11RatedElectricPowerOutput { get; set; } = new real;
//[Description("Availability schedule name for this generator. Schedule value > 0 means the generator is available.")]
//public virtual object-list Generator11AvailabilityScheduleName { get; set; } = new object-list;
//[Description("Required field when generator is used by an ElectricLoadCenter:Distribution object with Generator Operation Scheme set to FollowThermal or FollowThermalLimitElectrical")]
//public virtual real Generator11RatedThermalToElectricalPowerRatio { get; set; } = new real;
//[Description("No description available")]
//public virtual object-list Generator12Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice Generator12ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real Generator12RatedElectricPowerOutput { get; set; } = new real;
//[Description("Availability schedule name for this generator. Schedule value > 0 means the generator is available.")]
//public virtual object-list Generator12AvailabilityScheduleName { get; set; } = new object-list;
//[Description("Required field when generator is used by an ElectricLoadCenter:Distribution object with Generator Operation Scheme set to FollowThermal or FollowThermalLimitElectrical")]
//public virtual real Generator12RatedThermalToElectricalPowerRatio { get; set; } = new real;
//[Description("No description available")]
//public virtual object-list Generator13Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice Generator13ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real Generator13RatedElectricPowerOutput { get; set; } = new real;
//[Description("Availability schedule name for this generator. Schedule value > 0 means the generator is available.")]
//public virtual object-list Generator13AvailabilityScheduleName { get; set; } = new object-list;
//[Description("Required field when generator is used by an ElectricLoadCenter:Distribution object with Generator Operation Scheme set to FollowThermal or FollowThermalLimitElectrical")]
//public virtual real Generator13RatedThermalToElectricalPowerRatio { get; set; } = new real;
//[Description("No description available")]
//public virtual object-list Generator14Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice Generator14ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real Generator14RatedElectricPowerOutput { get; set; } = new real;
//[Description("Availability schedule name for this generator. Schedule value > 0 means the generator is available.")]
//public virtual object-list Generator14AvailabilityScheduleName { get; set; } = new object-list;
//[Description("Required field when generator is used by an ElectricLoadCenter:Distribution object with Generator Operation Scheme set to FollowThermal or FollowThermalLimitElectrical")]
//public virtual real Generator14RatedThermalToElectricalPowerRatio { get; set; } = new real;
//[Description("No description available")]
//public virtual object-list Generator15Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice Generator15ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real Generator15RatedElectricPowerOutput { get; set; } = new real;
//[Description("Availability schedule name for this generator. Schedule value > 0 means the generator is available.")]
//public virtual object-list Generator15AvailabilityScheduleName { get; set; } = new object-list;
//[Description("Required field when generator is used by an ElectricLoadCenter:Distribution object with Generator Operation Scheme set to FollowThermal or FollowThermalLimitElectrical")]
//public virtual real Generator15RatedThermalToElectricalPowerRatio { get; set; } = new real;
//[Description("No description available")]
//public virtual object-list Generator16Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice Generator16ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real Generator16RatedElectricPowerOutput { get; set; } = new real;
//[Description("Availability schedule name for this generator. Schedule value > 0 means the generator is available.")]
//public virtual object-list Generator16AvailabilityScheduleName { get; set; } = new object-list;
//[Description("Required field when generator is used by an ElectricLoadCenter:Distribution object with Generator Operation Scheme set to FollowThermal or FollowThermalLimitElectrical")]
//public virtual real Generator16RatedThermalToElectricalPowerRatio { get; set; } = new real;
//[Description("No description available")]
//public virtual object-list Generator17Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice Generator17ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real Generator17RatedElectricPowerOutput { get; set; } = new real;
//[Description("Availability schedule name for this generator. Schedule value > 0 means the generator is available.")]
//public virtual object-list Generator17AvailabilityScheduleName { get; set; } = new object-list;
//[Description("Required field when generator is used by an ElectricLoadCenter:Distribution object with Generator Operation Scheme set to FollowThermal or FollowThermalLimitElectrical")]
//public virtual real Generator17RatedThermalToElectricalPowerRatio { get; set; } = new real;
//[Description("No description available")]
//public virtual object-list Generator18Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice Generator18ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real Generator18RatedElectricPowerOutput { get; set; } = new real;
//[Description("Availability schedule name for this generator. Schedule value > 0 means the generator is available.")]
//public virtual object-list Generator18AvailabilityScheduleName { get; set; } = new object-list;
//[Description("Required field when generator is used by an ElectricLoadCenter:Distribution object with Generator Operation Scheme set to FollowThermal or FollowThermalLimitElectrical")]
//public virtual real Generator18RatedThermalToElectricalPowerRatio { get; set; } = new real;
//[Description("No description available")]
//public virtual object-list Generator19Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice Generator19ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real Generator19RatedElectricPowerOutput { get; set; } = new real;
//[Description("Availability schedule name for this generator. Schedule value > 0 means the generator is available.")]
//public virtual object-list Generator19AvailabilityScheduleName { get; set; } = new object-list;
//[Description("Required field when generator is used by an ElectricLoadCenter:Distribution object with Generator Operation Scheme set to FollowThermal or FollowThermalLimitElectrical")]
//public virtual real Generator19RatedThermalToElectricalPowerRatio { get; set; } = new real;
//[Description("No description available")]
//public virtual object-list Generator20Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice Generator20ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real Generator20RatedElectricPowerOutput { get; set; } = new real;
//[Description("Availability schedule name for this generator. Schedule value > 0 means the generator is available.")]
//public virtual object-list Generator20AvailabilityScheduleName { get; set; } = new object-list;
//[Description("Required field when generator is used by an ElectricLoadCenter:Distribution object with Generator Operation Scheme set to FollowThermal or FollowThermalLimitElectrical")]
//public virtual real Generator20RatedThermalToElectricalPowerRatio { get; set; } = new real;
//[Description("No description available")]
//public virtual object-list Generator21Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice Generator21ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real Generator21RatedElectricPowerOutput { get; set; } = new real;
//[Description("Availability schedule name for this generator. Schedule value > 0 means the generator is available.")]
//public virtual object-list Generator21AvailabilityScheduleName { get; set; } = new object-list;
//[Description("Required field when generator is used by an ElectricLoadCenter:Distribution object with Generator Operation Scheme set to FollowThermal or FollowThermalLimitElectrical")]
//public virtual real Generator21RatedThermalToElectricalPowerRatio { get; set; } = new real;
//[Description("No description available")]
//public virtual object-list Generator22Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice Generator22ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real Generator22RatedElectricPowerOutput { get; set; } = new real;
//[Description("Availability schedule name for this generator. Schedule value > 0 means the generator is available.")]
//public virtual object-list Generator22AvailabilityScheduleName { get; set; } = new object-list;
//[Description("Required field when generator is used by an ElectricLoadCenter:Distribution object with Generator Operation Scheme set to FollowThermal or FollowThermalLimitElectrical")]
//public virtual real Generator22RatedThermalToElectricalPowerRatio { get; set; } = new real;
//[Description("No description available")]
//public virtual object-list Generator23Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice Generator23ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real Generator23RatedElectricPowerOutput { get; set; } = new real;
//[Description("Availability schedule name for this generator. Schedule value > 0 means the generator is available.")]
//public virtual object-list Generator23AvailabilityScheduleName { get; set; } = new object-list;
//[Description("Required field when generator is used by an ElectricLoadCenter:Distribution object with Generator Operation Scheme set to FollowThermal or FollowThermalLimitElectrical")]
//public virtual real Generator23RatedThermalToElectricalPowerRatio { get; set; } = new real;
//[Description("No description available")]
//public virtual object-list Generator24Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice Generator24ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real Generator24RatedElectricPowerOutput { get; set; } = new real;
//[Description("Availability schedule name for this generator. Schedule value > 0 means the generator is available.")]
//public virtual object-list Generator24AvailabilityScheduleName { get; set; } = new object-list;
//[Description("Required field when generator is used by an ElectricLoadCenter:Distribution object with Generator Operation Scheme set to FollowThermal or FollowThermalLimitElectrical")]
//public virtual real Generator24RatedThermalToElectricalPowerRatio { get; set; } = new real;
//[Description("No description available")]
//public virtual object-list Generator25Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice Generator25ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real Generator25RatedElectricPowerOutput { get; set; } = new real;
//[Description("Availability schedule name for this generator. Schedule value > 0 means the generator is available.")]
//public virtual object-list Generator25AvailabilityScheduleName { get; set; } = new object-list;
//[Description("Required field when generator is used by an ElectricLoadCenter:Distribution object with Generator Operation Scheme set to FollowThermal or FollowThermalLimitElectrical")]
//public virtual real Generator25RatedThermalToElectricalPowerRatio { get; set; } = new real;
//[Description("No description available")]
//public virtual object-list Generator26Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice Generator26ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real Generator26RatedElectricPowerOutput { get; set; } = new real;
//[Description("Availability schedule name for this generator. Schedule value > 0 means the generator is available.")]
//public virtual object-list Generator26AvailabilityScheduleName { get; set; } = new object-list;
//[Description("Required field when generator is used by an ElectricLoadCenter:Distribution object with Generator Operation Scheme set to FollowThermal or FollowThermalLimitElectrical")]
//public virtual real Generator26RatedThermalToElectricalPowerRatio { get; set; } = new real;
//[Description("No description available")]
//public virtual object-list Generator27Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice Generator27ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real Generator27RatedElectricPowerOutput { get; set; } = new real;
//[Description("Availability schedule name for this generator. Schedule value > 0 means the generator is available.")]
//public virtual object-list Generator27AvailabilityScheduleName { get; set; } = new object-list;
//[Description("Required field when generator is used by an ElectricLoadCenter:Distribution object with Generator Operation Scheme set to FollowThermal or FollowThermalLimitElectrical")]
//public virtual real Generator27RatedThermalToElectricalPowerRatio { get; set; } = new real;
//[Description("No description available")]
//public virtual object-list Generator28Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice Generator28ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real Generator28RatedElectricPowerOutput { get; set; } = new real;
//[Description("Availability schedule name for this generator. Schedule value > 0 means the generator is available.")]
//public virtual object-list Generator28AvailabilityScheduleName { get; set; } = new object-list;
//[Description("Required field when generator is used by an ElectricLoadCenter:Distribution object with Generator Operation Scheme set to FollowThermal or FollowThermalLimitElectrical")]
//public virtual real Generator28RatedThermalToElectricalPowerRatio { get; set; } = new real;
//[Description("No description available")]
//public virtual object-list Generator29Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice Generator29ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real Generator29RatedElectricPowerOutput { get; set; } = new real;
//[Description("Availability schedule name for this generator. Schedule value > 0 means the generator is available.")]
//public virtual object-list Generator29AvailabilityScheduleName { get; set; } = new object-list;
//[Description("Required field when generator is used by an ElectricLoadCenter:Distribution object with Generator Operation Scheme set to FollowThermal or FollowThermalLimitElectrical")]
//public virtual real Generator29RatedThermalToElectricalPowerRatio { get; set; } = new real;
//[Description("No description available")]
//public virtual object-list Generator30Name { get; set; } = new object-list;
//[Description("No description available")]
//public virtual choice Generator30ObjectType { get; set; } = new choice;
//[Description("No description available")]
//public virtual real Generator30RatedElectricPowerOutput { get; set; } = new real;
//[Description("Availability schedule name for this generator. Schedule value > 0 means the generator is available.")]
//public virtual object-list Generator30AvailabilityScheduleName { get; set; } = new object-list;
//[Description("Required field when generator is used by an ElectricLoadCenter:Distribution object with Generator Operation Scheme set to FollowThermal or FollowThermalLimitElectrical")]
//public virtual real Generator30RatedThermalToElectricalPowerRatio { get; set; } = new real;
//}
//}
