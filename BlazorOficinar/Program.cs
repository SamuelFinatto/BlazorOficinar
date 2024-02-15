using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorOficinar;
using BlazorOficinar.ServiceDefaults.Models;
using Aspire.Npgsql;
using Aspire.Npgsql.EntityFrameworkCore.PostgreSQL;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.AddNpgsqlDbContext<OficinarContext>("db");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
