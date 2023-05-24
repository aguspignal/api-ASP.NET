var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Fulbito API");

app.MapGet("/test", () => "Ok");

// Hi?

app.Run();
