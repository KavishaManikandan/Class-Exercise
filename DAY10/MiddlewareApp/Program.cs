using DemoApp.Middleware;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Use our custom middleware
app.UseMiddleware<RequestLoggingMiddleware>();

// Serve files from wwwroot
app.UseStaticFiles();

// Example endpoint
app.MapGet("/time", () => Results.Text(DateTime.Now.ToString("F")));

app.Run();
