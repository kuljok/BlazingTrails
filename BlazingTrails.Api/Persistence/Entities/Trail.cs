using System.ComponentModel.DataAnnotations;
using BlazingTrails.Client.Features.Home;

namespace BlazingTrails.Api.Persistence.Entities;

public class Trail
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string? Image { get; set; }
    public string Location { get; set; } = default!;
    public int TimeInMinutes { get; set; }
    public int Length { get; set; }

    public ICollection<RouteInstruction> Route { get; set; } = default!;
}