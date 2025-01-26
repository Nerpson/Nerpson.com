using Microsoft.AspNetCore.Components;
using Nerpson.Models;

namespace Nerpson.Components;

public partial class LinksCollection
{
	[Parameter, EditorRequired]
	public List<Link> Links { get; set; } = [];
}
