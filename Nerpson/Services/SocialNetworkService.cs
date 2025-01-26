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
			Profiles.Add(new(SocialNetwork.Instagram, "https://instagram.com/nerpson"));
			Profiles.Add(new(SocialNetwork.TikTok, "https://tiktok.com/@nerpson_"));
			Profiles.Add(new(SocialNetwork.YouTube, "https://youtube.com/nerpson"));
			Profiles.Add(new(SocialNetwork.X, "https://x.com/nerpson"));
		}
	}
}
