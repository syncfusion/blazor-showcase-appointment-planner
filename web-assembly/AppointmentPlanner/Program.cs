using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Syncfusion.Blazor;
using AppointmentPlanner.Data;
using AppointmentPlanner.Models;

namespace AppointmentPlanner
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            builder.Services.AddSyncfusionBlazor();
            builder.Services.AddSingleton<AppointmentService, AppointmentService>();
            builder.Services.AddSingleton<Appointment, Appointment>();
            //builder.Services.AddBaseAddressHttpClient();
            await builder.Build().RunAsync();
        }
    }
}
