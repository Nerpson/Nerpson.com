using Nerpson.Models;

namespace Nerpson.Services
{
	/// <summary>
	/// Provides services for managing links.
	/// </summary>
	public class LinkService
	{
		/// <summary>
		/// Gets the list of links.
		/// </summary>
		public List<Link> Links { get; private set; } = new();

		/// <summary>
		/// Initializes a new instance of the <see cref="LinkService"/> class.
		/// </summary>
		public LinkService()
		{
			Links.Add(new Link(
				"Instagram",
				"https://instagram.com/nerpson",
				"See my photos and videos",
				"fa-brands fa-instagram"
			));
			Links.Add(new Link(
				"TikTok",
				"https://tiktok.com/@nerpson",
				"Watch my short videos",
				"fa-brands fa-tiktok"
			));
			Links.Add(new Link(
				"SoundCloud",
				"https://soundcloud.com/nerpson",
				"Find all my music here",
				"fa-brands fa-soundcloud"
			));
			Links.Add(new Link(
				"YouTube",
				"https://youtube.com/nerpson",
				"Watch my videos",
				"fa-brands fa-youtube"
			));
			Links.Add(new Link(
				"X (Twitter)",
				"https://x.com/nerpson",
				"Read my thoughts in 280 characters or less",
				"fa-brands fa-twitter"
			));
		}
	}
}
