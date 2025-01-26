using Nerpson.Models;

namespace Nerpson.Services
{
	/// <summary>
	/// Provides services related to social networks.
	/// </summary>
	public class SocialNetworkService
	{
		/// <summary>
		/// Gets the list of social network profiles.
		/// </summary>
		public List<SocialNetworkProfile> Profiles { get; private set; } = new();

		/// <summary>
		/// Initializes a new instance of the <see cref="SocialNetworkService"/> class.
		/// </summary>
		public SocialNetworkService()
		{
			Profiles.Add(new(SocialNetwork.Instagram, "https://go.nerpson.com/instagram"));
			Profiles.Add(new(SocialNetwork.TikTok, "https://go.nerpson.com/tiktok"));
			Profiles.Add(new(SocialNetwork.YouTube, "https://go.nerpson.com/youtube"));
			Profiles.Add(new(SocialNetwork.X, "https://go.nerpson.com/x"));
		}
	}
}
