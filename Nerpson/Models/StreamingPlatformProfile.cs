namespace Nerpson.Models;

/// <summary>
/// Represents a profile for a streaming platform.
/// </summary>
public struct StreamingPlatformProfile
{
	/// <summary>
	/// The streaming platform.
	/// </summary>
	public StreamingPlatform Platform;

	/// <summary>
	/// The URL of the streaming platform profile.
	/// </summary>
	public string Url;

	/// <summary>
	/// Initializes a new instance of the <see cref="StreamingPlatformProfile"/> struct.
	/// </summary>
	/// <param name="platform">The streaming platform.</param>
	/// <param name="url">The URL of the streaming platform profile.</param>
	public StreamingPlatformProfile(StreamingPlatform platform, string url)
	{
		Platform = platform;
		Url = url;
	}
}
