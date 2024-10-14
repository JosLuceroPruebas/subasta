using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using LivestockAuction;
using MudBlazor.Services;
using LivestockAuction.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices();

// Registrar los servicios personalizados
builder.Services.AddScoped<LotService>();
builder.Services.AddScoped<AnimalRegistrationService>();

await builder.Build().RunAsync();