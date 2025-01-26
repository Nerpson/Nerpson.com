using Microsoft.AspNetCore.Components;
using Nerpson.Models;

namespace Nerpson.Components;

public partial class SocialNetworksCollection
{
	[Parameter, EditorRequired]
	public List<SocialNetworkProfile> Profiles { get; set; } = new();
}
