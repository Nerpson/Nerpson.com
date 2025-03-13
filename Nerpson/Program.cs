using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Nerpson;
using Nerpson.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services
	.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) })
	.AddSingleton<LinkService>()
	.AddSingleton<SocialNetworkService>()
	.AddSingleton<StreamingPlatformService>()
	.AddHttpClient(nameof(LinkService), conf => {
		conf.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
	});

await builder.Build().RunAsync();
