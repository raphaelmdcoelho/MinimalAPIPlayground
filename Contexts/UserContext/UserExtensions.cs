namespace MinimalApiPlayground.Contexts.UserContext;

public static class UserExtensions
{
    public static void AddUserDbContext(this WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("User") ?? "Data Source=User.db";
        Console.WriteLine($"Connection String: {connectionString}");

        builder.Services.AddSqlite<UserDbContext>(connectionString);
    }
}