using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class SwimmingPoolIndoor : BHoMObject
    {
        [Description("No description available")]
        public virtual string SwimmingPoolIndoorName { get; set; } = "";
        [Description("Name of the floor surface where the pool is located.")]
        public virtual string SurfaceName { get; set; } = "";
        [Description("No description available")]
        public virtual double AverageDepth { get; set; } = 0.0;
        [Description("No description available")]
        public virtual string ActivityFactorScheduleName { get; set; } = "";
        [Description("No description available")]
        public virtual string MakeupWaterSupplyScheduleName { get; set; } = "";
        [Description("No description available")]
        public virtual string CoverScheduleName { get; set; } = "";
        [Description("No description available")]
        public virtual double CoverEvaporationFactor { get; set; } = 0.0;
        [Description("No description available")]
        public virtual double CoverConvectionFactor { get; set; } = 0.0;
        [Description("No description available")]
        public virtual double CoverShortWavelengthRadiationFactor { get; set; } = 0.0;
        [Description("No description available")]
        public virtual double CoverLongWavelengthRadiationFactor { get; set; } = 0.0;
        [Description("No description available")]
        public virtual string PoolWaterInletNode { get; set; } = "";
        [Description("No description available")]
        public virtual string PoolWaterOutletNode { get; set; } = "";
        [Description("No description available")]
        public virtual double PoolHeatingSystemMaximumWaterFlowRate { get; set; } = 0.0;
        [Description("Power input per pool water flow rate")]
        public virtual double PoolMiscellaneousEquipmentPower { get; set; } = 0.0;
        [Description("No description available")]
        public virtual string SetpointTemperatureSchedule { get; set; } = "";
        [Description("No description available")]
        public virtual int MaximumNumberOfPeople { get; set; } = 0;
        [Description("No description available")]
        public virtual string PeopleSchedule { get; set; } = "";
        [Description("No description available")]
        public virtual string PeopleHeatGainSchedule { get; set; } = "";
    }
}
