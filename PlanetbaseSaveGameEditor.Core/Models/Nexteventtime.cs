using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "next-event-time")]
	public class NextEventTime
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}