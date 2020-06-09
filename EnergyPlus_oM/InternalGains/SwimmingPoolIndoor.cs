using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class SwimmingPoolIndoor : BHoMObject
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "SwimmingPool:Indoor";
        [Order]
        [Description("No description available")]
        public override string Name { get; set; } = "";
        [Order]
        [Description("Name of the floor surface where the pool is located.")]
        public virtual string SurfaceName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual double AverageDepth { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual string ActivityFactorScheduleName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string MakeupWaterSupplyScheduleName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string CoverScheduleName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual double CoverEvaporationFactor { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double CoverConvectionFactor { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double CoverShortWavelengthRadiationFactor { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual double CoverLongWavelengthRadiationFactor { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual string PoolWaterInletNode { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string PoolWaterOutletNode { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual double PoolHeatingSystemMaximumWaterFlowRate { get; set; } = 0.0;
        [Order]
        [Description("Power input per pool water flow rate")]
        public virtual double PoolMiscellaneousEquipmentPower { get; set; } = 0.0;
        [Order]
        [Description("No description available")]
        public virtual string SetpointTemperatureSchedule { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual int MaximumNumberOfPeople { get; set; } = 0;
        [Order]
        [Description("No description available")]
        public virtual string PeopleSchedule { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string PeopleHeatGainSchedule { get; set; } = "";
    }
}
