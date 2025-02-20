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
				"Third preview of The Abyss EP",
				"https://go.nerpson.com/ig-the-abyss-ep-preview-3",
				"Release day is approaching! Check out the third preview of The Abyss EP on Instagram.",
				"fa-brands fa-instagram"
			));

			Links.Add(new Link(
				"Second preview of The Abyss EP",
				"https://go.nerpson.com/ig-the-abyss-ep-preview-2",
				"Heat up the hype for The Abyss EP with a preview of 'Resurgence' on Instagram.",
				"fa-brands fa-instagram"
			));

			Links.Add(new Link(
				"First preview of The Abyss EP",
				"https://go.nerpson.com/ig-the-abyss-ep-preview",
				"Check out the first preview of The Abyss EP on Instagram.",
				"fa-brands fa-instagram"
			));
		}
	}
}
