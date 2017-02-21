using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "real-game-time")]
	public class RealGameTime
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}