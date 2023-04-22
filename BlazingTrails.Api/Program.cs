using BlazingTrails.Api.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<BlazingTrailsContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("BlazingTrailsContext")!));
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Enable the debugging of Blazor WebAssembly code
    app.UseWebAssemblyDebugging();
}

app.UseHttpsRedirection();

// enables the API to serve the Blazor application
app.UseBlazorFrameworkFiles();
// enables static files to be served by the API
app.UseStaticFiles();

app.UseRouting();

app.MapControllers();
// if a request doesn't match a controller, 
// serve the index.html file from the Blazor project
app.MapFallbackToFile("index.html");

app.Run();
