using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.EnergyPlus
{
    public class ShadowCalculation : BHoMObject
    {
        [Description("choose calculation method. note that TimestepFrequency is only needed for certain cases")]
        public virtual CalculationMethod CalculationMethod { get; set; } = CalculationMethod.AverageOverDaysInFrequency;
        [Description("Frequency at which calculation will be made")]
        public virtual int CalculationFrequency { get; set; } = 20;
        [Description("Number of allowable figures in shadow overlap calculations")]
        public virtual int MaximumFiguresInShadowOverlapCalculations { get; set; } = 15000;
        [Description("Advanced Feature. Internal default is SutherlandHodgman")]
        public virtual PolygonClippingAlgorithm PolygonClippingAlgorithm { get; set; } = PolygonClippingAlgorithm.SutherlandHodgman;
        [Description("Advanced Feature. Internal default is SimpleSkyDiffuseModeling")]
        public virtual SkyDiffuseModelingAlgorithm SkyDiffuseModelingAlgorithm { get; set; } = SkyDiffuseModelingAlgorithm.SimpleSkyDiffuseModeling;
        [Description("If ScheduledShading is chosen, the External Shading Fraction Schedule Name is required")]
        public virtual ExternalShadingCalculationMethod ExternalShadingCalculationMethod { get; set; } = ExternalShadingCalculationMethod.InternalCalculation;
        [Description("If True is chosen, the calculated external shading fraction results will be saved to an external CSV file with surface names as the column headers.")]
        public virtual bool OutputExternalShadingCalculationResults { get; set; } = false;
        [Description("If True, self-shading will be disabled from all exterior surfaces in a given Shading Zone Group to surfaces within")]
        public virtual bool DisableSelfShadingWithinShadingZoneGroups { get; set; } = false;
        [Description("If True, self-shading will be disabled from all exterior surfaces in a given Shading Zone Group to all other zones in the model.")]
        public virtual bool DisableSelfShadingFromShadingZoneGroupsToOtherZones { get; set; } = false;
        [Description("Specifies a group of zones which are controlled by the Disable Self-Shading fields.")]
        public virtual List<string> ShadingZoneGroupZoneListName { get; set; } = new List<string>();
    }
}
