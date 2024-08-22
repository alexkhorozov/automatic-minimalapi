namespace GitHub.Api.Endpoints.Users;

public class UserDetails : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("/users/{username}", async (
            string username,
            GitHubService gitHubService) =>
        {
            var content = await gitHubService.GetByUsernameAsync(username);

            return Results.Ok(content);
        })
            .WithTags(Tags.Users);
    }
}