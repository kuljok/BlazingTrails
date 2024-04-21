namespace BlazingTrails.Api.Persistence.Entities;

public class Trail
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string? Image { get; set; }
    public string Location { get; set; } = default!;
    public int TimeInMinutes { get; set; }
    public int Length { get; set; }

    public string Owner { get; set; } = default!;

    public ICollection<Waypoint> Waypoints { get; set; } = new List<Waypoint>();
}