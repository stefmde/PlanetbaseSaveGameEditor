using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "colony")]
	public class Colony
	{
		[XmlElement(ElementName = "extra-prestige")]
		public ExtraPrestige ExtraPrestige { get; set; }

		[XmlElement(ElementName = "game-time")]
		public GameTime GameTime { get; set; }

		[XmlElement(ElementName = "real-game-time")]
		public RealGameTime RealGameTime { get; set; }

		[XmlElement(ElementName = "name")]
		public Name Name { get; set; }

		[XmlElement(ElementName = "latitude")]
		public Latitude Latitude { get; set; }

		[XmlElement(ElementName = "longitude")]
		public Longitude Longitude { get; set; }
	}
}