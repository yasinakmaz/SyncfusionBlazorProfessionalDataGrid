using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SyncfusionBlazorProfessionalDataGrid.Client.Services;
using Syncfusion.Blazor;

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("");

var builder = WebAssemblyHostBuilder.CreateDefault(args);
// Syncfusion servislerini ekleyin
builder.Services.AddSyncfusionBlazor();

// DataService'i DI container'a ekleyin
builder.Services.AddScoped<DataService>();

await builder.Build().RunAsync();