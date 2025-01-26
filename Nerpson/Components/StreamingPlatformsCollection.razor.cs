using Microsoft.AspNetCore.Components;
using Nerpson.Models;

namespace Nerpson.Components;

public partial class StreamingPlatformsCollection
{
	[Parameter, EditorRequired]
	public List<StreamingPlatformProfile> Profiles { get; set; } = [];
}
