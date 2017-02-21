using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "game-hints")]
	public class GameHints
	{
		[XmlElement(ElementName = "shown-hints")]
		public ShownHints Shownhints { get; set; }
	}
}