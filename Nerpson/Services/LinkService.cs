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
				"First preview of The Abyss EP",
				"https://www.instagram.com/p/DFN7r0aiyWG/",
				"Check out the first preview of The Abyss EP on Instagram.",
				"fa-brands fa-instagram"
			));

		}
	}
}
