using DeviceComparison.Domain.Model.Core;
using Microsoft.EntityFrameworkCore;

namespace DeviceComparison.Domain.Model;

[PrimaryKey("Id")]
public class DeviceType(string name) : IMarkingBase
{
    public required int Id { get; init; }
    public string Name { get; init; } = name;
}
