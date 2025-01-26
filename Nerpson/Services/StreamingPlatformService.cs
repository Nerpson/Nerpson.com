using Nerpson.Models;

namespace Nerpson.Services
{
	/// <summary>
	/// Provides services related to streaming platform profiles.
	/// </summary>
	public class StreamingPlatformService
	{
		/// <summary>
		/// Gets the list of streaming platform profiles.
		/// </summary>
		public List<StreamingPlatformProfile> Profiles { get; private set; } = new();

		/// <summary>
		/// Initializes a new instance of the <see cref="StreamingPlatformService"/> class.
		/// </summary>
		public StreamingPlatformService()
		{
			Profiles.Add(new(StreamingPlatform.Spotify, "https://go.nerpson.com/spotify"));
			Profiles.Add(new(StreamingPlatform.AppleMusic, "https://go.nerpson.com/applemusic"));
			Profiles.Add(new(StreamingPlatform.SoundCloud, "https://go.nerpson.com/soundcloud"));
			Profiles.Add(new(StreamingPlatform.YouTubeMusic, "https://go.nerpson.com/youtubemusic"));
			Profiles.Add(new(StreamingPlatform.Tidal, "https://go.nerpson.com/tidal"));
			Profiles.Add(new(StreamingPlatform.Deezer, "https://go.nerpson.com/deezer"));
			Profiles.Add(new(StreamingPlatform.AmazonMusic, "https://go.nerpson.com/amazonmusic"));
		}
	}
}
