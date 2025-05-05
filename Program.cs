using BlazorWebApp;
using BlazorWebApp.Authentication.DependencyInjection;
using BlazorWebApp.Authentication.Service;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

namespace Bank;

public class Program
{
    public static async Task Main(string[] args)
    {
        

        builder.Services.AddScoped(sp => new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7299") // <--  API-port
        });

        await builder.Build().RunAsync();
    }
