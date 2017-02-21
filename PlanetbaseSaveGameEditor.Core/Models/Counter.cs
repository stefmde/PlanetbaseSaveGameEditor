using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "counter")]
	public class Counter
	{
		[XmlElement(ElementName = "type-name")]
		public TypeName Typename { get; set; }
		[XmlElement(ElementName = "counts")]
		public Counts Counts { get; set; }
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
	}
}