using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "game-hints")]
	public class GameHints
	{
		[XmlElement(ElementName = "shown-hints")]
		public ShownHints ShownHints { get; set; }
	}
}