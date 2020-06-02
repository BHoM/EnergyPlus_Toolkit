namespace BH.oM.EnergyPlus
{
    public enum Terrain
    {
        Country,
        Suburbs,
        City,
        Ocean,
        Urban
    };

    public enum SolarDistribution
    {
        MinimalShadowing,
        FullExterior,
        FullInteriorAndExterior,
        FullExteriorWithReflections,
        FullInteriorAndExteriorWithReflections
    };

    public enum CalculationMethod
    {
        AverageOverDaysInFrequency,
        TimestepFrequency
    };

    public enum PolygonClippingAlgorithm
    {
        ConvexWeilerAtherton,
        SutherlandHodgman
    };

    public enum SkyDiffuseModelingAlgorithm
    {
        SimpleSkyDiffuseModeling,
        DetailedSkyDiffuseModeling
    };

    public enum ExternalShadingCalculationMethod
    {
        ScheduledShading,
        InternalCalculation,
        ImportedShading
    };

    public enum SurfaceConvectionAlgorithmInsideMethod
    {
        Simple,
        TARP,
        CeilingDiffuser,
        AdaptiveConvectionAlgorithm
    };

    public enum SurfaceConvectionAlgorithmOutsideMethod
    {
        SimpleCombined,
        TARP,
        MoWiTT,
        DOE2,
        AdaptiveConvectionAlgorithm
    };

    public enum HeatBalanceAlgorithmMethod
    {
        ConductionTransferFunction,
        MoisturePenetrationDepthConductionTransferFunction,
        ConductionFiniteDifference,
        CombinedHeatAndMoistureFiniteElement
    };

    public enum DifferenceScheme
    {
        CrankNicholsonSecondOrder,
        FullyImplicitFirstOrder
    };

    public enum ZoneAirHeatBalanceAlgorithmMethod
    {
        ThirdOrderBackwardDifference,
        AnalyticalSolution,
        EulerMethod
    };

    public enum InfiltrationBalancingMethod
    {
        AddInfiltrationFlow,
        AdjustInfiltrationFlow
    };

    public enum HVACSystemRootFindingAlgorithmMethod
    {
        RegulaFalsi,
        Bisection,
        BisectionThenRegulaFalsi,
        RegulaFalsiThenBisection,
        Alternation
    };

    public enum DayOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    };

    public enum ScheduleTypeLimitsNumericType
    {
        Continuous,
        Discrete
    };

    public enum ScheduleTypeLimitsUnitType
    {
        Dimensionless,
        Temperature,
        DeltaTemperature,
        PrecipitationRate,
        Angle,
        ConvectionCoefficient,
        ActivityLevel,
        Velocity,
        Capacity,
        Power,
        Availability,
        Percent,
        Control,
        Mode
    };

    public enum ColumnSeparator
    {
        Comma,
        Tab,
        Space,
        Semicolon
    };
}
