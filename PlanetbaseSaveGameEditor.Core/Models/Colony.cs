using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "colony")]
	public class Colony
	{
		[XmlElement(ElementName = "extra-prestige")]
		public ExtraPrestige Extraprestige { get; set; }
		[XmlElement(ElementName = "game-time")]
		public GameTime Gametime { get; set; }
		[XmlElement(ElementName = "real-game-time")]
		public RealGameTime Realgametime { get; set; }
		[XmlElement(ElementName = "name")]
		public Name Name { get; set; }
		[XmlElement(ElementName = "latitude")]
		public Latitude Latitude { get; set; }
		[XmlElement(ElementName = "longitude")]
		public Longitude Longitude { get; set; }
	}
}