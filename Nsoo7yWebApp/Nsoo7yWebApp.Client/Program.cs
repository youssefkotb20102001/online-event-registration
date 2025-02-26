using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Nsoo7yWebApp.Client.Classes;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped<LocalStorage>();
await builder.Build().RunAsync();
