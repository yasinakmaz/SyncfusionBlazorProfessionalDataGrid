using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SyncfusionBlazorProfessionalDataGrid.Client.Services;
using Syncfusion.Blazor;

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1JEaF5cXmRCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdmWXhcc3RdQ2JeVEN/WERWYEk=");

var builder = WebAssemblyHostBuilder.CreateDefault(args);
// Syncfusion servislerini ekleyin
builder.Services.AddSyncfusionBlazor();

// DataService'i DI container'a ekleyin
builder.Services.AddScoped<DataService>();

await builder.Build().RunAsync();