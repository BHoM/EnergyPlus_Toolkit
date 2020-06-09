using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.EnergyPlus
{
    public class ShadowCalculation : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]

        public virtual string ClassName { get; set; } = "ShadowCalculation";
        [Order]
        [Description("choose calculation method. note that TimestepFrequency is only needed for certain cases")]
        public virtual CalculationMethod CalculationMethod { get; set; } = CalculationMethod.AverageOverDaysInFrequency;
        [Order]
        [Description("Frequency at which calculation will be made")]
        public virtual int CalculationFrequency { get; set; } = 20;
        [Order]
        [Description("Number of allowable figures in shadow overlap calculations")]
        public virtual int MaximumFiguresInShadowOverlapCalculations { get; set; } = 15000;
        [Order]
        [Description("Advanced Feature. Internal default is SutherlandHodgman")]
        public virtual PolygonClippingAlgorithm PolygonClippingAlgorithm { get; set; } = PolygonClippingAlgorithm.SutherlandHodgman;
        [Order]
        [Description("Advanced Feature. Internal default is SimpleSkyDiffuseModeling")]
        public virtual SkyDiffuseModelingAlgorithm SkyDiffuseModelingAlgorithm { get; set; } = SkyDiffuseModelingAlgorithm.SimpleSkyDiffuseModeling;
        [Order]
        [Description("If ScheduledShading is chosen, the External Shading Fraction Schedule Name is required")]
        public virtual ExternalShadingCalculationMethod ExternalShadingCalculationMethod { get; set; } = ExternalShadingCalculationMethod.InternalCalculation;
        [Order]
        [Description("If True is chosen, the calculated external shading fraction results will be saved to an external CSV file with surface names as the column headers.")]
        public virtual bool OutputExternalShadingCalculationResults { get; set; } = false;
        [Order]
        [Description("If True, self-shading will be disabled from all exterior surfaces in a given Shading Zone Group to surfaces within")]
        public virtual bool DisableSelfShadingWithinShadingZoneGroups { get; set; } = false;
        [Order]
        [Description("If True, self-shading will be disabled from all exterior surfaces in a given Shading Zone Group to all other zones in the model.")]
        public virtual bool DisableSelfShadingFromShadingZoneGroupsToOtherZones { get; set; } = false;
        [Order]
        [Description("Specifies a group of zones which are controlled by the Disable Self-Shading fields.")]
        public virtual ZoneList ShadingZoneGroupZoneListName { get; set; } = new ZoneList();
    }
}
