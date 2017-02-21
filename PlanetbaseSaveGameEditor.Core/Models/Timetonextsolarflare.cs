using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "time-to-next-solar-flare")]
	public class TimeToNextSolarflare
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}