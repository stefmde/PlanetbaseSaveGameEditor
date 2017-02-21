using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "visitor-events")]
	public class VisitorEvents
	{
		[XmlElement(ElementName = "next-event-time")]
		public NextEventTime Nexteventtime { get; set; }
		[XmlElement(ElementName = "visitor-event")]
		public VisitorEvent Visitorevent { get; set; }
	}
}