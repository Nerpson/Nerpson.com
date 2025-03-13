using System.Net.Http.Json;
using Nerpson.Models;

namespace Nerpson.Services
{
	/// <summary>
	/// Provides services for managing links.
	/// </summary>
	public class LinkService
	{
		private readonly HttpClient _httpClient;

		/// <summary>
		/// Gets the list of links.
		/// </summary>
		public List<Link> Links { get; private set; } = [];

		/// <summary>
		/// Initializes a new instance of the <see cref="LinkService"/> class.
		/// </summary>
		/// <param name="httpClientFactory">The factory to use to create an <see cref="HttpClient"/>.</param>
		public LinkService(IHttpClientFactory httpClientFactory)
		{
			_httpClient = httpClientFactory.CreateClient(nameof(LinkService));
		}

		/// <summary>
		/// Loads the links from the JSON file.
		/// </summary>
		/// <returns>A task that represents the asynchronous operation.</returns>
		public async Task LoadLinksAsync()
		{
			try
			{
				Links = await _httpClient.GetFromJsonAsync<List<Link>>("data/links.json") ?? [];
			}
			catch (OperationCanceledException)
			{
				// The operation was canceled, so we'll just return an empty list.
				Links = [];
			}
		}
	}
}
