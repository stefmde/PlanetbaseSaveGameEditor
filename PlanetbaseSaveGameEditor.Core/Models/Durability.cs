using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "durability")]
	public class Durability
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}