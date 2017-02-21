using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "time-since-last-visitor-landing")]
	public class TimeSinceLastVisitorLanding
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}