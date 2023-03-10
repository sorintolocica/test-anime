global using AnimeRU.Shared;
global using System.Net.Http.Json;
global using AnimeRU.Client.Services.PostService;
using AnimeRU.Client;
using AnimeRU.Client.Services.PostService;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IPostService,PostService>();


await builder.Build().RunAsync();
