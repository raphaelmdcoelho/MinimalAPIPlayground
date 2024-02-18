using MinimalApiPlayground.Repositories;

namespace MinimalApiPlayground.Extensions;

public static class BuilderExtensions
{
    // If returning instead of void, is possible to make composition like: builder.AddServices().AddControllers();
    public static WebApplicationBuilder AddRepositories(this WebApplicationBuilder builder)
    {
        builder.Services.AddTransient<IUserRepository, UserRepository>();

        return builder;
    }
}