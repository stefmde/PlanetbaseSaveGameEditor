using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "hair-color-index")]
	public class HairColorIndex
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}