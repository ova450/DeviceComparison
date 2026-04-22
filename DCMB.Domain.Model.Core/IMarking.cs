namespace DeviceComparison.Domain.Model.Core;

public interface IMarkingBase
{
    int Id { get; init; }
    string Name { get; init; }
}

public interface IMarking:IMarkingBase
{
    string? Description { get; init; }
    string? LogoUrl { get; init; }
    string? WebsiteUrl { get; init; }
    IDoneTiming Created { get; init; }
    HashSet<IDoneTiming> Modified { get; init; }
}

public interface IDoneTiming
{
    DateTimeOffset Done { get; init; }
    int DoneBy { get; init; }
}