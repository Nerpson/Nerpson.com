namespace Nerpson.Models;

/// <summary>
/// Music streaming platforms.
/// </summary>
public enum StreamingPlatform
{
	Spotify,
	AppleMusic,
	SoundCloud,
	YouTube,
	Tidal,
	Deezer,
	AmazonMusic
}

public static class StreamingPlatformExtensions
{
	/// <summary>
	/// Gets the display name for the specified streaming platform.
	/// </summary>
	/// <param name="platform">The streaming platform.</param>
	/// <returns>The display name for the specified streaming platform.</returns>
	/// <exception cref="ArgumentOutOfRangeException"></exception>
	public static string GetDisplayName(this StreamingPlatform platform) => platform switch
	{
		StreamingPlatform.Spotify => "Spotify",
		StreamingPlatform.AppleMusic => "Apple Music",
		StreamingPlatform.SoundCloud => "SoundCloud",
		StreamingPlatform.YouTube => "YouTube",
		StreamingPlatform.Tidal => "Tidal",
		StreamingPlatform.Deezer => "Deezer",
		StreamingPlatform.AmazonMusic => "Amazon Music",
		_ => throw new ArgumentOutOfRangeException(nameof(platform))
	};

	/// <summary>
	/// Gets the font awesome icon class for the specified streaming platform.
	/// </summary>
	/// <param name="platform">The streaming platform.</param>
	/// <returns>The font awesome icon class for the specified streaming platform.</returns>
	/// <exception cref="ArgumentOutOfRangeException"></exception>
	public static string GetFontAwesomeIconClass(this StreamingPlatform platform) => platform switch
	{
		StreamingPlatform.Spotify => "fa-brands fa-spotify",
		StreamingPlatform.AppleMusic => "fa-brands fa-apple",
		StreamingPlatform.SoundCloud => "fa-brands fa-soundcloud",
		StreamingPlatform.YouTube => "fa-brands fa-youtube",
		StreamingPlatform.Tidal => "fa-brands fa-tidal",
		StreamingPlatform.Deezer => "fa-brands fa-deezer",
		StreamingPlatform.AmazonMusic => "fa-brands fa-amazon",
		_ => throw new ArgumentOutOfRangeException(nameof(platform))
	};
}
