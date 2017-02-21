using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "game-time")]
	public class GameTime
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}