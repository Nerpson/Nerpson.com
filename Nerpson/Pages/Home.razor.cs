using Microsoft.AspNetCore.Components;
using Nerpson.Services;

namespace Nerpson.Pages;

public partial class Home
{
	[Inject]
	private LinkService LinkService { get; set; } = default!;

	protected override async Task OnInitializedAsync()
	{
		await LinkService.LoadLinksAsync();
	}
}
