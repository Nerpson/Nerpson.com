namespace Nerpson.Models;

/// <summary>
/// Represents a link to display on the home page.
/// </summary>
public struct Link
{
	/// <summary>
	/// The title to display for this link.
	/// </summary>
	public string Title;

	/// <summary>
	/// The URL of the link.
	/// </summary>
	public string Url;

	/// <summary>
	/// The description to display with this link.
	/// </summary>
	public string Description;

	/// <summary>
	/// The font awesome icon class to display with this link.
	/// </summary>
	public string FontAwesomeIconClass;

	/// <summary>
	/// Creates a new link.
	/// </summary>
	/// <param name="name">The name to display for this link.</param>
	/// <param name="url">The URL of the link.</param>
	/// <param name="description">The description to display with this link.</param>
	public Link(string name, string url, string description, string fontAwesomeIconClass)
	{
		Title = name;
		Url = url;
		Description = description;
		FontAwesomeIconClass = fontAwesomeIconClass;
	}
}
