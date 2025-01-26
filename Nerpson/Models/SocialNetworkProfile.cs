namespace Nerpson.Models;

/// <summary>
/// Represents a profile for a social network.
/// </summary>
public struct SocialNetworkProfile
{
	/// <summary>
	/// The social network.
	/// </summary>
	public SocialNetwork Network;

	/// <summary>
	/// The URL of the social network profile.
	/// </summary>
	public string Url;

	/// <summary>
	/// Initializes a new instance of the <see cref="SocialNetworkProfile"/> struct.
	/// </summary>
	/// <param name="network">The social network.</param>
	/// <param name="url">The URL of the social network profile.</param>
	public SocialNetworkProfile(SocialNetwork network, string url)
	{
		Network = network;
		Url = url;
	}
}
