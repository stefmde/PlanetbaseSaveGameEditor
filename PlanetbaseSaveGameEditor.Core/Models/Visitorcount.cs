using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "visitor-count")]
	public class VisitorCount
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}