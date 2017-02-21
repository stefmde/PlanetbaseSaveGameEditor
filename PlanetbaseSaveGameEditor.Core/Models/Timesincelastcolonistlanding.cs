using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "time-since-last-colonist-landing")]
	public class TimeSinceLastColonistLanding
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}