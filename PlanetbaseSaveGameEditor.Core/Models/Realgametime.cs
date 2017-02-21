using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "real-game-time")]
	public class RealGameTime
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}