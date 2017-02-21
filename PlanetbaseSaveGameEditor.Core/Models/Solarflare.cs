using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "solar-flare")]
	public class Solarflare
	{
		[XmlElement(ElementName = "solar-flare-in-progress")]
		public SolarFlareInProgress Solarflareinprogress { get; set; }
		[XmlElement(ElementName = "time-to-next-solar-flare")]
		public TimeToNextSolarflare Timetonextsolarflare { get; set; }
		[XmlElement(ElementName = "time")]
		public Time Time { get; set; }
		[XmlElement(ElementName = "solar-flare-time")]
		public SolarFlareTime Solarflaretime { get; set; }
	}
}