using AppointmentPlanner.Data;
using AppointmentPlanner.Models;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Popups;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddSyncfusionBlazor();
builder.Services.AddScoped<SfDialogService>();
builder.Services.AddSingleton<AppointmentService, AppointmentService>();
builder.Services.AddSingleton<Appointment, Appointment>();
await builder.Build().RunAsync();
