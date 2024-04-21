using MediatR;

namespace BlazingTrails.Shared.Features.Home.Shared;

public class GetTrailsRequest: IRequest<GetTrailsRequest.Response>
{
    public const string RouteTemplate = "/api/trails";

    public record Trail(
        int Id,
        string Name,
        string? Image,
        string Location,
        int TimeInMinutes,
        int Length,
        string Description,
        string Owner,
        List<Waypoint> Waupoints);

    public record Response(IEnumerable<Trail> Trails);

    public record Waypoint(decimal Latitude, decimal Longitude);
}