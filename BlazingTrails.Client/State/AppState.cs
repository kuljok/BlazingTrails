using BlazingTrails.Shared.Features.ManageTrails.Shared;

public class AppState
{
    public NewTrailState NewTrailState { get; }

    public AppState()
    {
        NewTrailState = new NewTrailState();
    }
}
