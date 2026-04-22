using DeviceComparison.Domain.Model.Core;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeviceComparison.Domain.Model;


[PrimaryKey("Id")]
public class Device(string name, string? description = null, string? logoUrl = null, string? websiteUrl = null) : IMarking
{
    public required int Id { get; init; }
    public string Name { get; init; } = name;
    public string? Description { get; init; } = description;
    public string? LogoUrl { get; init; } = logoUrl;
    public string? WebsiteUrl { get; init; } = websiteUrl;
    public required IDoneTiming Created { get; init; }
    public required HashSet<IDoneTiming> Modified { get; init; }

    [ForeignKey("Id")]
    public int DeviceTypeId { get; init; }
    public required DeviceType DeviceType { get; init; }

    [ForeignKey("Id")]
    public int ModelId { get; init; }
    public required Model Model { get; init; }
}
