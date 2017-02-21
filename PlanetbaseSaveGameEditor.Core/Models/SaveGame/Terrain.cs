using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "terrain")]
	public class Terrain
	{
		[XmlElement(ElementName = "seed")]
		public Seed Seed { get; set; }
	}
}