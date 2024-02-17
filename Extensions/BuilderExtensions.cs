namespace MinimalApiPlayground.Extensions;

public static class BuilderExtensions
{
    public static void AddArchitectures(this WebApplicationBuilder builder)
    {
        //builder.Services.AddControllers();
    }

    // If returning instead of void, is possible to make composition like: builder.AddServices().AddControllers();
    public static WebApplicationBuilder AddServices(this WebApplicationBuilder builder)
    {
        return builder;
    }
}