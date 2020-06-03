namespace BH.oM.EnergyPlus
{
    public enum Terrain
    {
        Undefined,
        Country,
        Suburbs,
        City,
        Ocean,
        Urban
    };

    public enum SolarDistribution
    {
        Undefined,
        MinimalShadowing,
        FullExterior,
        FullInteriorAndExterior,
        FullExteriorWithReflections,
        FullInteriorAndExteriorWithReflections
    };

    public enum CalculationMethod
    {
        Undefined,
        AverageOverDaysInFrequency,
        TimestepFrequency
    };

    public enum PolygonClippingAlgorithm
    {
        Undefined,
        ConvexWeilerAtherton,
        SutherlandHodgman
    };

    public enum SkyDiffuseModelingAlgorithm
    {
        Undefined,
        SimpleSkyDiffuseModeling,
        DetailedSkyDiffuseModeling
    };

    public enum ExternalShadingCalculationMethod
    {
        Undefined,
        ScheduledShading,
        InternalCalculation,
        ImportedShading
    };

    public enum SurfaceConvectionAlgorithmInsideMethod
    {
        Undefined,
        Simple,
        TARP,
        CeilingDiffuser,
        AdaptiveConvectionAlgorithm
    };

    public enum SurfaceConvectionAlgorithmOutsideMethod
    {
        Undefined,
        SimpleCombined,
        TARP,
        MoWiTT,
        DOE2,
        AdaptiveConvectionAlgorithm
    };

    public enum HeatBalanceAlgorithmMethod
    {
        Undefined,
        ConductionTransferFunction,
        MoisturePenetrationDepthConductionTransferFunction,
        ConductionFiniteDifference,
        CombinedHeatAndMoistureFiniteElement
    };

    public enum DifferenceScheme
    {
        Undefined,
        CrankNicholsonSecondOrder,
        FullyImplicitFirstOrder
    };

    public enum ZoneAirHeatBalanceAlgorithmMethod
    {
        Undefined,
        ThirdOrderBackwardDifference,
        AnalyticalSolution,
        EulerMethod
    };

    public enum InfiltrationBalancingMethod
    {
        Undefined,
        AddInfiltrationFlow,
        AdjustInfiltrationFlow
    };

    public enum HVACSystemRootFindingAlgorithmMethod
    {
        Undefined,
        RegulaFalsi,
        Bisection,
        BisectionThenRegulaFalsi,
        RegulaFalsiThenBisection,
        Alternation
    };

    public enum DayOfWeek
    {
        Undefined,
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
        Undefined,
        Continuous,
        Discrete
    };

    public enum ScheduleTypeLimitsUnitType
    {
        Undefined,
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
        Undefined,
        Comma,
        Tab,
        Space,
        Semicolon
    };

    public enum Roughness
    {
        Undefined,
        VeryRough,
        Rough,
        MediumRough,
        MediumSmooth,
        Smooth,
        VerySmooth
    };

    public enum MoistureDiffusionCalculationMethod
    {
        Undefined,
        Simple,
        Advanced
    };

    public enum OpticalDataType
    {
        Undefined,
        SpectralAverage,
        Spectral,
        BSDF,
        SpectralAndAngle
    };

    public enum GasType
    {
        Undefined,
        Air,
        Argon,
        Krypton,
        Xenon,
        Custom
    };

    public enum StartingVertexPosition
    {
        Undefined,
        UpperLeftCorner,
        LowerLeftCorner,
        UpperRightCorner,
        LowerRightCorner
    };

    public enum VertexEntryDirection
    {
        Undefined,
        Counterclockwise,
        Clockwise
    };

    public enum CoordinateSystem
    {
        Undefined,
        Relative,
        World,
        Absolute
    };

    public enum BuildingSurfaceType
    {
        Undefined,
        Wall,
        Floor,
        Ceiling,
        Roof
    };

    public enum FenestrationSurfaceType
    {
        Undefined,
        Window,
        Door,
        GlassDoor,
        TubularDaylightDome,
        TubularDaylightDiffuser
    };

    public enum OutsideBoundaryCondition
    {
        Undefined,
        Adiabatic,
        Surface,
        Zone,
        Outdoors,
        Foundation,
        Ground,
        GroundFCfactorMethod,
        OtherSideCoefficients,
        OtherSideConditionsModel,
        GroundSlabPreprocessorAverage,
        GroundSlabPreprocessorCore,
        GroundSlabPreprocessorPerimeter,
        GroundBasementPreprocessorAverageWall,
        GroundBasementPreprocessorAverageFloor,
        GroundBasementPreprocessorUpperWall,
        GroundBasementPreprocessorLowerWall
    };

    public enum PeopleDesignLevelCalculationMethod
    {
        Undefined,
        People,
        PeoplePerArea,
        AreaPerPerson
    };

    public enum ElectricEquipmentDesignLevelCalculationMethod
    {
        Undefined,
        WattsPerArea,
        WattsPerPerson,
        EquipmentLevel
    };

    public enum LightsDesignLevelCalculationMethod
    {
        Undefined,
        WattsPerArea,
        WattsPerPerson,
        LightingLevel
    };

    public enum MeanRadiantTemperatureCalculationType
    {
        Undefined,
        ZoneAveraged,
        SurfaceWeighted,
        AngleFactor
    }

    public enum ClothingInsulationCalculationMethod
    {
        Undefined,
        ClothingInsulationSchedule,
        DynamicClothingModelASHRAE55,
        CalculationMethodSchedule
    }

    public enum ThermalComfortModelType
    {
        Undefined,
        Fanger,
        Pierce,
        KSU,
        AdaptiveASH55,
        AdaptiveCEN15251
    }

    public enum OutputVariableDictionaryKeyField
    {
        Undefined,
        IDF,
        regular
    }

    public enum OutputVariableDictionarySortOption
    {
        Undefined,
        Name,
        Unsorted
    }

    public enum ReportingFrequency
    {
        Undefined,
        Detailed,
        Timestep,
        Hourly,
        Daily,
        Monthly,
        RunPeriod,
        Environment,
        Annual
    }

    public enum OutputDiagnosticsKey
    {
        Undefined,
        DisplayAllWarnings,
        DisplayExtraWarnings,
        DisplayUnusedSchedules,
        DisplayUnusedObjects,
        DisplayAdvancedReportVariables,
        DisplayZoneAirHeatBalanceOffBalance,
        DoNotMirrorDetachedShading,
        DoNotMirrorAttachedShading,
        DisplayWeatherMissingDataWarnings,
        ReportDuringWarmup,
        ReportDetailedWarmupConvergence,
        ReportDuringHVACSizingSimulation
    }

    public enum OutputConstructionsDetailsType
    {
        Undefined,
        Constructions,
        Materials
    }
}
