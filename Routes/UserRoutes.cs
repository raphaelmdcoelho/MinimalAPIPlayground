namespace MinimalApiPlayground.Routes;

public static class UserRoutes
{
    public static void MapUserRoutes(this WebApplication app)
    {
        app.MapGet("/", () => "Hello World!");
        app.MapPost("/", () => "Hello World!");
        app.MapDelete("/", () => "Hello World!");
    }
}