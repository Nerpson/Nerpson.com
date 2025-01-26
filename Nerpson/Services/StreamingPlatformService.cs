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
			Profiles.Add(new(StreamingPlatform.Spotify, "https://open.spotify.com/artist/nerpson"));
			Profiles.Add(new(StreamingPlatform.AppleMusic, "https://music.apple.com/artist/nerpson"));
			Profiles.Add(new(StreamingPlatform.SoundCloud, "https://soundcloud.com/nerpson"));
			Profiles.Add(new(StreamingPlatform.YouTubeMusic, "https://music.youtube.com/nerpson"));
			Profiles.Add(new(StreamingPlatform.Tidal, "https://tidal.com/browse/artist/12345678"));
			Profiles.Add(new(StreamingPlatform.Deezer, "https://deezer.com/artist/12345678"));
			Profiles.Add(new(StreamingPlatform.AmazonMusic, "https://music.amazon.com/artists/nerpson"));
		}
	}
}
