var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.AddRepositories();
builder.AddUserDbContext();

var app = builder.Build();

app.MapUserRoutes();
   //.MapProductsRoutes();

app.UseSwagger();
app.UseSwaggerUI();

app.Run();
