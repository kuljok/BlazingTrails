using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazingTrails.Client;
using MediatR;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMediatR(typeof(Program).Assembly);

builder.Services.AddOidcAuthentication(o =>
{
    builder.Configuration.Bind("Auth0", o.ProviderOptions);
    o.ProviderOptions.ResponseType = "code";
});

await builder.Build().RunAsync();
