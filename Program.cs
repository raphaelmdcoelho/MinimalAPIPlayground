var builder = WebApplication.CreateBuilder(args);

builder.AddServices();

var app = builder.Build();

app.MapUserRoutes();
   //.MapProductsRoutes();

app.Run();
