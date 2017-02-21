using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "visitor-event")]
	public class VisitorEvent
	{
		[XmlElement(ElementName = "visitor-count")]
		public VisitorCount Visitorcount { get; set; }
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
	}
}