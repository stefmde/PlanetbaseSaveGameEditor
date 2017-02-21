using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "visitor-events")]
	public class VisitorEvents
	{
		[XmlElement(ElementName = "next-event-time")]
		public NextEventTime NextEventTime { get; set; }

		[XmlElement(ElementName = "visitor-event")]
		public VisitorEvent VisitorEvent { get; set; }
	}
}