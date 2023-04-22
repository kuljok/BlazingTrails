namespace BlazingTrails.Api.Persistence.Entities;

public class RouteInstruction
{
    public int Id { get; set; }
    public int TrailId { get; set; }
    public int Stage { get; set; }
    public string Description { get; set; } = default!;
    public Trail Trail { get; set; } = default!;
}