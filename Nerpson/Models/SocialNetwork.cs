namespace Nerpson.Models;

public enum SocialNetwork
{
	Instagram,
	TikTok,
	YouTube,
	X
}

public static class SocialNetworkExtensions
{
	/// <summary>
	/// Gets the display name for the social network.
	/// </summary>
	/// <param name="network">The social network.</param>
	/// <returns>The display name for the social network.</returns>
	/// <exception cref="ArgumentOutOfRangeException"></exception>
	public static string GetDisplayName(this SocialNetwork network) => network switch
	{
		SocialNetwork.Instagram => "Instagram",
		SocialNetwork.TikTok => "TikTok",
		SocialNetwork.YouTube => "YouTube",
		SocialNetwork.X => "Twitter",
		_ => throw new ArgumentOutOfRangeException(nameof(network))
	};

	/// <summary>
	/// Gets the font awesome icon class for the social network.
	/// </summary>
	/// <param name="network">The social network.</param>
	/// <returns>The font awesome icon class for the social network.</returns>
	/// <exception cref="NotImplementedException"></exception>
	public static string GetFontAwesomeIconClass(this SocialNetwork network) => network switch
	{
		SocialNetwork.Instagram => "fa-brands fa-instagram",
		SocialNetwork.TikTok => "fa-brands fa-tiktok",
		SocialNetwork.YouTube => "fa-brands fa-youtube",
		SocialNetwork.X => "fa-brands fa-twitter",
		_ => throw new NotImplementedException()
	};
}
