var builder = WebApplication.CreateBuilder(args);

// Register services
builder.Services.AddControllers();

// Keep OpenAPI support
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure OpenAPI in development
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// Register controller endpoints
app.MapControllers();

app.Run();