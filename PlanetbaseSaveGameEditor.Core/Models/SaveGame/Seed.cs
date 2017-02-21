using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "seed")]
	public class Seed
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}