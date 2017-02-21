using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "game-time")]
	public class GameTime
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}