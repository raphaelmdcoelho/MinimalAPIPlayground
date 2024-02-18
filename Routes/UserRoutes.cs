using Microsoft.AspNetCore.Mvc;
using MinimalApiPlayground.Modes;
using MinimalApiPlayground.Repositories;

namespace MinimalApiPlayground.Routes;

public static class UserRoutes
{
    public static void MapUserRoutes(this WebApplication app)
    {
        app.MapGet("/user/{id}", ([FromRoute] Guid id, [FromServices] IUserRepository userRepository) => 
        {
            var user = userRepository.Get(id);

            return Results.Ok(user);
        }).AddEndpointFilter(async (context, next) =>
        {
            var argument = context.Arguments[0];
            if(string.IsNullOrEmpty(argument?.ToString()))
            {
                return Results.Problem("Invalid id", statusCode: StatusCodes.Status400BadRequest);
            }
            
            return await next(context);
        });

        app.MapPost("/user", ([FromServices] IUserRepository userRepository) => 
        {
            var user = new User { Id = new Guid("c71122df-18e4-4a78-a446-fbf7b8f2969b"), FirstName = "John", LastName = "Doe" };
            userRepository.Add(user);

            return Results.Created($"/user/{user.Id}", user);
        
        });

        app.MapDelete("/user", () => "Hello World!");
    }
}