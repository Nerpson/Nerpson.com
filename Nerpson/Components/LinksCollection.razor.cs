using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Nerpson.Models;

namespace Nerpson.Components;

public partial class LinksCollection
{
	[Parameter, EditorRequired]
	public List<Link> Links { get; set; } = [];

	private async Task OpenLinkInNewTab(string url)
	{
		await JSRuntime.InvokeVoidAsync("open", url, "_blank");
	}
}
