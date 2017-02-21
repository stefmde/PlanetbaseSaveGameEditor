using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "extra-prestige")]
	public class ExtraPrestige
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}