using DeviceComparison.Domain.Model.Core;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeviceComparison.Domain.Model;

[PrimaryKey("Id")]
public class Band(string name, string? description = null, string? logoUrl = null, string? websiteUrl = null):IMarking
{
    [Required]
    public int Id { get; init; }
    public string Name { get; init; } = name;
    public string? Description { get; init; } = description;
    public string? LogoUrl { get; init; } = logoUrl;
    public string? WebsiteUrl { get; init; } = websiteUrl;
    public IDoneTiming Created { get; init; }
    public HashSet<IDoneTiming> Modified { get; init; }
}

[PrimaryKey("Id")]
public class Batch(string name, string? description = null, string? logoUrl = null, string? websiteUrl = null) : IMarking
{
    [Required]
    public int Id { get; init; }
    public string Name { get; init; } = name;
    public string? Description { get; init; } = description;
    public string? LogoUrl { get; init; } = logoUrl;
    public string? WebsiteUrl { get; init; } = websiteUrl;
    public IDoneTiming Created { get; init; }
    public HashSet<IDoneTiming> Modified { get; init; }

    [ForeignKey("Band")]
    public int BandId { get; init; }
    public Band Band { get; init; }
}

[PrimaryKey("Id")]
public class Model (string name, string? description = null, string? logoUrl = null, string? websiteUrl = null) : IMarking
{
    [Required]
    public int Id { get; init; }
    public string Name { get; init; } = name;
    public string? Description { get; init; } = description;
    public string? LogoUrl { get; init; } = logoUrl;
    public string? WebsiteUrl { get; init; } = websiteUrl;
    public IDoneTiming Created { get; init; }
    public HashSet<IDoneTiming> Modified { get; init; }

    [ForeignKey("Batch")]
    public int BatchId { get; init; }
    public Batch Batch { get; init; }
}
