using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "hair-color-index")]
	public class HairColorIndex
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}