using System.Text.Json.Serialization;

namespace Nerpson.Models;

/// <summary>
/// Represents a link to display on the home page.
/// </summary>
public struct Link
{
	/// <summary>
	/// The title to display for this link.
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// The URL of the link.
	/// </summary>
	[JsonPropertyName("url")]
	public string Url { get; set; }

	/// <summary>
	/// The description to display with this link.
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; set; }

	/// <summary>
	/// The font awesome icon class to display with this link.
	/// </summary>
	[JsonPropertyName("fontAwesomeIconClass")]
	public string FontAwesomeIconClass { get; set; }

	/// <summary>
	/// Creates a new link.
	/// </summary>
	/// <param name="title">The title to display for this link.</param>
	/// <param name="url">The URL of the link.</param>
	/// <param name="description">The description to display with this link.</param>
	/// <param name="fontAwesomeIconClass">The font awesome icon class to display with this link.</param>
	public Link(string title, string url, string description, string fontAwesomeIconClass)
	{
		Title = title;
		Url = url;
		Description = description;
		FontAwesomeIconClass = fontAwesomeIconClass;
	}
}
